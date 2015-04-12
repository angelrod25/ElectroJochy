using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

// si
namespace BLL
{
    public class Clientes
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public float Balance { get; set; }

        public Clientes()
        {
            this.IdCliente = 0;
            this.Fecha = DateTime.Now;
            this.Nombre = string.Empty;
            this.Cedula = string.Empty;
            this.Telefono = string.Empty;
            this.Direccion = string.Empty;
            this.Balance = 0.00f;
        }

        public static Boolean AumentarBalance(int IdCliente, float ValorAumentar)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Clientes Set Balance=Balance+" + ValorAumentar.ToString() + "Where IdCliente=" + IdCliente.ToString());

        }

        public static Boolean DecrementarBalance(int IdCliente, float ValorDecrementar)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Clientes set Balance= Balance-" + ValorDecrementar.ToString() + "Where IdCliente =" + IdCliente.ToString());
        }

     public Boolean Insertar()
        {
            this.IdCliente = 0;

            this.IdCliente = Convert.ToInt32(Conexion.ObtenerValorDb("Insert into Clientes (Fecha, Nombre, Cedula, Telefono, Direccion, Balance) values (GETDATE(), '" + this.Nombre + "', '" + this.Cedula + "', '" + this.Telefono + "', '" + this.Direccion + "', " + this.Balance + ") Select @@Identity"));

            return this.IdCliente > 0;

        }
     
        public Boolean Modificar()
         {

         bool paso1 = false;
         paso1 = Conexion.EjecutarDB("Update Clientes set Nombre = '" + this.Nombre + "', Cedula = '" + this.Cedula + "', Telefono = '" + this.Telefono + "', Direccion = '" + this.Direccion + "' Where IdCliente = " + this.IdCliente);
         return paso1;

         }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Clientes where IdCliente=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("IdCliente, Fecha, Nombre, Cedula, Telefono, Direccion, Balance", "IdCliente=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdCliente = (int)dt.Rows[0]["Id Cliente"];
                this.Nombre = dt.Rows[0]["Nombre del Cliente"].ToString();
                this.Cedula = dt.Rows[0]["Cedula del Cliente"].ToString();
                this.Telefono = dt.Rows[0]["Telefono del Cliente"].ToString();
                this.Direccion = dt.Rows[0]["Direccion del Cliente"].ToString();
                this.Balance = (float)dt.Rows[0]["Balance del Cliente"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha de Ingreso Cliente"];

                return true;
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Clientes where " + Filtro);
        }

    }
}
