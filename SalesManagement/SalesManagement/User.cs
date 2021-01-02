using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SalesManagement
{
    public class User
    {
        private string id;
        private string name;
        private string passWord;

        public User()
        {
            id = "";
            passWord = "";
            name = "";
        }

        public SqlConnection connection = new SqlConnection(global.conString);
        public User(string id, string pass)
        {
            this.id = id;
            this.passWord = pass;
            connection.Open();
            string sqlQuery = "";
            if (id.Contains("NV")) sqlQuery = "select TEN from NHANVIEN where MANV = '" + id + "'";
            else if(id.Contains("QL")) sqlQuery = "select TEN from QUANLY where MAQL = '" + id + "'";

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                this.name = dataReader.GetString(0);
            }
            connection.Close();
        }

        public string ID
        {
            get
            {
                return id;
            }
        }
        public string PASSWORD
        {
            get
            {
                return passWord;
            }
            set
            {
                this.passWord = value;
            }
        }
        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

    }
}
