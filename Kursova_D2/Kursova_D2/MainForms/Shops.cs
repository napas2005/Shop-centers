using Kursova_D2.Classes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova_D2.MainForms
{
    public partial class Shops : Form
    {
        DataBaseCtrl ctrl = new DataBaseCtrl();

        public Shops()
        {
            InitializeComponent();
            ctrl.readShopCenters(guna2DataGridView1);
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
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            ctrl.SearchFastShop(guna2DataGridView1, guna2TextBox2.Text);
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Text = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var shopName = guna2TextBox3.Text;
            Details detailsForm = new Details(shopName);
            detailsForm.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrl.SortShopCenters(guna2DataGridView1, guna2ComboBox1.Text);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

            string id = selectedRow.Cells[0].Value.ToString();

            ctrl.MegaDelete(guna2DataGridView1, "Назва");
        }
    }
}
