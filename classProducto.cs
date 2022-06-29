using System.Text.Json;
class producto
{
    private string nombre;
    private DateOnly fechaVencimiento;
    private float precio;
    private string tamanio;

    public producto()
    {
        var random = new Random();
        var nombres = new string[]
        {
            "Queso",
            "Jamon",
            "Salsa",
            "Galletas",
            "Caramelos",
            "Fideos",
            "Desodorante",
            "Gaseosa"
        };
        var tamanios = new string[]
        {
            "Chico",
            "Mediano",
            "Grande"
        };

        nombre = nombres[random.Next(nombres.Length)];
        fechaVencimiento = new DateOnly(random.Next(2022, 2033), random.Next(1, 13), random.Next(1, 29));
        precio = random.Next(1000, 5001);
        tamanio = tamanios[random.Next(tamanios.Length)];

    }
    
    public string Nombre { get => nombre; set => nombre = value; }
    public DateOnly FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    public float Precio { get => precio; set => precio = value; }
    public string Tamanio { get => tamanio; set => tamanio = value; }
}

class functions
{
    public static void mostrarProductos(List<producto> dataListaProductos)
    {
        
    }

    public static void escribirArchivo(string dataNombreArchivo, string dataListaProductosSerializada)
    {
        var archivoWrite = new StreamWriter(File.Open(dataNombreArchivo, FileMode.Create));
        archivoWrite.WriteLine(dataListaProductosSerializada);
        archivoWrite.Close();

    }

    public static string serializar(List<producto> dataListaProductos)
    {
        string listaProductosSerializada = JsonSerializer.Serialize(dataListaProductos);
        return listaProductosSerializada;

    }

    public static void crearListaProductos(List<producto> dataListaProductos, int dataCantidad)
    {
        for (int i = 0; i < dataCantidad; i++)
        {
            var producto = new producto();
            dataListaProductos.Add(producto);

        }
    }
}