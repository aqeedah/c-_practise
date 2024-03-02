using c__practise;
using System;
using System.Linq.Expressions;
using System.Numerics;

namespace C_sharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string Name = "John";
            int Age;
            Age = 35;
            char grade = 'A';
            double gpa = 3.3;
            bool isFemale = true;
            Console.WriteLine("There was a man named " + Name);
            Console.WriteLine("He was " + Age + " years old.");
            Name = "Jammy";
            Console.WriteLine("He really like the name " + Name);
            Console.WriteLine("But didn't like being " + Age);

            //String Methods
            string phrase = "String tutorial " + "learning";
            Console.WriteLine("string length is: " + phrase.Length);
            Console.WriteLine("string in upper case: " + phrase.ToUpper());
            Console.WriteLine("string in lower case: " + phrase.ToLower());
            Console.WriteLine("string is included or not? : " + phrase.Contains("learning"));//retun true or false as a result.
            Console.WriteLine("string's first character: " + phrase[0]);//print particular character of the string.
            Console.WriteLine("index of particular string: " + phrase.IndexOf("learning"));// return integer number which is index number of the string
            Console.WriteLine("index of first character occurance in string: " + phrase.IndexOf('l'));//return 14 as a result and if it not match than return -1.
            Console.WriteLine("substring of a string: " + phrase.Substring(8, 3));//return uto as substing as it starts from 8th position and continue to 3 character..3 is the length

            //Numbers 
            int num = 6;
            Console.WriteLine(4 + 5 * Age);
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);
            Console.WriteLine("absolute value: " + Math.Abs(-40));//return 40 as absolute value
            Console.WriteLine("power of number: " + Math.Pow(3.3, 2));//return power of given number
            Console.WriteLine("square root of number: " + Math.Sqrt(36));//return square root of a number
            Console.WriteLine("biggest from two numbers: " + Math.Max(4, 90));//return biggest number
            Console.WriteLine("smallest from two numbers: " + Math.Min(4, 90));//return smallest number
            Console.WriteLine("round of the decimal number: " + Math.Round(4.6));//return round of the number

            //taking input from user

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " You are " + age);

            //basic calculator

            int number = Convert.ToInt32("45");
            Console.WriteLine(number + 6);
        
            Console.WriteLine("Enter a number 1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number 2:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine("----------------------------------------------------------");


            //Excersise of wrds
            string color, pluralNoun, celebrity;

            Console.WriteLine("Enter a color :");
            color = Console.ReadLine();
            Console.WriteLine("Enter a Plural Noun :");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("Enter a celebrity :");
            celebrity = Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun +" are blue");
            Console.WriteLine("I Love " + celebrity); 

            //Array 

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };//creating an array
            string[] friends = new string[5];//creating an array after defining 
            friends[0] = "jim";
            friends[1] = "sandy";
            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);

            //calling Methods 
            SayHi("Aqeedah",25);
            SayHi("Aazam",30);
            Console.WriteLine("\n");
            int cubeNumber = cube(5);
            Console.WriteLine(cubeNumber);

            bool isFemale = true;
            bool isTall = false;

            if (isFemale && isTall)
            {
                Console.WriteLine("You are a tall Female.");
            }
            else if (isFemale && !isTall)
            {
                Console.WriteLine("You are a short Female");
            }
            else if(!isFemale && isTall)
            {
                Console.WriteLine("You are not female but you are Tall");
            }
            else
            {
                Console.WriteLine("You are not tall Male.");
            }

            Console.WriteLine(GetMax(2, 10,50)); 

            //calculator

            Console.WriteLine("Eneter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Eneter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Eneter operator: ");
            String op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if(op == "-") 
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            } 

            Console.WriteLine(GetDay(1)); 

            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5); 

            //Excersize of Guess a word

            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {   
                if(guessCount < guessLimit)
                {
                    Console.WriteLine("enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose.");
            }
            else
            {
                Console.WriteLine("You Win!");
            } 

            //for loop

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            } 

            Console.WriteLine(GetPow(3, 2)); 

            //2D array

            int[,] numberGrid = { { 1, 2},
                                  {3 , 4 },
                                  { 5, 6} };

            Console.WriteLine(numberGrid[1, 1]);

            int[,] ArrayNum = new int[2, 3]; //Another way of initializing 2D array where 2 is for rows and 3 is for column. 

            //Exception handling

            try
            {
                Console.WriteLine("Enter a number 1:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number 2:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(Exception ex)//There can be a multiple catch blocks for different exception handling
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //This block contains data which excecute every time.
            }  

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);  // Book class's  objects
            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;

            Console.WriteLine(book1.title);
            Book book2 = new Book("Lord of the Rings", "Tolkeir", 700);
            //book2.title = "Lord of the Rings";
            //book2.author = "Tolkeir";
            //book2.pages = 700;
            book2.title = "the Hobbit";


           //Console.WriteLine(book1.title);
           // Console.WriteLine(book1.author);
            //Console.WriteLine(book1.pages);

            Console.WriteLine(book2.title);  

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

           Console.WriteLine(student1.HasHonors());
           Console.WriteLine(student2.HasHonors());

            Movie avenger = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie Shrek = new Movie("Shrek", "Adam Adamsons", "PG");

            Console.WriteLine(avenger.Rating); 

            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song Kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(Song.songCount);

            //Console.WriteLine(Kashmir.getSongCount()); 

            UsefulTools.SayHi("Mike");  */

            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();
        }
        //creating method
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " You are " + age + " years old.");
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if(num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if(num2 >= num1 && num2 >= num3) 
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        } 
        static string GetDay(int daynum)
        {
            string dayName;

            switch(daynum)
            {
                case 0:
                    dayName = "Sunday"; 
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thurseday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number.";
                    break;
            }
            return dayName;
        }
        static int GetPow(int basenum, int pownum)
        {
            int result = 1;

            for(int i = 0; i < pownum; i++)
            {
                result = result * basenum;
            }
            return result;
        }
    }
}
