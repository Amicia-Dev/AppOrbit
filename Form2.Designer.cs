namespace AppOrbit
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            choosePathBtn = new Button();
            pathInputTextBox = new TextBox();
            panel1 = new Panel();
            githubLnkBtn = new Button();
            windowTitle = new Label();
            exitBtn2 = new Button();
            exitBtn = new Button();
            addBtn = new Button();
            imageInputTextBox = new TextBox();
            chooseImageBtn = new Button();
            pictureBox1 = new PictureBox();
            openImageLocationBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            errorLabelForm2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // choosePathBtn
            // 
            choosePathBtn.BackColor = Color.Transparent;
            choosePathBtn.BackgroundImageLayout = ImageLayout.None;
            choosePathBtn.Cursor = Cursors.Hand;
            choosePathBtn.FlatAppearance.BorderSize = 0;
            choosePathBtn.FlatStyle = FlatStyle.Flat;
            choosePathBtn.ForeColor = Color.Transparent;
            choosePathBtn.Image = (Image)resources.GetObject("choosePathBtn.Image");
            choosePathBtn.Location = new Point(354, 83);
            choosePathBtn.Name = "choosePathBtn";
            choosePathBtn.Size = new Size(29, 31);
            choosePathBtn.TabIndex = 2;
            choosePathBtn.UseVisualStyleBackColor = false;
            choosePathBtn.Click += choosePathBtn_Click;
            // 
            // pathInputTextBox
            // 
            pathInputTextBox.BackColor = Color.FromArgb(231, 192, 216);
            pathInputTextBox.BorderStyle = BorderStyle.FixedSingle;
            pathInputTextBox.Location = new Point(12, 87);
            pathInputTextBox.Name = "pathInputTextBox";
            pathInputTextBox.Size = new Size(336, 23);
            pathInputTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(158, 78, 100);
            panel1.Controls.Add(githubLnkBtn);
            panel1.Controls.Add(windowTitle);
            panel1.Controls.Add(exitBtn2);
            panel1.Controls.Add(exitBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 34);
            panel1.TabIndex = 4;
            panel1.MouseDown += mouse_Down2;
            panel1.MouseMove += mouse_Move2;
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
            githubLnkBtn.Location = new Point(334, 3);
            githubLnkBtn.Name = "githubLnkBtn";
            githubLnkBtn.Padding = new Padding(0, 0, 1, 0);
            githubLnkBtn.Size = new Size(26, 26);
            githubLnkBtn.TabIndex = 7;
            githubLnkBtn.UseVisualStyleBackColor = false;
            githubLnkBtn.Click += button1_Click;
            // 
            // windowTitle
            // 
            windowTitle.Anchor = AnchorStyles.Top;
            windowTitle.AutoSize = true;
            windowTitle.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            windowTitle.ForeColor = Color.FromArgb(231, 192, 216);
            windowTitle.Location = new Point(3, 3);
            windowTitle.Name = "windowTitle";
            windowTitle.Size = new Size(134, 25);
            windowTitle.TabIndex = 6;
            windowTitle.Text = "Add a Button";
            windowTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitBtn2
            // 
            exitBtn2.BackColor = Color.Transparent;
            exitBtn2.BackgroundImageLayout = ImageLayout.None;
            exitBtn2.Cursor = Cursors.Hand;
            exitBtn2.FlatAppearance.BorderSize = 0;
            exitBtn2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 88, 90);
            exitBtn2.FlatAppearance.MouseOverBackColor = Color.FromArgb(218, 137, 139);
            exitBtn2.FlatStyle = FlatStyle.Flat;
            exitBtn2.ForeColor = Color.Transparent;
            exitBtn2.Image = (Image)resources.GetObject("exitBtn2.Image");
            exitBtn2.Location = new Point(368, 4);
            exitBtn2.Name = "exitBtn2";
            exitBtn2.Size = new Size(27, 27);
            exitBtn2.TabIndex = 3;
            exitBtn2.UseVisualStyleBackColor = false;
            exitBtn2.Click += exitBtn2_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImageLayout = ImageLayout.None;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatAppearance.MouseDownBackColor = Color.DarkMagenta;
            exitBtn.FlatAppearance.MouseOverBackColor = Color.Purple;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.ForeColor = Color.Transparent;
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.Location = new Point(871, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(26, 27);
            exitBtn.TabIndex = 2;
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderColor = Color.FromArgb(158, 78, 100);
            addBtn.FlatAppearance.BorderSize = 2;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.FromArgb(158, 78, 100);
            addBtn.Location = new Point(299, 409);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(84, 35);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // imageInputTextBox
            // 
            imageInputTextBox.BackColor = Color.FromArgb(231, 192, 216);
            imageInputTextBox.BorderStyle = BorderStyle.FixedSingle;
            imageInputTextBox.Location = new Point(12, 156);
            imageInputTextBox.Name = "imageInputTextBox";
            imageInputTextBox.Size = new Size(336, 23);
            imageInputTextBox.TabIndex = 7;
            // 
            // chooseImageBtn
            // 
            chooseImageBtn.BackColor = Color.Transparent;
            chooseImageBtn.BackgroundImageLayout = ImageLayout.None;
            chooseImageBtn.Cursor = Cursors.Hand;
            chooseImageBtn.FlatAppearance.BorderSize = 0;
            chooseImageBtn.FlatStyle = FlatStyle.Flat;
            chooseImageBtn.ForeColor = Color.Transparent;
            chooseImageBtn.Image = (Image)resources.GetObject("chooseImageBtn.Image");
            chooseImageBtn.Location = new Point(354, 152);
            chooseImageBtn.Name = "chooseImageBtn";
            chooseImageBtn.Size = new Size(29, 31);
            chooseImageBtn.TabIndex = 8;
            chooseImageBtn.UseVisualStyleBackColor = false;
            chooseImageBtn.Click += chooseImageBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // openImageLocationBtn
            // 
            openImageLocationBtn.BackColor = Color.FromArgb(44, 25, 50);
            openImageLocationBtn.Cursor = Cursors.Hand;
            openImageLocationBtn.FlatAppearance.BorderColor = Color.FromArgb(158, 78, 100);
            openImageLocationBtn.FlatAppearance.BorderSize = 2;
            openImageLocationBtn.FlatStyle = FlatStyle.Flat;
            openImageLocationBtn.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openImageLocationBtn.ForeColor = Color.FromArgb(158, 78, 100);
            openImageLocationBtn.Location = new Point(12, 409);
            openImageLocationBtn.Name = "openImageLocationBtn";
            openImageLocationBtn.Size = new Size(163, 35);
            openImageLocationBtn.TabIndex = 10;
            openImageLocationBtn.Text = "Open data location";
            openImageLocationBtn.UseVisualStyleBackColor = false;
            openImageLocationBtn.Click += openImageLocationBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FloralWhite;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 11;
            label2.Text = "File";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FloralWhite;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 12;
            label3.Text = "Image";
            // 
            // errorLabelForm2
            // 
            errorLabelForm2.AutoSize = true;
            errorLabelForm2.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLabelForm2.ForeColor = Color.Red;
            errorLabelForm2.Location = new Point(18, 365);
            errorLabelForm2.Name = "errorLabelForm2";
            errorLabelForm2.Size = new Size(0, 25);
            errorLabelForm2.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 25, 50);
            ClientSize = new Size(398, 456);
            Controls.Add(errorLabelForm2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(openImageLocationBtn);
            Controls.Add(pictureBox1);
            Controls.Add(chooseImageBtn);
            Controls.Add(imageInputTextBox);
            Controls.Add(addBtn);
            Controls.Add(panel1);
            Controls.Add(pathInputTextBox);
            Controls.Add(choosePathBtn);
            Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Button";
            TopMost = true;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button choosePathBtn;
        private TextBox pathInputTextBox;
        private Panel panel1;
        private Button exitBtn;
        private Button exitBtn2;
        private Button addBtn;
        private TextBox imageInputTextBox;
        private Button chooseImageBtn;
        private PictureBox pictureBox1;
        private Button openImageLocationBtn;
        private Label windowTitle;
        private Label label2;
        private Label label3;
        private Label errorLabelForm2;
        private Button githubLnkBtn;
    }
}