using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Income calculator
             **/
            //float initialIncome = 100;
            //int numberOfDays = 7;

            //GetIncome(initialIncome, numberOfDays);


            /**
             *  Volume calculator
             * */
            //Get3DObjVolume(10, 10, 20, "cm");


            /**
             *  Array Sorter low - high
             * */
            //ArrangeArray(new int[] { 8, 2, 3, 6, 1, 5, 11, 7, 4, 9 });


            /**
             *  LETTER COMBINATION
             * */
            //LetterCombinations();


            /**
             *  TIME AND WORK COMPUTATION
             * */
            //TimeNWork();


            /**
             * RAFFLE APP
             * */
            StartRaffle();

        }

        public static void GetIncome(float firstDayIncome, int numberOfDays)
        {
            float result = firstDayIncome;
            float prevIncome = firstDayIncome;

            Console.WriteLine(string.Format("Day 1 - {0}", prevIncome));

            for (int i = 1; i < numberOfDays; i++)
            {
                prevIncome = (prevIncome * 2);
                result += prevIncome;

                Console.WriteLine(string.Format("Day {0} - {1}", i + 1, prevIncome));
            }

            Console.WriteLine(string.Format("Total ernings in {0} days: {1}", numberOfDays, result));
            Console.ReadKey();
        }

        public static void Get3DObjVolume(int length, int width, int height, string unit)
        {
            int volume = (length * width * height);

            Console.WriteLine(string.Format("Volume: {0}{4} x {1}{4} x {2}{4} = {3}{4}", length, width, height, volume, unit));
            Console.ReadKey();
        }

        public static void ArrangeArray(int[] arr)
        {
            int arrLength = arr.Length;

            for (int i = 0; i < arrLength; i++)
            {
                for (int x = i; x < arrLength; x++)
                {
                    if (arr[x] < arr[i])
                    {
                        var switch1 = arr[i];
                        var switch2 = arr[x];

                        arr[i] = switch2;
                        arr[x] = switch1;
                    }
                }
            }

            Console.WriteLine(string.Format("[{0}]", string.Join(", ", arr)));
            Console.ReadKey();
        }

        public static void LetterCombinations()
        {
            char[] letterArr = "ABC".Trim().ToCharArray();
            int combLimit = 0;

            for (int i = 0; i < letterArr.Length; i++)
            {
                for (int x = i; x < letterArr.Length; x++)
                {
                    char sw1 = letterArr[i];
                    char sw2 = letterArr[x];

                    if (x == letterArr.Length - 1)
                    {
                        letterArr[x] = sw1;
                        letterArr[0] = sw2;
                    }
                    else
                    {
                        letterArr[x] = sw1;
                        letterArr[i] = sw2;
                    }

                    Console.WriteLine(string.Join("", letterArr));
                    combLimit++;
                }

                if (combLimit == 3)
                {
                    Console.ReadLine();
                    return;
                }
            }
        }

        public static void TimeNWork()
        {
            int nOfWork = 1;
            int aaron = 12;
            int brandon = 15;

            decimal numerator = (nOfWork * brandon) + (nOfWork * aaron);
            decimal denominator = (aaron * brandon);

            decimal result = (numerator / 9) / (denominator / 9);

         
        }


        public static void StartRaffle()
        {
            Console.WriteLine("Raffle!!!!\n");
            var startRaffle = false;

            List<string> names = new List<string>();

            // GET NAMES
            while (!startRaffle)
            {
                Console.Clear();
                Console.WriteLine("****Raffle!!!!****\n");
                Console.WriteLine("Please insert name:");
                string entryName = Console.ReadLine();

                if (!names.Contains(entryName))
                {
                    names.Add(entryName);
                }
                else
                {
                    Console.WriteLine("Name already exists.");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Add more names? (y/n)");
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.KeyChar == 'n')
                {
                    startRaffle = true;
                }
            }

            Console.Clear();
            bool shuffle = true;
            while (names.Count > 0 && shuffle)
            {
                Console.Clear();
                Random rnd = new Random();

                int luckyIndx = rnd.Next(names.Count);

                Console.WriteLine("\nCongratulations!!! " + names[luckyIndx]);
                names.RemoveAt(luckyIndx);

                Console.WriteLine("\nContinue shuffle? (y/n)");
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.KeyChar == 'n')
                {
                    shuffle = false;
                }
            }

            Console.Clear();
            Console.WriteLine("\nNo more names. Thank you.");
            Console.ReadLine();
        }
    }
}
