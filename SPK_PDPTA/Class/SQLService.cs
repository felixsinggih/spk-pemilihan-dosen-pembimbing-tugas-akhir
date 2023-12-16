using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SPK_PDPTA.Class
{
    class SQLService : SQLConn
    {
        private String strCon = "";
        private MySqlConnection sConn;
        private MySqlCommand sComm;
        private MySqlDataAdapter dtAdp;
        public String query;

        public SQLService()
        {
            strCon = ConStr();
            sConn = new MySqlConnection(strCon);
            sComm = new MySqlCommand();
            dtAdp = new MySqlDataAdapter();
        }

        public String ConStr()
        {
            String data;
            data = "Server=localhost;database=sepik_pedos;user id=root;password=";
            return data;
        }

        public void BukaKoneksi()
        {
            if (sConn.State == ConnectionState.Closed)
            {
                try
                {
                    sConn.Open();
                }
                catch (Exception)
                { }
            }
        }

        public void TutupKoneksi()
        {
            sConn.Close();
        }

        public override int ExecNonQuery(String query)
        {
            int retVal = -1;

            try
            {
                BukaKoneksi();
                sComm.Connection = sConn;
                sComm.CommandText = query;
                retVal = sComm.ExecuteNonQuery();
            }
            catch (Exception)
            { }
            finally
            {
                TutupKoneksi();
            }

            return retVal;
        }

        public override DataTable ExecQuery(String query)
        {
            DataTable retVal = new DataTable();

            try
            {
                BukaKoneksi();
                sComm.Connection = sConn;
                sComm.CommandText = query;
                dtAdp.SelectCommand = sComm;
                dtAdp.Fill(retVal);
            }
            catch (Exception)
            { }
            finally
            {
                TutupKoneksi();
            }

            return retVal;
        }
    }
}
