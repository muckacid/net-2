/* DOCUMENTACION
 * Requerimientos
    CRUD: producto
 */

// Referencias

// Definiciones de variables y configuraciones
using net2.DB;
using net2.Model;
using net2.PModel;

MenuUsuario menu;
Productos data;
InitComponent();

// Ejecucion
string opcion;
bool run = true;
do
{
    Console.WriteLine(menu);
    Console.Write("Ingrese una opcion: ");
    opcion = Console.ReadLine();
    int opcionInt = int.Parse(opcion);

    Console.Clear();

    switch (opcionInt)
    {
        case 0:
            // Salir
            Console.WriteLine("Saliendo ....");
            run = false;
            break;
        case 1:
            // Agregar
            Producto producto = new Producto();
            Console.Write("Ingrese el nomvre del producto: ");
            producto.Name = Console.ReadLine();

            Console.Write("Ingrese la descripción: ");
            producto.Description = Console.ReadLine();

            Console.Write("Ingrese el precio: ");
            producto.Price = int.Parse(Console.ReadLine());

            data.Data.Add(producto);
            break;
        case 2:
            // Listar
            foreach (Producto item in data.Data)
            {
                Console.WriteLine(item);
            }
            break;
        case 3:
            // Modificar
            break;
        case 4:
            // Eliminar
            break;
        case 5:
            // Buscar
            break;

        default:
            Console.WriteLine("La opcion ingresada no es valida!");
            break;
    }


}
while (run);

void InitComponent()
{
    menu = new MenuUsuario();
    menu.Cabecera = "Menu de Productos";
    menu.Opciones.Add(new Opcion(1, "Agregar"));
    menu.Opciones.Add(new Opcion(2, "Listar"));
    menu.Opciones.Add(new Opcion(3, "Modificar"));
    menu.Opciones.Add(new Opcion(4, "Eliminar"));
    menu.Opciones.Add(new Opcion(5, "Buscar"));
    menu.Opciones.Add(new Opcion(0, "Salir"));

    data = new Productos();

}

