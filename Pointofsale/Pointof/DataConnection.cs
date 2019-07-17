using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointof
{
    class DataConnection
    {
        public string MyConnection() 
        {
            string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2013\Projects\Pointofsale\Pointof\POS_db.mdf;Integrated Security=True";
            return con;
        }
    }
}
