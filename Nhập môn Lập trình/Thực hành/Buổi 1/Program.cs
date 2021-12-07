using System;

namespace Buoi01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
			// paste here!
			Console.Write("Enter the amount of cash: ");
			int N = int.Parse(Console.ReadLine());
			int a, b, c, d, e, f, g;

			a = N / 100;
			N -= a * 100;
			b = N / 50;
			N -= b * 50;
			c = N / 20;
			N -= c * 20;
			d = N / 10;
			N -= d * 10;
			e = N / 5;
			N -= e * 5;
			f = N / 2;
			N -= f * 2;
			g = N / 1;
			

			Console.WriteLine("{0:4}: {1}", "100", a);
			Console.WriteLine("{0:4}: {1}", "100", b);
			Console.WriteLine("{0:4}: {1}", "100", c);
			Console.WriteLine("{0:4}: {1}", "100", d);
			Console.WriteLine("{0:4}: {1}", "100", e);
			Console.WriteLine("{0:4}: {1}", "100", f);
			Console.WriteLine("{0:4}: {1}", "100", g);
		
		}
    }
}























//BT1
/*
Console.Write("  Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine(" Hello, {0}!", name);
*/
//BT2
/*
Console.Write("Input string: ");
string stringNumber = Console.ReadLine();
int intNumber = Convert.ToInt32(stringNumber);
Console.WriteLine("\"stringNumber\" value & type: {0}, {1}", stringNumber, stringNumber.GetType());
Console.WriteLine("\"intNumber\" value & type: {0}, {1}", intNumber, intNumber.GetType());
*/
//BT3
/*
Console.Write("Nhap a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Nhap b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
*/
//BT4
/*
Console.Write(" Nhap a: ");
double a = double.Parse(Console.ReadLine()); 
Console.Write(" Nhap b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(" Before swapping: ");
Console.WriteLine(" a = {0}, b = {1}", a, b);
double temp = a;
a = b;
b = temp;
Console.WriteLine();
Console.WriteLine(" After swapping: ");
Console.WriteLine(" a = {0}, b = {1}", a, b);
*/
//BT5
/*
Console.Write("Nhap ban kinh: ");
double r = double.Parse(Console.ReadLine());
double P = 2 * Math.PI * r;
double A = Math.PI * Math.Pow(r, 2);
Console.WriteLine("P = {0:#.##}", P);
Console.WriteLine("A = {0:#.##}", A);
*/
//BT6
/*
Console.Write("Nhap N: ");
int N = int.Parse(Console.ReadLine());

if (N >= 1 && N <= 10)
{
    for (int i = 1; i < 11; i++)
        Console.WriteLine("{0,2} x {1,2} = {2,2}", N, i, N * i);
}
else
{
    Console.WriteLine("Vi pham.");
}
*/
//BT7
/*
Console.Write("Enter the Working hours: ");
double workHrs = double.Parse(Console.ReadLine());
Console.Write("Enter the unit prices: ");
int uPrices = int.Parse(Console.ReadLine());
Console.WriteLine("Your salary: {0:0.0}", workHrs * uPrices);
*/
//BT8
/*
Console.Write("Enter the amount of cash: ");
int N = int.Parse(Console.ReadLine());
int a, b, c, d, e, f, g;

a = N / 100;
N = N - a * 100;
b = N / 50;
N = N - b * 50;
c = N / 20;
N = N - c * 20;
d = N / 10;
N = N - d * 10;
e = N / 5;
N = N - e * 5;
f = N / 2;
N = N - f * 2;
g = N / 1;
N = N - g * 1;

Console.WriteLine("{0:4}: {1}", "100", a);
Console.WriteLine("{0:4}: {1}", "100", b);
Console.WriteLine("{0:4}: {1}", "100", c);
Console.WriteLine("{0:4}: {1}", "100", d);
Console.WriteLine("{0:4}: {1}", "100", e);
Console.WriteLine("{0:4}: {1}", "100", f);
Console.WriteLine("{0:4}: {1}", "100", g);
*/
//BT9
/*
Console.Write("Nhap thoi gian (Don vi: giay): ");
int inpSec = int.Parse(Console.ReadLine());

int h = inpSec / 3600;
int m = inpSec % 3600 / 60;
int s = inpSec % 3600 % 60;

Console.WriteLine("{0:00} : {1:00} : {2:00}", h, m ,s);  
*/
//BT10
/*
Console.Write("Input Attendant mark (0 - 10): ");
double atMark = double.Parse(Console.ReadLine());
Console.Write("Input Practical mark (0 - 10): ");
double prMark = double.Parse(Console.ReadLine());
Console.Write("Input Final exam's mark (0 - 10): ");
double fnMark = double.Parse(Console.ReadLine());

double Avg = atMark * 20 / 100 + prMark * 30 / 100 + fnMark * 50 / 100;

Console.Clear();
Console.WriteLine("Average mark: {0:0.0}", Avg);
*/


















//<var>.GetType(): lay kieu du lieu.
//Console.WriteLine("Chuoi \"{0}"\ co kieu: {1}", <var_of_num_string>, chuoiso.GetType());
//so+duong: le phai | so+am: le trai.
//Email: binh1601hg@gmail.com => deadline: Toi T5
//File name: B01_CN_Ca2_<tenSV>.txt

//cach trinh bay file: 
/* 
 Nguyễn Minh Trí, B01, CN, Ca 2
 ********************************************
 <chép nội dung qua>
 */