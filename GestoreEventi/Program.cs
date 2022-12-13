// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using GestoreEventi.CustomException;

List<Evento> eventi = new List<Evento>();


/*
Console.WriteLine("Titolo evento:");
Console.ReadLine();
Console.WriteLine("Data evento:");
Console.ReadLine();
Console.WriteLine("Capienza massima:");
Console.ReadLine();
Console.WriteLine("Posti prenotati:");
Console.ReadLine(); 
*/



try
{
    Evento eventoinserito = new Evento("Conferenza sul clima", "12/20/2022", 150);
    Console.WriteLine(eventoinserito.ToString());
    eventoinserito.PrenotaPosti(20);
    Console.WriteLine(eventoinserito.ToString());
    eventoinserito.DisdiciPosti(40);
    Console.WriteLine(eventoinserito.ToString());

}
catch(ResultCannotBeNegativeException e)
{
    Console.WriteLine(e.Message);
}
catch(ArgumentNullException e)
{
    Console.WriteLine(e.Message);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

