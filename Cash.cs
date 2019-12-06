namespace HW5
{
    class Cash:Payment
    {
        
        public double tenderCash;
        public double change;

        public Cash(double amount, string paymentDate,double tenderCash):base(amount,paymentDate)
        {
            this.tenderCash=tenderCash;
            this.amount=amount;
        }

        public double calcChange()
        {
            change = tenderCash - getAmount();
            return change;
        }

        public override string getPaymentType()
        {
            return "Cash";
        }
        
    }
}