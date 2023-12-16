using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servPengguna :Pengguna
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servPengguna()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String kode)
        {
            bool cek = false;
            dbServ.query = "select * from pemgguna where npak='" + kode + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        //CRUD
        public void Simpan()
        {
            dbServ.query = "insert into pengguna values ('" + NPAK + "', '" + NAMA + "', '" + USERNAME + "', md5('" + PASSWORD + "'), '" + BAGIAN + "', '" + STATUS + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public void Ubah(String kode)
        {
            dbServ.query = "Update pengguna set nama='" + NAMA + "', username='" + USERNAME + "', password=md5('" + PASSWORD + "'), bagian='" + BAGIAN + "', status='" + STATUS + "' where nidn='" + kode + "'";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public DataTable Tampil()
        {
            dbServ.query = "SELECT * FROM pengguna";
            return dbServ.ExecQuery(dbServ.query);
        }

        //login
        public String CekLogin(String kode, String pass)
        {
            String Auth = "";
            dbServ.query = "select bagian from pengguna where username='" + kode + "' and password=md5('" + pass + "')";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                Auth = dtTmp.Rows[0][0].ToString();
            }
            return Auth;
        }
    }
}
