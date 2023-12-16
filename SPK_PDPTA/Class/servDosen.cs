using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servDosen : Dosen
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servDosen()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String kode)
        {
            bool cek = false;
            dbServ.query = "select * from dosen where nidn='" + kode + "'";
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
            dbServ.query = "insert into dosen values ('" + NIDN + "', '" + NAMA_DSN + "', '" + TEMPAT_LHR + "', '" + TGL_LHR + "', '" + JNS_KELAMIN + "', '" + AGAMA + "', '" + ALAMAT + "', '" + TELP + "', '" + EMAIL + "', '" + STATUS + "', '" + KODE_KBK + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public void Ubah(String kode)
        {
            dbServ.query = "Update dosen set nm_dsn='" + NAMA_DSN + "', tempat_lhr='" + TEMPAT_LHR + "', tgl_lhr='" + TGL_LHR + "', jns_kelamin='" + JNS_KELAMIN + "', agama='" + AGAMA + "', alamat='" + ALAMAT + "', telp='" + TELP + "', email='" + EMAIL + "', status='" + STATUS + "', kd_kbk='" + KODE_KBK + "' where nidn='" + kode + "'";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public DataTable Tampil()
        {
            dbServ.query = "SELECT dosen.nidn, dosen.nm_dsn, CONCAT(dosen.tempat_lhr,', ', dosen.tgl_lhr) AS ttl, " +
                "dosen.jns_kelamin, dosen.telp, dosen.email, dosen.status, kbk.nm_kbk " +
                "FROM dosen, kbk WHERE dosen.kd_kbk=kbk.kd_kbk";
            return dbServ.ExecQuery(dbServ.query);
        }

        //Tampil Data
        public bool CekNama(String nama)
        {
            bool cek = false;

            dbServ.query = "select * from dosen where nm_dsn ='" + nama + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);

            if (dtTmp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public Dosen TampilDataByNidn(String nidn)
        {
            Dosen cell = new Dosen();

            dbServ.query = "SELECT dosen.nidn, dosen.nm_dsn, dosen.tempat_lhr, dosen.tgl_lhr, dosen.jns_kelamin, " +
                "dosen.agama, dosen.alamat, dosen.telp, dosen.email, dosen.status, kbk.nm_kbk FROM dosen, kbk " +
                "WHERE dosen.kd_kbk=kbk.kd_kbk AND dosen.nidn='" + nidn + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);

            if (dtTmp.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTmp.Rows)
                {
                    cell.NIDN = tmp[0].ToString();
                    cell.NAMA_DSN = tmp[1].ToString();
                    cell.TEMPAT_LHR = tmp[2].ToString();
                    cell.TGL_LHR = tmp[3].ToString();
                    cell.JNS_KELAMIN = tmp[4].ToString();
                    cell.AGAMA = tmp[5].ToString();
                    cell.ALAMAT = tmp[6].ToString();
                    cell.TELP = tmp[7].ToString();
                    cell.EMAIL = tmp[8].ToString();
                    cell.STATUS = tmp[9].ToString();
                    cell.KODE_KBK = tmp[10].ToString();
                }
            }
            return cell;
        }
        public Dosen TampilDataByNama(String nama)
        {
            Dosen cell = new Dosen();

            dbServ.query = "SELECT * FROM dosen WHERE nm_dsn='" + nama + "'";
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
