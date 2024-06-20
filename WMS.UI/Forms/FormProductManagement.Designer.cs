namespace WMS.UI.Forms
{
    partial class FormProductManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TbLayoutContent = new TableLayoutPanel();
            panel3 = new Panel();
            CardTop = new MaterialSkin.Controls.MaterialCard();
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
            ProductId = new DataGridViewTextBoxColumn();
            UpdateProduct = new DataGridViewImageColumn();
            RemoveProduct = new DataGridViewImageColumn();
            panel2 = new Panel();
            panel5 = new Panel();
            CbPageSize = new ComboBox();
            TbPageSearch = new TextBox();
            BtnPrev = new FontAwesome.Sharp.IconButton();
            BtnNext = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            BtnImportExcel = new FontAwesome.Sharp.IconButton();
            BtnCloseForm = new FontAwesome.Sharp.IconButton();
            BtnExportExcel = new FontAwesome.Sharp.IconButton();
            BtnRefresh = new FontAwesome.Sharp.IconButton();
            BtnAddProduct = new FontAwesome.Sharp.IconButton();
            PanelRight = new Panel();
            PanelBody = new Panel();
            TbLayoutContent.SuspendLayout();
            panel3.SuspendLayout();
            CardTop.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            materialCard2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GvProducts).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            PanelRight.SuspendLayout();
            PanelBody.SuspendLayout();
            SuspendLayout();
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
            TbLayoutContent.Size = new Size(1050, 820);
            TbLayoutContent.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(CardTop);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1044, 95);
            panel3.TabIndex = 4;
            // 
            // CardTop
            // 
            CardTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CardTop.BackColor = Color.FromArgb(255, 255, 255);
            CardTop.Controls.Add(groupBox1);
            CardTop.Depth = 0;
            CardTop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardTop.Location = new Point(11, 5);
            CardTop.Margin = new Padding(14);
            CardTop.MouseState = MaterialSkin.MouseState.HOVER;
            CardTop.Name = "CardTop";
            CardTop.Padding = new Padding(14);
            CardTop.Size = new Size(1022, 79);
            CardTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TbSearch);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(14, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 51);
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
            TbSearch.Size = new Size(430, 25);
            TbSearch.TabIndex = 0;
            TbSearch.KeyDown += TbSearch_KeyDown;
            // 
            // panel4
            // 
            panel4.Controls.Add(materialCard2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(1044, 713);
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
            materialCard2.Size = new Size(1022, 694);
            materialCard2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(GvProducts);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(14, 14);
            panel6.Name = "panel6";
            panel6.Size = new Size(994, 621);
            panel6.TabIndex = 7;
            // 
            // GvProducts
            // 
            GvProducts.AllowUserToAddRows = false;
            GvProducts.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GvProducts.ColumnHeadersHeight = 35;
            GvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductImage, ProductSku, ProductName, ExpirationDate, ProductCategory, IsActive, ProductId, UpdateProduct, RemoveProduct });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            GvProducts.Dock = DockStyle.Fill;
            GvProducts.EnableHeadersVisualStyles = false;
            GvProducts.Location = new Point(0, 0);
            GvProducts.Name = "GvProducts";
            GvProducts.RowTemplate.Height = 35;
            GvProducts.Size = new Size(994, 621);
            GvProducts.TabIndex = 2;
            GvProducts.CellClick += GvProducts_CellClick;
            GvProducts.CellFormatting += GvProducts_CellFormatting;
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
            // ProductId
            // 
            ProductId.HeaderText = "Id Sản Phẩm";
            ProductId.Name = "ProductId";
            // 
            // UpdateProduct
            // 
            UpdateProduct.HeaderText = "Sửa";
            UpdateProduct.Image = Properties.Resources.edit_16;
            UpdateProduct.Name = "UpdateProduct";
            UpdateProduct.Resizable = DataGridViewTriState.True;
            UpdateProduct.SortMode = DataGridViewColumnSortMode.Automatic;
            UpdateProduct.Width = 60;
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
            panel2.Location = new Point(14, 635);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 45);
            panel2.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(CbPageSize);
            panel5.Controls.Add(TbPageSearch);
            panel5.Controls.Add(BtnPrev);
            panel5.Controls.Add(BtnNext);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(704, 0);
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
            CbPageSize.SelectedIndexChanged += CbPageSize_SelectedIndexChanged;
            // 
            // TbPageSearch
            // 
            TbPageSearch.Anchor = AnchorStyles.None;
            TbPageSearch.BorderStyle = BorderStyle.FixedSingle;
            TbPageSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPageSearch.Location = new Point(171, 11);
            TbPageSearch.Name = "TbPageSearch";
            TbPageSearch.PlaceholderText = "Trang...";
            TbPageSearch.Size = new Size(76, 29);
            TbPageSearch.TabIndex = 3;
            TbPageSearch.KeyDown += TbPageSearch_KeyDown;
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
            BtnPrev.Location = new Point(132, 10);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.Size = new Size(30, 30);
            BtnPrev.TabIndex = 5;
            BtnPrev.UseVisualStyleBackColor = true;
            BtnPrev.Click += BtnPrev_Click;
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
            BtnNext.Location = new Point(256, 10);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(30, 30);
            BtnNext.TabIndex = 4;
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
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
            BtnImportExcel.Click += BtnImportExcel_Click;
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
            BtnCloseForm.Click += BtnCloseForm_Click;
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
            BtnExportExcel.Click += BtnExportExcel_Click;
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
            BtnRefresh.Click += BtnRefresh_Click;
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
            BtnAddProduct.Click += BtnAddProduct_Click;
            // 
            // PanelRight
            // 
            PanelRight.Controls.Add(panel1);
            PanelRight.Dock = DockStyle.Right;
            PanelRight.Font = new Font("Microsoft Sans Serif", 8.25F);
            PanelRight.Location = new Point(1050, 0);
            PanelRight.Name = "PanelRight";
            PanelRight.Size = new Size(150, 820);
            PanelRight.TabIndex = 1;
            // 
            // PanelBody
            // 
            PanelBody.Controls.Add(TbLayoutContent);
            PanelBody.Dock = DockStyle.Fill;
            PanelBody.Location = new Point(0, 0);
            PanelBody.Name = "PanelBody";
            PanelBody.Size = new Size(1050, 820);
            PanelBody.TabIndex = 2;
            // 
            // FormProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 820);
            Controls.Add(PanelBody);
            Controls.Add(PanelRight);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductManagement";
            Text = "FormProductManagement";
            Load += FormProductManagement_Load;
            TbLayoutContent.ResumeLayout(false);
            panel3.ResumeLayout(false);
            CardTop.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GvProducts).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelRight.ResumeLayout(false);
            PanelBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TbLayoutContent;
        private Panel panel1;
        private Panel PanelRight;
        private Panel PanelBody;
        private FontAwesome.Sharp.IconButton BtnAddProduct;
        private FontAwesome.Sharp.IconButton BtnRefresh;
        private FontAwesome.Sharp.IconButton BtnExportExcel;
        private FontAwesome.Sharp.IconButton BtnCloseForm;
        private FontAwesome.Sharp.IconButton BtnImportExcel;
        private Label label1;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialCard CardTop;
        private Panel panel4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Panel panel2;
        private Panel panel5;
        private TextBox TbPageSearch;
        private FontAwesome.Sharp.IconButton BtnPrev;
        private FontAwesome.Sharp.IconButton BtnNext;
        private Panel panel6;
        private DataGridView GvProducts;
        private ComboBox CbPageSize;
        private GroupBox groupBox1;
        private TextBox TbSearch;
        private DataGridViewImageColumn ProductImage;
        private DataGridViewTextBoxColumn ProductSku;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ExpirationDate;
        private DataGridViewComboBoxColumn ProductCategory;
        private DataGridViewCheckBoxColumn IsActive;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewImageColumn UpdateProduct;
        private DataGridViewImageColumn RemoveProduct;
    }
}