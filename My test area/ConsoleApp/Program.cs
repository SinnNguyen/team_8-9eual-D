using System; 

namespace ConsoleApp
{
    class Program
    {
        static int max = 100;  // khai báo biến toàn cục
        static int Menu()
        {
            Console.WriteLine();
            Console.WriteLine("SAP XEP & TIM KIEM TREN DAY");
            Console.WriteLine(" 1. Tim So nguyen nho nhat khong co trong day     2. Sang nguyen to");
            Console.WriteLine(" 3. Dem so lan xuat hien phan tu trong day        4. Mo rong voi day so nguyen am, duong");
            Console.WriteLine(" 5. Dem so ky tu trong chuoi                      6. Lop hoc");
            Console.WriteLine(" 7. Phan tich Thua so nguyen to                   0. Thoat");
            Console.WriteLine(new string('-',70));
            Console.Write(" Chon : "); int chon = int.Parse(Console.ReadLine());
            return chon;
        }
        // Tạo dãy ngẫu nhiên (nguyên dương)
        static void RandomArray(int[] a, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rd.Next(1, max);
            Console.WriteLine();
        }
        // Tạo dãy ngẫu nhiên số nguyên âm và dương
        static void RandomArray2(int[] a, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rd.Next(-max+1, max);
            Console.WriteLine();
        }
        //Xuất dãy
        static void PrintArray(int[] a, int n)
        {

        }
        // Bài 1 : Hãy tìm số nguyên dương nhỏ nhất không xuất hiện trong 𝑎.
        static int SoNguyenNhonhat(int[] a, int n)
        {	//Hàm trả về số nguyên nhỏ nhất không có trong dãy

        }
        // Bài 2 - Sàng nguyên tố : Cho số nguyên 𝑛 (1 ≤ 𝑛 ≤ 10^6).
        // Viết chương trình liệt kê các số nguyên tố nhỏ hơn hay bằng 𝑛.
        static bool[] Eratosthenes(int N)
        {	//Hàm trả về mảng đánh dấu kiểu bool

        }
        // Bài 3 : cho biết mỗi số nguyên trong dãy 𝑎 xuất hiện bao nhiêu lần?
        static void Bai03(int[] a, int n)
        {

        }
        // Bài 4 : mở rộng bài 3 với dãy 𝑎 chứa vừa số nguyên âm, vừa chứa số nguyên dương
        static void Bai04(int[] a, int n)
        {

        }
        // Bài 5 : Đếm số lần xuất hiện ký tự trong chuỗi
        static void Bai05()
        {

        }
        // Bài 6 : Lớp học
        static void Lophoc()
        {

        }
        // Bài 7: phân tích ra các thừa số nguyên tố.
        static string PhantichTSNT(int N)
        {	//Hàm trả về chuỗi thừa số nguyên tố của N

        }
        static void Main(string[] args)
        {
            int[] a = new int[max];
            int chon = 0;
            do
            {
                chon = Menu();
                switch (chon)
                {
                    case 1:
                    {  // Tim So nguyen nho nhat khong co trong day
                        Console.Write("  Nhap so phan tu n = ");
                        int n = int.Parse(Console.ReadLine());
                        RandomArray(a, n); Console.Write(" Day a: "); PrintArray(a, n);
                        int amin = SoNguyenNhonhat(a, n); Console.WriteLine();
                        Console.WriteLine(" So nguyen nho nhat khong co trong a : " + amin);            
                    } break;
                    case 2:
                    {  // sàng nguyên tố
                        Console.Write("  Nhap so N = ");
                        int N = int.Parse(Console.ReadLine());
                        bool[] check = new bool[N+1];
                        check = Eratosthenes(N);
                        // In ra các số là số nguyên tố <= N
                        Console.Write(" Cac so nguyen to <= {0} : ", N);
                        for (int i = 2; i <= N; i++)
                            if (check[i] == true) Console.Write(" " + i);
                                Console.WriteLine(); 
                    } break;
                    case 3:
                    {   // Dem so lan xuat hien phan tu trong day nguyên dương
                        Console.Write("  Nhap so phan tu n = ");
                        int n = int.Parse(Console.ReadLine());
                        RandomArray(a, n); Console.Write(" Day a: "); PrintArray(a, n);
                        Bai03(a,n); 
                    } break;
                    case 4:
                    {   // mở rộng bài 3, đếm trên dãy số nguyên
                        Console.Write("  Nhap so phan tu n = ");
                        int n = int.Parse(Console.ReadLine());
                        RandomArray2(a, n); Console.Write(" Day a: "); PrintArray(a, n); 
                        Bai04(a,n); 
                    } break;
                    case 5:
                    {    // Đếm số lần xuất hiện ký tự trong chuỗi
                      Bai05();  
                    } break;
                    case 6:
                    {   // Bài 6 : lớp học
                        Lophoc(); 
                    } break;
                    case 7:
                    {   // Bài 7 : phân tích thừa số nguyên tố
                        Console.Write(" Nhap so nguyen N = ");
                        int N = int.Parse(Console.ReadLine());
                        string tsNguyento = PhantichTSNT(N);
                        Console.WriteLine();
                        Console.Write(" Thua so nguyen to : {0} = {1}", N, tsNguyento); 
                    } break;
                }
                Console.WriteLine();
            } while (chon != 0);
        }
    }
}
