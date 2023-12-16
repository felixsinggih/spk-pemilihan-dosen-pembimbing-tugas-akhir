using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servKuotaBimbingan : KuotaBimbingan
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servKuotaBimbingan()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String nidn, String tahun)
        {
            bool cek = false;
            dbServ.query = "select * from kuota_bimbingan where nidn='" + nidn + "' and tahun_ajar='" + tahun + "'";
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
            dbServ.query = "insert into kuota_bimbingan values ('" + NIDN + "', '" + KUOTA_1 + "', '" + KUOTA_2 + "', '" + TAHUN_AJAR + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public DataTable Tampil()
        {
            dbServ.query = "SELECT dosen.nidn, dosen.nm_dsn, kuota_bimbingan.kuota_1, kuota_bimbingan.kuota_2 " +
                "FROM dosen, kuota_bimbingan WHERE dosen.nidn=kuota_bimbingan.nidn ";
            return dbServ.ExecQuery(dbServ.query);
        }
        public DataTable TampilDosen()
        {
            dbServ.query = "SELECT nidn, nm_dsn FROM dosen WHERE status='Aktif'";
            return dbServ.ExecQuery(dbServ.query);
        }
    }
}
