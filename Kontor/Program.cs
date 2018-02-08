using System;
using System.Threading;

namespace Kontor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Kes sa oled?\n1. Andmetöötleja\n2. Koristaja\n3. Nooremarendaja\n4. SpetsiaalKoristaja\n5. Vanemarendaja\n6. Ülemus\n7. Exit");
                string Töötaja = Console.ReadLine();
                if (Töötaja == "7")
                {
                    break;
                }
                Console.WriteLine(Töötaja);
                Console.WriteLine("Mis ruumi soovid minna?\n1. Peauks\n2. Arendajate ruum\n3. Ülemuste ruum\n4. Köök\n5. Andmetöötlejate ruum");
                string Tuba = Console.ReadLine();
                var Klass0 = new Klassi_Valik();
                var Klass1 = Klass0.Vali(Töötaja); //See isegi töötas?

                switch (Tuba)
                {
                    case "1": //peauks
                        if (Klass1.PeaUks_Access) //See isegi töötab?
                        {
                            Console.WriteLine("Tere tulemast pea ukse juurde");
                        }
                        else
                        {
                            Console.WriteLine("Access denied");
                        }
                        break;
                    case "2": //arendajate ruum
                        if (Klass1.ArendajateRuum_Access)
                        {
                            Console.WriteLine("Tere tulemast Arendajate ruumi");
                        }
                        else
                        {
                            Console.WriteLine("Access denied");
                        }
                        break;
                    case "3": //ülemuste ruum
                        if (Klass1.ÜlemusteRuum_Access)
                        {
                            Console.WriteLine("Tere tulemast ülemuste ruumi");
                        }
                        else
                        {
                            Console.WriteLine("Access denied");
                        }
                        break;
                    case "4": //köök
                        if (Klass1.Köök_Access)
                        {
                            Console.WriteLine("Tere tulemast kööki");
                        }
                        else
                        {
                            Console.WriteLine("Access denied");
                        }
                        break;
                    case "5": //andmetöötlejate ruum
                        if (Klass1.AndmetöötlejateRuum_Access)
                        {
                            Console.WriteLine("Tere tulemast andmetöötlejate ruumi");
                        }
                        else
                        {
                            Console.WriteLine("Access denied");
                        }
                        break;
                    default:
                        break;
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
