using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL2_28_Ticketing
{
     class koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=db_tiket_xii_rpl_2_28;" + "user id=postgres;password=admin");
    }
}
