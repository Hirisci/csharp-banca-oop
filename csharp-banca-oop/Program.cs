// See https://aka.ms/new-console-template for more information
using csharp_banca_oop;
using System.Diagnostics.SymbolStore;

Bank bank = new Bank("BPM");

bool status = true;
Console.WriteLine("Benvenuto");
do
{
    
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
                    bank.addUser(infoUser());
                    Console.WriteLine("Operazione avvenuta con successo");
                    break;
                case 2:
                    bank.editUser(bank.researchUser(askfiscalCodUser()), infoUser());
                    Console.WriteLine("Operazione avvenuta con successo");
                    //Aggiungere prestito ad un cliente
                    break;
                default:
                    Console.WriteLine("Azione non permessa, Torno al Menu precendete");
                    break;
            }
            break;
        case 2:
            //Aggiungere prestito ad un cliente
            Console.WriteLine("Aggingi prestito al clinente");
            string cf = askfiscalCodUser();
            Console.WriteLine(bank.Users[bank.researchUser(cf)].ToString);
            bank.addLoan(bank.researchUser(cf), askAmountLoan(), askMonthsLoan());
            Console.WriteLine("Operazione avvenuta con successo");
            break;
        case 3:
            //Resoconto Prestiti concessi a Cliente
            Console.WriteLine("Resoconti prestiti");
            cf = askfiscalCodUser();
            Console.WriteLine(bank.Users[bank.researchUser(cf)]);

            foreach (Loan loan in bank.loansClient(bank.researchUser(cf)))
            {
                Console.WriteLine(loan);
            }
            break;
        case 4:
            //Resoconto Stato Prestiti del Cliente
            cf = askfiscalCodUser();
            Console.WriteLine(bank.Users[bank.researchUser(cf)]);
            bank.remaningLoan(cf);
            break;
        default:
            Console.WriteLine("Azione non permessa");
            break;

    }
    Console.WriteLine("Premi invio per continuare");
    Console.ReadLine();
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
    Console.WriteLine("1) Aggiungi cliente");
    Console.WriteLine("2) Modifica dati clienti");
    Console.WriteLine("3) Torna indietro ");
    Console.WriteLine();
    Console.Write("Digita numero ");

}

static User infoUser()
{
    Console.Write("Inserisci Nome Cliente: ");
    string name = Console.ReadLine();
    Console.Write("Inserisci Cognome Cliente: ");
    string lastName = Console.ReadLine();
    Console.Write("Inserisci Codice fiscale Cliente: ");
    string fiscalCode = Console.ReadLine();
    Console.Write("Inserisci Salario Cliente: ");
    int salary = Convert.ToInt32(Console.ReadLine());
    return new User(name, lastName, fiscalCode, salary);
}

static string askfiscalCodUser()
{
    Console.Write("Inserisci Codice fiscale del Cliente: ");
    return Console.ReadLine();
}

static int askAmountLoan()
{
    Console.Write("Inserisci Somma Prestito: ");
    return Convert.ToInt32(Console.ReadLine());
}

static int askMonthsLoan()
{
    Console.Write("Inserisci Somma Prestito: ");
    return Convert.ToInt32(Console.ReadLine());
}

