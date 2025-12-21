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

namespace WinFormsApp1.Products
{
    public partial class frmProductIndex : Form
    {
        private void LoadProducts()
        {
            using var db = new ApplicationDbContext();

            cmbProductIndex.DisplayMember = "Name";
            cmbProductIndex.ValueMember = "Id";
            cmbProductIndex.DataSource = db.Products.ToList();

            if (cmbProductIndex.Items.Count > 0)
            {
                cmbProductIndex.SelectedIndex = 0;
                txtProductIndex.Text = cmbProductIndex.Text;
                btnProductIndexDelete.Enabled = true;
                btnProductIndexUpdate.Enabled = true;
            }
            else
            {
                txtProductIndex.Text ="*No products in database";
                btnProductIndexDelete.Enabled = false;
                btnProductIndexUpdate.Enabled = false;

            }
        }
        
        public frmProductIndex()
        {
            InitializeComponent();
            LoadProducts(); // 🔄 refresh dropdown

        }

        private void btnFrmCreateProduct_Click(object sender, EventArgs e)
        {
            //Form paymentForm = new frmCreateProduct();
            //DialogResult selectedButton = paymentForm.ShowDialog();
            var form = new frmCreateProduct();

            form.ProductSaved += (s, e2) =>
            {
                LoadProducts(); // 🔄 refresh dropdown
            };

            form.Show(); // non-modal, supports multiple saves
        }

        private void cmbProductIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductIndex.SelectedValue is int productId)
            {
                txtProductIndex.Text = cmbProductIndex.Text;
            }
        }

        private void btnProductIndexUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductIndex.Text))
            {
                MessageBox.Show("Product name is required");
                return;
            }
            if (cmbProductIndex.SelectedValue is not int productId)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            string newName = txtProductIndex.Text.Trim();
            string oldProductName = cmbProductIndex.Text;

            using var db = new ApplicationDbContext();

            var product = db.Products.Find(productId);
            if (product == null)
            {
                MessageBox.Show("Product not found");
                LoadProducts();
                return;
            }

            //bool duplicateExists = db.Products.Any(p =>
            //    p.Id != productId &&
            //    p.Name.Equals(newName, StringComparison.OrdinalIgnoreCase));
            product.Name = newName;

            var names = db.Products
          .Select(p => p.Name)
             .ToList();
            bool duplicateExists = names.Any(x => string.Equals(x, product.Name, StringComparison.OrdinalIgnoreCase));
            if (duplicateExists)
            {
                MessageBox.Show("Product already exists");
                return;
            }

            db.SaveChanges(); // ✅ no Update()

            LoadProducts();
            cmbProductIndex.SelectedValue = productId;

            MessageBox.Show($"Product '{oldProductName}' updated to '{product.Name}'");
        }

        private void btnProductIndexDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtProductIndex.Text))
            {
                MessageBox.Show("Product name is required");
                return;
            }
            if (cmbProductIndex.SelectedValue is not int id)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            string oldProductName = cmbProductIndex.Text;
            int productId = (int)cmbProductIndex.SelectedValue;

            using var db = new ApplicationDbContext();
            var product = db.Products.Find(productId);

            db.Products.Remove(product);
            db.SaveChanges();
            if (cmbProductIndex.Items.Count > 0)
            {
                cmbProductIndex.SelectedIndex = 0;
            }
            else
            {
                txtProductIndex.Text = string.Empty;
            }
            LoadProducts();

            MessageBox.Show($"Product '{oldProductName}' deleted!");
        }
    }
}
