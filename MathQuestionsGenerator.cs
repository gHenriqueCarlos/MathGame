using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class MathQuestionsGenerator{
        static Random random = new Random();

        private string CurrentMathQuestion = string.Empty;
        private int CurrentMathResult = 0;
        public void GenerateMathQuestion(int level, out string question, out int result){
            level = (level < 0) ? 0 : level;

            int number1 = random.Next(1, level * 10 + 1); 
            int number2 = random.Next(1, level * 10 + 1);
            string operation;

            switch (random.Next(0, 4)){
                case 0:
                    operation = "+";
                    result = number1 + number2;
                    break;
                case 1:
                    operation = "-";
                    result = number1 - number2;
                    break;
                case 2:
                    operation = "*";
                    result = number1 * number2;
                    break;
                default:
                    operation = "/";
                    result = number1 / number2;
                    break;
            }

            question = $"{number1} {operation} {number2}";
            CurrentMathResult = result;
            CurrentMathQuestion = question;
        }
    }
}
