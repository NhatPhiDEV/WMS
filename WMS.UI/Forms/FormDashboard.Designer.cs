namespace WMS.UI.Forms
{
    partial class FormDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            GbTransaction = new GroupBox();
            dgvInventoryTransactionType = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colProductSku = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colInventoryTransactionType = new DataGridViewTextBoxColumn();
            colQuanlity = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTransactionDate = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            PnTransaction = new Panel();
            tbSearchInventoryTransaction = new TextBox();
            GbProcess = new GroupBox();
            DgvProcess = new DataGridView();
            GvProcessColCheckBox = new DataGridViewCheckBoxColumn();
            GvProcessColStt = new DataGridViewTextBoxColumn();
            GvProcessColSku = new DataGridViewTextBoxColumn();
            GvProcessColTransactionType = new DataGridViewTextBoxColumn();
            GvProcessColLocation = new DataGridViewTextBoxColumn();
            GvProcessColQuantity = new DataGridViewTextBoxColumn();
            GvProcessColLocationId = new DataGridViewTextBoxColumn();
            GvProcessColTransactionTypeId = new DataGridViewTextBoxColumn();
            panel13 = new Panel();
            BtnExecuteAll = new FontAwesome.Sharp.IconButton();
            BtnExecuteSelected = new FontAwesome.Sharp.IconButton();
            BtnDeleteAll = new FontAwesome.Sharp.IconButton();
            BtnDeleteSelected = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            CardLocations = new MaterialSkin.Controls.MaterialCard();
            FlpLocations = new FlowLayoutPanel();
            GbSearchByProduct = new GroupBox();
            TbSearchByProduct = new TextBox();
            GbSearchByLocation = new GroupBox();
            TbSearchByLocation = new TextBox();
            GbZones = new GroupBox();
            flpZones = new FlowLayoutPanel();
            groupBox3 = new GroupBox();
            BtnRefresh = new FontAwesome.Sharp.IconButton();
            BtnAddToQueue = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            LbQuantityLimit = new Label();
            NumQuantity = new NumericUpDown();
            NumQuantityLimit = new NumericUpDown();
            LabelQuantity = new Label();
            panel8 = new Panel();
            CboLocation = new ComboBox();
            LbLocation = new Label();
            panel6 = new Panel();
            DtpCurrentDate = new DateTimePicker();
            LbCurrentDate = new Label();
            panel5 = new Panel();
            CboStrategy = new ComboBox();
            LbStrategy = new Label();
            panel4 = new Panel();
            CboInventoryTransactionType = new ComboBox();
            LbInventoryTransactionType = new Label();
            panel10 = new Panel();
            LbSku = new Label();
            TbSku = new TextBox();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            materialCard1.SuspendLayout();
            GbTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryTransactionType).BeginInit();
            PnTransaction.SuspendLayout();
            GbProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProcess).BeginInit();
            panel13.SuspendLayout();
            panel1.SuspendLayout();
            CardLocations.SuspendLayout();
            GbSearchByProduct.SuspendLayout();
            GbSearchByLocation.SuspendLayout();
            GbZones.SuspendLayout();
            groupBox3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumQuantityLimit).BeginInit();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(GbTransaction);
            materialCard1.Controls.Add(GbProcess);
            materialCard1.Controls.Add(panel1);
            materialCard1.Controls.Add(groupBox3);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(10, 10);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1360, 800);
            materialCard1.TabIndex = 0;
            // 
            // GbTransaction
            // 
            GbTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GbTransaction.Controls.Add(dgvInventoryTransactionType);
            GbTransaction.Controls.Add(PnTransaction);
            GbTransaction.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbTransaction.Location = new Point(7, 424);
            GbTransaction.Name = "GbTransaction";
            GbTransaction.Size = new Size(805, 371);
            GbTransaction.TabIndex = 3;
            GbTransaction.TabStop = false;
            GbTransaction.Text = "Lịch sử thực thi";
            // 
            // dgvInventoryTransactionType
            // 
            dgvInventoryTransactionType.AllowUserToAddRows = false;
            dgvInventoryTransactionType.AllowUserToDeleteRows = false;
            dgvInventoryTransactionType.BackgroundColor = SystemColors.Control;
            dgvInventoryTransactionType.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventoryTransactionType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventoryTransactionType.ColumnHeadersHeight = 30;
            dgvInventoryTransactionType.Columns.AddRange(new DataGridViewColumn[] { colSTT, colProductSku, colLocation, colInventoryTransactionType, colQuanlity, colStatus, colTransactionDate, colReason });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvInventoryTransactionType.DefaultCellStyle = dataGridViewCellStyle4;
            dgvInventoryTransactionType.Dock = DockStyle.Fill;
            dgvInventoryTransactionType.EnableHeadersVisualStyles = false;
            dgvInventoryTransactionType.GridColor = SystemColors.Control;
            dgvInventoryTransactionType.Location = new Point(3, 61);
            dgvInventoryTransactionType.Name = "dgvInventoryTransactionType";
            dgvInventoryTransactionType.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvInventoryTransactionType.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvInventoryTransactionType.RowHeadersVisible = false;
            dgvInventoryTransactionType.Size = new Size(799, 307);
            dgvInventoryTransactionType.TabIndex = 1;
            dgvInventoryTransactionType.CellFormatting += DgvInventoryTransactionType_CellFormatting;
            // 
            // colSTT
            // 
            colSTT.Frozen = true;
            colSTT.HeaderText = "STT";
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            colSTT.Width = 40;
            // 
            // colProductSku
            // 
            colProductSku.Frozen = true;
            colProductSku.HeaderText = "Mã SP";
            colProductSku.Name = "colProductSku";
            colProductSku.ReadOnly = true;
            colProductSku.Width = 150;
            // 
            // colLocation
            // 
            colLocation.Frozen = true;
            colLocation.HeaderText = "Vị trí";
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            colLocation.Width = 80;
            // 
            // colInventoryTransactionType
            // 
            colInventoryTransactionType.HeaderText = "Lệnh";
            colInventoryTransactionType.Name = "colInventoryTransactionType";
            colInventoryTransactionType.ReadOnly = true;
            colInventoryTransactionType.Width = 80;
            // 
            // colQuanlity
            // 
            colQuanlity.HeaderText = "SL";
            colQuanlity.Name = "colQuanlity";
            colQuanlity.ReadOnly = true;
            colQuanlity.Width = 50;
            // 
            // colStatus
            // 
            dataGridViewCellStyle2.BackColor = Color.White;
            colStatus.DefaultCellStyle = dataGridViewCellStyle2;
            colStatus.HeaderText = "Trạng Thái";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colTransactionDate
            // 
            dataGridViewCellStyle3.BackColor = Color.White;
            colTransactionDate.DefaultCellStyle = dataGridViewCellStyle3;
            colTransactionDate.HeaderText = "Thời gian";
            colTransactionDate.Name = "colTransactionDate";
            colTransactionDate.ReadOnly = true;
            colTransactionDate.Width = 150;
            // 
            // colReason
            // 
            colReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colReason.HeaderText = "Ghi chú";
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            // 
            // PnTransaction
            // 
            PnTransaction.Controls.Add(tbSearchInventoryTransaction);
            PnTransaction.Dock = DockStyle.Top;
            PnTransaction.Location = new Point(3, 21);
            PnTransaction.Name = "PnTransaction";
            PnTransaction.Size = new Size(799, 40);
            PnTransaction.TabIndex = 0;
            // 
            // tbSearchInventoryTransaction
            // 
            tbSearchInventoryTransaction.BorderStyle = BorderStyle.FixedSingle;
            tbSearchInventoryTransaction.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearchInventoryTransaction.Location = new Point(7, 8);
            tbSearchInventoryTransaction.Name = "tbSearchInventoryTransaction";
            tbSearchInventoryTransaction.PlaceholderText = " Nhập từ khóa tìm kiếm...";
            tbSearchInventoryTransaction.Size = new Size(300, 25);
            tbSearchInventoryTransaction.TabIndex = 10;
            tbSearchInventoryTransaction.KeyDown += TbSearchInventoryTransaction_KeyDown;
            // 
            // GbProcess
            // 
            GbProcess.Controls.Add(DgvProcess);
            GbProcess.Controls.Add(panel13);
            GbProcess.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbProcess.Location = new Point(294, 8);
            GbProcess.Name = "GbProcess";
            GbProcess.Size = new Size(518, 410);
            GbProcess.TabIndex = 23;
            GbProcess.TabStop = false;
            GbProcess.Text = "Danh sách tiến trình";
            // 
            // DgvProcess
            // 
            DgvProcess.AllowUserToAddRows = false;
            DgvProcess.AllowUserToDeleteRows = false;
            DgvProcess.BackgroundColor = SystemColors.Control;
            DgvProcess.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DgvProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DgvProcess.ColumnHeadersHeight = 30;
            DgvProcess.Columns.AddRange(new DataGridViewColumn[] { GvProcessColCheckBox, GvProcessColStt, GvProcessColSku, GvProcessColTransactionType, GvProcessColLocation, GvProcessColQuantity, GvProcessColLocationId, GvProcessColTransactionTypeId });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            DgvProcess.DefaultCellStyle = dataGridViewCellStyle7;
            DgvProcess.Dock = DockStyle.Fill;
            DgvProcess.EnableHeadersVisualStyles = false;
            DgvProcess.GridColor = SystemColors.Control;
            DgvProcess.Location = new Point(3, 21);
            DgvProcess.Name = "DgvProcess";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DgvProcess.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DgvProcess.RowHeadersVisible = false;
            DgvProcess.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DgvProcess.Size = new Size(512, 335);
            DgvProcess.TabIndex = 3;
            // 
            // GvProcessColCheckBox
            // 
            GvProcessColCheckBox.HeaderText = "";
            GvProcessColCheckBox.Name = "GvProcessColCheckBox";
            GvProcessColCheckBox.Width = 24;
            // 
            // GvProcessColStt
            // 
            GvProcessColStt.HeaderText = "STT";
            GvProcessColStt.Name = "GvProcessColStt";
            GvProcessColStt.ReadOnly = true;
            GvProcessColStt.Width = 40;
            // 
            // GvProcessColSku
            // 
            GvProcessColSku.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GvProcessColSku.HeaderText = "Mã SP";
            GvProcessColSku.Name = "GvProcessColSku";
            GvProcessColSku.ReadOnly = true;
            // 
            // GvProcessColTransactionType
            // 
            GvProcessColTransactionType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GvProcessColTransactionType.HeaderText = "Lệnh";
            GvProcessColTransactionType.Name = "GvProcessColTransactionType";
            GvProcessColTransactionType.ReadOnly = true;
            GvProcessColTransactionType.Resizable = DataGridViewTriState.True;
            GvProcessColTransactionType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // GvProcessColLocation
            // 
            GvProcessColLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GvProcessColLocation.HeaderText = "Vị trí";
            GvProcessColLocation.Name = "GvProcessColLocation";
            GvProcessColLocation.ReadOnly = true;
            // 
            // GvProcessColQuantity
            // 
            GvProcessColQuantity.HeaderText = "SL";
            GvProcessColQuantity.Name = "GvProcessColQuantity";
            GvProcessColQuantity.ReadOnly = true;
            GvProcessColQuantity.Resizable = DataGridViewTriState.True;
            GvProcessColQuantity.SortMode = DataGridViewColumnSortMode.NotSortable;
            GvProcessColQuantity.Width = 50;
            // 
            // GvProcessColLocationId
            // 
            GvProcessColLocationId.HeaderText = "LocationId";
            GvProcessColLocationId.Name = "GvProcessColLocationId";
            GvProcessColLocationId.ReadOnly = true;
            GvProcessColLocationId.Visible = false;
            GvProcessColLocationId.Width = 5;
            // 
            // GvProcessColTransactionTypeId
            // 
            GvProcessColTransactionTypeId.HeaderText = "TransactionTypeId";
            GvProcessColTransactionTypeId.Name = "GvProcessColTransactionTypeId";
            GvProcessColTransactionTypeId.Visible = false;
            // 
            // panel13
            // 
            panel13.Controls.Add(BtnExecuteAll);
            panel13.Controls.Add(BtnExecuteSelected);
            panel13.Controls.Add(BtnDeleteAll);
            panel13.Controls.Add(BtnDeleteSelected);
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(3, 356);
            panel13.Name = "panel13";
            panel13.Size = new Size(512, 51);
            panel13.TabIndex = 2;
            // 
            // BtnExecuteAll
            // 
            BtnExecuteAll.Font = new Font("Segoe UI", 9.75F);
            BtnExecuteAll.IconChar = FontAwesome.Sharp.IconChar.ChalkboardUser;
            BtnExecuteAll.IconColor = Color.DodgerBlue;
            BtnExecuteAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnExecuteAll.IconSize = 24;
            BtnExecuteAll.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExecuteAll.Location = new Point(385, 5);
            BtnExecuteAll.Name = "BtnExecuteAll";
            BtnExecuteAll.Size = new Size(120, 40);
            BtnExecuteAll.TabIndex = 8;
            BtnExecuteAll.Text = "Xử lý tất cả";
            BtnExecuteAll.TextAlign = ContentAlignment.MiddleLeft;
            BtnExecuteAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnExecuteAll.UseVisualStyleBackColor = true;
            BtnExecuteAll.Click += BtnExecuteAll_Click;
            // 
            // BtnExecuteSelected
            // 
            BtnExecuteSelected.Font = new Font("Segoe UI", 9.75F);
            BtnExecuteSelected.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            BtnExecuteSelected.IconColor = Color.DodgerBlue;
            BtnExecuteSelected.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnExecuteSelected.IconSize = 24;
            BtnExecuteSelected.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExecuteSelected.Location = new Point(259, 5);
            BtnExecuteSelected.Name = "BtnExecuteSelected";
            BtnExecuteSelected.Size = new Size(120, 40);
            BtnExecuteSelected.TabIndex = 7;
            BtnExecuteSelected.Text = "Xử lý các mục";
            BtnExecuteSelected.TextAlign = ContentAlignment.MiddleLeft;
            BtnExecuteSelected.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnExecuteSelected.UseVisualStyleBackColor = true;
            BtnExecuteSelected.Click += BtnExecuteSelected_Click;
            // 
            // BtnDeleteAll
            // 
            BtnDeleteAll.Font = new Font("Segoe UI", 9.75F);
            BtnDeleteAll.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnDeleteAll.IconColor = Color.Red;
            BtnDeleteAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnDeleteAll.IconSize = 24;
            BtnDeleteAll.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDeleteAll.Location = new Point(133, 5);
            BtnDeleteAll.Name = "BtnDeleteAll";
            BtnDeleteAll.Size = new Size(120, 40);
            BtnDeleteAll.TabIndex = 6;
            BtnDeleteAll.Text = "Xóa tất cả";
            BtnDeleteAll.TextAlign = ContentAlignment.MiddleLeft;
            BtnDeleteAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDeleteAll.UseVisualStyleBackColor = true;
            BtnDeleteAll.Click += BtnDeleteAll_Click;
            // 
            // BtnDeleteSelected
            // 
            BtnDeleteSelected.Font = new Font("Segoe UI", 9.75F);
            BtnDeleteSelected.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            BtnDeleteSelected.IconColor = Color.Red;
            BtnDeleteSelected.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnDeleteSelected.IconSize = 24;
            BtnDeleteSelected.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDeleteSelected.Location = new Point(7, 5);
            BtnDeleteSelected.Name = "BtnDeleteSelected";
            BtnDeleteSelected.Size = new Size(120, 40);
            BtnDeleteSelected.TabIndex = 5;
            BtnDeleteSelected.Text = "Xóa các mục";
            BtnDeleteSelected.TextAlign = ContentAlignment.MiddleLeft;
            BtnDeleteSelected.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDeleteSelected.UseVisualStyleBackColor = true;
            BtnDeleteSelected.Click += BtnDeleteSelected_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(CardLocations);
            panel1.Controls.Add(GbSearchByProduct);
            panel1.Controls.Add(GbSearchByLocation);
            panel1.Controls.Add(GbZones);
            panel1.Location = new Point(819, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 793);
            panel1.TabIndex = 21;
            // 
            // CardLocations
            // 
            CardLocations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CardLocations.BackColor = Color.FromArgb(255, 255, 255);
            CardLocations.Controls.Add(FlpLocations);
            CardLocations.Depth = 0;
            CardLocations.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CardLocations.Location = new Point(3, 143);
            CardLocations.Margin = new Padding(14);
            CardLocations.MouseState = MaterialSkin.MouseState.HOVER;
            CardLocations.Name = "CardLocations";
            CardLocations.Padding = new Padding(14);
            CardLocations.Size = new Size(527, 641);
            CardLocations.TabIndex = 29;
            // 
            // FlpLocations
            // 
            FlpLocations.AutoScroll = true;
            FlpLocations.Dock = DockStyle.Fill;
            FlpLocations.FlowDirection = FlowDirection.TopDown;
            FlpLocations.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FlpLocations.Location = new Point(14, 14);
            FlpLocations.Name = "FlpLocations";
            FlpLocations.Size = new Size(499, 613);
            FlpLocations.TabIndex = 3;
            FlpLocations.WrapContents = false;
            FlpLocations.Resize += FlpLocations_Resize;
            // 
            // GbSearchByProduct
            // 
            GbSearchByProduct.Controls.Add(TbSearchByProduct);
            GbSearchByProduct.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            GbSearchByProduct.Location = new Point(270, 79);
            GbSearchByProduct.Name = "GbSearchByProduct";
            GbSearchByProduct.Size = new Size(260, 54);
            GbSearchByProduct.TabIndex = 28;
            GbSearchByProduct.TabStop = false;
            GbSearchByProduct.Text = "Tra cứu nhanh theo mã hàng:";
            // 
            // TbSearchByProduct
            // 
            TbSearchByProduct.BorderStyle = BorderStyle.FixedSingle;
            TbSearchByProduct.Dock = DockStyle.Fill;
            TbSearchByProduct.Font = new Font("Segoe UI", 9.75F);
            TbSearchByProduct.Location = new Point(3, 21);
            TbSearchByProduct.Name = "TbSearchByProduct";
            TbSearchByProduct.Size = new Size(254, 25);
            TbSearchByProduct.TabIndex = 1;
            TbSearchByProduct.KeyDown += TbSearchByProduct_KeyDown;
            // 
            // GbSearchByLocation
            // 
            GbSearchByLocation.Controls.Add(TbSearchByLocation);
            GbSearchByLocation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbSearchByLocation.Location = new Point(3, 78);
            GbSearchByLocation.Name = "GbSearchByLocation";
            GbSearchByLocation.Size = new Size(260, 54);
            GbSearchByLocation.TabIndex = 26;
            GbSearchByLocation.TabStop = false;
            GbSearchByLocation.Text = "Tra cứu nhanh theo vị trí:";
            // 
            // TbSearchByLocation
            // 
            TbSearchByLocation.BorderStyle = BorderStyle.FixedSingle;
            TbSearchByLocation.Dock = DockStyle.Fill;
            TbSearchByLocation.Font = new Font("Segoe UI", 9.75F);
            TbSearchByLocation.Location = new Point(3, 21);
            TbSearchByLocation.Name = "TbSearchByLocation";
            TbSearchByLocation.Size = new Size(254, 25);
            TbSearchByLocation.TabIndex = 1;
            TbSearchByLocation.KeyDown += TbSearchByLocation_KeyDown;
            // 
            // GbZones
            // 
            GbZones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GbZones.Controls.Add(flpZones);
            GbZones.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbZones.Location = new Point(3, 4);
            GbZones.Name = "GbZones";
            GbZones.Size = new Size(527, 70);
            GbZones.TabIndex = 25;
            GbZones.TabStop = false;
            GbZones.Text = "Danh sách khu vực";
            // 
            // flpZones
            // 
            flpZones.Dock = DockStyle.Fill;
            flpZones.Font = new Font("Segoe UI", 9.75F);
            flpZones.Location = new Point(3, 21);
            flpZones.Name = "flpZones";
            flpZones.Size = new Size(521, 46);
            flpZones.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnRefresh);
            groupBox3.Controls.Add(BtnAddToQueue);
            groupBox3.Controls.Add(panel9);
            groupBox3.Controls.Add(panel8);
            groupBox3.Controls.Add(panel6);
            groupBox3.Controls.Add(panel5);
            groupBox3.Controls.Add(panel4);
            groupBox3.Controls.Add(panel10);
            groupBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            groupBox3.Location = new Point(7, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(281, 410);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // BtnRefresh
            // 
            BtnRefresh.Font = new Font("Segoe UI", 9.75F);
            BtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            BtnRefresh.IconColor = Color.DodgerBlue;
            BtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRefresh.IconSize = 24;
            BtnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRefresh.Location = new Point(146, 362);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(120, 40);
            BtnRefresh.TabIndex = 9;
            BtnRefresh.Text = "Làm mới";
            BtnRefresh.TextAlign = ContentAlignment.MiddleLeft;
            BtnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // BtnAddToQueue
            // 
            BtnAddToQueue.Font = new Font("Segoe UI", 9.75F);
            BtnAddToQueue.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            BtnAddToQueue.IconColor = Color.OliveDrab;
            BtnAddToQueue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAddToQueue.IconSize = 24;
            BtnAddToQueue.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAddToQueue.Location = new Point(17, 362);
            BtnAddToQueue.Name = "BtnAddToQueue";
            BtnAddToQueue.Size = new Size(120, 40);
            BtnAddToQueue.TabIndex = 0;
            BtnAddToQueue.Text = "Thêm dòng";
            BtnAddToQueue.TextAlign = ContentAlignment.MiddleLeft;
            BtnAddToQueue.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAddToQueue.UseVisualStyleBackColor = true;
            BtnAddToQueue.Click += BtnAddToQueue_Click;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(LbQuantityLimit);
            panel9.Controls.Add(NumQuantity);
            panel9.Controls.Add(NumQuantityLimit);
            panel9.Controls.Add(LabelQuantity);
            panel9.Location = new Point(10, 308);
            panel9.Name = "panel9";
            panel9.Size = new Size(260, 46);
            panel9.TabIndex = 8;
            // 
            // LbQuantityLimit
            // 
            LbQuantityLimit.AutoSize = true;
            LbQuantityLimit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LbQuantityLimit.Location = new Point(157, 15);
            LbQuantityLimit.Name = "LbQuantityLimit";
            LbQuantityLimit.Size = new Size(48, 17);
            LbQuantityLimit.TabIndex = 6;
            LbQuantityLimit.Text = "Tối đa:";
            // 
            // NumQuantity
            // 
            NumQuantity.Font = new Font("Segoe UI", 9.75F);
            NumQuantity.Location = new Point(93, 11);
            NumQuantity.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            NumQuantity.Name = "NumQuantity";
            NumQuantity.Size = new Size(46, 25);
            NumQuantity.TabIndex = 6;
            NumQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumQuantityLimit
            // 
            NumQuantityLimit.Enabled = false;
            NumQuantityLimit.Font = new Font("Segoe UI", 9.75F);
            NumQuantityLimit.Location = new Point(206, 11);
            NumQuantityLimit.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            NumQuantityLimit.Name = "NumQuantityLimit";
            NumQuantityLimit.Size = new Size(42, 25);
            NumQuantityLimit.TabIndex = 5;
            NumQuantityLimit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LabelQuantity
            // 
            LabelQuantity.AutoSize = true;
            LabelQuantity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LabelQuantity.Location = new Point(10, 13);
            LabelQuantity.Name = "LabelQuantity";
            LabelQuantity.Size = new Size(65, 17);
            LabelQuantity.TabIndex = 1;
            LabelQuantity.Text = "Số lượng:";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(CboLocation);
            panel8.Controls.Add(LbLocation);
            panel8.Location = new Point(10, 251);
            panel8.Name = "panel8";
            panel8.Size = new Size(260, 46);
            panel8.TabIndex = 5;
            // 
            // CboLocation
            // 
            CboLocation.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CboLocation.FormattingEnabled = true;
            CboLocation.Location = new Point(93, 9);
            CboLocation.Name = "CboLocation";
            CboLocation.Size = new Size(155, 25);
            CboLocation.TabIndex = 5;
            CboLocation.SelectedIndexChanged += CboLocation_SelectedIndexChanged;
            // 
            // LbLocation
            // 
            LbLocation.AutoSize = true;
            LbLocation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LbLocation.Location = new Point(10, 14);
            LbLocation.Name = "LbLocation";
            LbLocation.Size = new Size(39, 17);
            LbLocation.TabIndex = 7;
            LbLocation.Text = "Vị trí:";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(DtpCurrentDate);
            panel6.Controls.Add(LbCurrentDate);
            panel6.Location = new Point(10, 194);
            panel6.Name = "panel6";
            panel6.Size = new Size(260, 46);
            panel6.TabIndex = 3;
            // 
            // DtpCurrentDate
            // 
            DtpCurrentDate.Enabled = false;
            DtpCurrentDate.Font = new Font("Segoe UI", 9.75F);
            DtpCurrentDate.Format = DateTimePickerFormat.Short;
            DtpCurrentDate.Location = new Point(93, 9);
            DtpCurrentDate.Name = "DtpCurrentDate";
            DtpCurrentDate.Size = new Size(155, 25);
            DtpCurrentDate.TabIndex = 3;
            // 
            // LbCurrentDate
            // 
            LbCurrentDate.AutoSize = true;
            LbCurrentDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LbCurrentDate.Location = new Point(10, 14);
            LbCurrentDate.Name = "LbCurrentDate";
            LbCurrentDate.Size = new Size(83, 17);
            LbCurrentDate.TabIndex = 1;
            LbCurrentDate.Text = "Ngày tháng:";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(CboStrategy);
            panel5.Controls.Add(LbStrategy);
            panel5.Location = new Point(10, 137);
            panel5.Name = "panel5";
            panel5.Size = new Size(260, 46);
            panel5.TabIndex = 2;
            // 
            // CboStrategy
            // 
            CboStrategy.Enabled = false;
            CboStrategy.Font = new Font("Segoe UI", 9.75F);
            CboStrategy.FormattingEnabled = true;
            CboStrategy.Location = new Point(93, 8);
            CboStrategy.Name = "CboStrategy";
            CboStrategy.Size = new Size(155, 25);
            CboStrategy.TabIndex = 2;
            // 
            // LbStrategy
            // 
            LbStrategy.AutoSize = true;
            LbStrategy.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LbStrategy.Location = new Point(10, 11);
            LbStrategy.Name = "LbStrategy";
            LbStrategy.Size = new Size(74, 17);
            LbStrategy.TabIndex = 1;
            LbStrategy.Text = "Chiến lược:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(CboInventoryTransactionType);
            panel4.Controls.Add(LbInventoryTransactionType);
            panel4.Location = new Point(10, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 46);
            panel4.TabIndex = 1;
            // 
            // CboInventoryTransactionType
            // 
            CboInventoryTransactionType.Font = new Font("Segoe UI", 9.75F);
            CboInventoryTransactionType.FormattingEnabled = true;
            CboInventoryTransactionType.Location = new Point(93, 11);
            CboInventoryTransactionType.Name = "CboInventoryTransactionType";
            CboInventoryTransactionType.Size = new Size(155, 25);
            CboInventoryTransactionType.TabIndex = 1;
            CboInventoryTransactionType.SelectedIndexChanged += CboInventoryTransactionType_SelectedIndexChanged;
            // 
            // LbInventoryTransactionType
            // 
            LbInventoryTransactionType.AutoSize = true;
            LbInventoryTransactionType.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LbInventoryTransactionType.Location = new Point(10, 11);
            LbInventoryTransactionType.Name = "LbInventoryTransactionType";
            LbInventoryTransactionType.Size = new Size(40, 17);
            LbInventoryTransactionType.TabIndex = 1;
            LbInventoryTransactionType.Text = "Lệnh:";
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(LbSku);
            panel10.Controls.Add(TbSku);
            panel10.Location = new Point(10, 23);
            panel10.Name = "panel10";
            panel10.Size = new Size(260, 46);
            panel10.TabIndex = 0;
            // 
            // LbSku
            // 
            LbSku.AutoSize = true;
            LbSku.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LbSku.Location = new Point(10, 11);
            LbSku.Name = "LbSku";
            LbSku.Size = new Size(65, 17);
            LbSku.TabIndex = 1;
            LbSku.Text = "Mã hàng:";
            // 
            // TbSku
            // 
            TbSku.BorderStyle = BorderStyle.FixedSingle;
            TbSku.Font = new Font("Segoe UI", 9.75F);
            TbSku.Location = new Point(93, 9);
            TbSku.Name = "TbSku";
            TbSku.Size = new Size(155, 25);
            TbSku.TabIndex = 0;
            TbSku.KeyDown += TbSku_KeyDown;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.HeaderText = "";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "STT";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Mã hàng";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Lệnh";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Vị trí";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 90;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 820);
            Controls.Add(materialCard1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "FromDashboard";
            Load += FromDashboard_Load;
            materialCard1.ResumeLayout(false);
            GbTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventoryTransactionType).EndInit();
            PnTransaction.ResumeLayout(false);
            PnTransaction.PerformLayout();
            GbProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvProcess).EndInit();
            panel13.ResumeLayout(false);
            panel1.ResumeLayout(false);
            CardLocations.ResumeLayout(false);
            GbSearchByProduct.ResumeLayout(false);
            GbSearchByProduct.PerformLayout();
            GbSearchByLocation.ResumeLayout(false);
            GbSearchByLocation.PerformLayout();
            GbZones.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumQuantityLimit).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private ImageList Icons;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialCard CardLocations;
        private FlowLayoutPanel FlpLocations;
        private GroupBox GbSearchByProduct;
        private TextBox TbSearchByProduct;
        private GroupBox GbSearchByLocation;
        private TextBox TbSearchByLocation;
        private GroupBox GbZones;
        private FlowLayoutPanel flpZones;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton BtnRefresh;
        private FontAwesome.Sharp.IconButton BtnAddToQueue;
        private Panel panel9;
        private Label LbQuantityLimit;
        private NumericUpDown NumQuantity;
        private NumericUpDown NumQuantityLimit;
        private Label LabelQuantity;
        private Panel panel8;
        private ComboBox CboLocation;
        private Label LbLocation;
        private Panel panel6;
        private DateTimePicker DtpCurrentDate;
        private Label LbCurrentDate;
        private Panel panel5;
        private ComboBox CboStrategy;
        private Label LbStrategy;
        private Panel panel4;
        private ComboBox CboInventoryTransactionType;
        private Label LbInventoryTransactionType;
        private Panel panel10;
        private Label LbSku;
        private TextBox TbSku;
        private DataGridView dgvInventoryTransactionType;
        private Panel PnTransaction;
        private TextBox tbSearchInventoryTransaction;
        private GroupBox GbProcess;
        private Panel panel13;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private GroupBox GbTransaction;
        private DataGridView DgvProcess;
        private FontAwesome.Sharp.IconButton BtnExecuteAll;
        private FontAwesome.Sharp.IconButton BtnExecuteSelected;
        private FontAwesome.Sharp.IconButton BtnDeleteAll;
        private FontAwesome.Sharp.IconButton BtnDeleteSelected;
        private DataGridViewCheckBoxColumn GvProcessColCheckBox;
        private DataGridViewTextBoxColumn GvProcessColStt;
        private DataGridViewTextBoxColumn GvProcessColSku;
        private DataGridViewTextBoxColumn GvProcessColTransactionType;
        private DataGridViewTextBoxColumn GvProcessColLocation;
        private DataGridViewTextBoxColumn GvProcessColQuantity;
        private DataGridViewTextBoxColumn GvProcessColLocationId;
        private DataGridViewTextBoxColumn GvProcessColTransactionTypeId;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colProductSku;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colInventoryTransactionType;
        private DataGridViewTextBoxColumn colQuanlity;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTransactionDate;
        private DataGridViewTextBoxColumn colReason;
    }
}