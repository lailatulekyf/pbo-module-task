// LAILATUL EKY FITRIYANINGSIH
// 222410102019
// PBO A


using System;

namespace PR1_PBO
{
    class Processor
    {
        public string Merk;
        public string Tipe;

        public Processor(string merk, string tipe)
        {
            Merk = merk;
            Tipe = tipe;
        }
    }

    class Intel : Processor
    {
        public Intel(string tipe) : base("Intel", tipe)
        {
            Tipe = tipe;
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3() : base("Core i3")
        {

        }
    }

    class CoreI5 : Intel
    {
        public CoreI5() : base("Core i5")
        {

        }
    }

    class CoreI7 : Intel
    {
        public CoreI7() : base("Core i7")
        {

        }
    }

    class AMD : Processor
    {
        public AMD(string tipe) : base("AMD", tipe)
        {
            Tipe = tipe;
        }
    }

    class Ryzen : AMD
    {
        public Ryzen() : base("RYZEN")
        {

        }
    }

    class Athlon : AMD
    {
        public Athlon() : base("ATHLON")
        {

        }
    }

    class Vga
    {
        public string Merk;

        public Vga(string merk)
        {
            Merk = merk;
        }
    }

    class Nvidia : Vga
    {
        public Nvidia() : base("Nvidia")
        {

        }
    }

    class Amd : Vga
    {
        public Amd() : base("AMD")
        {

        }
    }

    class Laptop
    {
        public string Merk;
        public string Tipe;
        public Vga Vga { get; set; }
        public Processor Processor { get; set; }

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            Merk = merk;
            Tipe = tipe;
            Vga = vga;
            Processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
        {
            Tipe = tipe;
            Vga = vga;
            Processor = processor;
        }
    }

    class ROG : ASUS
    {
        public ROG(Vga vga, Processor processor) : base("ROG", vga, processor)
        {

        }
    }

    class Vivobook : ASUS
    {
        public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor)
        {

        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
        {
            Tipe = tipe;
            Vga = vga;
            Processor = processor;
        }
    }

    class Swift : ACER
    {
        public Swift(Vga vga, Processor processor) : base("Swift", vga, processor)
        {

        }
    }

    class Predator : ACER
    {
        public Predator(Vga vga, Processor processor) : base("Predator", vga, processor)
        {

        }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
        {
            Tipe = tipe;
            Vga = vga;
            Processor = processor;
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor)
        {

        }
    }

    class Legion : Lenovo
    {
        public Legion(Vga vga, Processor processor) : base("Legion", vga, processor)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var laptop1 = new Vivobook(new Nvidia(), new CoreI5());
            var laptop2 = new IdeaPad(new Amd(), new Ryzen());
            var predator = new Predator(new Amd(), new CoreI7());

            Console.WriteLine("---- Soal Nomer 1 ----" + "\n");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine("\n");

            Console.WriteLine("---- Soal Nomer 2 ----" + "\n");
            laptop1.Ngoding();
            Console.WriteLine("\n");

            Console.WriteLine("---- Soal Nomer 3 ----" + "\n");
            Console.WriteLine("===== SPESIFIKASI LAPTOP1 =====");
            Console.WriteLine("Merk VGA : " + laptop1.Vga.Merk);
            Console.WriteLine("Merk Processor : " + laptop1.Processor.Merk);
            Console.WriteLine("Tipe Processor : " + laptop1.Processor.Tipe);
            Console.WriteLine("\n");

            Console.WriteLine("---- Soal Nomer 4 ----" + "\n");
            predator.BermainGame();
            Console.WriteLine("\n");

            //Console.WriteLine("---- Soal Nomer 5 ----" + "\n");
            //ACER acer = new Predator(new Amd(), new Intel("Corei7"));
            //acer.BermainGame();
            //Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}