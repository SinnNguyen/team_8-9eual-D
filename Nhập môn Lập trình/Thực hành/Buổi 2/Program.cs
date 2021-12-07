using System;

namespace Buoi02
{
    class Program
    {
        //BT1: Viết chương trình nhập một một số nguyên n.Cho n là số âm hay số dương và n là số chẵn hay số lẻ.
        static void Bai1()
        {
            Console.Write("Nhap 1 so NGUYEN: ");
            int n = int.Parse(Console.ReadLine());

            string ansChanLe = "";
            string ansAmDuong = "";

            if (n % 2 == 0)
                ansChanLe = "so chan";
            else
                ansChanLe = "so le";

            if (n > 0)
                ansAmDuong = "so duong";
            else
                ansAmDuong = "so am";

            Console.WriteLine("{0} la {1} va la {2}.", n, ansAmDuong, ansChanLe);
        }
        //BT2: Cho 3 số thực a, b, c (𝑎≠0). Giải phương trình bậc hai 𝒂𝒙𝟐+𝒃𝒙+ 𝒄=𝟎
        static void Bai2()
        {
            double x1, x2;

            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                x1 = -b + Math.Sqrt(delta) / 2 * a;
                x2 = -b - Math.Sqrt(delta) / 2 * a;
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = {0} | x2 = {1} ", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = -b / 2 * a;
                Console.WriteLine("Phuong trinh co nghiem kep = {0}", x1);
            }
            else
                Console.WriteLine("Phuong trinh vo nghiem. ");
        }
        //BT3: Cho 3 số thực a, b, c. Hãy tìm giá trị lớn nhất của 3 số đó.
        static void Bai3()
        {
            Console.Write("Nhap SO THUC thu 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap SO THUC thu 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap SO THUC thu 3: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double Max = a;
            if (b > Max)
                Max = b;
            if (c > Max)
                Max = c;

            Console.WriteLine("Max({0},{1},{2}) = {3}", a, b, c, Max);
        }
        //BT4: Cho 3 số thực a, b, c.Hãy hoán đổi giá trị của 3 số sao cho giá trị của a, b, c có thứ tự không giảm(sắp xếp tăng dần).
        static void Bai4()
        {
            double temp;

            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc c: ");
            double c = double.Parse(Console.ReadLine());

            Console.Clear();

            if (a > b)
            {
                temp = b;
                b = a;
                a = temp;
                if (b > c)
                {
                    temp = c;
                    c = b;
                    b = temp;
                }
            }
            else if (a < b)
            {
                if (b > c)
                {
                    temp = c;
                    c = b;
                    b = temp;
                }
            }
            Console.WriteLine("Re-arrange: {0} | {1} | {2} ", a, b, c);
        }
        /*
         * BT5:
         * Nhập 3 số thực a, b, c. Hãy kiểm tra 3 số vừa nhập có thể tạo thành một tam giác với độ dài 3 cạnh lần lượt là a, b, c hay không?
            ▪ Nếu là tam giác thì tính chu vi của tam giác này.
            ▪ Nếu không là tam giác thì tính diện tích hình thang có 2 đáy là a, b; chiều cao là c.
         */
        static void Bai5()
        {
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (a + b > c && a + c > b && b + c > a)
            {
                double P = a + b + c;
                Console.WriteLine("Day la tam giac co chu vi = {0} ", P);
            }
            else
            {
                double S = (a + b) * c / 2;
                Console.WriteLine("Day la hinh thang co dien tich = {0}", S);
            }
        }
        //BT6: Nhập vào một số nguyên thuộc đoạn [1,12]. Hãy in ra tên tháng (bằng tiếng Anh) tương ứng với số đó.
        static void Bai6()
        {
            Console.Write("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("June"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("October"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
                default: Console.WriteLine("Thang khong hop le..."); break;
            }
        }
        //BT7: Viết chương trình nhập vào 2 số nguyên a, b và một phép toán op (+, -, *, / , %). Hãy tính và in ra màn hình kết quả của phép toán tương ứng.
        static void Bai7()
        {
            Console.Write("Nhap so NGUYEN thu 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so NGUYEN thu 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Nhap phep toan(+, -, *, /, %): ");
            char op = char.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (op)
            {
                case '+': Console.WriteLine("{0} + {1} = {2}", a, b, a + b); break;
                case '-': Console.WriteLine("{0} - {1} = {2}", a, b, a - b); break;
                case '*': Console.WriteLine("{0} * {1} = {2}", a, b, a * b); break;
                case '/': Console.WriteLine("{0} / {1} = {2}", a, b, a / b); break;
                case '%': Console.WriteLine("{0} % {1} = {2}", a, b, a % b); break;
            }
        }
        /*Cho số thực 𝑥 (0≤𝑥≤100). Hãy cho biết 𝒙 thuộc đoạn nào trong các đoạn dưới đây:
                        [0,25]; (25,50]; (50,75]; (75,100]
        */
        static void Bai8()
        {
            Console.Write("Nhap 1 so (0 <= x <= 100): ");
            double x = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= 25)
                Console.WriteLine($"{x:0.00} thuoc [0,25]");
            else if (x <= 50)
                Console.WriteLine($"{x:0.00} thuoc (25,50]");
            else if (x <= 75)
                Console.WriteLine($"{x:0.00} thuoc (50,75]");
            else if (x <= 100)
                Console.WriteLine($"{x:0.00} thuoc (75,100]");
            else
                Console.WriteLine($"{x:0.00} khong thuoc!");
        }
        //BT9: Viết chương trình nhập vào mã sản phẩm (code) và số lượng (amount) cần mua. Hãy tính và in ra màn hình thông tin thanh toán
        static void Bai9()
        {
            string pName = "";
            double price = 0;

            Console.Write("Enter the PRODUCT'S CODE: ");
            sbyte pCode = sbyte.Parse(Console.ReadLine());
            Console.Write("Enter the PRODUCT'S QUANTITY: ");
            sbyte pQuantity = sbyte.Parse(Console.ReadLine());

            switch (pCode)
            {
                case 1:
                    {
                        pName = "Cochorro Quente";
                        price = 4;
                    }
                    break;
                case 2:
                    {
                        pName = "X-Salada";
                        price = 4.5;
                    }
                    break;
                case 3:
                    {
                        pName = "X-Bacon";
                        price = 5;
                    }
                    break;
                case 4:
                    {
                        pName = "Torrada simples";
                        price = 2;
                    }
                    break;
                case 5:
                    {
                        pName = "Refrigerante";
                        price = 1;
                    }
                    break;
            }

            double total = price * pQuantity;

            Console.Clear();

            Console.WriteLine("{0,-20} | {1,12} | {2,12} | {3,12}", "PRODUCT NAME", "PRICE", "QUANTITY", "TOTAL(R$)");
            Console.WriteLine("{0,-20} | {1,12:0.00} | {2,12} | {3,12:0.00}", pName, price, pQuantity, total);

            Console.WriteLine("");
            Console.Write("Go ENTER de ket thuc..."); Console.ReadLine();
        }
        //BT10: Viết chương trình nhập vào lương hiện tại của một nhân viên. Tính lương mới cho nhân viên đó.
        static void Bai10()
        {
            double ansSalary = 0;
            Console.Write("Enter the current Salary: ");
            double salary = double.Parse(Console.ReadLine());

            if (salary <= 400)
            {
                ansSalary = salary + (salary * 15 / 100);
                Console.WriteLine("Your salary this month: {0}", ansSalary);
            }
            else if (salary > 400 && salary <= 800)
            {
                ansSalary = salary + (salary * 12 / 100);
                Console.WriteLine("Your salary this month: {0}", ansSalary);
            }
            else if (salary > 800 && salary <= 1200)
            {
                ansSalary = salary + (salary * 10 / 100);
                Console.WriteLine("Your salary this month: {0}", ansSalary);
            }
            else if (salary > 1200 && salary <= 2000)
            {
                ansSalary = salary + (salary * 7 / 100);
                Console.WriteLine("Your salary this month: {0}", ansSalary);
            }
            else
            {
                ansSalary = salary + (salary * 4 / 100);
                Console.WriteLine("Your salary this month: {0}", ansSalary);
            }
        }
        //BT11: Viết thuật toán nhập vào 2 số thực x, y là tọa độ của một điểm trong mặt phẳng. Hãy cho biết điểm nằm ở vị trí nào?
        static void Bai11()
        {
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
                Console.WriteLine($"{x},{y} o goc toa do");
            else if (x == 0)
                Console.WriteLine($"{x},{y} o truc tung");
            else if (y == 0)
                Console.WriteLine($"{x},{y} o truc hoanh");
            else if (x > 0 && y > 0)
                Console.WriteLine($"{x},{y} tai o Q1");
            else if (x < 0 && y > 0)
                Console.WriteLine($"{x},{y} tai o Q2");
            else if (x < 0 && y < 0)
                Console.WriteLine($"{x},{y} tai o Q3");
            else
                Console.WriteLine($"{x},{y} tai o Q4");
        }
        /* BT12: 
         * Viết chương trình C# cho phép người sử dụng chọn câu trả lời (giống như chương trình thi trắc nghiệm). Hiển thị câu hỏi ở dưới đây:
         * Cách nào khai báo một biến và gán giá trị số nguyên là đúng trong các câu lệnh C# sau?
                a.	int 1x=10;
                b.	int x=10;
                c.	float x=10.0f;
                d.	string x=”10″;
         */
        static void Bai12()
        {
            Console.WriteLine("Cach nao de khai bao 1 bien va gan gia tri so nguyen la dung trong cac cau lenh C# sau? ");
            Console.WriteLine("{0,10}.int 1x = 10;", "a");
            Console.WriteLine("{0,10}.int  x = 10;", "b");
            Console.WriteLine("{0,10}.float x = 10.0f;", "c");
            Console.WriteLine("{0,10}.string x = \"10\";", "d");

            Console.WriteLine();

            Console.Write("Nhap dap an (a, b, c, d): ");
            char ans = char.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (ans)
            {
                case 'a': Console.WriteLine("Dap an sai!"); break;
                case 'b': Console.WriteLine("Dap an DUNG!"); break;
                case 'c': Console.WriteLine("Dap an sai!"); break;
                case 'd': Console.WriteLine("Dap an sai!"); break;
            }
        }
        /* BT13:
         * Nhập số tháng (thang) kiểm tra tháng nhập hợp lệ hay không. 
         * Nếu tháng hợp lệ thì cho biết tháng đó có bao nhiêu ngày, 
         * ngược lại (không hợp lệ) thì thông báo “Tháng nhập không hợp lệ”
         */
        static void Bai13()
        {
            Console.Write("Nhap so thang: ");
            int Month = int.Parse(Console.ReadLine());

            if (Month >= 1 || Month <= 12)
            {
                if (Month != 2)
                {
                    switch (Month)
                    {
                        case 1: Console.WriteLine("Thang {0:2} co 31 ngay.", "1"); break;
                        case 3: Console.WriteLine("Thang {0:2} co 31 ngay.", "3"); break;
                        case 4: Console.WriteLine("Thang {0:2} co 30 ngay.", "4"); break;
                        case 5: Console.WriteLine("Thang {0:2} co 31 ngay.", "5"); break;
                        case 6: Console.WriteLine("Thang {0:2} co 30 ngay.", "6"); break;
                        case 7: Console.WriteLine("Thang {0:2} co 31 ngay.", "7"); break;
                        case 8: Console.WriteLine("Thang {0:2} co 31 ngay.", "8"); break;
                        case 9: Console.WriteLine("Thang {0:2} co 30 ngay.", "9"); break;
                        case 10: Console.WriteLine("Thang {0:2} co 31 ngay.", "10"); break;
                        case 11: Console.WriteLine("Thang {0:2} co 30 ngay.", "11"); break;
                        case 12: Console.WriteLine("Thang {0:2} co 31 ngay.", "12"); break;

                    }
                }
                else
                    Console.WriteLine("Thang {0:2} co 28/29 ngay.", "2");
            }
            else
            {
                Console.WriteLine("Thang nhap khong hop le!");
            }
        }
        /* BT14:
         * Nhập vào một năm (theo dương lich), cho biết năm đó có nhuận hay không 
         * Năm nhuận là năm chia hết cho 4, không chia hết 100, ngoài ra năm chia hết cho 400 (năm đầu thế kỷ) là năm nhuần.
         */
        static void Bai14()
        {
            Console.Write("Nhap vao nam duong lich: ");
            int y = int.Parse(Console.ReadLine());
            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
                Console.WriteLine("Nam {0} la nam nhuan.", y);
            else
                Console.WriteLine("Nam {0} khong phai nam nhuan!", y);

        }
        /* BT15:
         * Nhập vào chiều dài của 3 cạnh a, b, c. 
         * Cho biết 3 cạnh a, b, c có thể là 3 cạnh của một tam giác hay không? 
         * Nếu là 3 cạnh tam giác cho biết là tam giác gì : vuông, vuông cân, cân, đều hay thường?
         */
        static void Bai15()
        {
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (a + b > c && a + c > b && b + c > a)
            {
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    if (a == b || b == c || c == a)
                        Console.WriteLine("Day la tam giac vuong can!");
                    else
                        Console.WriteLine("Day la tam giac vuong.");
                }
                else if (a == b || b == c || c == a)
                {
                    if (a == b && b == c && c == a)
                        Console.WriteLine("Day la tam giac deu.");
                    else
                        Console.WriteLine("Day la tam gian can.");
                }
                else
                {
                    Console.WriteLine("Day la tam giac thuong.");
                }
            }
            else
            {
                Console.WriteLine("Day khong phai tam giac!");
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();

            Bai1();

            //Bai2(); 

            //Bai3(); 

            //Bai4(); 

            //Bai5(); 

            //Bai6(); 

            //Bai7(); 

            //Bai8(); 

            //Bai9(); 

            //Bai10(); 

            //Bai11(); 

            //Bai12(); 

            //Bai13(); 

            //Bai14(); 

            //Bai15(); 
        }
    }
}
