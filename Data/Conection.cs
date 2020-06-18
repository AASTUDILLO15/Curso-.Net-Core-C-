using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conection : DataConnection
    {
        public Conection() : base("STUDENT_PROJECT")//se conecta a la base de datos indicada en App.config mediante el name
        { 
        }
        public ITable<Student> _Student { get { return GetTable<Student>(); } }//pasa la info mediante el objeto _Student a la tabla de SQL
        //consultar, actualizar, eliminar mediante _Student. Se obtiene mediante una colección de datos
    }
}
