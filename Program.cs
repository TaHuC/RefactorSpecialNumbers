using System;

namespace RefactorSpecialNumbers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int inputNum = int.Parse(Console.ReadLine());
			int sum = 0; int specialNum = 0; bool special = false;
			for (int num = 1; num <= inputNum; num++)
			{
				specialNum = num;
				while (num > 0)
				{
					sum += num % 10;
					num = num / 10;
				}
				special = (sum == 5) || (sum == 7) || (sum == 11);
				Console.WriteLine($"{specialNum} -> {special}");
				sum = 0;
				num = specialNum;
			}
		}
	}
}
