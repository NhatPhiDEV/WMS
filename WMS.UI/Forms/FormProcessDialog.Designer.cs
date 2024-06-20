namespace WMS.UI.Forms
{
    partial class FormProcessDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcessDialog));
            panel1 = new Panel();
            panel2 = new Panel();
            BtnCancel = new FontAwesome.Sharp.IconButton();
            LbProcessName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 247);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 55);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnCancel);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 55);
            panel2.TabIndex = 1;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.None;
            BtnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancel.IconColor = Color.Red;
            BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancel.IconSize = 24;
            BtnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancel.Location = new Point(12, 8);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(120, 40);
            BtnCancel.TabIndex = 0;
            BtnCancel.Text = "Hủy tiến trình";
            BtnCancel.TextAlign = ContentAlignment.MiddleLeft;
            BtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // LbProcessName
            // 
            LbProcessName.Dock = DockStyle.Fill;
            LbProcessName.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LbProcessName.Image = (Image)resources.GetObject("LbProcessName.Image");
            LbProcessName.Location = new Point(0, 0);
            LbProcessName.Name = "LbProcessName";
            LbProcessName.Padding = new Padding(20, 0, 20, 20);
            LbProcessName.Size = new Size(444, 247);
            LbProcessName.TabIndex = 1;
            LbProcessName.Text = "Vui lòng chờ...";
            LbProcessName.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FormProcessDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(444, 302);
            Controls.Add(LbProcessName);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProcessDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LbProcessName;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton BtnCancel;
    }
}