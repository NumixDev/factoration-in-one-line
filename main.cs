using System;class Program{static void Main(string[] args){int num, divisor; Console.Write("Number: "); num = int.Parse(Console.ReadLine()); Console.Write("Factoration {0}: ", num); divisor = 2; while (num > 1) {if (num % divisor == 0){Console.Write(divisor + " ");num /= divisor;}else{divisor++;}}Console.ReadKey();}}
