using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPK_PDPTA.Class
{
    class KuotaBimbingan
    {
        private String _nidn;
        private String _kuota_1;
        private String _kuota_2;
        private String _tahun_ajar;

        public KuotaBimbingan()
        {
            _nidn = "";
            _kuota_1 = "";
            _kuota_2 = "";
            _tahun_ajar = "";
        }

        public String NIDN
        {
            get { return _nidn; }
            set { _nidn = value; }
        }
        public String KUOTA_1
        {
            get { return _kuota_1; }
            set { _kuota_1 = value; }
        }
        public String KUOTA_2
        {
            get { return _kuota_2; }
            set { _kuota_2 = value; }
        }
        public String TAHUN_AJAR
        {
            get { return _tahun_ajar; }
            set { _tahun_ajar = value; }
        }
    }
}
