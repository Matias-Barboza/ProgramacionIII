using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        DataTable dtEditorial = new DataTable();
        DataTable dtLibros = new DataTable();

        //Definicion de esquema de DataTable dtEditorial
        DataColumn dcCodigoEditorial = new DataColumn();
        dcCodigoEditorial.ColumnName = "Codigo Editorial";
        dcCodigoEditorial.AutoIncrement = true;
        dcCodigoEditorial.ReadOnly = true;
        dcCodigoEditorial.AllowDBNull = false;
        dcCodigoEditorial.AutoIncrementSeed = 1;
        dcCodigoEditorial.AutoIncrementStep = 1;
        dcCodigoEditorial.Unique = true;
        dcCodigoEditorial.DataType = typeof(int);

        DataColumn dcDireccion = new DataColumn();
        dcDireccion.ColumnName = "Direccion";
        dcDireccion.AllowDBNull = true;
        dcDireccion.DataType = typeof(String);

        DataColumn dcTelefono = new DataColumn();
        dcTelefono.ColumnName = "Telefono";
        dcTelefono.AllowDBNull = true;
        dcTelefono.DataType = typeof(String);

        DataColumn dcNombre = new DataColumn();
        dcNombre.ColumnName = "Nombre";
        dcNombre.AllowDBNull = true;
        dcNombre.DataType = typeof(String);

        dtEditorial.Columns.Add(dcCodigoEditorial);
        dtEditorial.Columns.Add(dcDireccion);
        dtEditorial.Columns.Add(dcTelefono);
        dtEditorial.Columns.Add(dcNombre);

        //Instacia de una DataRow siguiendo el esquema de la DataTable dtEditorial
        DataRow dr1 = dtEditorial.NewRow();

        dr1[1] = "Don Bosco 414";
        dr1[2] = "3624443567";
        dr1[3] = "HarperCollins";

        //Definicion de esquema de DataTable dtLibros
        DataColumn dcISBN = new DataColumn();
        dcISBN.ColumnName = "ISBN";
        dcISBN.AutoIncrement = true;
        dcISBN.ReadOnly = true;
        dcISBN.AllowDBNull = false;
        dcISBN.AutoIncrementSeed = 1;
        dcISBN.AutoIncrementStep = 1;
        dcISBN.Unique = true;
        dcISBN.DataType = typeof(int);

        DataColumn dcTitulo = new DataColumn();
        dcTitulo.ColumnName = "Titulo";
        dcTitulo.AllowDBNull = true;
        dcTitulo.DataType = typeof(String);

        DataColumn dcAutor = new DataColumn();
        dcAutor.ColumnName = "Autor";
        dcAutor.AllowDBNull = true;
        dcAutor.DataType = typeof(String);

        DataColumn dcCodigoEditorialL = new DataColumn();
        dcCodigoEditorialL.ColumnName = "Codigo Editorial";
        dcCodigoEditorialL.AllowDBNull = false;
        dcCodigoEditorialL.ReadOnly = true;
        dcCodigoEditorialL.DataType = typeof(int);

        dtLibros.Columns.Add(dcISBN);
        dtLibros.Columns.Add(dcTitulo);
        dtLibros.Columns.Add(dcAutor);
        dtLibros.Columns.Add(dcCodigoEditorialL);

        //Instacia de una DataRow siguiendo el esquema de la DataTable dtLibro
        DataRow dr2 = dtLibros.NewRow();
        dr2[1] = "El poder del perro";
        dr2[2] = "Don Winslow";
        dr2[3] = dr1[0];

        dtLibros.Rows.Add(dr2);

        DataRowCollection drcLibros = dtLibros.Rows;

        //Recorrido de una DataRowCollection
        foreach (DataRow dr in drcLibros) 
        {
            Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]} {dr[3]}");
        }
    }
}