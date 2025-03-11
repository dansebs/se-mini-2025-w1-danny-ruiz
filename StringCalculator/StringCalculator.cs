using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;


public class StringCalculator
{
    public int Add(string numbers)
    {
        List<char> list = new List<char>();

        list.Add('\n');list.Add(',');


        if (numbers.Contains('-')) throw new Exception("Exist negative number");

        if (numbers.Contains('\n') || numbers.Contains(','))
        {
            string[] result = numbers.Split(',');
            int sum = 0;
            foreach (string number in result)
            {
                if (number.Contains("\n"))
                {
                    string[] nums = number.Split("\n");
                    foreach (string num in nums)
                    {
                        sum += int.Parse(num) > 1000 ? 0 : int.Parse(num); ;
                    }
                }
                else
                {
                    sum += int.Parse(number) > 1000 ? 0 : int.Parse(number); ;
                }
            }
            return sum;
        }
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }
        int rt = int.Parse(numbers) > 1000 ? 0:int.Parse(numbers);
        return rt;
    }


}

