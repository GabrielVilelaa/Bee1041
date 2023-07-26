using System;
using System.Globalization;
class bee1041
{

    static void Main(string[] args)
    {

        float x, y;
        string[] vet = (Console.ReadLine().Split(' '));
        x = float.Parse(vet[0], (CultureInfo.InvariantCulture));
        y = float.Parse(vet[1], (CultureInfo.InvariantCulture));

        if (x == 0.0 && y == 0.0)
        {
            Console.WriteLine("Origem");
        }
        else if (x == 0)
        {
            Console.WriteLine("Eixo Y");

        }
         else if  (y == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x > 0.1 &&  y < -0.1  )  
        {
            Console.WriteLine("Q4");
        }
        else if (x > 0.1 && y > 0.1)
        {
            Console.WriteLine("Q1");

        } 
       else if (x < -0.1  && y > 0.1 )
        {
            Console.WriteLine("Q2");

        }
        else if (x < -0.1 &&  y < -0.1 )
        {
            Console.WriteLine("Q3");
        }
    }

}

