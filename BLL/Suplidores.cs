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
    public class Suplidores
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdSuplidor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string RNC { get; set; }


      public Suplidores()
       {
           this.IdSuplidor = 0;
           this.Nombre = string.Empty;
           this.Telefono = string.Empty;
       }

      public Boolean Insertar()
      {
          this.IdSuplidor = 0;

          this.IdSuplidor = Convert.ToInt32(Conexion.ObtenerValorDb("Insert into Suplidores (Nombre, Telefono, RNC) values ('" + this.Nombre +"', '"+ this.Telefono + "', '"+this.RNC + "') Select @@Identity"));

          return this.IdSuplidor > 0;
      }


      public Boolean Modificar()
      {
          bool paso1 = false;

          paso1 = Conexion.EjecutarDB("Update Suplidores set Nombre = '" + this.Nombre + "', Telefono = '"+ this.Telefono +"' Where IdSuplidor = " + this.IdSuplidor);

          return paso1;
      }

      public Boolean Eliminar(Int32 IdBuscado)
      {
          return Conexion.EjecutarDB("Delete from Suplidores where IdSuplidor =" + IdBuscado);
      }

      public Boolean Buscar(Int32 IdBuscado)
      {
          bool Encontro = false;
          DataTable dt = new DataTable();
          dt = this.Listar("Nombre, Telefono", "IdSuplidor=" + IdBuscado);

          if (dt.Rows.Count > 0)
          {
              Encontro = true;

              this.IdSuplidor = (int)dt.Rows[0]["Id Suplidor"];
              this.Telefono = dt.Rows[0]["Telefono"].ToString();

              return true;

          }

          return Encontro;
      }

      public DataTable Listar(string campos = "*", string Filtro = "1=1")
      {
          return Conexion.BuscarDb("Select " + campos + " from Suplidores where " + Filtro);
      }

    }
}
