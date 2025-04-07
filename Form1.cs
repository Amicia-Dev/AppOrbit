using System.Diagnostics;

namespace AppOrbit
{
    public partial class Form1 : Form
    {
        string saveFileLocation;
        string buttonImagesLocation;
        public Point mouseLocation;

        public Form1()
        {
            InitializeComponent();
            saveFileLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AppOrbit");
            buttonImagesLocation = Path.Combine(saveFileLocation, "buttonImages");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(saveFileLocation);
            Directory.CreateDirectory(buttonImagesLocation);
            LoadButtonsFromDataFile(Path.Combine(saveFileLocation, "button.data"));
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(-mouseLocation.X, -mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void addLauncherBtn_Click(object sender, EventArgs e)
        {
            Form2 addLauncherForm = new Form2();
            addLauncherForm.Show();
        }

        private void LoadButtonsFromDataFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Data file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('&');
                if (parts.Length == 2)
                {
                    CreateButtonWithImage(parts[0], parts[1]);
                }
            }
        }

        private void CreateButtonWithImage(string filePath, string imagePath)
        {
            Panel panel = new Panel();
            panel.AutoSize = true;

            Button button = new Button
            {
                Tag = filePath,
                Width = 199,
                Height = 199,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Transparent,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, MouseDownBackColor = Color.Purple, MouseOverBackColor = Color.Transparent },
                Margin = new Padding(10),
                Padding = new Padding(10),
                TextAlign = ContentAlignment.MiddleCenter,
                ImageAlign = ContentAlignment.TopCenter,
                BackgroundImage = Image.FromFile(imagePath),
                BackgroundImageLayout = ImageLayout.Zoom,
                Cursor = Cursors.Hand,
            };

            button.Click += (sender, e) =>
            {
                var path = (sender as Button).Tag.ToString();
                var workingDirectory = Path.GetDirectoryName(path);

                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        WorkingDirectory = workingDirectory
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open file: {ex.Message}");
                }
            };

            panel.Controls.Add(button);
            flowLayoutPanel1.Controls.Add(panel);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void githubLnkBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/Amicia-Dev/AppOrbit");
        }
    }
}
