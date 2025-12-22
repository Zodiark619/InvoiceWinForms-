namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFrmProductIndex = new Button();
            dataGridView1 = new DataGridView();
            lblGrandTotals = new Label();
            btnExportPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFrmProductIndex
            // 
            btnFrmProductIndex.Location = new Point(46, 51);
            btnFrmProductIndex.Name = "btnFrmProductIndex";
            btnFrmProductIndex.Size = new Size(265, 35);
            btnFrmProductIndex.TabIndex = 0;
            btnFrmProductIndex.Text = "Products";
            btnFrmProductIndex.UseVisualStyleBackColor = true;
            btnFrmProductIndex.Click += btnFrmProductIndex_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(639, 261);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // lblGrandTotals
            // 
            lblGrandTotals.AutoSize = true;
            lblGrandTotals.Location = new Point(295, 409);
            lblGrandTotals.Name = "lblGrandTotals";
            lblGrandTotals.Size = new Size(38, 15);
            lblGrandTotals.TabIndex = 3;
            lblGrandTotals.Text = "label2";
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(688, 51);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(75, 23);
            btnExportPdf.TabIndex = 4;
            btnExportPdf.Text = "PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportPdf);
            Controls.Add(lblGrandTotals);
            Controls.Add(dataGridView1);
            Controls.Add(btnFrmProductIndex);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFrmProductIndex;
        private DataGridView dataGridView1;
        private Label lblGrandTotals;
        private Button btnExportPdf;
    }
}
