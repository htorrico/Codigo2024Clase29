
using Negocio;
using Entidad;




void GrabarComputo()
{

    NCabecera nCabecera = new NCabecera();

    ECabecera eCabecera = new ECabecera
    {
        Cliente = "Juan Torrico",
        Fecha = DateTime.Now
    };

    List<EDetalle> eDetalles = new List<EDetalle>();
    eDetalles.Add(new EDetalle { Cantidad = 1, Precio = 3000, Producto = "PC" });
    eDetalles.Add(new EDetalle { Cantidad = 2, Precio = 2000, Producto = "TV" });
    eDetalles.Add(new EDetalle { Cantidad = 4, Precio = 1000, Producto = "Equipo" });

    try
    {
        nCabecera.Grabar(eCabecera, eDetalles);
        Console.WriteLine("Registro exitosamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        
    }
   




}


void GrabarFerreteria()
{

}

void GrabarMercado()
{

}

GrabarComputo();
Console.Read();

