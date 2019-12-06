using System;
namespace HW5
{
    class Check: Payment
    {public string Bank;
        public string custName;
        public string acctNum;

        public Check(double amount,string Bank, string custName, string acctNum, string paymentDate):base(amount, paymentDate)
        {
            this.Bank=Bank;
            this.custName=custName;
            this.acctNum=acctNum;
        }

        public override bool verify()
        {
            Console.WriteLine("\t Signature and balance verified ...");
            return true;
        }

        public override string getPaymentType()
        {
            return "Check";
        }
    
        
    }
}