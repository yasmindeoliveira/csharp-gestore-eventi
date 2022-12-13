// See https://aka.ms/new-console-template for more information
using GestoreEventi;
using GestoreEventi.CustomException;

Evento eventoinserito = new Evento("Conferenza sul clima", "12/20/2022", 150);
Console.WriteLine(eventoinserito.ToString());
eventoinserito.PrenotaPosti(120);
Console.WriteLine(eventoinserito.ToString());
eventoinserito.DisdiciPosti(10);
Console.WriteLine(eventoinserito.ToString());


Console.WriteLine("Inserisci il nome dell'evento:");
string titoloUtente = Console.ReadLine();
Console.WriteLine("Inserisci la data dell'evento (MM/dd/yyyy):");
string dataUtente = Console.ReadLine();
Console.WriteLine("Inserisci il numero di posti totali:");
int postiUtente = int.Parse(Console.ReadLine());


Evento eventoUtente = new Evento(titoloUtente, dataUtente, postiUtente);


Console.WriteLine("Quanti posti desideri prenotare?");
int quantitaPostiUtente = int.Parse(Console.ReadLine());
eventoUtente.PrenotaPosti(quantitaPostiUtente);

int postiDisponibili = eventoUtente.GetMaxPosti() - eventoUtente.GetPostiPrenotati();
Console.WriteLine("I posti disponibili sono: " + postiDisponibili);
Console.WriteLine("I posti prenotati sono: " + eventoUtente.GetPostiPrenotati());

Console.WriteLine("Vuoi disdire dei posti? (si/no)?");
string check = Console.ReadLine();
while(check == "si")
{
    Console.WriteLine("Indica il numero di posti da disdire:");
    int numeriPostiDisdetta = int.Parse(Console.ReadLine());
    eventoUtente.DisdiciPosti(numeriPostiDisdetta);

    postiDisponibili = eventoUtente.GetMaxPosti() - eventoUtente.GetPostiPrenotati();
    Console.WriteLine("I posti disponibili sono: " + postiDisponibili);
    Console.WriteLine("I posti prenotati sono: " + eventoUtente.GetPostiPrenotati());

    Console.WriteLine("Vuoi disdire altri posti? (si/no)?");
    check = Console.ReadLine();
}





















/*
try
{
    Evento eventoinserito = new Evento("Conferenza sul clima", "12/20/2022", 150);
    Console.WriteLine(eventoinserito.ToString());
    eventoinserito.PrenotaPosti(120);
    Console.WriteLine(eventoinserito.ToString());
    eventoinserito.DisdiciPosti(10);
    Console.WriteLine(eventoinserito.ToString());

    Console.WriteLine("Inserisci il nome dell'evento:");
    Console.ReadLine();
    Console.WriteLine("Inserisci la data dell'evento (MM/dd/yyyy):");
    Console.ReadLine();
    Console.WriteLine("Inserisci il numero di posti totali:");
    Console.ReadLine();
    
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
*/
