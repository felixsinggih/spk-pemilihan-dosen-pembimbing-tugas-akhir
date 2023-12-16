using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPK_PDPTA.Class
{
    class SPK
    {
        private String _kode_ta;
        private String _npm;
        private String _nama_mhs;
        private String _judul;
        private String _nidn;
        private String _nama_dsn;
        private String _tahun_ajar;
        private String _matakuliah;

        public SPK()
        {
            _kode_ta = "";
            _npm = "";
            _nama_mhs = "";
            _judul = "";
            _nidn = "";
            _nama_dsn = "";
            _tahun_ajar = "";
            _matakuliah = "";
        }

        public String KODE_TA
        {
            get { return _kode_ta; }
            set { _kode_ta = value; }
        }
        public String NPM
        {
            get { return _npm; }
            set { _npm = value; }
        }
        public String NAMA_MHS
        {
            get { return _nama_mhs; }
            set { _nama_mhs = value; }
        }
        public String JUDUL
        {
            get { return _judul; }
            set { _judul = value; }
        }
        public String NIDN
        {
            get { return _nidn; }
            set { _nidn = value; }
        }
        public String NAMA_DSN
        {
            get { return _nama_dsn; }
            set { _nama_dsn = value; }
        }
        public String TAHUN_AJAR
        {
            get { return _tahun_ajar; }
            set { _tahun_ajar = value; }
        }
        public String MATAKULIAH
        {
            get { return _matakuliah; }
            set { _matakuliah = value; }
        }
    }
}
