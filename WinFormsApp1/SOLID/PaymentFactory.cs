using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsPayment.SOLID
{
    public class PaymentFactory
    {
       

        public IPaymentMethod createNewPayment(string className)
        {
            //CashPayment dbLogIyi = new CashPayment();
            var newObject = System.Reflection.Assembly.GetAssembly(typeof(IPaymentMethod)).CreateInstance("WinFormsPayment.SOLID." + className);

            return (IPaymentMethod)newObject;
        }
    }
}
