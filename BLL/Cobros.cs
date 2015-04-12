using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
// 
namespace BLL
{
    public class Cobros
    {
        private ConexionDb Conexion = new ConexionDb();


        public int IdCobro { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public string Concepto { get; set; }
        public int IdCliente { get; set; }


        public Cobros()
        {

            this.IdCobro = 0;
            this.Fecha = DateTime.Now;
            this.Monto = 0.00f;
            this.Concepto = string.Empty;
            this.IdCliente = 0;

        }


        public Boolean Insertar()
        {
            bool paso2 = false;

            this.IdCobro = 0;

            this.IdCobro = Convert.ToInt32(Conexion.ObtenerValorDb("Insert into Cobros (Fecha, Concepto, Monto) values (GETDATE(), '" + this.Concepto + "', " + this.Monto + ") Select @@Identity"));

            paso2 = this.IdCobro > 0;

            if (paso2)
            {
                Clientes.DecrementarBalance(this.IdCliente, this.Monto);
            }

            return paso2;
        }

        public Boolean Modificar()
        {

            bool paso1 = false;

            paso1 = Conexion.EjecutarDB("Update Cobros set Concepto = '" + this.Concepto + "', Monto = " + this.Monto + " Where IdCobro = " + this.IdCobro);

            if (paso1)
            {
                Clientes.DecrementarBalance(this.IdCliente, this.Monto);
            }

            return paso1;

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Cobros where IdCobro =" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();
            dt = this.Listar("Fecha, Concepto, Monto, IdCliente", "IdCobro=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                return true;

            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cobros where " + Filtro);
        }
    }

 }
