// See https://aka.ms/new-console-template for more information
using GestoreEventi;

List<Evento> eventi = new List<Evento>();
Evento eventoinserito = new Evento("Conferenza sul clima", "20/12/22", 150, 120);

Console.WriteLine(eventoinserito.ToString());

eventoinserito.PrenotaPosti(20);
Console.WriteLine(eventoinserito.ToString());
