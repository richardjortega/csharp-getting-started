using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // hello world example //
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("tutorial: Hello, World!");
            Console.WriteLine("--------");
            
            Console.WriteLine("Hello World!");

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("tutorial: variables");
            Console.WriteLine("--------");
            
            string aFriend = "Bill";
            // Console.WriteLine(aFriend);
            // Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}"); // string interpolation

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("tutorial: work with strings");
            Console.WriteLine("--------");
            
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
        
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("tutorial: do more with strings");
            Console.WriteLine("--------");

            // do more with strings //
            string greeting = "     Hello World!      ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"TrimStart() --- [{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"TrimEnd()   --- [{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"Trim()     ---- [{trimmedGreeting}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());
            
            // search strings //
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("tutorial: search strings");
            Console.WriteLine("--------");

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("tutorial: complete challenge");
            Console.WriteLine("--------");

            string songLyrics2 = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics2.StartsWith("You"));
            Console.WriteLine(songLyrics2.StartsWith("goodbye"));
            Console.WriteLine(songLyrics2.EndsWith("hello"));
            Console.WriteLine(songLyrics2.EndsWith("goodbye"));


        }
    }
}
