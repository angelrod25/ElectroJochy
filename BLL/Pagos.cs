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
    public class Pagos
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdPago { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public float Monto { get; set; }

        public Pagos()
        {
            this.IdPago = 0;
            this.Fecha = DateTime.Now;
            this.Concepto = string.Empty;
            this.Monto = 0.00f;
        }

        public Boolean Insertar()
        {
            this.IdPago = 0;

            this.IdPago = Convert.ToInt32(Conexion.ObtenerValorDb("Insert into Pagos (Fecha, Concepto, Monto) values (GETDATE(), '" + this.Concepto + "', "+ this.Monto + ") Select @@Identity"));

            return this.IdPago > 0;
        }

        public Boolean Modificar()
        {

            bool paso1 = false;

            paso1 = Conexion.EjecutarDB("Update Pagos set Concepto = '" + this.Concepto + "', Monto = " + this.Monto + " Where IdPago = " + this.IdPago);

            return paso1;

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Pagos where IdPago =" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();
            dt = this.Listar("Fecha, Concepto, Monto", "IdPago=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

            //    this.IdSuplidor = (int)dt.Rows[0]["Id Suplidor"];
             //   this.Telefono = dt.Rows[0]["Telefono"].ToString();

                return true;

            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Pagos where " + Filtro);
        }
    }

}
