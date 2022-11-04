using static System.Console;
using System.IO;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = "3";
            int j = 3;

            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply");
            }

        A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random numer is {number}");

            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break; // jumps to the end of switch statement

                case 2:
                    WriteLine("two");
                    goto case 1;

                case 3:
                case 4:
                    WriteLine("three or four");
                    goto case 1;
                case 5:
                    // go to sleep for halp a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            }

            string path = "/Users/adrian/C#/C# KNIJKA/Chapter03";

            Write("Press R for readonly or W for write: ");

            ConsoleKeyInfo key = ReadKey();
            WriteLine();

            Stream s = null;

            if (key.Key == ConsoleKey.R)
            {
                s = File.Open(
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Read
                );
            }
            else
            {
                s = File.Open(
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Write
                );
            }

            string message = string.Empty;

            // switch (s)
            // {
            //     case FileStream writeableFile when s.CanWrite: // aishi as mearga case-u ista numa daca s as shie tipu de FileStream sh as aiba proprietatea CanWrite to true 
            //         message = "The stream is a file that I can write to";
            //         break;

            //     case FileStream readOnlyFile:
            //         message = "The stream is a read-only file";
            //         break;

            //     case MemoryStream ms:
            //         message = "The stream is a memory address.";
            //         break;

            //     default:
            //         message = "The stream is some other type.";
            //         break;

            //     case null:
            //         message = "The stream is null.";
            //         break;
            // }

            message = s switch
            {
                FileStream writeableFile when s.CanWrite
                => "The stream is a file that I can write to.",
                FileStream readOnlyFile
                => "The stream is a read-only file.",
                MemoryStream ms
                => "The stream is a memory address.",
                null
                => "The stream is null",
                _ // default
                => "The stream is some other type."
            };

            WriteLine(message);

        }
    }
}