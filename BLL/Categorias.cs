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
    public class Categorias
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

    public Categorias()
        {
            this.IdCategoria = 0;
            this.Nombre = string.Empty;
        }

        // 
    public Boolean Insertar()
        {

        this.IdCategoria = 0;

        this.IdCategoria = Convert.ToInt32(Conexion.ObtenerValorDb("Insert into Categorias (Nombre) values ('" + this.Nombre + "') Select @@Identity"));

        return this.IdCategoria > 0;

        }

    public Boolean Modificar()  
        {

        bool paso1 = false;

        paso1 = Conexion.EjecutarDB("Update Categorias set Nombre = '" + this.Nombre + "' Where IdCategoria = " + this.IdCategoria);

        return paso1;

         }

    public Boolean Eliminar(Int32 IdBuscado)
    {
        return Conexion.EjecutarDB("Delete from Categorias where IdCategoria=" + IdBuscado);
    }


    public Boolean Buscar(Int32 IdBuscado)
    {
        bool Encontro = false;
        DataTable dt = new DataTable();

        dt = this.Listar("Nombre", "IdCategoria=" + IdBuscado);

        if (dt.Rows.Count > 0)
        {
            Encontro = true;

            this.IdCategoria = (int)dt.Rows[0]["Id Categoria"];
            this.Nombre = dt.Rows[0]["Nombre"].ToString();

            return true;

        }

        return Encontro;
    }

    public DataTable Listar(string campos = "*", string Filtro = "1=1")
    {
        return Conexion.BuscarDb("Select " + campos + " from Categorias where " + Filtro);
    }

    }
}
