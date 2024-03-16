using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    public class CustomerManager 
    {
        private Customer _customer;
        private ICreditManager _creditManager;

        public CustomerManager(Customer customer, ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;

        }
        public void Save()
        {
            Console.WriteLine("Kaydedildi.");
        }
        public void Delete()
        {
            Console.WriteLine("Müşteri silindi.");
        }
        public void GiveCredit()
        {
            _creditManager.Calculate();

            Console.WriteLine("Kredi onaylandı.");
        }
    }
}
