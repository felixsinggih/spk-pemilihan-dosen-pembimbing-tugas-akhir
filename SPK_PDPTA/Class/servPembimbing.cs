using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servPembimbing : TugasAkhir
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servPembimbing()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String kode, String stat)
        {
            bool cek = false;
            dbServ.query = "select * from pembimbing where kd_ta='" + kode + "' and status='" + stat + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void Simpan()
        {
            dbServ.query = "insert into pembimbing values ('" + KODE_TA + "', '" + NIDN + "', '" + STATUS + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
    }
}
