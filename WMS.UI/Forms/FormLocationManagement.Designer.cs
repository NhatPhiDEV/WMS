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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            PanelBody = new Panel();
            TbLayoutContent = new TableLayoutPanel();
            panel3 = new Panel();
            CardTop = new MaterialSkin.Controls.MaterialCard();
            groupBox1 = new GroupBox();
            TbSearch = new TextBox();
            panel4 = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            panel6 = new Panel();
            GvLocations = new DataGridView();
            panel2 = new Panel();
            panel5 = new Panel();
            CbPageSize = new ComboBox();
            TbPageSearch = new TextBox();
            BtnPrev = new FontAwesome.Sharp.IconButton();
            BtnNext = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            BtnCloseForm = new FontAwesome.Sharp.IconButton();
            BtnExportExcel = new FontAwesome.Sharp.IconButton();
            BtnRefresh = new FontAwesome.Sharp.IconButton();
            BtnAddProduct = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            PanelRight = new Panel();
            LocationId = new DataGridViewTextBoxColumn();
            LocationCode = new DataGridViewTextBoxColumn();
            LocationName = new DataGridViewTextBoxColumn();
            ZoneId = new DataGridViewTextBoxColumn();
            ZoneName = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            PointX = new DataGridViewTextBoxColumn();
            PointY = new DataGridViewTextBoxColumn();
            PointZ = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            UpdatedAt = new DataGridViewTextBoxColumn();
            Update = new DataGridViewImageColumn();
            Remove = new DataGridViewImageColumn();
            PanelBody.SuspendLayout();
            TbLayoutContent.SuspendLayout();
            panel3.SuspendLayout();
            CardTop.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            materialCard2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GvLocations).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            PanelRight.SuspendLayout();
            SuspendLayout();
            // 
            // PanelBody
            // 
            PanelBody.Controls.Add(TbLayoutContent);
            PanelBody.Dock = DockStyle.Fill;
            PanelBody.Location = new Point(0, 0);
            PanelBody.Name = "PanelBody";
            PanelBody.Size = new Size(1050, 820);
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
            CardTop.Location = new Point(8, 5);
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
            materialCard2.Location = new Point(8, 11);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(1022, 694);
            materialCard2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(GvLocations);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(14, 14);
            panel6.Name = "panel6";
            panel6.Size = new Size(994, 610);
            panel6.TabIndex = 7;
            // 
            // GvLocations
            // 
            GvLocations.AllowUserToAddRows = false;
            GvLocations.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GvLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GvLocations.ColumnHeadersHeight = 30;
            GvLocations.Columns.AddRange(new DataGridViewColumn[] { LocationId, LocationCode, LocationName, ZoneId, ZoneName, Capacity, PointX, PointY, PointZ, IsActive, CreatedAt, UpdatedAt, Update, Remove });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GvLocations.DefaultCellStyle = dataGridViewCellStyle2;
            GvLocations.Dock = DockStyle.Fill;
            GvLocations.EnableHeadersVisualStyles = false;
            GvLocations.Location = new Point(0, 0);
            GvLocations.Name = "GvLocations";
            GvLocations.RowTemplate.Height = 35;
            GvLocations.Size = new Size(994, 610);
            GvLocations.TabIndex = 2;
            GvLocations.CellClick += GvLocations_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(14, 624);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 56);
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
            panel5.Size = new Size(290, 56);
            panel5.TabIndex = 0;
            // 
            // CbPageSize
            // 
            CbPageSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbPageSize.FormattingEnabled = true;
            CbPageSize.Location = new Point(63, 10);
            CbPageSize.Name = "CbPageSize";
            CbPageSize.Size = new Size(57, 29);
            CbPageSize.TabIndex = 10;
            CbPageSize.SelectedIndexChanged += CbPageSize_SelectedIndexChanged;
            // 
            // TbPageSearch
            // 
            TbPageSearch.Anchor = AnchorStyles.None;
            TbPageSearch.BorderStyle = BorderStyle.FixedSingle;
            TbPageSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPageSearch.Location = new Point(171, 10);
            TbPageSearch.Name = "TbPageSearch";
            TbPageSearch.PlaceholderText = "Trang...";
            TbPageSearch.Size = new Size(76, 29);
            TbPageSearch.TabIndex = 7;
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
            BtnPrev.TabIndex = 9;
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
            BtnNext.TabIndex = 8;
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
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
            // BtnCloseForm
            // 
            BtnCloseForm.Font = new Font("Segoe UI", 9.75F);
            BtnCloseForm.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            BtnCloseForm.IconColor = Color.Red;
            BtnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCloseForm.IconSize = 24;
            BtnCloseForm.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCloseForm.Location = new Point(16, 183);
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
            BtnExportExcel.Location = new Point(16, 91);
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
            BtnRefresh.Location = new Point(16, 137);
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
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtnCloseForm);
            panel1.Controls.Add(BtnExportExcel);
            panel1.Controls.Add(BtnRefresh);
            panel1.Controls.Add(BtnAddProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 231);
            panel1.TabIndex = 1;
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
            // LocationId
            // 
            LocationId.HeaderText = "Id vị trí";
            LocationId.Name = "LocationId";
            LocationId.ReadOnly = true;
            LocationId.Visible = false;
            // 
            // LocationCode
            // 
            LocationCode.HeaderText = "Mã vị trí";
            LocationCode.Name = "LocationCode";
            LocationCode.ReadOnly = true;
            LocationCode.Width = 80;
            // 
            // LocationName
            // 
            LocationName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LocationName.HeaderText = "Tên vị trí";
            LocationName.Name = "LocationName";
            LocationName.ReadOnly = true;
            // 
            // ZoneId
            // 
            ZoneId.HeaderText = "Id Khu vực";
            ZoneId.Name = "ZoneId";
            ZoneId.ReadOnly = true;
            ZoneId.Visible = false;
            // 
            // ZoneName
            // 
            ZoneName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ZoneName.HeaderText = "Khu vực";
            ZoneName.Name = "ZoneName";
            ZoneName.ReadOnly = true;
            // 
            // Capacity
            // 
            Capacity.HeaderText = "Kích thước";
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            Capacity.Width = 80;
            // 
            // PointX
            // 
            PointX.HeaderText = "X";
            PointX.Name = "PointX";
            PointX.ReadOnly = true;
            PointX.Width = 40;
            // 
            // PointY
            // 
            PointY.HeaderText = "Y";
            PointY.Name = "PointY";
            PointY.ReadOnly = true;
            PointY.Width = 40;
            // 
            // PointZ
            // 
            PointZ.HeaderText = "Z";
            PointZ.Name = "PointZ";
            PointZ.ReadOnly = true;
            PointZ.Width = 40;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "Trạng thái";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Resizable = DataGridViewTriState.True;
            IsActive.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CreatedAt
            // 
            CreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CreatedAt.HeaderText = "Ngày tạo";
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            // 
            // UpdatedAt
            // 
            UpdatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UpdatedAt.HeaderText = "Ngày sửa";
            UpdatedAt.Name = "UpdatedAt";
            UpdatedAt.ReadOnly = true;
            // 
            // Update
            // 
            Update.HeaderText = "Sửa";
            Update.Image = Properties.Resources.edit_16;
            Update.Name = "Update";
            Update.ReadOnly = true;
            Update.Resizable = DataGridViewTriState.True;
            Update.SortMode = DataGridViewColumnSortMode.Automatic;
            Update.Width = 60;
            // 
            // Remove
            // 
            Remove.HeaderText = "Xóa";
            Remove.Image = Properties.Resources.delete_16;
            Remove.Name = "Remove";
            Remove.ReadOnly = true;
            Remove.Resizable = DataGridViewTriState.True;
            Remove.SortMode = DataGridViewColumnSortMode.Automatic;
            Remove.Width = 60;
            // 
            // FormLocationManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 820);
            Controls.Add(PanelBody);
            Controls.Add(PanelRight);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLocationManagement";
            Text = "FormLocationManagement";
            Load += FormLocationManagement_Load;
            PanelBody.ResumeLayout(false);
            TbLayoutContent.ResumeLayout(false);
            panel3.ResumeLayout(false);
            CardTop.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GvLocations).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBody;
        private TableLayoutPanel TbLayoutContent;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialCard CardTop;
        private GroupBox groupBox1;
        private TextBox TbSearch;
        private Panel panel4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Panel panel6;
        private DataGridView GvLocations;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnCloseForm;
        private FontAwesome.Sharp.IconButton BtnExportExcel;
        private FontAwesome.Sharp.IconButton BtnRefresh;
        private FontAwesome.Sharp.IconButton BtnAddProduct;
        private Panel panel1;
        private Panel PanelRight;
        private Panel panel5;
        private ComboBox CbPageSize;
        private TextBox TbPageSearch;
        private FontAwesome.Sharp.IconButton BtnPrev;
        private FontAwesome.Sharp.IconButton BtnNext;
        private DataGridViewTextBoxColumn LocationId;
        private DataGridViewTextBoxColumn LocationCode;
        private DataGridViewTextBoxColumn LocationName;
        private DataGridViewTextBoxColumn ZoneId;
        private DataGridViewTextBoxColumn ZoneName;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn PointX;
        private DataGridViewTextBoxColumn PointY;
        private DataGridViewTextBoxColumn PointZ;
        private DataGridViewCheckBoxColumn IsActive;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn UpdatedAt;
        private DataGridViewImageColumn Update;
        private DataGridViewImageColumn Remove;
    }
}