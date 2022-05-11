using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TasmaControl;
namespace QuanLyGiangDay
{
    class kn
    {
        public static SqlConnection ketnoi = TasmaMain.ketnoi(@"DESKTOP-MC\SQLEXPRESS", "QLDG");
    }
}
