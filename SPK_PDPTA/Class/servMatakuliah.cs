using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servMatakuliah : Matakuliah
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servMatakuliah()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String kode)
        {
            bool cek = false;
            dbServ.query = "select * from matakuliah where kd_makul='" + kode + "'";
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
            dbServ.query = "insert into matakuliah values ('" + KODE_MAKUL + "', '" + NAMA_MAKUL + "', '" + JENIS + "', '" + JML_SKS + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public void Ubah(String kode)
        {
            dbServ.query = "Update matakuliah set nm_makul='" + NAMA_MAKUL + "', jenis='" + JENIS + "', jml_sks='" + JML_SKS + "' where kd_makul='" + kode + "'";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public DataTable Tampil()
        {
            dbServ.query = "SELECT * FROM matakuliah";
            return dbServ.ExecQuery(dbServ.query);
        }

        //Tampil kode makul 
        public bool CekNama(String nama)
        {
            bool cek = false;
            dbServ.query = "select * from matakuliah where nm_makul='" + nama + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public Matakuliah TampilDataByNama(String nama)
        {
            Matakuliah cell = new Matakuliah();

            dbServ.query = "select * from matakuliah where nm_makul='" + nama + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTmp.Rows)
                {
                    cell.KODE_MAKUL = tmp[0].ToString();
                    cell.NAMA_MAKUL = tmp[1].ToString();
                    cell.JENIS = tmp[2].ToString();
                    cell.JML_SKS = tmp[3].ToString();
                }
            }
            return cell;
        }
    }
}
