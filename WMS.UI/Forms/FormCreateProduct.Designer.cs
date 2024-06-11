namespace WMS.UI.Forms
{
    partial class FormCreateProduct
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
            panel1 = new Panel();
            btnUploadFile = new FontAwesome.Sharp.IconButton();
            pbProductImage = new PictureBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            tbSku = new TextBox();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            tbProductName = new TextBox();
            panel4 = new Panel();
            groupBox3 = new GroupBox();
            cbProductCategory = new ComboBox();
            btnAddAttribute = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            groupBox4 = new GroupBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            panel6 = new Panel();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnOk = new FontAwesome.Sharp.IconButton();
            customizeButton1 = new Common.Customize.CustomizeButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnUploadFile);
            panel1.Controls.Add(pbProductImage);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 289);
            panel1.TabIndex = 0;
            // 
            // btnUploadFile
            // 
            btnUploadFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnUploadFile.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnUploadFile.IconColor = Color.Black;
            btnUploadFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUploadFile.IconSize = 24;
            btnUploadFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnUploadFile.Location = new Point(42, 251);
            btnUploadFile.Name = "btnUploadFile";
            btnUploadFile.Size = new Size(102, 32);
            btnUploadFile.TabIndex = 2;
            btnUploadFile.Text = "Chọn ảnh";
            btnUploadFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUploadFile.UseVisualStyleBackColor = true;
            // 
            // pbProductImage
            // 
            pbProductImage.BorderStyle = BorderStyle.FixedSingle;
            pbProductImage.Location = new Point(8, 7);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(183, 238);
            pbProductImage.TabIndex = 0;
            pbProductImage.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(215, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 53);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSku);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 53);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SKU";
            // 
            // tbSku
            // 
            tbSku.BorderStyle = BorderStyle.FixedSingle;
            tbSku.Dock = DockStyle.Fill;
            tbSku.Enabled = false;
            tbSku.Font = new Font("Segoe UI", 9F);
            tbSku.Location = new Point(3, 20);
            tbSku.Name = "tbSku";
            tbSku.Size = new Size(308, 23);
            tbSku.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Location = new Point(215, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 53);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbProductName);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 53);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên sản phẩm";
            // 
            // tbProductName
            // 
            tbProductName.BorderStyle = BorderStyle.FixedSingle;
            tbProductName.Dock = DockStyle.Fill;
            tbProductName.Font = new Font("Segoe UI", 9F);
            tbProductName.Location = new Point(3, 20);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(308, 23);
            tbProductName.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox3);
            panel4.Location = new Point(215, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(314, 53);
            panel4.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbProductCategory);
            groupBox3.Controls.Add(btnAddAttribute);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(314, 53);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Loại sản phẩm";
            // 
            // cbProductCategory
            // 
            cbProductCategory.Dock = DockStyle.Left;
            cbProductCategory.Font = new Font("Segoe UI", 9F);
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Location = new Point(3, 20);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new Size(199, 23);
            cbProductCategory.TabIndex = 0;
            // 
            // btnAddAttribute
            // 
            btnAddAttribute.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddAttribute.IconColor = Color.OliveDrab;
            btnAddAttribute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddAttribute.IconSize = 24;
            btnAddAttribute.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAttribute.Location = new Point(208, 15);
            btnAddAttribute.Name = "btnAddAttribute";
            btnAddAttribute.Size = new Size(102, 32);
            btnAddAttribute.TabIndex = 0;
            btnAddAttribute.Text = "Thêm mới";
            btnAddAttribute.TextAlign = ContentAlignment.MiddleLeft;
            btnAddAttribute.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAttribute.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox4);
            panel5.Location = new Point(215, 189);
            panel5.Name = "panel5";
            panel5.Size = new Size(314, 53);
            panel5.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(314, 53);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hạn sử dụng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(108, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "(Ngày)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Left;
            numericUpDown1.Font = new Font("Segoe UI", 9F);
            numericUpDown1.Location = new Point(3, 20);
            numericUpDown1.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(101, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(btnOk);
            panel6.Location = new Point(215, 248);
            panel6.Name = "panel6";
            panel6.Size = new Size(314, 53);
            panel6.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Red;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 24;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(161, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnOk.IconColor = Color.Blue;
            btnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOk.IconSize = 24;
            btnOk.ImageAlign = ContentAlignment.MiddleLeft;
            btnOk.Location = new Point(40, 10);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(102, 32);
            btnOk.TabIndex = 1;
            btnOk.Text = "Xác nhận";
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // customizeButton1
            // 
            customizeButton1.BackColor = Color.MediumSlateBlue;
            customizeButton1.BackgroundColor = Color.MediumSlateBlue;
            customizeButton1.BorderColor = Color.PaleVioletRed;
            customizeButton1.BorderRadius = 8;
            customizeButton1.BorderSize = 0;
            customizeButton1.FlatAppearance.BorderSize = 0;
            customizeButton1.FlatStyle = FlatStyle.Flat;
            customizeButton1.ForeColor = Color.White;
            customizeButton1.Location = new Point(144, 353);
            customizeButton1.Name = "customizeButton1";
            customizeButton1.Size = new Size(8, 8);
            customizeButton1.TabIndex = 6;
            customizeButton1.Text = "customizeButton1";
            customizeButton1.TextColor = Color.White;
            customizeButton1.UseVisualStyleBackColor = false;
            // 
            // Form_CreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 308);
            Controls.Add(customizeButton1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form_CreateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo nhanh sản phẩm";
            Load += Form_CreateProduct_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbProductImage;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox tbSku;
        private TextBox tbProductName;
        private ComboBox cbProductCategory;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnAddAttribute;
        private Common.Customize.CustomizeButton customizeButton1;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnOk;
        private FontAwesome.Sharp.IconButton btnUploadFile;
    }
}