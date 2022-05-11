// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dou");

var Condicion = "S";

while (Condicion == "S" )
{
    Console.Clear();

    Console.WriteLine("Introduze tu nombre:");
   var nombre = Console.ReadLine();
    Console.WriteLine("Hola " + nombre);

    Console.WriteLine("Quieres continuar? S/N");
    Condicion = Console.ReadLine().ToUpper();

    if (Condicion == "N")
    {
        Console.WriteLine("Programa finalizado correctamente");
      
    }
   
    else 
    {
        Console.WriteLine("Opcion no valida");
        
    }
}

