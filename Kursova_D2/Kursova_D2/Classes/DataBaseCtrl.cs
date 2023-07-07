using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Security.Policy;
using System.Security.Permissions;
using MongoDB.Driver.Core.Clusters;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Data;
using Kursova_D2.Classes;
using System.Numerics;
using Guna.UI2.WinForms;
using Kursova_D2.MainForms;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Drawing;

namespace Kursova_D2.Classes
{
    public class DataBaseCtrl
    {
        private IMongoClient _client;
        private IMongoDatabase _db;
        private IMongoCollection<EuShops> _collection;
        public DataBaseCtrl()
        {
            _client = new MongoClient(Environment.GetEnvironmentVariable("mongoString"));
            _db = _client.GetDatabase("EuShops");
            _collection = _db.GetCollection<EuShops>("EuShops");
        }
        public IMongoCollection<EuShops> GetCollection() 
        {
            return _collection;
        }
        public void AddCenter(EuShops centeradd)
        {
            _collection.InsertOne(centeradd);
        }
        public void DeleteCenter(string id)
        {
            _collection.DeleteOne(u => u.ShopName == id);
        }
        public void readShopCenters(DataGridView datagv)
        {
            List<EuShops> shopCenters = _collection.Find(u => true).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Країна");
            dt.Columns.Add("Робочий час");
            dt.Columns.Add("Категорія");
            dt.Columns.Add("Назва");
            foreach (var item in shopCenters)
            {
                dt.Rows.Add(item.Country, item.Worktime, item.Category, item.ShopName);
            }
            datagv.DataSource = dt;
        }
        public void SortShopCenters(DataGridView datagv, string sortParam)
        {
            List<EuShops> shopCenters = _collection.Find(u => true).ToList();
            switch (sortParam.ToLower())
            {
                case "назва":
                    shopCenters = _collection.Find(u => true)
                        .Sort(Builders<EuShops>.Sort.Ascending(p => p.ShopName))
                        .ToList();
                    break;
                case "нраїна":
                    shopCenters = _collection.Find(u => true)
                        .Sort(Builders<EuShops>.Sort.Ascending(p => p.Country))
                        .ToList();
                    break;
                case "категорія":
                    shopCenters = _collection.Find(u => true)
                        .Sort(Builders<EuShops>.Sort.Ascending(p => p.Category))
                        .ToList();
                    break;
                default:
                    shopCenters = _collection.Find(u => true).ToList();
                    break;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Країна");
            dt.Columns.Add("Частина Європи");
            dt.Columns.Add("Час візиту");
            dt.Columns.Add("Час роботи");
            foreach (var item in shopCenters)
            {
                dt.Rows.Add(item.Country, item.Worktime, item.Category, item.ShopName);
            }
            datagv.DataSource = dt;
        }
        public void SearchFastShop(DataGridView datagv, string searchQuery)
        {
            List<EuShops> shopCenters = _collection.Find(u => u.ShopName.StartsWith(searchQuery)).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Країна");
            dt.Columns.Add("Робочий час");
            dt.Columns.Add("Категорія");
            dt.Columns.Add("Назва");
            foreach (var item in shopCenters)
            {
                dt.Rows.Add(item.Country, item.Worktime, item.Category, item.ShopName);
            }
            datagv.DataSource = dt;
        }
        public void DisplayShopDetails(string shopName, Guna2TextBox countryTextBox, Guna2TextBox worktimeTextBox, Guna2TextBox categoryTextBox, Guna2TextBox nameTextBox, RichTextBox Doptxt)
        {
            var shopCenter = _collection.Find(s => s.ShopName == shopName).FirstOrDefault();
            if (shopCenter != null)
            {
                countryTextBox.Text = shopCenter.Country;
                worktimeTextBox.Text = shopCenter.Worktime;
                categoryTextBox.Text = shopCenter.Category;
                nameTextBox.Text = shopCenter.ShopName;
                Doptxt.Text = shopCenter.Dop;
            }
        }
        public void MegaDelete(DataGridView datagv, string columnName)
        {
            int selectedIndex = datagv.CurrentCell.RowIndex;

            string id = datagv.Rows[selectedIndex].Cells[columnName].Value.ToString();

            DeleteCenter(id);

            datagv.Rows.RemoveAt(selectedIndex);
        }
    }
}
