using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace AppOrbit
{
    public partial class Form2 : Form
    {

        public Point mouseLocation;
        string saveFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string btnImageFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        public Form2()
        {
            InitializeComponent();
            saveFileLocation = $"{saveFileLocation}\\AppOrbit";
            btnImageFileLocation = $"{btnImageFileLocation}\\AppOrbit\\buttonImages\\";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void exitBtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mouse_Down2(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void mouse_Move2(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(-mouseLocation.X, -mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void choosePathBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathInputTextBox.Text = openFileDialog.FileName;
                }
            }
        }


        private void chooseImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = btnImageFileLocation;
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageInputTextBox.Text = openFileDialog.FileName;
                }
            }
            string selectedImagePath = imageInputTextBox.Text;
            try
            {
                pictureBox1.Image = Image.FromFile(selectedImagePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            string saveFileFullPath = $"{saveFileLocation}\\button.data";

            string filePath = pathInputTextBox.Text;
            string selectedImagePath = imageInputTextBox.Text;

            string fullNewBtnImageLocation = btnImageFileLocation + Path.GetFileName(selectedImagePath);



            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                errorLabelForm2.Text = "Selected file does not exist";
                return;
            }

            if (File.Exists(selectedImagePath))
            {
                Console.WriteLine("Image Exists");
            }
            else
            {
                errorLabelForm2.Text = "Selected image does not exist";
                return;
            }



            try
            {
                File.Copy(selectedImagePath, fullNewBtnImageLocation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            string dataToSave = $"{filePath}&{fullNewBtnImageLocation}";
            File.AppendAllText(saveFileFullPath, dataToSave + Environment.NewLine);

            Console.WriteLine("Button Successfully Created");

            pathInputTextBox.Clear();
            imageInputTextBox.Clear();

            Application.Restart();
            this.Close();
        }

        private void openImageLocationBtn_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("explorer.exe", saveFileLocation));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/Amicia-Dev/AppOrbit");
        }
    }
}
