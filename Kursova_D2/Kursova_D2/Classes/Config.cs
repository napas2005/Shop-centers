using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_D2.Classes
{
    public class Config
    {
        public Config()
        {
            Environment.SetEnvironmentVariable("mongoString", "mongodb://localhost:27017/");
        }
    }
}
