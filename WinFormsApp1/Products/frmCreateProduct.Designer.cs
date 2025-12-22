namespace WinFormsApp1
{
    partial class frmCreateProduct
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
            label1 = new Label();
            btnCreateProductSave = new Button();
            txtProductName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtProductPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtProductPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 39F);
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(721, 72);
            label1.TabIndex = 0;
            label1.Text = "Create Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCreateProductSave
            // 
            btnCreateProductSave.Location = new Point(276, 302);
            btnCreateProductSave.Name = "btnCreateProductSave";
            btnCreateProductSave.Size = new Size(220, 54);
            btnCreateProductSave.TabIndex = 1;
            btnCreateProductSave.Text = "Save";
            btnCreateProductSave.UseVisualStyleBackColor = true;
            btnCreateProductSave.Click += btnCreateProductSave_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(326, 171);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(484, 23);
            txtProductName.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 29F);
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(291, 59);
            label2.TabIndex = 3;
            label2.Text = "Product Name :";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 29F);
            label3.Location = new Point(12, 222);
            label3.Name = "label3";
            label3.Size = new Size(291, 59);
            label3.TabIndex = 5;
            label3.Text = "Product Price :";
            // 
            // txtProductPrice
            // 
            txtProductPrice.DecimalPlaces = 2;
            txtProductPrice.Location = new Point(326, 240);
            txtProductPrice.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(484, 23);
            txtProductPrice.TabIndex = 6;
            // 
            // frmCreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 393);
            Controls.Add(txtProductPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(btnCreateProductSave);
            Controls.Add(label1);
            Name = "frmCreateProduct";
            Text = "frmCreateProduct";
            ((System.ComponentModel.ISupportInitialize)txtProductPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCreateProductSave;
        private TextBox txtProductName;
        private Label label2;
        private Label label3;
        private NumericUpDown txtProductPrice;
    }
}