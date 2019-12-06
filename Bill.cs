using System.Collections.Generic;

namespace HW5
{
    class Bill
    {
        public string billDate;
        public string description;
        public double amount;
        List<Payment> paymentList = new List<Payment>();
        public Bill(string billDate, string description, double amount)
        {
            this.billDate = billDate;
            this.description = description;
            this.amount = amount;
        }

        public string getBillInfo()
        {
            string info = $"Date: {billDate}\nDescription: {description}\nAmount Due: {(amount.ToString("C0"))}"; 

            foreach (var p in paymentList)
            {
                info += $"\n On {p.getPaymentDate()} payment with {p.getPaymentType()} the amount {p.getAmount().ToString("C0")} was processed";
            }
            info += $"\n Total payed : {GetAmount()}\n Remaining Balance: {getBalance()}";
            return info;
        }

        public double getBalance()
        {
            double Total = 0;
            foreach (var m in paymentList)
            {
                Total = Total + m.getAmount();
            }
            return amount - GetAmount();
        }

        public double GetAmount()
        {
            double Total = 0;
            foreach(var a in paymentList)
            {
                Total = Total + a.getAmount();
            }
            return Total;
        }

        public bool addPayment(Payment b)
        {
            if (b.verify() == true)
            {
                paymentList.Add(b);
                return true;
            }
            return false; 
        }
    }
}