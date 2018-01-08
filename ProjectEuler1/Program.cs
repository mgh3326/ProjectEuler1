﻿using System;

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

//http://euler.synap.co.kr/prob_detail.php?id=1

//    10보다 작은 자연수 중에서 3 또는 5의 배수는 3, 5, 6, 9 이고, 이것을 모두 더하면 23입니다.

//1000보다 작은 자연수 중에서 3 또는 5의 배수를 모두 더하면 얼마일까요?