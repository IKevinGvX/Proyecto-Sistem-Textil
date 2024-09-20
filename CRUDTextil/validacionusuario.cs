using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class validacionusuario
    {
        public    bool validarusuarioempleado(string Nombre, string DNI)
        {
            using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-FFTCVLK\\DEVELOPEKEV;Initial Catalog= textil ; Integrated Security =true;")) 
            {
                bool res;
                connection.Open();
                string query = ("select Nombre, DNI from Empleados where Nombre = '" + Nombre + "' and DNI = '" + DNI + "'");
                SqlCommand com = new SqlCommand(query, connection);
                SqlDataReader read = com.ExecuteReader();
                if (read.Read())
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                read.Close();
                return res;
            }
        }
    }
}
