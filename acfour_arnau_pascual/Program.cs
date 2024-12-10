using System;

namespace acfour_arnau_pascual
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProgramCore();
        }
        public static void ProgramCore()
        {
            int[] numbers = new int[SetQuantity()];

            FillNumbers(numbers);

            WriteNumbers(numbers);

            OrderNumbers(numbers);

            WriteOrderedNumbers(numbers);
        }
        public static int SetQuantity()
        {
            const string MsgSetQuantity = "Quants nombres vols emmagatzemar:";

            int quantity = 0;

            Console.WriteLine(MsgSetQuantity);
            quantity = ReadUserInput();

            return quantity;
        }
        public static void FillNumbers(int[] numbers)
        {
            const string MsgFillNumbers = "Introdueix el nombre de la posició";

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{MsgFillNumbers} {i}");

                numbers[i] = ReadUserInput();
            }
        }
        public static void WriteNumbers(int[] numbers)
        {
            const string MsgWriteNumbers = "Posició {0}: {1}";

            for (int i = 0;i < numbers.Length; i++)
            {
                Console.WriteLine(MsgWriteNumbers, i, numbers[i]);
            }
        }
        public static void OrderNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        int aux = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = aux;
                    }
                }
            }
        }
        public static void WriteOrderedNumbers(int[] numbers)
        {
            const string MsgOrderedNumbers = "Nombres ordenats";

            Console.WriteLine(MsgOrderedNumbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        public static int ReadUserInput()
        {
            const string ErrFormatException = "No és un nombre enter";
            const string ErrOverflowException = "El nombre és massa gran";
            const string ErrException = "Error inesperat";
            const string Err = "El nombre s'ha establit com a 1";

            int num = 0;

            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(ErrFormatException);
                Console.WriteLine(Err);
                num = 1;
            }
            catch (OverflowException)
            {
                Console.WriteLine(ErrOverflowException);
                Console.WriteLine(Err);
                num = 1;
            }
            catch (Exception)
            {
                Console.WriteLine(ErrException);
                Console.WriteLine(Err);
                num = 1;
            }
            return num;
        }
    }
}
