namespace WinFormsApp1.Products
{
    partial class frmProductIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnFrmCreateProduct = new Button();
            cmbProductIndex = new ComboBox();
            productBindingSource = new BindingSource(components);
            txtProductIndex = new TextBox();
            btnProductIndexUpdate = new Button();
            btnProductIndexDelete = new Button();
            txtProductPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductPrice).BeginInit();
            SuspendLayout();
            // 
            // btnFrmCreateProduct
            // 
            btnFrmCreateProduct.Location = new Point(31, 47);
            btnFrmCreateProduct.Name = "btnFrmCreateProduct";
            btnFrmCreateProduct.Size = new Size(265, 35);
            btnFrmCreateProduct.TabIndex = 1;
            btnFrmCreateProduct.Text = "Create Product";
            btnFrmCreateProduct.UseVisualStyleBackColor = true;
            btnFrmCreateProduct.Click += btnFrmCreateProduct_Click;
            // 
            // cmbProductIndex
            // 
            cmbProductIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductIndex.FormattingEnabled = true;
            cmbProductIndex.Location = new Point(208, 143);
            cmbProductIndex.Name = "cmbProductIndex";
            cmbProductIndex.Size = new Size(408, 23);
            cmbProductIndex.TabIndex = 2;
            cmbProductIndex.SelectedIndexChanged += cmbProductIndex_SelectedIndexChanged;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Data.Product);
            // 
            // txtProductIndex
            // 
            txtProductIndex.Location = new Point(143, 189);
            txtProductIndex.Name = "txtProductIndex";
            txtProductIndex.Size = new Size(543, 23);
            txtProductIndex.TabIndex = 3;
            // 
            // btnProductIndexUpdate
            // 
            btnProductIndexUpdate.Location = new Point(208, 289);
            btnProductIndexUpdate.Name = "btnProductIndexUpdate";
            btnProductIndexUpdate.Size = new Size(75, 23);
            btnProductIndexUpdate.TabIndex = 4;
            btnProductIndexUpdate.Text = "Update";
            btnProductIndexUpdate.UseVisualStyleBackColor = true;
            btnProductIndexUpdate.Click += btnProductIndexUpdate_Click;
            // 
            // btnProductIndexDelete
            // 
            btnProductIndexDelete.Location = new Point(541, 289);
            btnProductIndexDelete.Name = "btnProductIndexDelete";
            btnProductIndexDelete.Size = new Size(75, 23);
            btnProductIndexDelete.TabIndex = 5;
            btnProductIndexDelete.Text = "Delete";
            btnProductIndexDelete.UseVisualStyleBackColor = true;
            btnProductIndexDelete.Click += btnProductIndexDelete_Click;
            // 
            // txtProductPrice
            // 
            txtProductPrice.DecimalPlaces = 2;
            txtProductPrice.Location = new Point(143, 227);
            txtProductPrice.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(543, 23);
            txtProductPrice.TabIndex = 6;
            // 
            // frmProductIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProductPrice);
            Controls.Add(btnProductIndexDelete);
            Controls.Add(btnProductIndexUpdate);
            Controls.Add(txtProductIndex);
            Controls.Add(cmbProductIndex);
            Controls.Add(btnFrmCreateProduct);
            Name = "frmProductIndex";
            Text = "frmProductIndex";
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFrmCreateProduct;
        private ComboBox cmbProductIndex;
        private TextBox txtProductIndex;
        private Button btnProductIndexUpdate;
        private Button btnProductIndexDelete;
        private BindingSource productBindingSource;
        private NumericUpDown txtProductPrice;
    }
}