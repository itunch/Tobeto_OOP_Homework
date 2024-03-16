using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
        public abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate(); // calculate dinamik yapıda save ise hep aynı bu yüzde calculate abstract
        
        public virtual void Save()
        {
            Console.WriteLine("Kaydedildi");
        }
    }
}
