using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts
{
    class MyContactOperations : IMyContactsOperations
    {
        private string connectionString = "Data Source= .; Initial Catalog= MyContacts_DB; Integrated Security= true";
        
        public DataTable SelectAll()
        {
            string query = "select * from MyContacts";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);

            return data;
        }

        public DataTable Select(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string family, string phone, string email, string address)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, string name, string family, string phone, string email, string address)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}