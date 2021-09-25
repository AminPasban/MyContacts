using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts
{
    interface IMyContactsOperations
    {
        DataTable SelectAll();

        DataTable Select(int id);

        bool Insert(string name, String family, String phone, String email, string address);

        bool Update(int id, string name, String family, String phone, String email, string address);

        bool Delete(int id);
    }
}
