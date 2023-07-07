using Kursova_D2.Classes;
using Kursova_D2.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_D2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            button2.MouseHover += button2_MouseHover;//при навождєнії на іконку отображається текст
            button3.MouseHover += button3_MouseHover;
            button4.MouseHover += button4_MouseHover;
            button5.MouseHover += button5_MouseHover;
            button6.MouseHover += button6_MouseHover;
            Config cfg = new Config();//визов класа конфіг(привязка бази даних при откритії главного вікна програми)
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            string objectInfo = "Перегляд";
            ToolTip tooltip = new ToolTip();//тул тіп штучка яка появляється з тєкстом при навождєнії на іконку
            tooltip.SetToolTip((Control)sender, objectInfo);
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            string objectInfo = "Пошук";
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip((Control)sender, objectInfo);
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            string objectInfo = "Домашня(Ви зараз тут)";
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip((Control)sender, objectInfo);
        }
        private void button5_MouseHover(object sender, EventArgs e)
        {
            string objectInfo = "Рейтинг";
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip((Control)sender, objectInfo);
        }
        private void button6_MouseHover(object sender, EventArgs e)
        {
            string objectInfo = "Сортування";
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip((Control)sender, objectInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm closeForm = new CloseForm();//кнопочка вихода
            closeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shops shops = new Shops();//новий обьект форми магазіни
            shops.Show();//показ форми
            this.Hide();//тєкуще окно скрить
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            rating.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
            sort.Show();
            this.Hide();
        }
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            //guna2PictureBox1.Image = Image.FromFile(@"img\Сортування.png");
            //guna2PictureBox1.Visible = true;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;

        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = Image.FromFile(@"img\Сортування.png");
            guna2PictureBox1.Visible = true;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = Image.FromFile(@"img\Видалення.png");
            guna2PictureBox1.Visible = true;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = Image.FromFile(@"img\Пошук.png");
            guna2PictureBox1.Visible = true;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            guna2PictureBox1.Image = Image.FromFile(@"img\Деталі.png");
            guna2PictureBox1.Visible = true;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            guna2PictureBox1.Visible = false;
        }
    }
}
