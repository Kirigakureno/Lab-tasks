﻿using System;

class Program
{

    static void Main(string[] args)
    {

        int num1;
        int num2;
        string operand;
        float answer;

        Console.Write("This is calculator made by switch!");
        Console.Write("Please enter the first integer: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter an symbol of operation (+, -, /, *): ");
        operand = Console.ReadLine();
         Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (operand)
        {

            case "-":
                answer = num1 - num2;
                break;

            case "+":
                answer = num1 + num2;
                break;

            case "/":
                answer = num1 / num2;
                break;

            case "*":
                answer = num1 * num2;
                break;

            default:
                answer = 0;
                break;
        }
        Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
        Console.ReadLine();

    }

}
