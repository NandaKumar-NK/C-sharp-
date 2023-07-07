using CODE_FIRST.Models;

namespace CODE_FIRST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StdContext stdctx = new StdContext();
            Std std = new Std();
            std.stdName = "bala";
            std.stddept = "mca";
            //stdctx.stds.Add(std);
            //stdctx.SaveChanges();


            var udate = stdctx.stds.FirstOrDefault(x => x.stdName == "Balu");
            stdctx.stds.Remove(udate);
            //udate.stdName = "Balu";
            //stdctx.stds.Update(udate);
            stdctx.SaveChanges();
            



            var tb=stdctx.stds.ToList();
            foreach(var i in tb)
            {
                Console.WriteLine(i.stdName+" "+i.stddept+" "+i.stdRoll);
            }
            


        }
    }
}