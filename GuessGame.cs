using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Guessing_Game
{
    public class GuessGame
    {

        Random random = new Random();

        public GuessGame() 
        {
            SecretNumber = GetSecretNumber();
            Attempts = 0;
            Score = 50;
            MaxAttempts = 5;
        }  


        public int SecretNumber { get; set; }

        public int PlayerGuess { get; set; }

        public int Attempts { get; set; }

        public int MaxAttempts { get; set; }
        
        public int Score { get; set; }

        public bool HasWon {  get; set; }   = false;

        int GetSecretNumber()
        {
            int secretNumber = random.Next(1, 100);
            return secretNumber;
        }

        public void Play()
        {
            //bool hasWon = false;

            Console.WriteLine("Welcome to Guessing Game");
            do
            {
                Console.Write("Guess number: ");
                PlayerGuess = int.Parse(Console.ReadLine());
                Attempts++;

                if(PlayerGuess == SecretNumber)
                {
                    HasWon = true;

                    Console.WriteLine("shen moige");
                    break;
                }
                else if (PlayerGuess > SecretNumber)
                {
                    AdjustScore();
                    Console.WriteLine("naklebi aige");
                }
                else
                {
                    AdjustScore();
                    Console.WriteLine("metia am ricxvze");
                }


            }
            while (Attempts < MaxAttempts);
            DisplayResult();

        }

        public void AdjustScore()
        {
            Score -= 10;
        }

        public void DisplayResult()
        {
            string outPut = HasWon ? $"You Won \nScore: {Score} Attempts: {Attempts}" : $"You Lose \nScore: {Score} Attempts: {Attempts}";
            Console.WriteLine(outPut);

            string damaluliRicxvi = $"Secret numberi iyo --- {SecretNumber}";
            Console.WriteLine(damaluliRicxvi);

            Console.WriteLine("1.daiwye tavidan \n2.agar minda tamashi");
            string gindaarginda = Console.ReadLine();

            switch (gindaarginda)
            {
                case "1":
                    ReserGame();
                    break;
                case "2":
                    break;
            }
        }
        public void ReserGame()
        {
            GuessGame guessGame = new GuessGame();
            guessGame.Play();
        }
    }
}
