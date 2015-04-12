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
    public class Articulos
    {
       private ConexionDb Conexion = new ConexionDb();

       public int IdArticulo { get; set; }
       public string Descripcion { get; set; }
       public float Costo { get; set; }
       public float Precio { get; set; }
       public float Existencia { get; set; }
       public int IdSuplidor { get; set; }
       public int IdCategoria { get; set; }
    

       public Articulos()
       {
           this.IdArticulo = 0;
           this.Descripcion = string.Empty;
           this.Costo = 0.00f;
           this.Precio = 0.00f;
           this.Existencia = 0.00f;
           this.IdSuplidor = 0;
           this.IdCategoria = 0;

       }


       public Boolean Insertar()
       {
           this.IdArticulo = 0;

           this.IdArticulo = Convert.ToInt32(Conexion.ObtenerValorDb("Insert into Articulos (Descripcion, Costo, Precio, Existencia, IdSuplidor, IdCategoria) values ('" + this.Descripcion + "', " + this.Costo + ", " + this.Precio +  "," + this.Existencia +  "," + this.IdSuplidor +  ", " +this.IdCategoria+") Select @@Identity"));

           return this.IdArticulo > 0;

       }


       public Boolean Modificar() 
       {
           bool paso1 = false;
           paso1 = Conexion.EjecutarDB("Update Articulos set Precio = " + this.Precio + ", Descripcion = '" + this.Descripcion + "', Costo = "+this.Costo+", Existencia = "+this.Existencia+", IdSuplidor = "+this.IdSuplidor+" Where IdArticulo = " + this.IdArticulo);
           return paso1;
       }

       public Boolean Eliminar(Int32 IdBuscado)
       {
           return Conexion.EjecutarDB("Delete from Articulos where IdArticulo=" + IdBuscado);
       }

       public Boolean Buscar(Int32 IdBuscado)  
       {
           bool Encontro = false;
           DataTable dt = new DataTable();

           dt = this.Listar("*", "IdArticulo=" + IdBuscado);

           if (dt.Rows.Count > 0)
           {
               Encontro = true;

               this.IdArticulo = (int)dt.Rows[0]["IdArticulo"];
               this.Costo = (float)dt.Rows[0]["Costo"];
               this.Precio = (float)dt.Rows[0]["Precio"];
               this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
               this.Existencia = (float)dt.Rows[0]["Existencia"];
               this.IdSuplidor = (int)dt.Rows[0]["IdSuplidor"];
               this.IdCategoria = (int)dt.Rows[0]["IdCategoria"];

               return true;

           }

           return Encontro;
       }

       public DataTable Listar(string campos = "*", string Filtro = "1=1")
       {
           return Conexion.BuscarDb("Select " + campos + " from Articulos where " + Filtro);
       }

    }
}
