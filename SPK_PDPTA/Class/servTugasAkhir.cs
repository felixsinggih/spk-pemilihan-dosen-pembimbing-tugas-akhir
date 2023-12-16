using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servTugasAkhir : TugasAkhir
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servTugasAkhir()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String kode)
        {
            bool cek = false;
            dbServ.query = "select * from tugas_akhir where kd_ta='" + kode + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void SimpanTA()
        {
            dbServ.query = "insert into tugas_akhir values ('" + KODE_TA + "', '" + NPM + "', '" + JUDUL + "', '" + TAHUN_AJAR + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public void SimpanMakulTA()
        {
            dbServ.query = "insert into detail_makul_ta values ('" + KODE_TA + "', '" + MATAKULIAH + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public DataTable Tampil()
        {
            dbServ.query = "select * from v_tugas_akhir";
            return dbServ.ExecQuery(dbServ.query);
        }
        public DataTable TampilDosen()
        {
            dbServ.query = "SELECT kuota_bimbingan.nidn, dosen.nm_dsn FROM dosen, kuota_bimbingan WHERE dosen.nidn=kuota_bimbingan.nidn " +
                "AND kuota_bimbingan.kuota_1!=0";
            return dbServ.ExecQuery(dbServ.query);
        }
        public DataTable TampilBimbingan()
        {
            dbServ.query = "SELECT mahasiswa.npm, mahasiswa.nm_mhs, " +
                "MAX(CASE WHEN pembimbing.status='Pembimbing 1' THEN dosen.nm_dsn ELSE '' END) AS pembimbing_1, " +
                "MAX(CASE WHEN pembimbing.status='Pembimbing 2' THEN dosen.nm_dsn ELSE '' END) AS pembimbing_2 " +
                "FROM mahasiswa, tugas_akhir, pembimbing, dosen " +
                "WHERE mahasiswa.npm=tugas_akhir.npm AND tugas_akhir.kd_ta=pembimbing.kd_ta " +
                "AND pembimbing.nidn=dosen.nidn";
            return dbServ.ExecQuery(dbServ.query);
        }
    }
}
