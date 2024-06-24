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
            TabLocationManagement = new TabPage();
            TabProductManagement = new TabPage();
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
            IconTabs.Images.SetKeyName(4, "product-32.png");
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
            TabControlMain.Controls.Add(TabLocationManagement);
            TabControlMain.Controls.Add(TabProductManagement);
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
            // TabLocationManagement
            // 
            TabLocationManagement.ImageKey = "icons8-pallet-32.png";
            TabLocationManagement.Location = new Point(4, 31);
            TabLocationManagement.Name = "TabLocationManagement";
            TabLocationManagement.Padding = new Padding(3);
            TabLocationManagement.Size = new Size(1439, 785);
            TabLocationManagement.TabIndex = 2;
            TabLocationManagement.Text = "Sơ đồ kho";
            TabLocationManagement.UseVisualStyleBackColor = true;
            // 
            // TabProductManagement
            // 
            TabProductManagement.ImageKey = "product-32.png";
            TabProductManagement.Location = new Point(4, 31);
            TabProductManagement.Name = "TabProductManagement";
            TabProductManagement.Size = new Size(1439, 785);
            TabProductManagement.TabIndex = 4;
            TabProductManagement.Text = "Sản phẩm";
            TabProductManagement.UseVisualStyleBackColor = true;
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
        private TabPage TabLocationManagement;
        private TabPage TabProductManagement;
    }
}