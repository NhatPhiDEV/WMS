namespace WMS.UI.Common.Customize
{
    partial class CellControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnText = new Button();
            flpCell = new FlowLayoutPanel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnText
            // 
            BtnText.BackColor = SystemColors.ActiveCaption;
            BtnText.Dock = DockStyle.Left;
            BtnText.FlatAppearance.BorderSize = 0;
            BtnText.FlatStyle = FlatStyle.Flat;
            BtnText.Location = new Point(0, 0);
            BtnText.Name = "BtnText";
            BtnText.Size = new Size(46, 58);
            BtnText.TabIndex = 0;
            BtnText.UseVisualStyleBackColor = false;
            // 
            // flpCell
            // 
            flpCell.AutoScroll = true;
            flpCell.AutoSize = true;
            flpCell.Dock = DockStyle.Fill;
            flpCell.Location = new Point(0, 0);
            flpCell.Name = "flpCell";
            flpCell.Size = new Size(554, 58);
            flpCell.TabIndex = 1;
            flpCell.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(flpCell);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(46, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 58);
            panel1.TabIndex = 2;
            // 
            // CellControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(BtnText);
            Name = "CellControl";
            Size = new Size(600, 58);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnText;
        private FlowLayoutPanel flpCell;
        private Panel panel1;
    }
}
