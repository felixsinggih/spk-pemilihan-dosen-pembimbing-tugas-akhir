using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servMatakuliahDosen : Matakuliah
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servMatakuliahDosen()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String nidn, String kode)
        {
            bool cek = false;
            dbServ.query = "select * from matakuliah_dosen where nidn='" + nidn + "' and kd_makul='" + kode + "'";
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
            dbServ.query = "insert into matakuliah_dosen values ('" + NIDN + "', '" + KODE_MAKUL + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public DataTable Tampil()
        {
            dbServ.query = "SELECT matakuliah_dosen.nidn, dosen.nm_dsn, matakuliah_dosen.kd_makul, matakuliah.nm_makul " +
                "FROM matakuliah_dosen, dosen, matakuliah " +
                "WHERE matakuliah_dosen.nidn=dosen.nidn AND matakuliah_dosen.kd_makul=matakuliah.kd_makul";
            return dbServ.ExecQuery(dbServ.query);
        }

        //tampil data dosen
        public DataTable TampilDosen()
        {
            dbServ.query = "SELECT nidn, nm_dsn FROM dosen";
            return dbServ.ExecQuery(dbServ.query);
        }
        public bool CekNama(String nama)
        {
            bool cek = false;
            dbServ.query = "select * from dosen where nm_dsn='" + nama + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public Dosen TampilDataByNama(String nama)
        {
            Dosen cell = new Dosen();

            dbServ.query = "select * from dosen where nm_dsn='" + nama + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTmp.Rows)
                {
                    cell.NIDN = tmp[0].ToString();
                }
            }
            return cell;
        }
    }
}
