namespace WMS.UI.Forms
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            IconTabs = new ImageList(components);
            TabDashboard = new TabPage();
            TabControlMain = new MaterialSkin.Controls.MaterialTabControl();
            TabLocation = new TabPage();
            TabNotification = new TabPage();
            TabSetting = new TabPage();
            TabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // IconTabs
            // 
            IconTabs.ColorDepth = ColorDepth.Depth32Bit;
            IconTabs.ImageStream = (ImageListStreamer)resources.GetObject("IconTabs.ImageStream");
            IconTabs.TransparentColor = Color.Transparent;
            IconTabs.Images.SetKeyName(0, "home-32.png");
            IconTabs.Images.SetKeyName(1, "notification-32.png");
            IconTabs.Images.SetKeyName(2, "icons8-pallet-32.png");
            IconTabs.Images.SetKeyName(3, "settings-32.png");
            // 
            // TabDashboard
            // 
            TabDashboard.ImageKey = "home-32.png";
            TabDashboard.Location = new Point(4, 31);
            TabDashboard.Name = "TabDashboard";
            TabDashboard.Padding = new Padding(3);
            TabDashboard.Size = new Size(1439, 785);
            TabDashboard.TabIndex = 0;
            TabDashboard.Text = "Dashboard";
            TabDashboard.UseVisualStyleBackColor = true;
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(TabDashboard);
            TabControlMain.Controls.Add(TabLocation);
            TabControlMain.Controls.Add(TabNotification);
            TabControlMain.Controls.Add(TabSetting);
            TabControlMain.Depth = 0;
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlMain.ImageList = IconTabs;
            TabControlMain.ItemSize = new Size(99, 27);
            TabControlMain.Location = new Point(0, 72);
            TabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            TabControlMain.Multiline = true;
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(1447, 820);
            TabControlMain.TabIndex = 0;
            TabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
            // 
            // TabLocation
            // 
            TabLocation.ImageKey = "icons8-pallet-32.png";
            TabLocation.Location = new Point(4, 31);
            TabLocation.Name = "TabLocation";
            TabLocation.Padding = new Padding(3);
            TabLocation.Size = new Size(1439, 785);
            TabLocation.TabIndex = 2;
            TabLocation.Text = "Sơ đồ kho";
            TabLocation.UseVisualStyleBackColor = true;
            // 
            // TabNotification
            // 
            TabNotification.ImageKey = "notification-32.png";
            TabNotification.Location = new Point(4, 31);
            TabNotification.Name = "TabNotification";
            TabNotification.Padding = new Padding(3);
            TabNotification.Size = new Size(1439, 785);
            TabNotification.TabIndex = 1;
            TabNotification.Text = "Thông báo";
            TabNotification.UseVisualStyleBackColor = true;
            // 
            // TabSetting
            // 
            TabSetting.ImageKey = "settings-32.png";
            TabSetting.Location = new Point(4, 31);
            TabSetting.Name = "TabSetting";
            TabSetting.Padding = new Padding(3);
            TabSetting.Size = new Size(1439, 785);
            TabSetting.TabIndex = 3;
            TabSetting.Text = "Cấu hình";
            TabSetting.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 895);
            Controls.Add(TabControlMain);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = TabControlMain;
            FormStyle = FormStyles.ActionBar_48;
            MinimumSize = new Size(1450, 895);
            Name = "FormMain";
            Padding = new Padding(0, 72, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WMS Software";
            TabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ImageList IconTabs;
        private TabPage TabDashboard;
        private MaterialSkin.Controls.MaterialTabControl TabControlMain;
        private TabPage TabNotification;
        private TabPage TabLocation;
        private TabPage TabSetting;
    }
}