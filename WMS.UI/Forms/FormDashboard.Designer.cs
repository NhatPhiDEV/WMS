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
            panel1 = new Panel();
            panel3 = new Panel();
            groupBox8 = new GroupBox();
            label12 = new Label();
            tbSearchInventoryTransaction = new TextBox();
            dgvInventoryTransactionType = new DataGridView();
            colSTT = new DataGridViewTextBoxColumn();
            colProductSku = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colInventoryTransactionType = new DataGridViewTextBoxColumn();
            colQuanlity = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTransactionDate = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            panel9 = new Panel();
            label2 = new Label();
            numQuantity = new NumericUpDown();
            numQuanlityLimit = new NumericUpDown();
            label7 = new Label();
            btnRefresh = new Button();
            btnOk = new Button();
            panel8 = new Panel();
            cboLocation = new ComboBox();
            label9 = new Label();
            panel6 = new Panel();
            dtpCurrentDate = new DateTimePicker();
            label6 = new Label();
            panel5 = new Panel();
            cboStrategy = new ComboBox();
            label5 = new Label();
            panel4 = new Panel();
            cboInventoryTransactionType = new ComboBox();
            label4 = new Label();
            panel10 = new Panel();
            label3 = new Label();
            tbSku = new TextBox();
            groupBox7 = new GroupBox();
            btnManual = new Button();
            btnStart = new Button();
            label10 = new Label();
            btnStop = new Button();
            cbDevice = new ComboBox();
            pbCamera = new PictureBox();
            panelRight = new Panel();
            groupBox1 = new GroupBox();
            flpZones = new FlowLayoutPanel();
            groupBox4 = new GroupBox();
            label1 = new Label();
            tbSearch = new TextBox();
            groupBox2 = new GroupBox();
            flpLocations = new FlowLayoutPanel();
            panel3.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryTransactionType).BeginInit();
            groupBox3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuanlityLimit).BeginInit();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCamera).BeginInit();
            panelRight.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 800);
            panel1.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(groupBox8);
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox7);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 800);
            panel3.TabIndex = 20;
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox8.Controls.Add(label12);
            groupBox8.Controls.Add(tbSearchInventoryTransaction);
            groupBox8.Controls.Add(dgvInventoryTransactionType);
            groupBox8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox8.Location = new Point(12, 396);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(601, 392);
            groupBox8.TabIndex = 17;
            groupBox8.TabStop = false;
            groupBox8.Text = "Lịch sử";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(285, 22);
            label12.Name = "label12";
            label12.Size = new Size(76, 17);
            label12.TabIndex = 9;
            label12.Text = "Tìm nhanh:";
            // 
            // tbSearchInventoryTransaction
            // 
            tbSearchInventoryTransaction.BorderStyle = BorderStyle.FixedSingle;
            tbSearchInventoryTransaction.Location = new Point(364, 18);
            tbSearchInventoryTransaction.Name = "tbSearchInventoryTransaction";
            tbSearchInventoryTransaction.Size = new Size(229, 25);
            tbSearchInventoryTransaction.TabIndex = 8;
            tbSearchInventoryTransaction.KeyDown += tbSearchInventoryTransaction_KeyDown;
            // 
            // dgvInventoryTransactionType
            // 
            dgvInventoryTransactionType.AllowUserToAddRows = false;
            dgvInventoryTransactionType.AllowUserToDeleteRows = false;
            dgvInventoryTransactionType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvInventoryTransactionType.BackgroundColor = SystemColors.Control;
            dgvInventoryTransactionType.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvInventoryTransactionType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoryTransactionType.Columns.AddRange(new DataGridViewColumn[] { colSTT, colProductSku, colLocation, colInventoryTransactionType, colQuanlity, colStatus, colTransactionDate, colReason });
            dgvInventoryTransactionType.EnableHeadersVisualStyles = false;
            dgvInventoryTransactionType.GridColor = SystemColors.Control;
            dgvInventoryTransactionType.Location = new Point(10, 49);
            dgvInventoryTransactionType.Name = "dgvInventoryTransactionType";
            dgvInventoryTransactionType.ReadOnly = true;
            dgvInventoryTransactionType.RowHeadersVisible = false;
            dgvInventoryTransactionType.Size = new Size(583, 337);
            dgvInventoryTransactionType.TabIndex = 0;
            dgvInventoryTransactionType.CellFormatting += dgvInventoryTransactionType_CellFormatting;
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
            colProductSku.Width = 80;
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
            colStatus.HeaderText = "Trạng Thái";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colTransactionDate
            // 
            colTransactionDate.HeaderText = "Thời gian";
            colTransactionDate.Name = "colTransactionDate";
            colTransactionDate.ReadOnly = true;
            colTransactionDate.Width = 150;
            // 
            // colReason
            // 
            colReason.HeaderText = "Ghi chú";
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            colReason.Width = 300;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(panel9);
            groupBox3.Controls.Add(btnRefresh);
            groupBox3.Controls.Add(btnOk);
            groupBox3.Controls.Add(panel8);
            groupBox3.Controls.Add(panel6);
            groupBox3.Controls.Add(panel5);
            groupBox3.Controls.Add(panel4);
            groupBox3.Controls.Add(panel10);
            groupBox3.Font = new Font("Segoe UI", 9.75F);
            groupBox3.Location = new Point(300, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 379);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(label2);
            panel9.Controls.Add(numQuantity);
            panel9.Controls.Add(numQuanlityLimit);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(10, 278);
            panel9.Name = "panel9";
            panel9.Size = new Size(295, 46);
            panel9.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(175, 13);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 6;
            label2.Text = "Tối đa:";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 9.75F);
            numQuantity.Location = new Point(103, 11);
            numQuantity.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(66, 25);
            numQuantity.TabIndex = 6;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numQuanlityLimit
            // 
            numQuanlityLimit.Enabled = false;
            numQuanlityLimit.Font = new Font("Segoe UI", 9.75F);
            numQuanlityLimit.Location = new Point(229, 11);
            numQuanlityLimit.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numQuanlityLimit.Name = "numQuanlityLimit";
            numQuanlityLimit.Size = new Size(52, 25);
            numQuanlityLimit.TabIndex = 5;
            numQuanlityLimit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(15, 13);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 1;
            label7.Text = "Số lượng:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(128, 255, 128);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(167, 333);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(138, 40);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "LÀM MỚI";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(255, 255, 128);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(10, 333);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(138, 40);
            btnOk.TabIndex = 6;
            btnOk.Text = "XÁC NHẬN";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += ButtonOk_Click;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(cboLocation);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(10, 227);
            panel8.Name = "panel8";
            panel8.Size = new Size(295, 46);
            panel8.TabIndex = 5;
            // 
            // cboLocation
            // 
            cboLocation.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLocation.FormattingEnabled = true;
            cboLocation.Location = new Point(104, 11);
            cboLocation.Name = "cboLocation";
            cboLocation.Size = new Size(177, 25);
            cboLocation.TabIndex = 5;
            cboLocation.SelectedIndexChanged += cboLocation_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(15, 11);
            label9.Name = "label9";
            label9.Size = new Size(39, 17);
            label9.TabIndex = 7;
            label9.Text = "Vị trí:";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(dtpCurrentDate);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(10, 174);
            panel6.Name = "panel6";
            panel6.Size = new Size(295, 46);
            panel6.TabIndex = 3;
            // 
            // dtpCurrentDate
            // 
            dtpCurrentDate.Enabled = false;
            dtpCurrentDate.Font = new Font("Segoe UI", 9.75F);
            dtpCurrentDate.Format = DateTimePickerFormat.Short;
            dtpCurrentDate.Location = new Point(103, 11);
            dtpCurrentDate.Name = "dtpCurrentDate";
            dtpCurrentDate.Size = new Size(178, 25);
            dtpCurrentDate.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(15, 11);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 1;
            label6.Text = "Ngày tháng:";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(cboStrategy);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(10, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(295, 46);
            panel5.TabIndex = 2;
            // 
            // cboStrategy
            // 
            cboStrategy.Enabled = false;
            cboStrategy.Font = new Font("Segoe UI", 9.75F);
            cboStrategy.FormattingEnabled = true;
            cboStrategy.Location = new Point(104, 8);
            cboStrategy.Name = "cboStrategy";
            cboStrategy.Size = new Size(177, 25);
            cboStrategy.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(15, 11);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 1;
            label5.Text = "Chiến lược:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(cboInventoryTransactionType);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(10, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(295, 46);
            panel4.TabIndex = 1;
            // 
            // cboInventoryTransactionType
            // 
            cboInventoryTransactionType.Font = new Font("Segoe UI", 9.75F);
            cboInventoryTransactionType.FormattingEnabled = true;
            cboInventoryTransactionType.Location = new Point(104, 11);
            cboInventoryTransactionType.Name = "cboInventoryTransactionType";
            cboInventoryTransactionType.Size = new Size(177, 25);
            cboInventoryTransactionType.TabIndex = 1;
            cboInventoryTransactionType.SelectedIndexChanged += cboInventoryTransactionType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(15, 11);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 1;
            label4.Text = "Lệnh:";
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(label3);
            panel10.Controls.Add(tbSku);
            panel10.Location = new Point(10, 21);
            panel10.Name = "panel10";
            panel10.Size = new Size(295, 46);
            panel10.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(15, 11);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 1;
            label3.Text = "Mã hàng:";
            // 
            // tbSku
            // 
            tbSku.BorderStyle = BorderStyle.FixedSingle;
            tbSku.Font = new Font("Segoe UI", 9.75F);
            tbSku.Location = new Point(104, 9);
            tbSku.Name = "tbSku";
            tbSku.Size = new Size(177, 25);
            tbSku.TabIndex = 0;
            tbSku.TextChanged += tbSku_TextChanged;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox7.BackColor = SystemColors.Control;
            groupBox7.Controls.Add(btnManual);
            groupBox7.Controls.Add(btnStart);
            groupBox7.Controls.Add(label10);
            groupBox7.Controls.Add(btnStop);
            groupBox7.Controls.Add(cbDevice);
            groupBox7.Controls.Add(pbCamera);
            groupBox7.Font = new Font("Segoe UI", 9.75F);
            groupBox7.Location = new Point(11, 11);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(285, 379);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Quét mã";
            // 
            // btnManual
            // 
            btnManual.Font = new Font("Segoe UI", 9F);
            btnManual.Location = new Point(174, 333);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(99, 33);
            btnManual.TabIndex = 3;
            btnManual.Text = "Nhập thủ công";
            btnManual.UseVisualStyleBackColor = true;
            btnManual.Click += btnManual_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 9F);
            btnStart.Location = new Point(11, 333);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(77, 33);
            btnStart.TabIndex = 1;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(11, 27);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 6;
            label10.Text = "Chọn thiết bị:";
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 9F);
            btnStop.Location = new Point(93, 333);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(77, 33);
            btnStop.TabIndex = 2;
            btnStop.Text = "Kết thúc";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStop_Click;
            // 
            // cbDevice
            // 
            cbDevice.Font = new Font("Segoe UI", 9F);
            cbDevice.FormattingEnabled = true;
            cbDevice.Location = new Point(102, 23);
            cbDevice.Name = "cbDevice";
            cbDevice.Size = new Size(171, 23);
            cbDevice.TabIndex = 5;
            // 
            // pbCamera
            // 
            pbCamera.BorderStyle = BorderStyle.FixedSingle;
            pbCamera.Location = new Point(11, 52);
            pbCamera.Name = "pbCamera";
            pbCamera.Size = new Size(262, 272);
            pbCamera.TabIndex = 2;
            pbCamera.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.Control;
            panelRight.Controls.Add(groupBox1);
            panelRight.Controls.Add(groupBox4);
            panelRight.Controls.Add(groupBox2);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(623, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(577, 800);
            panelRight.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(flpZones);
            groupBox1.Font = new Font("Segoe UI", 9.75F);
            groupBox1.Location = new Point(8, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(562, 70);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khu vực";
            // 
            // flpZones
            // 
            flpZones.Dock = DockStyle.Fill;
            flpZones.Font = new Font("Segoe UI", 9.75F);
            flpZones.Location = new Point(3, 21);
            flpZones.Name = "flpZones";
            flpZones.Size = new Size(556, 46);
            flpZones.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(tbSearch);
            groupBox4.Font = new Font("Segoe UI", 9.75F);
            groupBox4.Location = new Point(8, 87);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(338, 54);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tra cứu nhanh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 2;
            label1.Text = "Vị trí tìm:";
            // 
            // tbSearch
            // 
            tbSearch.BorderStyle = BorderStyle.FixedSingle;
            tbSearch.Font = new Font("Segoe UI", 9.75F);
            tbSearch.Location = new Point(78, 19);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(254, 25);
            tbSearch.TabIndex = 1;
            tbSearch.KeyDown += TbSearch_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(flpLocations);
            groupBox2.Font = new Font("Segoe UI", 9.75F);
            groupBox2.Location = new Point(5, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(562, 643);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách vị trí trên kệ hàng";
            // 
            // flpLocations
            // 
            flpLocations.AutoScroll = true;
            flpLocations.Dock = DockStyle.Fill;
            flpLocations.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpLocations.Location = new Point(3, 21);
            flpLocations.Name = "flpLocations";
            flpLocations.Size = new Size(556, 619);
            flpLocations.TabIndex = 0;
            // 
            // Form_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(panelRight);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Dashboard";
            Text = "From_Test";
            Load += Form_Dashboard_Load;
            panel3.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryTransactionType).EndInit();
            groupBox3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuanlityLimit).EndInit();
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
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCamera).EndInit();
            panelRight.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private GroupBox groupBox3;
        private Panel panel9;
        private Button btnRefresh;
        private Button btnOk;
        private Panel panel8;
        private Label label7;
        private Panel panel6;
        private Label label6;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel10;
        private Label label3;
        private TextBox tbSku;
        private GroupBox groupBox7;
        private Label label10;
        private ComboBox cbDevice;
        private PictureBox pbCamera;
        private Panel panelRight;
        private GroupBox groupBox2;
        private FlowLayoutPanel flpLocations;
        private GroupBox groupBox8;
        private ComboBox cboStrategy;
        private DateTimePicker dtpCurrentDate;
        private NumericUpDown numQuantity;
        private ComboBox cboInventoryTransactionType;
        private GroupBox groupBox4;
        private Label label1;
        private TextBox tbSearch;
        private GroupBox groupBox1;
        private FlowLayoutPanel flpZones;
        private Button btnStart;
        private Button btnStop;
        private Button btnManual;
        private NumericUpDown numQuanlityLimit;
        private Label label2;
        private Label label9;
        private ComboBox cboLocation;
        private DataGridView dgvInventoryTransactionType;
        private Label label12;
        private TextBox tbSearchInventoryTransaction;
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