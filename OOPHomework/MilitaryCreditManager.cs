using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    public class MilitaryCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker kredisi hesaplandı.");
        }

        //public void Save()  basecreditmanager geldikten sonra gereksiz
        //{
        //    throw new NotImplementedException();
        //}
    }
}
