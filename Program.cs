using System;

class Programe{
    static void Main(string[] args ){
        int answer;
        Console.WriteLine("Please input a number of station: ");
        answer = int.Parse(Console.ReadLine());
        
           if (answer == 1)
           {
            Console.WriteLine("Cost (THB) : 16");
           }
        if (answer == 2 )
        {
            Console.WriteLine("Cost (THB): 23");
        }
        if (answer == 3 )
        {
            Console.WriteLine("Cost (THB): 26");
        }
        if (answer == 4 )
        {
            Console.WriteLine("Cost (THB): 30");
        }
        if (answer == 5 )
        {
            Console.WriteLine("Cost (THB): 33");
        }
        if (answer == 6 )
        {
            Console.WriteLine("Cost (THB): 37");
        }
        if (answer == 7 )
        {
            Console.WriteLine("Cost (THB): 40");
        }
         if ((answer >= 8 )&& (answer <= 15))
        {
            Console.WriteLine("Cost (THB): 40");
        }
        if(answer > 15)
        {
            Console.WriteLine("Cost (THB): 59");
        }



    }

}
