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
    
        public Bank(string name)
        {
            Name = name;
            Users.Add(new User("Alan", "Bruno", "BRNLNA092EG205F", 2000));
            Users.Add(new User("Cristian", "Rossi", "RSSCRS092EG205F", 600));
            Users.Add(new User("Michele", "Bianchi", "MCHBNC092EG205F", 2500));
            Users.Add(new User("Marco", "gialli", "GLLMRC092EG205F", 950));
            Loans.Add(new Loan(Users[0],25000,36));
            Loans.Add(new Loan(Users[1],2400,24));
            Loans.Add(new Loan(Users[1],5000,36));
            Loans.Add(new Loan(Users[2],5000,36));
            Loans.Add(new Loan(Users[3],10000,24));
            Loans.Add(new Loan(Users[4],600,6));


        }


        public void addLoan(User user, int amount, int months)
        {
            Loans.Add(new Loan(user, amount, months));
        }

        public int researchUser(string fiscalCode)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].FiscalCode == fiscalCode)
                {
                    return i;
                }
            } 
           

            return -1;
        }

        public string editUser(int idxUser, string name = "null", string lastName= "null", string fiscalCode = "null", int salary = -1)
        {
            if(idxUser != -1)
            {
                Users[idxUser].Name = name == "null" ? Users[idxUser].Name : name;
                Users[idxUser].LastName = lastName == "null" ? Users[idxUser].LastName : lastName;
                Users[idxUser].FiscalCode = fiscalCode == "null" ? Users[idxUser].FiscalCode : fiscalCode;
                Users[idxUser].Salary = salary == -1 ? Users[idxUser].Salary : salary;
                return $"Campi utente modificato con successo";
            }
            else
            {
                return $"Utente non presente nel Archivio";
            }
        }

        public List<Loan> showLoansClient(int idxUser)
        {
            List<Loan> loans = new List<Loan>();
            if(idxUser != -1)
            {
                foreach (Loan loan in Loans)
                {
                    if (User.equalsUser(loan.Contractor, Users[idxUser]))
                    {
                    loans.Add(loan) ;
                    }
                }
                return loans;
            }
            else
            {
                return loans;
            }
        }

        







    }
    

    //effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
    //sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
    //sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
}
