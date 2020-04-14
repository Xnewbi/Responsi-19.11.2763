using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(    "Nama     : Dian Pratama");
            Console.WriteLine("NIM      : 19.11.2763");
            Console.WriteLine("Kelas    : Informatika 03");
            Console.WriteLine("");

            Karyawan karyawan1 = new Karyawan();
            Karyawan karyawan2 = new Karyawan();
            Karyawan karyawan3 = new Karyawan();

            karyawan1.No = 1;
            karyawan1.Nik = 19112763;
            karyawan1.Nama = "Dian Pratama  ";
            karyawan1.Gaji = 2000000;

            karyawan2.No = 2;
            karyawan2.Nik = 65747377;
            karyawan2.Nama = "Reyhan A      ";
            karyawan2.Gaji = 1000000;

            karyawan3.No = 3;
            karyawan3.Nik = 54636222;
            karyawan3.Nama = "Al-Zahran     ";
            karyawan3.Gaji = -109990;

            Console.WriteLine("No |NIK      |Nama             |Gaji       ");
            Console.WriteLine("==========================================");
            karyawan1.InfoKaryawan();
            karyawan2.InfoKaryawan();
            karyawan3.InfoKaryawan();
            Console.WriteLine("");
            Console.WriteLine("Kenaikan Gaji Bulan ini 20%");
            Console.WriteLine("");
            Console.WriteLine("No |   NIK   |Nama             |Gaji     ");
            Console.WriteLine("==========================================");
            karyawan1.BonusGaji();
            karyawan2.BonusGaji();
            karyawan3.BonusGaji();
	}
	public class Karyawan
    {
        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }

       

        public void InfoKaryawan()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}  | {1}|{2}   |{3}        ", No, Nik, Nama, Gaji);
            
        }

        public void BonusGaji()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }

            Console.WriteLine("{0}  | {1}|{2}   |{3}        ", No, Nik, Nama, Gaji*0.2+Gaji);

        }


    }
}