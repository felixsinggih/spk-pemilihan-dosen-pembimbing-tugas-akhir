using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPK_PDPTA.Class
{
    class TugasAkhir
    {
        private String _kd_ta;
        private String _judul;
        private String _tahun_ajar;
        private String _npm;

        //pembimbing
        private String _nidn;
        private String _status;
        //detail makul ta
        private String _matakuliah;

        public TugasAkhir()
        {
            _kd_ta = "";
            _judul = "";
            _tahun_ajar = "";
            _npm = "";

            //pembimbing
            _nidn = "";
            _status = "";
            //detail makul ta
            _matakuliah = "";
        }

        public String KODE_TA
        {
            get { return _kd_ta; }
            set { _kd_ta = value; }
        }
        public String JUDUL
        {
            get { return _judul; }
            set { _judul = value; }
        }
        public String TAHUN_AJAR
        {
            get { return _tahun_ajar; }
            set { _tahun_ajar = value; }
        }
        public String NPM
        {
            get { return _npm; }
            set { _npm = value; }
        }

        //pemimbing
        public String NIDN
        {
            get { return _nidn; }
            set { _nidn = value; }
        }
        public String STATUS
        {
            get { return _status; }
            set { _status = value; }
        }
        //detail maul ta
        public String MATAKULIAH
        {
            get { return _matakuliah; }
            set { _matakuliah = value; }
        }
    }
}
