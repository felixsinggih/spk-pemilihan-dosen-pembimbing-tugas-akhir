using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servKamusKata : KBK
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servKamusKata()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String kode, String kata)
        {
            bool cek = false;
            dbServ.query = "select * from kamus_kata where kd_kbk='" + kode + "' AND kata='" + kata + "'";
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
            dbServ.query = "insert into kamus_kata values ('" + KODE_KBK + "', '" + KATA + "')";
            if (!(dbServ.ExecNonQuery(dbServ.query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public DataTable Tampil()
        {
            dbServ.query = "SELECT MAX(Case when nm_kbk='Pemrograman' then kata else '' end) as Pemrograman, " +
                "MAX(Case when nm_kbk='Jaringan' then kata else '' end) as Jaringan, " +
                "MAX(Case when nm_kbk='Multimedia' then kata else '' end) as Multimedia " +
                "from kbk, kamus_kata where kbk.kd_kbk=kamus_kata.kd_kbk group by kata";
            return dbServ.ExecQuery(dbServ.query);
        }
        public DataTable TampilCari(String kata)
        {
            dbServ.query = "SELECT MAX(Case when nm_kbk='Pemrograman' then kata else '' end) as Pemrograman, " +
                "MAX(Case when nm_kbk='Jaringan' then kata else '' end) as Jaringan, " +
                "MAX(Case when nm_kbk='Multimedia' then kata else '' end) as Multimedia " +
                "from kbk, kamus_kata where kbk.kd_kbk=kamus_kata.kd_kbk " +
                "And kata LIKE '%" + kata + "%'group by kata";
            return dbServ.ExecQuery(dbServ.query);
        }

        //tampil kode
        public DataTable TampilKBK()
        {
            dbServ.query = "SELECT * from kbk";
            return dbServ.ExecQuery(dbServ.query);
        }
        public KBK TampilDataByNama(String nama)
        {
            KBK cell = new KBK();

            dbServ.query = "select * from kbk where nm_kbk='" + nama + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTmp.Rows)
                {
                    cell.KODE_KBK = tmp[0].ToString();
                    cell.NAMA_KBK = tmp[1].ToString();
                }
            }
            return cell;
        }
    }
}
