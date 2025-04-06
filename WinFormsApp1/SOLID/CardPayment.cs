using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPayment.SOLID
{
    public class CardPayment : IPaymentMethod
    {
        public string process(string amount)
        {
            return amount + " TL kart ile ödendi.";
        }
    }
}
