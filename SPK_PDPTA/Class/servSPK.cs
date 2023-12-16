using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SPK_PDPTA.Class
{
    class servSPK :SPK
    {
        SQLService dbServ; //database
        DataTable dtTmp; //temporary

        public servSPK()
        {
            dbServ = new SQLService();
            dtTmp = new DataTable();
        }

        public bool Cek(String kode)
        {
            bool cek = false;
            dbServ.query = "select * from tugas_akhir where npm='" + kode + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public SPK TampilDataByNpm(String nama)
        {
            SPK cell = new SPK();

            dbServ.query = "SELECT tugas_akhir.kd_ta, mahasiswa.nm_mhs, tugas_akhir.judul, pembimbing.nidn, dosen.nm_dsn, tugas_akhir.tahun_ajar " +
                "FROM mahasiswa, tugas_akhir, pembimbing, dosen " +
                "WHERE mahasiswa.npm=tugas_akhir.npm AND tugas_akhir.kd_ta=pembimbing.kd_ta " +
                "AND pembimbing.nidn=dosen.nidn AND mahasiswa.npm='" + nama + "' and pembimbing.status='Pembimbing 1'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTmp.Rows)
                {
                    cell.KODE_TA = tmp[0].ToString();
                    cell.NAMA_MHS = tmp[1].ToString();
                    cell.JUDUL = tmp[2].ToString();
                    cell.NIDN = tmp[3].ToString();
                    cell.NAMA_DSN = tmp[4].ToString();
                    cell.TAHUN_AJAR = tmp[5].ToString();
                }
            }
            return cell;
        }
        public DataTable TampilMatakuliah(String kode)
        {
            dbServ.query = "SELECT matakuliah FROM detail_makul_ta WHERE kd_ta='" + kode + "'";
            return dbServ.ExecQuery(dbServ.query);
        }
        public String CekJudul(String kata)
        {
            int P = 0;
            int J = 0;
            int M = 0;
            String Hasil = "";

            string[] Split_kata = kata.Split(' ');
            int jumlah = Split_kata.Length;

            for (int i = 0; i < jumlah; i++)
            {
                dbServ.query = "SELECT kbk.nm_kbk FROM kbk, kamus_kata " +
                "WHERE kbk.kd_kbk=kamus_kata.kd_kbk AND kamus_kata.kata='" + Split_kata[i] + "'";
                dtTmp = dbServ.ExecQuery(dbServ.query);

                if (dtTmp.Rows.Count > 0)
                {
                    int row_count = dtTmp.Rows.Count;
                    for (int y = 0; y < row_count; y++)
                    {
                        if (dtTmp.Rows[y][0].ToString() == "Pemrograman")
                        {
                            P = P + 1;
                        }
                        else if (dtTmp.Rows[y][0].ToString() == "Jaringan")
                        {
                            J = J + 1;
                        }
                        else if (dtTmp.Rows[y][0].ToString() == "Multimedia")
                        {
                            M = M + 1;
                        }
                    }
                }
            }

            if (P > J && P > M)
            {
                Hasil = "Pemrograman";
            }
            else if (J > P && J > M)
            {
                Hasil = "Jaringan";
            }
            else if (M > P && M > J)
            {
                Hasil = "Multimedia";
            }
            else
            {
                Hasil = "Gak ada";
            }

            return Hasil;
        }
        public DataTable TampilAlternatif(String bidang, String tahun, List<string> Matakuliah, String nidn)
        {
            dbServ.query = "SELECT dosen.nidn, dosen.nm_dsn," +
                "CASE WHEN kbk.nm_kbk='" + bidang + "' THEN '5' ELSE '1' END AS Topik, " +
                "CASE WHEN kuota_bimbingan.kuota_2 >= 1 && kuota_bimbingan.kuota_2 <= 3 THEN '1' " +
                    "WHEN kuota_bimbingan.kuota_2 >= 4 && kuota_bimbingan.kuota_2 <= 6 THEN '2' " +
                    "WHEN kuota_bimbingan.kuota_2 >= 7 && kuota_bimbingan.kuota_2 <= 9 THEN '3' " +
                    "WHEN kuota_bimbingan.kuota_2 >= 10 && kuota_bimbingan.kuota_2 <= 12 THEN '4' " +
                    "WHEN kuota_bimbingan.kuota_2 <= 13 THEN '5' END AS Kuota, " +
                "CASE WHEN COUNT(matakuliah.nm_makul) >= 5 THEN '5' " +
                    "WHEN COUNT(matakuliah.nm_makul) = 4 THEN '4' " +
                    "WHEN COUNT(matakuliah.nm_makul) = 3 THEN '3' " +
                    "WHEN COUNT(matakuliah.nm_makul) = 2 THEN '2' " +
                    "WHEN COUNT(matakuliah.nm_makul) = 1 THEN '1' END AS Matakuliah " +
                "FROM dosen, kbk, kuota_bimbingan, matakuliah_dosen, matakuliah " +
                "WHERE dosen.kd_kbk=kbk.kd_kbk AND dosen.nidn=kuota_bimbingan.nidn " +
                "AND dosen.nidn=matakuliah_dosen.nidn AND matakuliah_dosen.kd_makul=matakuliah.kd_makul " +
                "AND kuota_bimbingan.kuota_2 != 0 " +
                "AND kbk.nm_kbk='" + bidang + "' " +
                "AND kuota_bimbingan.tahun_ajar='" + tahun + "' " +
                "AND (matakuliah.nm_makul LIKE '%" + Matakuliah[0].ToString() + "%' " +
                                         "OR matakuliah.nm_makul LIKE '%" + Matakuliah[1].ToString() + "%' " +
                                         "OR matakuliah.nm_makul LIKE '%" + bidang + "%' " +
                                         "OR matakuliah.nm_makul LIKE '%" + Matakuliah[2].ToString() + "%') " +
                "AND dosen.nidn != '" + nidn + "' " +
                "GROUP BY nidn";
            return dbServ.ExecQuery(dbServ.query);
        }
    }
}
