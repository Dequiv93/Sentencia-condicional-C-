using System;

class program

{
    static void Main (string [] args)
    {
        Console.WriteLine ("Welcome to the grade convertor EEUU");
    
        Console.WriteLine ("Now please enter the grade in order to convert it");

        string input = Console.ReadLine();

        int grade = int.Parse(input);

        if (grade <= 100 && grade >= 0)

        {
            if (grade <= 100 && grade > 92)
            {Console.WriteLine ("A+");}
            else if (grade <= 92 && grade > 89)
            {Console.WriteLine ("A");}
            else if (grade <= 89 && grade > 86)
            {Console.WriteLine ("B+");}
            else if (grade <= 86 && grade > 82)
            {Console.WriteLine ("B");}
            else if (grade <= 82 && grade > 79)
            {Console.WriteLine ("B-");}
            else if (grade <= 79 && grade > 76)
            {Console.WriteLine ("C+");}
            else if (grade <= 76 && grade > 72)
            {Console.WriteLine ("C");}
            else if (grade <= 72 && grade > 69)
            {Console.WriteLine ("C-");}
            else if (grade <= 69 && grade > 66)
            {Console.WriteLine ("D+");}
            else if (grade <= 66 && grade > 62)
            {Console.WriteLine ("D");}
            else if (grade <= 62 && grade > 59)
            {Console.WriteLine ("D-");}
            else {Console.WriteLine("F");}

        }

        else 

        {Console.WriteLine ("ERROR IT'S NOT A VALID NUMBER");}


    








    }

}







