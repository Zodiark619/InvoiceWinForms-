using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class frmCreateProduct : Form
    {
        public frmCreateProduct()
        {
            InitializeComponent();
        }
        public event EventHandler ProductSaved;


        private void btnCreateProductSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product name is required");
                return;
            }

            var product = new Product
            {
                Name = txtProductName.Text.Trim()
            };

            using var db = new ApplicationDbContext();
            var   names = db.Products
             .Select(p => p.Name)
                .ToList();
            if (names.Any(x=> string.Equals(x, product.Name, StringComparison.OrdinalIgnoreCase))  )
            {
                MessageBox.Show("Product already exists");
                return;
            }
            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show($"Product '{product.Name}' is successfully created!");
            ProductSaved?.Invoke(this, EventArgs.Empty);
            txtProductName.Clear();
            txtProductName.Focus();
        }
            //   this.DialogResult = DialogResult.OK;
            //  this.Close();

    }
}
