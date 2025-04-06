using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsPayment.SOLID
{
    public class PaymentProcessor
    {
        public IPaymentMethod paymentMethod;

        //Constructor Injection
        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public string ProcessPayment(string amount)
        {
           return paymentMethod.process(amount);
        }
    }
}
