using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPK_PDPTA.Class
{
    class Dosen
    {
        private String _nidn;
        private String _nama_dsn;
        private String _tempat_lhr;
        private String _tgl_lhr;
        private String _agama;
        private String _alamat;
        private String _telp;
        private String _email;
        private String _jns_kelamin;
        private String _status;
        private String _kd_kbk;

        public Dosen()
        {
            _nidn = "";
            _nama_dsn = "";
            _tempat_lhr = "";
            _tgl_lhr = "";
            _agama = "";
            _alamat = "";
            _telp = "";
            _email = "";
            _jns_kelamin = "";
            _status = "";
            _kd_kbk = "";
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
        public String TEMPAT_LHR
        {
            get { return _tempat_lhr; }
            set { _tempat_lhr = value; }
        }
        public String TGL_LHR
        {
            get { return _tgl_lhr; }
            set { _tgl_lhr = value; }
        }
        public String AGAMA
        {
            get { return _agama; }
            set { _agama = value; }
        }
        public String ALAMAT
        {
            get { return _alamat; }
            set { _alamat = value; }
        }
        public String TELP
        {
            get { return _telp; }
            set { _telp = value; }
        }
        public String EMAIL
        {
            get { return _email; }
            set { _email = value; }
        }
        public String JNS_KELAMIN
        {
            get { return _jns_kelamin; }
            set { _jns_kelamin = value; }
        }
        public String STATUS
        {
            get { return _status; }
            set { _status = value; }
        }
        public String KODE_KBK
        {
            get { return _kd_kbk; }
            set { _kd_kbk = value; }
        }
    }
}
