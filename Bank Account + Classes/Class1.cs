using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account___Classes
{
    class BankAccount
    {
        // Otra forma de hacerlo 
        // public string Number     {Get;}
        // public string Owner      {Get;Set;}
        // public decimal Balance   {Get;}

        string  vNumber  = "";
        string  vOwner   = "";
        decimal vBalance = 0;




        /*
         Cuando en el Get/Set de las propiedades uso la misma variable que use para declararlas, por ejemplo get {return Number}, le estoy diciendo
        al compilador "usa Number para guardar y setear", lo que da un error de stack overflow, por lo que cuando no estoy usando azucar sintactica
        (public string Number {Get;Set;} ) y creo una version explicita de la propiedad cada get y set necesita su propia variable o espacio de memoria
        para hacer sus oepraciones. 

        
         https://en.wikipedia.org/wiki/Stack_overflow
         
        ** Investigar mas sobre el concepto de Stack overflow 

         */


        public string Number
        {            
            get { return vNumber; } 
        }

        public string Owner
        {
            get { 
                    return this.Owner; 
                }

            set {   
                    this.Owner = value; 
                }       
        
        }

        public decimal Balance
        {

            get { 
                    return vBalance; 
                }

            set { 
                    vBalance = value; 
                }
        
        }

        public BankAccount( string pName, decimal pInitialBalance)
        {
            this.Owner   = pName;                   // this en este caso no es mandatorio
            this.Balance = pInitialBalance;
        }


        public void MakeDeposit(decimal Amount, DateTime date, string Note)
        { 
        
        }


        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        { 
        
        }

    }
}
