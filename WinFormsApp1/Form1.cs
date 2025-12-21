using WinFormsApp1.Data;
using WinFormsApp1.Products;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    using var db = new ApplicationDbContext();
        //    var products = db.Products.ToList();

        //    // Bind to UI here
        //    // dataGridView1.DataSource = products;
        //}
        public Form1()
        {

            InitializeComponent();
            // Load += Form1_Load;
        }

        private void btnFrmProductIndex_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmProductIndex();
            DialogResult selectedButton = paymentForm.ShowDialog();

            //if (selectedButton == DialogResult.OK)
            //{
            //    lblPayment.Text = paymentForm.Tag?.ToString();
            //}
        }

         
    }
}
