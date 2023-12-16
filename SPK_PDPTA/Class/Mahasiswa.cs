﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPK_PDPTA.Class
{
    class Mahasiswa
    {
        private String _npm;
        private String _nama_mhs;
        private String _tempat_lhr;
        private String _tgl_lhr;
        private String _agama;
        private String _alamat;
        private String _telp;
        private String _email;
        private String _jns_kelamin;
        private String _status;
        private String _prodi;

        public Mahasiswa()
        {
            _npm = "";
            _nama_mhs = "";
            _tempat_lhr = "";
            _tgl_lhr = "";
            _agama = "";
            _alamat = "";
            _telp = "";
            _email = "";
            _jns_kelamin = "";
            _status = "";
            _prodi = "";
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
        public String PRODI
        {
            get { return _prodi; }
            set { _prodi = value; }
        }

    }
}
