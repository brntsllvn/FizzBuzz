using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Game
    {
        public string FizzBuzzifier(int fizzBuzzRoundNumber)
        {
            String Fizz = "Fizz";
            String Buzz = "Buzz";
            String fizzBuzzResult;

            if (DividesByThree(fizzBuzzRoundNumber))
            {
                fizzBuzzResult = Fizz;

                if (DividesByFive(fizzBuzzRoundNumber))
                {
                    fizzBuzzResult += " " + Buzz;
                }
            }
            else if (DividesByFive(fizzBuzzRoundNumber))
            {
                fizzBuzzResult = Buzz;
            }
            else
            {
                fizzBuzzResult = fizzBuzzRoundNumber.ToString();
            }

            return fizzBuzzResult;
        }

        public bool DividesByThree(int i)
        {
            return (i % 3 == 0);
        }

        public bool DividesByFive(int i)
        {
            return (i % 5 == 0);
        }
    }
}
