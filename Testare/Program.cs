//1. Write a program that reads from the console three numbers of type int and prints their sum.
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;
            Console.WriteLine("First number: ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number: ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Third number: ");
            third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Suma numerelor este: {0}", first + second + third);
        }
    }
}


//2. Write a program that reads five numbers from the console and prints the greatest of them.
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Numarul {0}", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cel mai mare numar este: {0}", MaxNumber(array));
        }

        public static int MaxNumber(int[] numere)
        {
            int maxim;
            maxim = numere[0];

            for (int i = 1; i < numere.Length; i++)
            {
                if (numere[i] > maxim)
                {
                    maxim = numere[i];
                }
            }

            return maxim;
        }
    }
}

//3. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double perimetru, aria;

            Console.WriteLine("Raza cercului = ");
            radius = Convert.ToInt32(Console.ReadLine());

            perimetru = 2 * Math.PI * radius;
            Console.WriteLine("Perimetrul cercului = 2*π*{0} = {1}", radius, perimetru);

            aria = Math.PI * radius * radius;
            Console.WriteLine("Aria cercului = π*{0}*{0} = {1}", radius, aria);
        }

    }
}

/*4. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5. 
 * such that the remainder of their division by 5 is 0.
 * Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25.
 * */
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, contor;

            Console.WriteLine("First number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            contor = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    contor++;
                }
            }

            Console.WriteLine($"In the range ({firstNumber}, {secondNumber}) there are {contor} numbers that are divisible with 5.");
        }

    }
}

/*5. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and 
 * with conditional statements.*/
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            bool maxim;

            Console.WriteLine("First number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            //without using conditional statements
            Console.WriteLine("Greater number is: {0}", firstNumber > secondNumber ? firstNumber : secondNumber);

            //with conditional statements
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Greater number is: {0}", firstNumber);
            }
            else
            {
                Console.WriteLine("Greater number is: {0}", secondNumber);
            }

        }

    }
}

/*6. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter 
 * another number(only once)*/
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            string citesteNumarul;
            int numar;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduceti numar {0}", i + 1);
                citesteNumarul = Console.ReadLine();

                if (!int.TryParse(citesteNumarul, out numar))
                {
                    Console.WriteLine("Invalid. Introduceti din nou numarul {0}", i + 1);
                    citesteNumarul = Console.ReadLine();
                }

                if (int.TryParse(citesteNumarul, out numar))
                {
                    suma = suma + numar;
                }
            }

            Console.WriteLine("Suma este {0}", suma);

        }

    }
}

//7. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("N = ");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }

        }

    }
}

//8. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read
//from the standard input.
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("N = ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numere care nu sunt divizibile cu 3 si 7 simultan:");

            for (int i = 1; i <= N; i++)
            {
                if (!(i % 21 == 0))
                {
                    Console.WriteLine(i);
                }
            }

        }

    }
}

//9. Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Introduceti numarul {0}", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(array);

            Console.WriteLine("Cel mai mic numar = {0}", array[0]);
            Console.WriteLine("Cel mai mare numar = {0}", array[array.Length - 1]);

        }

    }
}

/*10. Write program that outputs a triangle made of stars with variable size, depending on an input parameter. Look at the examples to get an idea.
The input comes as a string number, which needs to be parsed to a number. The output is a series of lines printed on the console, forming a triangle
of variable size.

Input 2:   
Output:
*
**
*
*/
using System;
using System.Text;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            string numarText;

            Console.WriteLine("Numar = ");
            numarText = Console.ReadLine();

            int.TryParse(numarText, out int numar);

            Console.WriteLine(PrintStars(numar));

        }

        public static string PrintStars(int numar)
        {
            string textStelute;
            StringBuilder auxiliar = new StringBuilder();
            int contor = 0;

            while (contor < numar)
            {
                for (int i = 0; i <= contor; i++)
                {
                    auxiliar = auxiliar.Append("*");
                }

                auxiliar = auxiliar.Append("\n");
                contor++;
            }

            while (contor > 0)
            {
                for (int i = 0; i < contor - 1; i++)
                {
                    auxiliar = auxiliar.Append("*");
                }

                auxiliar = auxiliar.Append("\n");
                contor--;
            }
            textStelute = Convert.ToString(auxiliar);

            return textStelute;
        }
    }
}


//11 * .Write a program that converts a given number from decimal to binary notation (numeral system).
using System;
using System.Text;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar;
            StringBuilder conversie = new StringBuilder();

            Console.WriteLine("Numar pentru conversie: ");
            numar = Convert.ToInt32(Console.ReadLine());

            while (numar != 0)
            {
                conversie = conversie.Append(numar % 2);
                numar = numar / 2;
            }

            Console.WriteLine("Numarul {0} se scrie {1} in baza 2:", numar, Convert.ToString(conversie));

        }

    }
}

//12 *.Write a program that by a given integer N prints the numbers from 1 to N in random order
using System;
using System.Linq;
using System.Text;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar, numarRandom, auxiliara, i;
            var rand = new Random();

            Console.WriteLine("Numar = ");
            numar = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[numar];

            for (i = 1; i <= numar; i++)
            {
                array[i - 1] = i;
            }

            foreach (int index in array)
            {
                numarRandom = rand.Next(0, numar - 1);
                auxiliara = array[index - 1];
                array[index - 1] = array[numarRandom];
                array[numarRandom] = auxiliara;
            }

            Console.WriteLine("Randomizare:");
            for (i = 0; i < numar; i++)
            {
                Console.WriteLine(array[i]);
            }


        }

    }
}

/*13 *. A program which iterates the integers from 1 to 50 For multiples of three print "Fizz" instead of the number and for the multiples of five
print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".

Output : 
fizzbuzz
1
2
fizz
4
buzz
*/
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("{0}{1}{2}", MultipluDe3(i), MultipluDe5(i), MultipluDe3(i) == "" && MultipluDe5(i) == "" ? Convert.ToString(i) : "");
            }

        }

        public static string MultipluDe3(int n)
        {
            return n % 3 == 0 ? "Fizz" : "";
        }

        public static string MultipluDe5(int n)
        {
            return n % 5 == 0 ? "Buzz" : "";
        }
    }
}

/* 14 A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. 
Write a program that reads information about the company and its manager and then prints it on the console.*/
using System;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            //A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number.Write a program that reads information about the company and its manager and then prints it on the console.

            string companyName, companyAddress, companyPhone, companyFax, companyWebSite, managerName, managerSurname, managerPhone;

            Console.WriteLine("Please provide the company name");
            companyName = Console.ReadLine();

            Console.WriteLine("Please provide the company address");
            companyAddress = Console.ReadLine();

            Console.WriteLine("Please provide the company phone number");
            companyPhone = Console.ReadLine();

            Console.WriteLine("Please provide the company fax number");
            companyFax = Console.ReadLine();

            Console.WriteLine("Please provide the company web site");
            companyWebSite = Console.ReadLine();

            Console.WriteLine("Please provide the name of the manager");
            managerName = Console.ReadLine();

            Console.WriteLine("Please provide the surname of the manager");
            managerSurname = Console.ReadLine();

            Console.WriteLine("Please provide the phone number of the manager");
            managerPhone = Console.ReadLine();

            Console.WriteLine("Company name: {0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Phone number: {0}", companyPhone);
            Console.WriteLine("Fax number: {0}", companyFax);
            Console.WriteLine("Web site: {0}", companyWebSite);
            Console.WriteLine("Manager name: {0} {1}", managerName, managerSurname);
            Console.WriteLine("Manager Phone number: {0}", managerPhone);

        }

    }
}