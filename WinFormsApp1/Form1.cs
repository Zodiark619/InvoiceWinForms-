using System.ComponentModel;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using WinFormsApp1.Products;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private BindingList<InvoiceDto> _lines;
        private List<Product> _products;
        private void LoadProducts()
        {
            using var db = new ApplicationDbContext();
            _products = db.Products.ToList();
        }
        private void UpdateGrandTotal()
        {
            decimal grandTotal = _lines.Sum(x => x.Total);
            lblGrandTotals.Text = $"Total: {grandTotal:C}";
        }
        private void Lines_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateGrandTotal();
        }
        private void InitializeGrid()
        {
            _lines = new BindingList<InvoiceDto>();

            _lines.ListChanged += Lines_ListChanged;
            dataGridView1.AutoGenerateColumns = false;
            // dataGridView1.DataSource = _lines;

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewComboBoxColumn
            {
                HeaderText = "Product",
                DataPropertyName = "ProductId",
                DataSource = _products,
                DisplayMember = "Name",
                ValueMember = "Id",
                FlatStyle = FlatStyle.Flat
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Qty",
                DataPropertyName = "Quantity"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                DataPropertyName = "UnitPrice",
                ReadOnly = true,
                DefaultCellStyle = { Format = "c" }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                DataPropertyName = "Total",
                ReadOnly = true,
                DefaultCellStyle = { Format = "c" }
            });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Remove",
                HeaderText = "",
                Text = "Remove",
                UseColumnTextForButtonValue = true
            });
            dataGridView1.DataSource = _lines;

        }

        public Form1()
        {

            InitializeComponent();
            LoadProducts();
            InitializeGrid();
            dataGridView1.EditingControlShowing += DataGridView1_EditingControlShowing;
        }
        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.DataPropertyName == "Quantity")
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress -= Qty_KeyPress;
                    tb.KeyPress += Qty_KeyPress;
                }
            }
        }
        private void Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnFrmProductIndex_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmProductIndex();
            DialogResult selectedButton = paymentForm.ShowDialog();


        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Product")
            {
                var line = _lines[e.RowIndex];
                var product = _products.FirstOrDefault(p => p.Id == line.ProductId);

                if (product != null)
                    line.UnitPrice = product.Price;

                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
            {
                _lines.RemoveAt(e.RowIndex);
            }
        }

        //private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.IsCurrentCellDirty)
        //    {
        //        dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //    }
        //}
    }
    //if (selectedButton == DialogResult.OK)
    //{
    //    lblPayment.Text = paymentForm.Tag?.ToString();
    //}
    // Load += Form1_Load;
}
