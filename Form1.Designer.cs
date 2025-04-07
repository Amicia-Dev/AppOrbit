namespace AppOrbit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            exitBtn = new Button();
            panel1 = new Panel();
            refreshBtn = new Button();
            windowTitle = new Label();
            addLauncherBtn = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            flowLayoutPanel1 = new FlowLayoutPanel();
            githubLnkBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImageLayout = ImageLayout.None;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 88, 90);
            exitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(218, 137, 139);
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.ForeColor = Color.Transparent;
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.Location = new Point(871, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(25, 25);
            exitBtn.TabIndex = 2;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(158, 48, 100);
            panel1.Controls.Add(githubLnkBtn);
            panel1.Controls.Add(refreshBtn);
            panel1.Controls.Add(windowTitle);
            panel1.Controls.Add(addLauncherBtn);
            panel1.Controls.Add(exitBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 30);
            panel1.TabIndex = 3;
            panel1.MouseDown += mouse_Down;
            panel1.MouseMove += mouse_Move;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.Transparent;
            refreshBtn.BackgroundImageLayout = ImageLayout.None;
            refreshBtn.Cursor = Cursors.Hand;
            refreshBtn.FlatAppearance.BorderSize = 0;
            refreshBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 232, 166);
            refreshBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 250, 214);
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.ForeColor = Color.Transparent;
            refreshBtn.Image = (Image)resources.GetObject("refreshBtn.Image");
            refreshBtn.Location = new Point(35, 3);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(25, 25);
            refreshBtn.TabIndex = 6;
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // windowTitle
            // 
            windowTitle.Anchor = AnchorStyles.Top;
            windowTitle.AutoSize = true;
            windowTitle.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            windowTitle.ForeColor = Color.FromArgb(231, 192, 216);
            windowTitle.Location = new Point(402, 2);
            windowTitle.Name = "windowTitle";
            windowTitle.Size = new Size(100, 25);
            windowTitle.TabIndex = 5;
            windowTitle.Text = "App Orbit";
            windowTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addLauncherBtn
            // 
            addLauncherBtn.BackColor = Color.Transparent;
            addLauncherBtn.BackgroundImageLayout = ImageLayout.None;
            addLauncherBtn.Cursor = Cursors.Hand;
            addLauncherBtn.FlatAppearance.BorderSize = 0;
            addLauncherBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(155, 232, 155);
            addLauncherBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 254, 210);
            addLauncherBtn.FlatStyle = FlatStyle.Flat;
            addLauncherBtn.ForeColor = Color.Transparent;
            addLauncherBtn.Image = (Image)resources.GetObject("addLauncherBtn.Image");
            addLauncherBtn.Location = new Point(3, 3);
            addLauncherBtn.Name = "addLauncherBtn";
            addLauncherBtn.Size = new Size(25, 25);
            addLauncherBtn.TabIndex = 4;
            addLauncherBtn.UseVisualStyleBackColor = false;
            addLauncherBtn.Click += addLauncherBtn_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Location = new Point(12, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(877, 416);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // githubLnkBtn
            // 
            githubLnkBtn.BackColor = Color.Transparent;
            githubLnkBtn.BackgroundImageLayout = ImageLayout.None;
            githubLnkBtn.Cursor = Cursors.Hand;
            githubLnkBtn.FlatAppearance.BorderSize = 0;
            githubLnkBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 88, 90);
            githubLnkBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(218, 137, 139);
            githubLnkBtn.FlatStyle = FlatStyle.Flat;
            githubLnkBtn.ForeColor = Color.Transparent;
            githubLnkBtn.Image = (Image)resources.GetObject("githubLnkBtn.Image");
            githubLnkBtn.Location = new Point(839, 2);
            githubLnkBtn.Name = "githubLnkBtn";
            githubLnkBtn.Padding = new Padding(0, 0, 1, 0);
            githubLnkBtn.Size = new Size(26, 26);
            githubLnkBtn.TabIndex = 8;
            githubLnkBtn.UseVisualStyleBackColor = false;
            githubLnkBtn.Click += githubLnkBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 30, 60);
            ClientSize = new Size(901, 474);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "AppOrbit";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Button exitBtn;
        private Panel panel1;
        private FileSystemWatcher fileSystemWatcher1;
        private Button addLauncherBtn;
        private Label windowTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button refreshBtn;
        private Button githubLnkBtn;
    }
}
