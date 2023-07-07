using System;

 class demo2
{
   public  void big2Num()
    {
int num1, num2;

Console.WriteLine("Enter 2 Numbers");
num1=Convert.ToInt32(Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());


if (num1 == num2)
    Console.WriteLine("both are equal");
else if (num1 > num2)
    Console.WriteLine(num1 + " is big");

else Console.WriteLine(num2 + "is big");
    }

    public void big3Num(int num1,int num2,int num3)
    {
        /* int num1, num2, num3;

         Console.WriteLine("Enter 3 Numbers");
         num1 = Convert.ToInt32(Console.ReadLine());
         num2 = Convert.ToInt32(Console.ReadLine());
         num3 = Convert.ToInt32(Console.ReadLine());*/

        if ((num1 > num2) && (num1 > num3))
            Console.WriteLine(num1 + "num1 is big");
        else if ((num2 > num1) && (num2 > num3))
            Console.WriteLine(num2 + " is big");
        else if (num1 == num2 && num2 == num3) Console.WriteLine("all are equal");

        else Console.WriteLine(num3 + "is big");

    }
    public void check()
    {
        Console.WriteLine("s==> 2 numbers M==>3 numbers");
        String choice = (Console.ReadLine());
        switch (choice.ToLower()){
            case "S" or "A":
                //Console.WriteLine("you entered S");
                big2Num();

                break;
            case "M":
                // Console.WriteLine("you entered M");
                big3Num(2, 2, 2);
                break;
            default:
                Console.WriteLine("Enter S or M");
                break;

        }
    }
    public int while_loop()
    {
        int max,sum=0,cou=1;
        Console.WriteLine("enter a max number");
        max=Convert.ToInt32(Console.ReadLine());
        while (max >= cou) 
        {
            sum = sum + cou;
            cou++;
            
        }
       return sum;
    }

    public void for_loop()
    {
        int leng;
        Console.WriteLine("Enter a length: ");
        leng =Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<leng; i++)
        {
            for(int j=0; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.WriteLine(Math.Pow(leng, 3));
    }
    public void for_each_loop(string s1)
    {
       
        foreach (char s in s1)
        {
            Console.WriteLine(s);
        }

    }

    public void arrdis()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach(int n in nums)
        {
            Console.WriteLine(n);
        }
    }
}
