using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Currency
{
    public class Transaction
    {
        // Making it private readonly allows its info insde the class, but we can only set it at the time of construction
        private readonly ICurrency _currency;

        public Transaction(ICurrency currency)
        {
            _currency = currency;

            DateOfTransaction = DateTimeOffset.Now;
        }

        public DateTimeOffset DateOfTransaction { get; private set; }
        //accesor //return // name (Parameters)
        public decimal GetTransactionAmount()
        {
            //Acessing the object being held in the readonly _currency field, getting into its properties
            return _currency.Value;
        }

        public string GetTransactionType()
        {
            return _currency.Name;
        }
    }
}
