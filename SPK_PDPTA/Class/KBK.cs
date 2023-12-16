using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPK_PDPTA.Class
{
    class KBK
    {
        private String _kd_kbk;
        private String _nm_kbk;
        private String _kata;

        public KBK()
        {
            _kd_kbk = "";
            _nm_kbk = "";
            _kata = "";
        }

        public String KODE_KBK
        {
            get { return _kd_kbk; }
            set { _kd_kbk = value; }
        }
        public String NAMA_KBK
        {
            get { return _nm_kbk; }
            set { _nm_kbk = value; }
        }
        public String KATA
        {
            get { return _kata; }
            set { _kata = value; }
        }
    }
}
