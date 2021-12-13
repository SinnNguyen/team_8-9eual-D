using System; 

namespace Buoi_7 
{
    class Program           
    {
        static int Menu()
        {
            Console.WriteLine();
            Console.WriteLine("SAP XEP & TIM KIEM TREN DAY");
            Console.WriteLine(" 1. Tao day a        2. Xuat dãy");
            Console.WriteLine(" 3. InterChangSort   4. BubbleSort");
            Console.WriteLine(" 5. Bai 3      6. Bai 4     7. Bai 5      8. Bai 6");
            Console.WriteLine(" 9. Bai 7     10. Bai 8    11. Bai 9 : BubbleSort2");
            Console.WriteLine(" 0. Thoat");
            Console.Write(" Chon : ");  int chon = int.Parse(Console.ReadLine());
            return chon;
        }
        // Tạo dãy ngẫu nhiên
        static void RandomArray(int[] a, int n)
        {    
            Random rd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rd.Next(1, 100);
            Console.WriteLine();
        }
        //Xuất dãy
        static void PrintArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(" " + a[i]);
        }
        static void Swap(ref int x, ref int y)
        {
            int tmp = x; 
            x = y; 
            y = tmp;
        }
        // Bài 1 : InterchangeSort

        // Bài 2 : BubbleSort

        // Bài 3 : sắp xếp dãy tăng dần trong đoạn (left, right)

        // Bài 4 : tìm phần tử lớn thứ k

        // Bài 5 : tìm phần tử chẳn trong dãy số nguyên a(n)

        // Bài 6 : Hãy cho biết trong dãy 𝑎 có tồn tại cặp chỉ số 𝑖, 𝑗 mà 𝑖 < 𝑗 và 𝑎𝑖 + 𝑎𝑗 = 0 ?

        // Bài 7 : Trộn 2 dãy a, b tăng dần thành dãy c tăng dần

        // Bài 8 : Sắp xếp các phần tử vị trí lẻ tăng dần, các phần tử vị trí chẳn giảm dần

        // Bài 9 : BubbleSort2
 
        static void Main(string[] args)
        {
            int[] a = new int[5000];
            Console.Write("  Nhap so phan tu: ");
            int N = int.Parse(Console.ReadLine());

            int chon = 0; 
            do 
            {
                chon = Menu();
                switch(chon) 
                {
                    case 1: 
                    {
                        RandomArray(a, N); 
                        Console.Write(" Day a: "); 
                        PrintArray(a, N); 
                    } break;
                    case 2:
                    {
                        Console.Write(" Day a: "); 
                        PrintArray(a, N);
                    } break;
                    case 3: 
                    {
                        
                    } break; 
                } 
            } while (chon >= 1 && chon <= 11);
        }
    }
}