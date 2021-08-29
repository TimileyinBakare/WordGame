using System;

namespace WordGames
{
    class Program
    {
        string[] threeWord = {"ate","see","box","axe","cop","dig","peg","cap","jug","old","big"};
        string[] fiveWord = { "cable", "keeps", "books", "spoon", "smoke", "anime", "memes", "green", "dunks"};
        string subWords;
        int usersScore;
        string replace;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program obj = new Program();
            obj.loopsAgain();
        }

        public int userChoice()
        {
            Random random = new Random();

            int numbers;
            int points=0;
            Console.WriteLine("Enter Your Prefered Choice of words ?");
            numbers =Convert.ToInt32(Console.ReadLine());

            string[] currentWordsArr = numbers == 3 ? threeWord : fiveWord;
            
            string myRandoms = currentWordsArr[random.Next(currentWordsArr.Length)];
            int indexOfSwap = random.Next(3);

            subWords = myRandoms.Substring(indexOfSwap,1);

            replace = myRandoms.Replace(subWords, "_");
                
            Console.WriteLine(replace);
            Console.WriteLine("This is the correct answer: {0}",subWords);

            Console.WriteLine("Enter the correct char");
            string usersInput = (Console.ReadLine()).Trim();

            if (usersInput.Equals(subWords))
            {
                Console.WriteLine("You'vegotten this one right o, Werey!");
                points += 5;
            }
            else
            {
                Console.WriteLine("You no simple spelling, Werey!");
            }

            return points;
        }


        public void loopsAgain()
        {
            Console.WriteLine("You have 3 tries");
            for (int i = 0; i < 3; i++)
            {
                usersScore += userChoice();

            }

            Console.WriteLine("Your total score is: {0}", usersScore);
        }
    }
}
