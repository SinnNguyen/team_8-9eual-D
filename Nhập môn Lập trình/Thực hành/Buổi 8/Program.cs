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
            for (int i = 0; i <= n; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        // Bài 1 : Hãy tìm số nguyên dương nhỏ nhất không xuất hiện trong 𝑎.
        static int SoNguyenNhonhat(int[] a, int n)
        {	//Hàm trả về số nguyên nhỏ nhất không có trong dãy
            bool[] check = new bool[max + 1];
            for(int i = 0; i < n - 1; i++)
            {
                check[i] = false;
                check[a[i]] = true;
            }
            for(int  i = 1; i <= n; i++)
                if (check[i] == false) 
                    return i;
            return 0;
        }
        // Bài 2 - Sàng nguyên tố : Cho số nguyên 𝑛 (1 ≤ 𝑛 ≤ 10^6).
        // Viết chương trình liệt kê các số nguyên tố nhỏ hơn hay bằng 𝑛.
        static bool[] Eratosthenes(int N)
        {	//Hàm trả về mảng đánh dấu kiểu bool
            bool[] check = new bool[N + 1];
            for (int i = 0; i < N + 1; i++)      
                check[i] = true;
            for (int i = 2; i <= N; i++)
            {
                if (check[i] == true)
                {
                    for (int j = 2 * i; j <= N; j = j + i)
                        check[j] = false;
                }
            }
            return check;
        }
        // Bài 3 : cho biết mỗi số nguyên trong dãy 𝑎 xuất hiện bao nhiêu lần?
        static void Bai03(int[] a, int n)
        {
            int i, j, bien_dem;
            int[] Count = new int[max];
            for (i = 0; i < n; i++)
                Count[i] = -1;
            for (i = 0; i < n; i++)
            {
                bien_dem = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        bien_dem++;
                        Count[j] = 0;
                    }
                }
                if (Count[i] != 0)
                    Count[i] = bien_dem; 
            }
            for (i = 0; i < n; i++)
            {
                if (Count[i] != 0)   
                    Console.WriteLine("{0} xuat hien {1} lan", a[i], Count[i]); 
            }
        }
        // Bài 4 : mở rộng bài 3 với dãy 𝑎 chứa vừa số nguyên âm, vừa chứa số nguyên dương
        static void Bai04(int[] a, int n)
        {
            int i, j, bien_dem;
            int[] Count = new int[max];
            for (i = 0; i < n; i++)       
                Count[i] = -1;
            for (i = 0; i < n; i++)
            {
                bien_dem = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        bien_dem++;
                        Count[j] = 0;
                    }
                }
                if (Count[i] != 0)
                    Count[i] = bien_dem;
            }
            for (i = 0; i < n; i++)
            {
                if (Count[i] != 0)
                    Console.WriteLine("{0,3} : {1,3} lan", a[i], Count[i]);
            }
        }
        // Bài 5 : Đếm số lần xuất hiện ký tự trong chuỗi
        static void Bai05()
        {
            int[] count = new int[26];
            Console.Write("Nhap xau: ");
            string s = Console.ReadLine().ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 97 && s[i] <= 125 && s[i] != 32)    
                    count[s[i] - 97]++;
                
                Console.WriteLine(s[i] + ": " + count[s[i] - 97]);
            }
        }
        // Bài 6 : Lớp học
        static void Lophoc()
        {
            int[] a = { 7, 4, 2, 8, 6, 4, 2, 4 };
            int[] b = { 3, 7, 2, 1, 2, 7, 1, 4, 5 };
            int[] count = new int[11];
            for (int i = 1; i < count.Length; i++)
            {
                count[i] = 0;
                for (int j = 0; j <= count.Length; j++)
                {
                    if (a[i] == b[j]) 
                        count[i]++;
                    Console.WriteLine(count[i]++);
                }
            }
        }
        // Bài 7: phân tích ra các thừa số nguyên tố.
        static string PhantichTSNT(int N)
        {	//Hàm trả về chuỗi thừa số nguyên tố của N
            bool[] check = new bool[N + 1];
            check = Eratosthenes(N);
            string thuaso = "";
            int n = N;
            for (int i = 2; i <= n / 2 && N != 0; i++)
            {
                if (check[i])
                {
                    for (int luythua = 2; luythua < i; luythua++)
                    {
                        if (N % luythua == 0)
                        {
                            if (N == luythua)
                            {
                                thuaso += $"{luythua}";
                                N /= luythua;
                            }
                            else
                            {
                                thuaso += $"{luythua}.";
                                N /= luythua;
                            }
                        }
                    }
                }
            }
            if (thuaso == "")
                thuaso = $"{N}";
            return thuaso;
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

