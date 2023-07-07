using Kursova_D2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_D2.MainForms
{
    public partial class Sort : Form
    {
        DataBaseCtrl ctrl = new DataBaseCtrl();
        public Sort()
        {
            InitializeComponent();        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm closeForm = new CloseForm();
            closeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shops shops = new Shops();
            shops.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            rating.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            EuShops shopCenters = new EuShops(guna2TextBox1.Text, guna2TextBox2.Text, guna2ComboBox1.Text, guna2TextBox3.Text, pictureBox1.ImageLocation, guna2TextBox4.Text);
            ctrl.AddCenter(shopCenters);
            ctrl.readShopCenters(guna2DataGridView1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.bmp;*.jpg;*.jpeg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                // Получаем путь к выбранному файлу
                string filePath = openFileDialog1.FileName;

                // Задаем путь к папке, в которую нужно скопировать файл
                string destinationPath = @"D:\СоняКурсач\Kursova_D2\Kursova_D2\bin\Debug\img\";

                // Копируем файл в нужную папку
                string fileName = Path.GetFileName(filePath);
                File.Copy(filePath, Path.Combine(destinationPath, fileName = guna2TextBox3.Text+".png"), true);

                //"/img/"id+"rozshir"
                //copy to project
            }
        }





 
    }
}
