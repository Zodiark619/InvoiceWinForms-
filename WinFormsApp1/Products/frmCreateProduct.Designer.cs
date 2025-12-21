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
            btnCreateProductSave.Location = new Point(271, 245);
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
            // frmCreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 334);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(btnCreateProductSave);
            Controls.Add(label1);
            Name = "frmCreateProduct";
            Text = "frmCreateProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCreateProductSave;
        private TextBox txtProductName;
        private Label label2;
    }
}