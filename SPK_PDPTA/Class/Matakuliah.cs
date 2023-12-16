using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPK_PDPTA.Class
{
    class Matakuliah
    {
        private String _kd_makul;
        private String _nama_makul;
        private String _jenis;
        private String _jml_sks;

        //makul dosen
        private String _nidn;

        public Matakuliah()
        {
            _kd_makul = "";
            _nama_makul = "";
            _jenis = "";
            _jml_sks = "";

            //makul dosen
            _nidn = "";
        }

        public String KODE_MAKUL
        {
            get { return _kd_makul; }
            set { _kd_makul = value; }
        }
        public String NAMA_MAKUL
        {
            get { return _nama_makul; }
            set { _nama_makul = value; }
        }
        public String JENIS
        {
            get { return _jenis; }
            set { _jenis = value; }
        }
        public String JML_SKS
        {
            get { return _jml_sks; }
            set { _jml_sks = value; }
        }

        //makul dosen
        public String NIDN
        {
            get { return _nidn; }
            set { _nidn = value; }
        }
    }
}
