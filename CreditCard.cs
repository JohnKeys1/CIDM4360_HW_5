using System;
namespace HW5
{
    class CreditCard:Payment
    {
         public string CCNum;
        public string expDate;
        public string CHolderName;
        public string CType;
    
        public  CreditCard(double amount, string paymentDate, string CCNum, string expDate,string CHolderName,string CType):base(amount,paymentDate)
        {
            this.CCNum=CCNum;
            this.expDate=expDate;
            this.CHolderName=CHolderName;
            this.CType=CType;
            this.amount=amount;
            this.paymentDate=paymentDate;
        }

        public override bool verify()
        {
            Console.WriteLine("\t Credit card verified ...");
            return true;
        }
        public override string getPaymentType()
        {
            return "CreditCard";
        }
        
    }
}