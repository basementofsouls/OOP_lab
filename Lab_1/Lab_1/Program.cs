using System;
using System.Linq;
using System.Text;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //a.
            int a = 1;
            bool Byte = true;
            byte c = 67;
            sbyte d = -67;
            char f = 'C';
            decimal g = 1.1314E0m;
            short h = -375;
            ushort ush = 375;
            uint k = 10;
            long l = 133;
            ulong m = 13166745073736851;
            float n = 314.15E-2f;
            double p = 3.1515;
            string stroka = "stroka";
            object obj = 063147;
            Console.WriteLine("Task1.\n\nTask A:\n");
            Console.WriteLine(Byte);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(ush);
            Console.WriteLine(a);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(p);
            Console.WriteLine(stroka);
            Console.WriteLine(obj);

            //b. Преобразование типов
            Console.WriteLine("\nTask B:\n");
            double Double = 1234.7;
            int Int = (int)Double;
            float Float = (float)Double;
            decimal Decimal = (decimal)Double;
            long Long = (long)Double;
            byte Byte5 = 5;
            short s = Byte5;
            int Int_Short = Byte5;
            long Long2 = Byte5;
            double Double_Long = l;
            float Float_Long = l;
            Console.WriteLine($"Double = {Double}: Int = {Int}, Float = {Float},Decimal = {Decimal},Long = {Long}\n{Byte5}: {s}, {Int_Short}, {Long2}, {Double_Long},{Float_Long}");
            //Convert
            int I_Convert = Convert.ToInt32("23");
            bool Bool = true;
            double Double_Convert = Convert.ToDouble(Bool);
            Console.WriteLine($"n={I_Convert}  d={Double_Convert}");

            //c. упаковка и распаковка значимых типов
            Console.WriteLine("\nTask C:\n");
            int a_box = 123;
            object Int_box = a_box;//boxing
            int a_unbox = (int)Int_box;//unboxing
            float b_box = 14.15E-2f;
            object float_box = b_box;
            float b_unbox = (float)float_box;
            double c_box = 5.1615;
            object double_box = c_box;
            double c_unbox = (double)double_box;
            Console.WriteLine("int - {0},{1},{2}\nfloat - {3},{4},{5}\ndouble - {6},{7},{8}", a_box, Int, a_unbox, b_box, float_box, b_unbox, c_box, double_box, c_unbox);

            //d. работа с неявно типизированной переменной
            Console.WriteLine("\nTask D:\n");
            var mas1 = new[] { 1, 3, 5, 7, 9 };
            var mas2 = new[] { 'a', 'b', 'c', 'd', 'e' };
            var mas3 = new[] { 1, 1.11 };
            Console.WriteLine(mas1.GetType());
            Console.WriteLine(mas2.GetType());
            Console.WriteLine(mas3.GetType());

            //e.
            Console.WriteLine("\nTask E:\n");
            int? val = null;
            Console.WriteLine(val);

            //F. изменение значения переменной типа var
            var anyVar = 5;
            anyVar = '5';
            Console.WriteLine(anyVar);


			//Task 2.
			//a.
			Console.WriteLine("\n\nTask 2.\n\nTask A:\n");
			string string2 = "Hello World";
			string string3 = "Hello World";
			Console.WriteLine(String.Equals(string2, string3));

			//b.
			Console.WriteLine("\nTask B:\n");
			string str1 = "This";
			string str2 = "is";
			string str3 = "a string";
			string str4 = str1 + " " + str2 + " " + str3;
			Console.WriteLine(str4);

			string strA = "hello";
			string strB = String.Copy(strA);
			Console.WriteLine(strA);
			Console.WriteLine(strB);

			string value = "This is a string.";
			int startIndex = 5;
			int length = 2;
			string substring = value.Substring(startIndex, length);
			Console.WriteLine(substring);


			string str = "Good luck, have fun.";

			string[] subs = str.Split(' ');

			foreach (var sub in subs)
			{
				Console.WriteLine($"Substring: {sub}");
			}


			string text1 = "If you want something done right...";
			string text2 = "bla bla bla";

			text1 = text1.Insert(8, text2);
			Console.WriteLine(text1);

			string text = "Хороший день";
			// индекс последнего символа
			int ind = text.Length - 1;
			// вырезаем последний символ
			text = text.Remove(ind);
			Console.WriteLine(text);

			string name = "Jane Doe";
			int age = 21;

			Console.WriteLine($"Имя: {name}  Возраст: {age}");

			//c.
			Console.WriteLine("\nTask C:\n");
			bool TestForNullOrEmpty(string s)
			{
				bool result;
				result = s == null || s == string.Empty;
				return result;
			}
			string strok1 = "";
			string strok2 = null;
			Console.WriteLine(TestForNullOrEmpty(strok1));
			Console.WriteLine(TestForNullOrEmpty(strok2));

			//d.
			Console.WriteLine("\nTask D:\n");
			StringBuilder sb = new StringBuilder("ABCDEFG", 50);
			char plus = '+';

			sb.Append(plus);
			sb.Remove(2, 1);
			sb.Insert(0, plus);

			Console.WriteLine(sb.ToString());

			//Task 3.
			//a.
			Console.WriteLine("\nTask 3.\n\nTask A:\n");
			int[,] myArr1 = new int[4, 5];

			Random ran = new Random();

			for (int i = 0; i < 4; i++)
			{
				for (int ja = 0; ja < 5; ja++)
				{
					myArr1[i, ja] = ran.Next(1, 15);
					Console.Write("{0}\t", myArr1[i, ja]);
				}
				Console.WriteLine();
			}

			//b.
			Console.WriteLine("\nTask B:\n");
			string[] daysOfWeek = { "Sunday", "Monday", "Tuersday",
		  "Wednesday", "Thirsday", "Friday", "Saturday" };


			int choosePos = Convert.ToInt32(Console.ReadLine());
			string chooseValue = Console.ReadLine();

			daysOfWeek[choosePos] = chooseValue;

			for (int i = 0; i < daysOfWeek.Length; i++)
				Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);

			Console.WriteLine(daysOfWeek.Length);

			//c.
			Console.WriteLine("\nTask C:\n");
			int[][] myArr = new int[3][] { new int[2], new int[3], new int[4] };
			for (int i = 0; i < myArr.Length; i++)
			{
				for (int j = 0; j < myArr[i].Length; j++)
				{
					Console.Write($"myArr[{i}][{j}] = ");
					myArr[i][j] = int.Parse(Console.ReadLine());
				}
			}
			for (int i = 0; i < myArr.Length; i++)
			{
				Console.WriteLine(string.Join(" ", myArr[i]));
			}

			//d.
			var neyavniy_massiv = new[] { 5, 10, 23, 16, 8 };
			var neyav_str = "";


			//Task 4.
			//a.
			(int, string, char, string, ulong) kortezh = (1, "Hello", '+', "wrld", 21232131);

			//b.
			Console.WriteLine("\nTask B:\n");
			Console.WriteLine(kortezh.Item1);
			Console.WriteLine(kortezh.Item3);
			Console.WriteLine(kortezh.Item4);

			Console.WriteLine(kortezh);

			//c.
			Console.WriteLine("\nTask C:\n");
			var kor_1 = kortezh.Item1;
			var kor_2 = kortezh.Item2;

			Console.WriteLine($"{kor_1};{kor_2}");

			(var aaa, var bbb) = ("123", 456);
			Console.WriteLine($"{aaa} {bbb}"); //распаковка кортежа	

			var _kor = "kortezh";
			Console.WriteLine(_kor);

			//d.
			Console.WriteLine("\nTask D:\n");
			var firstTuple = (9, 3);
			var secondTuple = (9, 3);

			if (firstTuple == secondTuple)
				Console.WriteLine("Первый кортеж равен второму");
			else
				Console.WriteLine("Первый кортеж не равен второму");

			//Task 5.
			Console.WriteLine("\nTask 5.\n");
			static (int, int, int, char) LocalFunction(int[] arrVar, string strVar)
			{
				int maxArrayElement = arrVar.Max();
				int minArrayElement = arrVar.Min();
				int arrayElementsSum = arrVar.Sum();
				char firstStringChar = strVar[0];
				return (maxArrayElement, minArrayElement, arrayElementsSum, firstStringChar);
			}
			int[] arrVar = new int[] { 5, 3, 12, 42, -23 };
			var strVar = "ABCD";
			Console.WriteLine(LocalFunction(arrVar, strVar));


			//Task 6.
			Console.WriteLine("\nTask 6.\n");
			static void FunctionWithChecked()
			{
				checked
				{
					var intVar = int.MaxValue;
					intVar++;
					Console.WriteLine(intVar);
				}
			}

			static void FunctionWithUnchecked()
			{
				unchecked
				{
					var intVar = int.MaxValue;
					intVar++;
					Console.WriteLine(intVar);
				}
			}
			//FunctionWithChecked();
			//FunctionWithUnchecked();
		}
    }
}


