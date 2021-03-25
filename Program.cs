using System;
using System.Linq;
using System.Text;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            var result = new StringBuilder(message);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Decode")
                {
                    break;
                }

                string[] token = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string instruction = token[0];
                switch (instruction)
                {
                    case "Move":
                        int numOfLetters = int.Parse(token[1]);

                        for (int i = 0; i < numOfLetters; i++)
                        {
                            result.Append(result[i]);
                        }

                        result.Remove(0, numOfLetters);

                        break;
                    case "Insert":
                        int idx = int.Parse(token[1]);
                        string value = token[2];
                        result.Insert(idx, value);
                        break;
                    case "ChangeAll":
                        result.Replace(token[1], token[2]);
                        break;
                }

            }

            Console.WriteLine($"The decrypted message is: {result}");
        }
    }
}
