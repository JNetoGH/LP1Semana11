using System;

namespace GuessTheNumber
{
    public enum State
    {
        TooLow,
        TooHigh,
        Right
    }
    
    public class Model
    {
        private Random _random = new Random(); 
        private int _targetNumber = 0;  // between 1 and 100
        public int Attempts { get; private set; }
        public int Guess = -1;

        public State AttemptState
        {
            get
            {
                if (Guess < _targetNumber) return State.TooLow;
                if (Guess > _targetNumber) return State.TooHigh;
                return State.Right;
            }
        }
        
        public void GenerateNewTargetNumber()
        {
            _targetNumber = _random.Next(1, 101); 
        }
        
        public void GenerateNewGuess()
        {
            Guess = Convert.ToInt32(Console.ReadLine());
            Attempts++;
        }
        
    }
}