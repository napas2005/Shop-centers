using Kursova_D2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_D2.MainForms
{
    public partial class Rating : Form
    {
        public Rating()
        {

            InitializeComponent();      
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

        private void button6_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
            sort.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm closeForm = new CloseForm();
            closeForm.Show();
        }

        /*private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataBaseCtrl dataBase = new DataBaseCtrl();
            dataBase.RateShop(guna2DataGridView1, guna2TextBox3.Text, guna2ComboBox1.Text);
        }*/

        private void guna2TextBox3_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Text = "";
        }

    }
}
