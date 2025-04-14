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
MenuUsuario menuModificar;
Inventario data;
InitComponent();
main();

// Ejecucion
void main()
{
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
                Console.Write("Ingrese el nombre del producto: ");
                producto.Name = Console.ReadLine();

                Console.Write("Ingrese la descripción: ");
                producto.Description = Console.ReadLine();

                Console.Write("Ingrese el precio: ");
                producto.Price = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad");
                int amount = int.Parse(Console.ReadLine());


                data.Data.Add(new Item(producto, amount));
                break;
            case 2:
                // Listar
                break;
            case 3:
                // Modificar
                Console.WriteLine(menuModificar);
                Console.WriteLine("Ingrese una opcion: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        // Buscar Producto
                        break;
                    case 2:
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
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
}

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

    menuModificar = new MenuUsuario();
    menuModificar.Cabecera = "Modificar productos";
    menuModificar.Opciones.Add(new Opcion(1, "Buscar productos por nombre"));
    menuModificar.Opciones.Add(new Opcion(0, "Salir"));


    data = new Inventario();

}

