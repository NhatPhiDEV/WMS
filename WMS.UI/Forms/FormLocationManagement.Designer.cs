namespace WMS.UI.Forms
{
    partial class FormLocationManagement
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            PanelRight = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            BtnImportExcel = new FontAwesome.Sharp.IconButton();
            BtnCloseForm = new FontAwesome.Sharp.IconButton();
            BtnExportExcel = new FontAwesome.Sharp.IconButton();
            BtnRefresh = new FontAwesome.Sharp.IconButton();
            BtnAddProduct = new FontAwesome.Sharp.IconButton();
            RemoveProduct = new DataGridViewImageColumn();
            panel2 = new Panel();
            panel5 = new Panel();
            CbPageSize = new ComboBox();
            TbPageSearch = new TextBox();
            BtnPrev = new FontAwesome.Sharp.IconButton();
            BtnNext = new FontAwesome.Sharp.IconButton();
            EditProduct = new DataGridViewImageColumn();
            PanelBody = new Panel();
            TbLayoutContent = new TableLayoutPanel();
            panel3 = new Panel();
            CardTop = new MaterialSkin.Controls.MaterialCard();
            groupBox2 = new GroupBox();
            RbDeactive = new RadioButton();
            RbActivate = new RadioButton();
            groupBox1 = new GroupBox();
            TbSearch = new TextBox();
            panel4 = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            panel6 = new Panel();
            GvProducts = new DataGridView();
            ProductImage = new DataGridViewImageColumn();
            ProductSku = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ExpirationDate = new DataGridViewTextBoxColumn();
            ProductCategory = new DataGridViewComboBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            PanelRight.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            PanelBody.SuspendLayout();
            TbLayoutContent.SuspendLayout();
            panel3.SuspendLayout();
            CardTop.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            materialCard2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GvProducts).BeginInit();
            SuspendLayout();
            // 
            // PanelRight
            // 
            PanelRight.Controls.Add(panel1);
            PanelRight.Dock = DockStyle.Right;
            PanelRight.Font = new Font("Microsoft Sans Serif", 8.25F);
            PanelRight.Location = new Point(1050, 0);
            PanelRight.Name = "PanelRight";
            PanelRight.Size = new Size(150, 820);
            PanelRight.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnImportExcel);
            panel1.Controls.Add(BtnCloseForm);
            panel1.Controls.Add(BtnExportExcel);
            panel1.Controls.Add(BtnRefresh);
            panel1.Controls.Add(BtnAddProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 287);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 16);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 6;
            label1.Text = "Hành động";
            // 
            // BtnImportExcel
            // 
            BtnImportExcel.Font = new Font("Segoe UI", 9.75F);
            BtnImportExcel.IconChar = FontAwesome.Sharp.IconChar.ArrowRightToFile;
            BtnImportExcel.IconColor = Color.SlateGray;
            BtnImportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnImportExcel.IconSize = 24;
            BtnImportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            BtnImportExcel.Location = new Point(16, 91);
            BtnImportExcel.Name = "BtnImportExcel";
            BtnImportExcel.Size = new Size(120, 40);
            BtnImportExcel.TabIndex = 5;
            BtnImportExcel.Text = "Nhập Excel";
            BtnImportExcel.TextAlign = ContentAlignment.MiddleLeft;
            BtnImportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnImportExcel.UseVisualStyleBackColor = true;
            // 
            // BtnCloseForm
            // 
            BtnCloseForm.Font = new Font("Segoe UI", 9.75F);
            BtnCloseForm.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            BtnCloseForm.IconColor = Color.Red;
            BtnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCloseForm.IconSize = 24;
            BtnCloseForm.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCloseForm.Location = new Point(16, 225);
            BtnCloseForm.Name = "BtnCloseForm";
            BtnCloseForm.Size = new Size(120, 40);
            BtnCloseForm.TabIndex = 4;
            BtnCloseForm.Text = "Đóng";
            BtnCloseForm.TextAlign = ContentAlignment.MiddleLeft;
            BtnCloseForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCloseForm.UseVisualStyleBackColor = true;
            // 
            // BtnExportExcel
            // 
            BtnExportExcel.Font = new Font("Segoe UI", 9.75F);
            BtnExportExcel.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            BtnExportExcel.IconColor = Color.DimGray;
            BtnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnExportExcel.IconSize = 24;
            BtnExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExportExcel.Location = new Point(16, 133);
            BtnExportExcel.Name = "BtnExportExcel";
            BtnExportExcel.Size = new Size(120, 40);
            BtnExportExcel.TabIndex = 3;
            BtnExportExcel.Text = "Xuất Excel";
            BtnExportExcel.TextAlign = ContentAlignment.MiddleLeft;
            BtnExportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnExportExcel.UseVisualStyleBackColor = true;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Font = new Font("Segoe UI", 9.75F);
            BtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            BtnRefresh.IconColor = Color.DodgerBlue;
            BtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRefresh.IconSize = 24;
            BtnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRefresh.Location = new Point(16, 179);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(120, 40);
            BtnRefresh.TabIndex = 2;
            BtnRefresh.Text = "Làm mới";
            BtnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            BtnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Font = new Font("Segoe UI", 9.75F);
            BtnAddProduct.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            BtnAddProduct.IconColor = Color.OliveDrab;
            BtnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAddProduct.IconSize = 24;
            BtnAddProduct.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAddProduct.Location = new Point(16, 45);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(120, 40);
            BtnAddProduct.TabIndex = 1;
            BtnAddProduct.Text = "Thêm dòng";
            BtnAddProduct.TextAlign = ContentAlignment.MiddleLeft;
            BtnAddProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAddProduct.UseVisualStyleBackColor = true;
            // 
            // RemoveProduct
            // 
            RemoveProduct.HeaderText = "Xóa";
            RemoveProduct.Image = Properties.Resources.delete_16;
            RemoveProduct.Name = "RemoveProduct";
            RemoveProduct.Resizable = DataGridViewTriState.True;
            RemoveProduct.SortMode = DataGridViewColumnSortMode.Automatic;
            RemoveProduct.Width = 60;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(14, 1248);
            panel2.Name = "panel2";
            panel2.Size = new Size(1988, 45);
            panel2.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(CbPageSize);
            panel5.Controls.Add(TbPageSearch);
            panel5.Controls.Add(BtnPrev);
            panel5.Controls.Add(BtnNext);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1698, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(290, 45);
            panel5.TabIndex = 0;
            // 
            // CbPageSize
            // 
            CbPageSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbPageSize.FormattingEnabled = true;
            CbPageSize.Location = new Point(63, 11);
            CbPageSize.Name = "CbPageSize";
            CbPageSize.Size = new Size(57, 29);
            CbPageSize.TabIndex = 6;
            // 
            // TbPageSearch
            // 
            TbPageSearch.Anchor = AnchorStyles.None;
            TbPageSearch.BorderStyle = BorderStyle.FixedSingle;
            TbPageSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPageSearch.Location = new Point(216, -17);
            TbPageSearch.Name = "TbPageSearch";
            TbPageSearch.PlaceholderText = "Trang...";
            TbPageSearch.Size = new Size(76, 29);
            TbPageSearch.TabIndex = 3;
            // 
            // BtnPrev
            // 
            BtnPrev.Anchor = AnchorStyles.None;
            BtnPrev.AutoSize = true;
            BtnPrev.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnPrev.IconChar = FontAwesome.Sharp.IconChar.AnglesLeft;
            BtnPrev.IconColor = SystemColors.MenuText;
            BtnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnPrev.IconSize = 24;
            BtnPrev.Location = new Point(177, -18);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.Size = new Size(30, 30);
            BtnPrev.TabIndex = 5;
            BtnPrev.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            BtnNext.Anchor = AnchorStyles.None;
            BtnNext.AutoSize = true;
            BtnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnNext.IconChar = FontAwesome.Sharp.IconChar.AnglesRight;
            BtnNext.IconColor = SystemColors.MenuText;
            BtnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnNext.IconSize = 24;
            BtnNext.Location = new Point(301, -18);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(30, 30);
            BtnNext.TabIndex = 4;
            BtnNext.UseVisualStyleBackColor = true;
            // 
            // EditProduct
            // 
            EditProduct.HeaderText = "Sửa";
            EditProduct.Image = Properties.Resources.edit_16;
            EditProduct.Name = "EditProduct";
            EditProduct.Resizable = DataGridViewTriState.True;
            EditProduct.SortMode = DataGridViewColumnSortMode.Automatic;
            EditProduct.Width = 60;
            // 
            // PanelBody
            // 
            PanelBody.Controls.Add(TbLayoutContent);
            PanelBody.Dock = DockStyle.Fill;
            PanelBody.Location = new Point(0, 0);
            PanelBody.Name = "PanelBody";
            PanelBody.Size = new Size(1200, 820);
            PanelBody.TabIndex = 4;
            // 
            // TbLayoutContent
            // 
            TbLayoutContent.ColumnCount = 1;
            TbLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TbLayoutContent.Controls.Add(panel3, 0, 0);
            TbLayoutContent.Controls.Add(panel4, 0, 1);
            TbLayoutContent.Dock = DockStyle.Fill;
            TbLayoutContent.Location = new Point(0, 0);
            TbLayoutContent.Name = "TbLayoutContent";
            TbLayoutContent.RowCount = 2;
            TbLayoutContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 101F));
            TbLayoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 92.61214F));
            TbLayoutContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TbLayoutContent.Size = new Size(1200, 820);
            TbLayoutContent.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(CardTop);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1194, 95);
            panel3.TabIndex = 4;
            // 
            // CardTop
            // 
            CardTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CardTop.BackColor = Color.FromArgb(255, 255, 255);
            CardTop.Controls.Add(groupBox2);
            CardTop.Controls.Add(groupBox1);
            CardTop.Depth = 0;
            CardTop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardTop.Location = new Point(11, 5);
            CardTop.Margin = new Padding(14);
            CardTop.MouseState = MaterialSkin.MouseState.HOVER;
            CardTop.Name = "CardTop";
            CardTop.Padding = new Padding(14);
            CardTop.Size = new Size(2016, 79);
            CardTop.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RbDeactive);
            groupBox2.Controls.Add(RbActivate);
            groupBox2.Location = new Point(314, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 51);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trạng thái";
            // 
            // RbDeactive
            // 
            RbDeactive.AutoSize = true;
            RbDeactive.Location = new Point(120, 21);
            RbDeactive.Name = "RbDeactive";
            RbDeactive.Size = new Size(99, 19);
            RbDeactive.TabIndex = 1;
            RbDeactive.TabStop = true;
            RbDeactive.Text = "Hủy kích hoạt";
            RbDeactive.UseVisualStyleBackColor = true;
            // 
            // RbActivate
            // 
            RbActivate.AutoSize = true;
            RbActivate.Location = new Point(18, 21);
            RbActivate.Name = "RbActivate";
            RbActivate.Size = new Size(75, 19);
            RbActivate.TabIndex = 0;
            RbActivate.TabStop = true;
            RbActivate.Text = "Kích hoạt";
            RbActivate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TbSearch);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(14, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 51);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tra cứu nhanh";
            // 
            // TbSearch
            // 
            TbSearch.BorderStyle = BorderStyle.FixedSingle;
            TbSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbSearch.Location = new Point(11, 18);
            TbSearch.Name = "TbSearch";
            TbSearch.PlaceholderText = "Nhập từ khóa tìm kiếm...";
            TbSearch.Size = new Size(264, 25);
            TbSearch.TabIndex = 0;
            TbSearch.TextChanged += TbSearch_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(materialCard2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(1194, 713);
            panel4.TabIndex = 5;
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(panel6);
            materialCard2.Controls.Add(panel2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(11, 8);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(2016, 1307);
            materialCard2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(GvProducts);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(14, 14);
            panel6.Name = "panel6";
            panel6.Size = new Size(1988, 1234);
            panel6.TabIndex = 7;
            // 
            // GvProducts
            // 
            GvProducts.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            GvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            GvProducts.ColumnHeadersHeight = 35;
            GvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductImage, ProductSku, ProductName, ExpirationDate, ProductCategory, IsActive, EditProduct, RemoveProduct });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            GvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            GvProducts.Dock = DockStyle.Fill;
            GvProducts.EnableHeadersVisualStyles = false;
            GvProducts.Location = new Point(0, 0);
            GvProducts.Name = "GvProducts";
            GvProducts.RowTemplate.Height = 35;
            GvProducts.Size = new Size(1988, 1234);
            GvProducts.TabIndex = 2;
            // 
            // ProductImage
            // 
            ProductImage.HeaderText = "Hình ảnh";
            ProductImage.Name = "ProductImage";
            ProductImage.ReadOnly = true;
            ProductImage.Resizable = DataGridViewTriState.True;
            ProductImage.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ProductSku
            // 
            ProductSku.HeaderText = "Mã hàng";
            ProductSku.Name = "ProductSku";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Tên hàng";
            ProductName.Name = "ProductName";
            ProductName.Width = 200;
            // 
            // ExpirationDate
            // 
            ExpirationDate.HeaderText = "Hạn sử dụng";
            ExpirationDate.Name = "ExpirationDate";
            // 
            // ProductCategory
            // 
            ProductCategory.HeaderText = "Loại sản phẩm";
            ProductCategory.Name = "ProductCategory";
            ProductCategory.Resizable = DataGridViewTriState.True;
            ProductCategory.SortMode = DataGridViewColumnSortMode.Automatic;
            ProductCategory.Width = 200;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "Trạng thái";
            IsActive.Name = "IsActive";
            IsActive.Resizable = DataGridViewTriState.True;
            IsActive.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FormLocationManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 820);
            Controls.Add(PanelRight);
            Controls.Add(PanelBody);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLocationManagement";
            Text = "FormLocationManagement";
            PanelRight.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            PanelBody.ResumeLayout(false);
            TbLayoutContent.ResumeLayout(false);
            panel3.ResumeLayout(false);
            CardTop.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelRight;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnImportExcel;
        private FontAwesome.Sharp.IconButton BtnCloseForm;
        private FontAwesome.Sharp.IconButton BtnExportExcel;
        private FontAwesome.Sharp.IconButton BtnRefresh;
        private FontAwesome.Sharp.IconButton BtnAddProduct;
        private DataGridViewImageColumn RemoveProduct;
        private Panel panel2;
        private Panel panel5;
        private ComboBox CbPageSize;
        private TextBox TbPageSearch;
        private FontAwesome.Sharp.IconButton BtnPrev;
        private FontAwesome.Sharp.IconButton BtnNext;
        private DataGridViewImageColumn EditProduct;
        private Panel PanelBody;
        private TableLayoutPanel TbLayoutContent;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialCard CardTop;
        private GroupBox groupBox2;
        private RadioButton RbDeactive;
        private RadioButton RbActivate;
        private GroupBox groupBox1;
        private TextBox TbSearch;
        private Panel panel4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Panel panel6;
        private DataGridView GvProducts;
        private DataGridViewImageColumn ProductImage;
        private DataGridViewTextBoxColumn ProductSku;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ExpirationDate;
        private DataGridViewComboBoxColumn ProductCategory;
        private DataGridViewCheckBoxColumn IsActive;
    }
}