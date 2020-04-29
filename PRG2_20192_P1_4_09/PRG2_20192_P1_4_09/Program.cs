using System;

namespace PRG2_20192_P1_4_09
{
    class Program
    {
        static void Main()
        {
            ulang: 
            Console.Clear();
            
            Console.WriteLine("MENU SEGITIGA SIKU-SIKU\na. Hitung Luas\nb. Hitung Hipotunesa\nc. Hitung Keliling\nd. Keluar");
            Console.Write("\nMenu pilihan : ");
            char pil = Convert.ToChar(Console.ReadLine());

            switch (pil)
            {
                case 'a': Luas(); break;
                case 'b': Hipotunesa(); break;
                case 'c': Keliling(); break;
                case 'd': Console.Clear(); break;
                default: Console.WriteLine("Pilihan tidak ada"); goto ulang;             
            }

        static void Luas()
            {
                Console.WriteLine("\nLUAS SEGITIGA");
            
                Console.Write("Masukkan alas   : ");
                double a = Convert.ToDouble(Console.ReadLine());
            
                Console.Write("Masukkan tinggi : ");
                double t = Convert.ToDouble(Console.ReadLine());

                double l = (a * t) / 2;
                l = Math.Round(l, 2);

                Console.WriteLine("Luas segitiga dengan alas {0} satuan dan tinggi {1} satuan adalah {2} satuan", a, t, l);
                _ = Console.ReadKey();
                Main();
            }

        static void Hipotunesa()
            {
                Console.Write("Masukkan alas   : ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan tinggi : ");
                double t = Convert.ToDouble(Console.ReadLine());

                double h = (a * a) + (t * t);
                double hasil = Math.Sqrt(Convert.ToInt32(h));
                hasil = Math.Round(hasil, 2);

                Console.WriteLine("Hipotunesa dengan alas {0} satuan dan tinggi {1} satuan adalah {2} satuan", a, t, hasil);
                _ = Console.ReadKey();
                Main();
            }

        static void Keliling()
            {
                Console.Write("Masukkan alas       : ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan tinggi     : ");
                double t = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan hipotunesa : ");
                double h = Convert.ToDouble(Console.ReadLine());

                double k = a + t + h;
                k = Math.Round(k, 2);

                Console.WriteLine("Keliling dari segitiga dengan alas {0} satuan dan tinggi {1} satuan serta hipotunesa {2} satuan adalah {3} satuan", a, t, h, k);
                _ = Console.ReadKey();
                Main();
            }
        }
    }
}
