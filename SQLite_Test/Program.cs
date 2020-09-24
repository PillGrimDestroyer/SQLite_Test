using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Test
{
    class Program
    {
        public static void Main()
        {
            var db = new ApplicationContext();
            var l = db.Phones.ToList();
            var p = l?.FirstOrDefault();
        }
    }
}
