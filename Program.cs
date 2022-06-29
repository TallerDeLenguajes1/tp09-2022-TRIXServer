using System.Text.Json;

System.Console.Clear();

string nombreArchivo = "productos.json";
var random = new Random();
var listaProductos = new List<producto>();
int cantidad = random.Next(1,16);
var functions = new functions();

System.Console.WriteLine($"--\tProductos");
System.Console.WriteLine("--");
System.Console.WriteLine($"Cantidad de productos: \t{cantidad}");
System.Console.WriteLine("--");

functions.crearListaProductos(listaProductos, cantidad);

string listaProductosSerializada = functions.serializar(listaProductos);

functions.escribirArchivo(nombreArchivo, listaProductosSerializada);

string contenidoArchivo = File.ReadAllText(nombreArchivo);

var datosDeserializados = JsonSerializer.Deserialize<List<producto>>(contenidoArchivo);

functions.mostrarProductos(datosDeserializados);

