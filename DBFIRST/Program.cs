using DBFIRST.Models;

namespace DBFIRST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrainTicketBookingContext ctx= new TrainTicketBookingContext();
            var tbl=ctx.PassangerDetails.ToList();
            foreach(var i in tbl)
            {
                Console.WriteLine(value: $"{i.PassangerName} {i.MobileNo}");
            }
          /*  PassangerDetail pas = new PassangerDetail()
            {
                PassangerName="Something",
                MobileNo=8909876789
            };
            ctx.PassangerDetails.Add( pas );
            ctx.SaveChanges();*/

            PassangerDetail ps1 = ctx.PassangerDetails.First(x=>x.PassangerName=="Modified");
           // ps1.PassangerName = "Modified";
           ctx.PassangerDetails.Remove(ps1);
            ctx.SaveChanges();

        }
    }
}