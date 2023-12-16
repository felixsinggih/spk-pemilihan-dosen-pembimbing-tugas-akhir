using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servMahasiswa : Mahasiswa
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servMahasiswa()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String kode)
        {
            bool cek = false;
            dbServ.query = "select * from mahasiswa where npm='" + kode + "'";
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
            dbServ.query = "insert into mahasiswa values ('" + NPM + "', '" + NAMA_MHS + "', '" + TEMPAT_LHR + "', '" + TGL_LHR + "', '" + JNS_KELAMIN + "', '" + AGAMA + "', '" + ALAMAT + "', '" + TELP + "', '" + EMAIL + "', '" + STATUS + "', '" + PRODI + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public void Ubah(String kode)
        {
            dbServ.query = "Update mahasiswa set nm_mhs='" + NAMA_MHS + "', tempat_lhr='" + TEMPAT_LHR + "', tgl_lhr='" + TGL_LHR + "', jns_kelamin='" + JNS_KELAMIN + "', agama='" + AGAMA + "', alamat='" + ALAMAT + "', telp='" + TELP + "', email='" + EMAIL + "', status='" + STATUS + "', prodi='" + PRODI + "' where npm='" + kode + "'";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public DataTable Tampil()
        {
            dbServ.query = "SELECT npm, nm_mhs, CONCAT(tempat_lhr,', ', tgl_lhr) AS ttl, jns_kelamin, " +
                "telp, email, status, prodi FROM mahasiswa";
            return dbServ.ExecQuery(dbServ.query);
        }

        //Tampil Data
        public bool CekNama(String nama)
        {
            bool cek = false;

            dbServ.query = "select * from mahasiswa where nm_mhs ='" + nama + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);

            if (dtTmp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public Mahasiswa TampilDataByNpm(String npm)
        {
            Mahasiswa cell = new Mahasiswa();

            dbServ.query = "select * from mahasiswa where npm='" + npm + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTmp.Rows)
                {
                    cell.NPM = tmp[0].ToString();
                    cell.NAMA_MHS = tmp[1].ToString();
                    cell.TEMPAT_LHR = tmp[2].ToString();
                    cell.TGL_LHR = tmp[3].ToString();
                    cell.JNS_KELAMIN = tmp[4].ToString();
                    cell.AGAMA = tmp[5].ToString();
                    cell.ALAMAT = tmp[6].ToString();
                    cell.TELP = tmp[7].ToString();
                    cell.EMAIL = tmp[8].ToString();
                    cell.STATUS = tmp[9].ToString();
                    cell.PRODI = tmp[10].ToString();
                }
            }
            return cell;
        }
    }
}
