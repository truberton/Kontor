namespace Kontor
{
    class Klassi_Valik
    {
        public dynamic Vali(string Töötaja)
        {
            switch (Töötaja)
            {
                case "1":
                    var Klass = new Andmetöötleja();
                    return Klass;
                case "2":
                    var Klass1 = new Koristaja();
                    return Klass1;
                case "3":
                    var Klass2 = new NooremArendaja();
                    return Klass2;
                case "4":
                    var Klass3 = new SpetsiaalKoristaja();
                    return Klass3;
                case "5":
                    var Klass4 = new VanemArendaja();
                    return Klass4;
                case "6":
                    var Klass5 = new Ülemus();
                    return Klass5;
                default:
                    return "Tere";
            }
        }
    }
}
