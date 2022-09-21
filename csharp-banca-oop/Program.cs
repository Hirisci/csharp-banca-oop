// See https://aka.ms/new-console-template for more information
using csharp_banca_oop;
using System.Diagnostics.SymbolStore;

Bank bank = new Bank("BPM");

bool status = true;
Console.WriteLine("Benvenuto");
do
{
    Thread.Sleep(1000);
    Console.Clear();
    printMenu();
    int operation = Convert.ToInt32(Console.ReadLine());
    switch (operation)
    {
        case 0:
            status = !status;
            break;
        case 1:
            //Operazioni su clienti(Modifica, Agiungi)
            printMenu1();
            int operationM1 = Convert.ToInt32(Console.ReadLine());
            switch (operationM1)
            {
                case 1:
                    //Aggiungere prestito ad un cliente
                    Console.WriteLine("test 1");
                    break;
                case 2:
                    Console.WriteLine("test 2");
                    //Aggiungere prestito ad un cliente
                    break;
                default:
                    Console.WriteLine("Azione non permessa");
                    break;
            }
            break;
        case 2:
            //Aggiungere prestito ad un cliente
            break;
        case 3:
            //Resoconto Prestiti concessi a Cliente
            break;
        case 4:
            //Resoconto Stato Prestiti del Cliente
            break;
        default:
            Console.WriteLine("Azione non permessa");
            break;

    }

} while (status);









static void printMenu()
{
    Console.WriteLine();
    Console.WriteLine("Digita numero del operazione da Eseguire");
    Console.WriteLine("1) Operazioni su clienti (Modifica, Agiungi)");
    Console.WriteLine("2) Aggiungere prestito ad un cliente");
    Console.WriteLine("3) Resoconto Prestiti concessi a Cliente");
    Console.WriteLine("4) Resoconto Stato Prestiti del Cliente");
    Console.WriteLine("0) Termina Operazioni");
    Console.WriteLine();
    Console.Write("Digita numero ");
}

static void printMenu1(){
    Console.Clear();
    Console.WriteLine("Digita numero del operazione da Eseguire");
    Console.WriteLine("1) Modifica dati clienti");
    Console.WriteLine("2) Aggiungi cliente");
    Console.WriteLine("3) Torna indietro ");
    Console.WriteLine();
    Console.Write("Digita numero ");

}

static void infoUser()
{
    string name = Console.ReadLine();
    string lastName = Console.ReadLine();
    string fiscalCode = Console.ReadLine();
    int salary = Convert.ToInt32(Console.ReadLine());
}
