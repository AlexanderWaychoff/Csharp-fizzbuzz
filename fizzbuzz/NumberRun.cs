using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class NumberRun
    {
        FizzBuzzTester testFizzBuzz = new FizzBuzzTester();
        public int number = 0;
        int[] numbers;

        public var TestFizzBuzz()
        { 
            string fizzbuzzy;
            foreach int number in numbers
            {
                fizzbuzzy = FizzBuzzTester.CheckIfFizzAndOrBuzz(number);
            }
        }
        public int createNumberList()
        {
            for (int i = 0; i <= 100; i++)
            {
                number += 1;
                numbers.Add(number);
            }
            return numbers;
        }
    }
}
