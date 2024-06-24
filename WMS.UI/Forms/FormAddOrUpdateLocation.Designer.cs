namespace WMS.UI.Forms
{
    partial class FormAddOrUpdateLocation
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
            groupBox1 = new GroupBox();
            TbLocationCode = new TextBox();
            groupBox2 = new GroupBox();
            TbLocationName = new TextBox();
            groupBox3 = new GroupBox();
            CbZones = new ComboBox();
            groupBox4 = new GroupBox();
            NumCapacity = new NumericUpDown();
            groupBox5 = new GroupBox();
            TbPointX = new TextBox();
            groupBox6 = new GroupBox();
            TbPointY = new TextBox();
            groupBox7 = new GroupBox();
            TbPointZ = new TextBox();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnOk = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumCapacity).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TbLocationCode);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 53);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mã vị trí";
            // 
            // TbLocationCode
            // 
            TbLocationCode.BorderStyle = BorderStyle.FixedSingle;
            TbLocationCode.Dock = DockStyle.Fill;
            TbLocationCode.Font = new Font("Segoe UI", 9F);
            TbLocationCode.Location = new Point(3, 20);
            TbLocationCode.Name = "TbLocationCode";
            TbLocationCode.Size = new Size(308, 23);
            TbLocationCode.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TbLocationName);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(9, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 53);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên vị trí";
            // 
            // TbLocationName
            // 
            TbLocationName.BorderStyle = BorderStyle.FixedSingle;
            TbLocationName.Dock = DockStyle.Fill;
            TbLocationName.Font = new Font("Segoe UI", 9F);
            TbLocationName.Location = new Point(3, 20);
            TbLocationName.Name = "TbLocationName";
            TbLocationName.Size = new Size(308, 23);
            TbLocationName.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CbZones);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(9, 136);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(314, 53);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khu vực";
            // 
            // CbZones
            // 
            CbZones.Dock = DockStyle.Fill;
            CbZones.DropDownStyle = ComboBoxStyle.DropDownList;
            CbZones.FormattingEnabled = true;
            CbZones.Location = new Point(3, 20);
            CbZones.Name = "CbZones";
            CbZones.Size = new Size(308, 23);
            CbZones.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(NumCapacity);
            groupBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(9, 198);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(314, 53);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kích thước";
            // 
            // NumCapacity
            // 
            NumCapacity.Dock = DockStyle.Fill;
            NumCapacity.Location = new Point(3, 20);
            NumCapacity.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            NumCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumCapacity.Name = "NumCapacity";
            NumCapacity.Size = new Size(308, 24);
            NumCapacity.TabIndex = 0;
            NumCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(TbPointX);
            groupBox5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(13, 257);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(83, 53);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Vị trí X";
            // 
            // TbPointX
            // 
            TbPointX.BorderStyle = BorderStyle.FixedSingle;
            TbPointX.Dock = DockStyle.Fill;
            TbPointX.Font = new Font("Segoe UI", 9F);
            TbPointX.Location = new Point(3, 20);
            TbPointX.Name = "TbPointX";
            TbPointX.Size = new Size(77, 23);
            TbPointX.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(TbPointY);
            groupBox6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(124, 257);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(84, 53);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Vị trí Y";
            // 
            // TbPointY
            // 
            TbPointY.BorderStyle = BorderStyle.FixedSingle;
            TbPointY.Dock = DockStyle.Fill;
            TbPointY.Font = new Font("Segoe UI", 9F);
            TbPointY.Location = new Point(3, 20);
            TbPointY.Name = "TbPointY";
            TbPointY.Size = new Size(78, 23);
            TbPointY.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(TbPointZ);
            groupBox7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox7.Location = new Point(236, 257);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(84, 53);
            groupBox7.TabIndex = 7;
            groupBox7.TabStop = false;
            groupBox7.Text = "Vị trí Z";
            // 
            // TbPointZ
            // 
            TbPointZ.BorderStyle = BorderStyle.FixedSingle;
            TbPointZ.Dock = DockStyle.Fill;
            TbPointZ.Font = new Font("Segoe UI", 9F);
            TbPointZ.Location = new Point(3, 20);
            TbPointZ.Name = "TbPointZ";
            TbPointZ.Size = new Size(78, 23);
            TbPointZ.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Red;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 24;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(217, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 32);
            btnCancel.TabIndex = 9;
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
            btnOk.Location = new Point(96, 328);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(102, 32);
            btnOk.TabIndex = 8;
            btnOk.Text = "Xác nhận";
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // FormAddOrUpdateLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 380);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FormAddOrUpdateLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thiết lập vị trí";
            Load += FormAddOrUpdateLocation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NumCapacity).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TbLocationCode;
        private GroupBox groupBox2;
        private TextBox TbLocationName;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox TbPointX;
        private GroupBox groupBox6;
        private TextBox TbPointY;
        private GroupBox groupBox7;
        private TextBox TbPointZ;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnOk;
        private ComboBox CbZones;
        private NumericUpDown NumCapacity;
    }
}