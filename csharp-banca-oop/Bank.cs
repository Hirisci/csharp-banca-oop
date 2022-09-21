using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class Bank
    {
        public string Name { get; set; }
        List<User> Users = new List<User>();
        List<Loan> Loans = new List<Loan>();
    }

    //aggiungere un prestito.
    //aggiungere, modificare e ricercare un cliente.
    //effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
    //sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
    //sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
}
