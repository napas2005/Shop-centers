using Guna.UI2.WinForms;
using Kursova_D2.Classes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kursova_D2.MainForms
{
    public partial class Details : Form
    {
        private string _shopName;

        public Details(string shopName)
        {
            DataBaseCtrl ctrl = new DataBaseCtrl();
            InitializeComponent();
            _shopName = shopName;
            ctrl.DisplayShopDetails(shopName, txtCountry, txtWorkTime, txtCategory, txtName, richTextBox1);
            label2.Text = shopName;
            string imagePath = @"img\"+shopName+".png";
            pictureBox1.Image = Image.FromFile(imagePath);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
