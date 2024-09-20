using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class obtenerconexion
    {
        public SqlConnection Connection()
        {
            using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-FFTCVLK\\DEVELOPEKEV;Initial Catalog= textil ; Integrated Security =true;"))
            {
                connection.Open();
                return connection;
            }
        }
    }
}
