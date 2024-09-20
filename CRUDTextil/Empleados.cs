using CRUDTextil.TextilTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTextil
{
    public class Empleados
    {
        private static EmpleadosTableAdapter employees = new EmpleadosTableAdapter();
        public Textil.EmpleadosDataTable GetDataEmpleados()
        {
            return employees.GetDataEmpleados();
        }
        public Textil.EmpleadosDataTable GetDataByIDEmpleados(int employ)
        {
            return employees.GetDataByIDEmpleados(employ);
        }
        public Textil.EmpleadosDataTable Nombrecompleto(string dni)
        {
            return (Textil.EmpleadosDataTable)employees.Nombrecompleto(dni);
        }
    }
}
