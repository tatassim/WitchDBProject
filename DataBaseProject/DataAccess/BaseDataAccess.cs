using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject.DataAccess
{
    public class BaseDataAccess
    {
        protected string connectionString;


        protected BaseDataAccess(string connectionString)
        {
            this.connectionString = connectionString;

        }
    }
}
