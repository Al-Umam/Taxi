using System;

namespace Tugas
{   
    public class Program
    {   
        public class taxi{

        public string DriverName = "Robert";
        public Boolean onDuty = false;
        public int NumPassenger = 10;

        public void TaxiInfo(){
            Console.WriteLine("Saya " + this.DriverName + ", benar dengan " + this.NumPassenger + "Ya? selamat menikmati perjalanan \n");
        }
        public void PickUpPassenger(){
            Console.WriteLine("Driver " + this.DriverName + " sedang menjemput penumpang \n");
        }
        public void DropOffPassenger(){
            Console.WriteLine("Driver " + this.DriverName + " selesai mengantar penumpang \n");
        }
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Objek pertama yang belum ada pengubahan property \n");

            taxi Oldtaxi = new taxi();

            Oldtaxi.TaxiInfo();
            Oldtaxi.PickUpPassenger();
            Oldtaxi.DropOffPassenger();
            Console.WriteLine("Objek kedua, setelah value property kita ubah \n");

            taxi Ntaxi = new taxi();

            Ntaxi.DriverName = "Kowalski";
            Ntaxi.onDuty = true;
            Ntaxi.NumPassenger = 10;

            Ntaxi.TaxiInfo();
            Ntaxi.PickUpPassenger();
            Ntaxi.DropOffPassenger();

        }
    }
}