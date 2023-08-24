using System;

namespace TekliSayi
{
    class Program
    {
        //XOR işlemi 
        static int TekliSayi(int[] sayilar)
        {
            int result = 0; //0'la hir sayı XOR'landığında kendisini verdiğinden resultı başta 0 yaptım
            foreach (int c in sayilar) 
            {
                result ^= c; //Dizideki elemanları result ile XOR işlemine sokuyorum
            }
            return result;
        }
        

        static void Main(string[] args)
        {
            int[] sayi= { 5, 7, 8, 8, 5 };
            int ts = TekliSayi(sayi); //TekliSayi fonksiyonuna sayi dizisini atıyorum, sayılar XOR'lanıyor ve tek olan sayı ts'ye atanıyor
            Console.WriteLine("Tek Sayı: " + ts);
        }
    }
}


/* 0000 ^ 0101 = 0101 
  0101^ 0111 = 0010 
  0010^ 1000 = 1010
  1010^ 1000 = 0010
  0010^0101 = 0111 result=7 */
