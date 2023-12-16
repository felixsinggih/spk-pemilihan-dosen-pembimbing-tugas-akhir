using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPK_PDPTA.Class
{
    class Pengguna
    {
        private String _npak;
        private String _nama;
        private String _username;
        private String _password;
        private String _bagian;
        private String _status;
        
        public Pengguna()
        {
            _npak = "";
            _nama = "";
            _username = "";
            _password = "";
            _bagian = "";
            _status = "";
        }

        public String NPAK
        {
            get { return _npak; }
            set { _npak = value; }
        }
        public String NAMA
        {
            get { return _nama; }
            set { _nama = value; }
        }
        public String USERNAME
        {
            get { return _username; }
            set { _username = value; }
        }
        public String PASSWORD
        {
            get { return _password; }
            set { _password = value; }
        }
        public String BAGIAN
        {
            get { return _bagian; }
            set { _bagian = value; }
        }
        public String STATUS
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
