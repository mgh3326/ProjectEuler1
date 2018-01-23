# ProjectEuler1

Project Euler Problem 1 Solution with C#
=============
Multiples of 3 and 5
-------------
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
- - -
번역
-------------
10보다 작은 자연수 중에서 3 또는 5의 배수는 3, 5, 6, 9 이고, 이것을 모두 더하면 23입니다.

1000보다 작은 자연수 중에서 3 또는 5의 배수를 모두 더하면 얼마일까요?
- - -
```csharp ProjectEuler1.cs https://github.com/mgh3326/ProjectEuler1/blob/master/ProjectEuler1/Program.cs github
using System;

namespace ProjectEuler1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    num += i;
                }
            }
            Console.WriteLine(num);

        }
    }
}
```
