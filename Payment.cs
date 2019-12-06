using System;
namespace HW5
{
    abstract class Payment
    {
        public double amount;
        public string paymentDate;
        public Payment(double amount, string paymentDate)
        {
            this.amount = amount;
            this.paymentDate = paymentDate;
        }
        public double getAmount(){
             return this.amount;
        }
         public string getPaymentDate(){
                return this.paymentDate;
        }
         public abstract string getPaymentType();
        
         public virtual bool  verify(){
              Console.WriteLine("\t Payment verified ...");
             
            return true;
        }
        
    }
}