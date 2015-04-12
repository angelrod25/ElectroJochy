using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;


namespace BLL
{
    public class Facturas
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public int IdCliente { get; set; }
        public string Tipo { get; set; }



        public Facturas()
        {
            this.IdFactura = 0;
            this.Fecha = DateTime.Now;
            this.Monto = 0.00f;
            this.IdCliente = 0;
            this.Tipo = string.Empty;
        }

        public Boolean Insertar()
        {
            this.IdCliente = 0;

            this.IdCliente = Convert.ToInt32(Conexion.ObtenerValorDb("Insert into Facturas (Fecha, Monto, IdCliente, Tipo) values (GETDATE(), " + this.Monto + ", " + this.IdCliente + ", '" + this.Tipo + "') Select @@Identity"));

            return this.IdCliente > 0;

        }

        public Boolean Modificar()
        {

            bool paso1 = false;

            paso1 = Conexion.EjecutarDB("Update Facturas set Monto = " + this.Monto + ", IdCliente = " + this.IdCliente + " Where IdFactura = " + this.IdFactura);

            return paso1;

        }


        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Facturas where IdFactura =" + IdBuscado);
        }



    }
}
