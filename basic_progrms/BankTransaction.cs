using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_progrms
{
    public class BankTransaction
    {
        private int custid;
        private long accno;
        private string accname, status;
        private decimal balance, creditamt, debitamt;
         public BankTransaction(int custid,long accno,string accname,decimal balance)
            {
            this.balance = balance;
            this.accno = accno;
            this.custid =custid;
            this.accname = accname;
            status = "InActive";
            creditamt = debitamt = 0;
        }

        public int Custid
        {
            get => custid;
            set => custid = value;
        }
        public long Accno
        {
            get => accno;
            set => accno = value;
        }
        public string Accname
        {
            get => accname;
            set => accname = value;
        }
        public string Status
        {
            get => status;
            set => status = value;
        }
        public decimal Balance
        {
            get => balance;
            set => balance = value;
        }
        public decimal Creditamt
        {
            get => creditamt;
            set => creditamt = value;
        }
        public decimal Debitamt
        {
            get => debitamt;
            set => debitamt = value;
        }

        //private void ReadCustomerDetails()
        //{
        //    Console.WriteLine("Enter Customer Id, "+"Account No, Name, Balance ");
        //    custid=Convert.ToInt32(Console.ReadLine());
        //    accno = Convert.ToInt64(Console.ReadLine());
        //    accname = Console.ReadLine();
        //    balance = Convert.ToDecimal(Console.ReadLine());

        //}
        internal decimal PerformTransaction()
        {
            //ReadCustomerDetails();
            Console.WriteLine("1. Credit 2. Debit");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice) 
            {
                case 1:
                    Console.WriteLine("Enter Credit Amount");
                    creditamt=Convert.ToDecimal(Console.ReadLine());
                    this.balance += creditamt;
                    status="Active";
                    break;
                case 2:
                    Console.WriteLine("Enter Debit Amount");
                    debitamt = Convert.ToDecimal(Console.ReadLine());
                    this.balance -= debitamt;
                    status = "Active";
                    break;
                default:
                    Console.WriteLine("Enter 1 or 2 only");
                    break;
            }
            return this.balance;
        }
        //internal void DisplayCustomerDetails()
        //{
            
        //    PerformTransaction();
        //    Console.WriteLine($"Name:{accname} \n Balance:{balance} \n status:{status} \n");

        //}
    }
}
