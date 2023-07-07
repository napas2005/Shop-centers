using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_D2.Classes
{
    public class EuShops
    {
        public EuShops(string _country, string _worktime, string _catergory, string _shopname, string _picturepath, string _dop)
        {
            Country = _country;
            Worktime = _worktime;
            Category = _catergory;
            ShopName = _shopname;
            PicturePath =  _picturepath;
            Dop = _dop;
        }
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("country")]
        public string Country;
        [BsonElement("worktime")]
        public string Worktime;
        [BsonElement("category")]
        public string Category;
        [BsonElement("shopname")]
        public string ShopName;
        [BsonElement]
        public string PicturePath { get; set; }
        [BsonElement("Dop")]
        public string Dop;
    }
}

