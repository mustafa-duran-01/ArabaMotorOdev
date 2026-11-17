namespace ArabaMotorOdev
{
    class Motor
    {
        public string Model { get; set; }
        public int BeygirGucu { get; set; }

        public Motor(string model, int beygirGucu)
        {
            Model = model;
            BeygirGucu = beygirGucu;
        }

        public void Calistir()
        {
            Console.WriteLine($"{Model} ({BeygirGucu} HP) motor çalıştırıldı.");
        }
    }

    // Bu ilişki Composition'dır (Inheritance değildir).
    // Çünkü Araba bir Motor değildir (is-a ilişkisi yok), Araba'nın bir Motor'u vardır (has-a ilişkisi var).
    // Yani Araba sınıfı Motor sınıfından kalıtım almaz, içinde bir Motor nesnesi barındırır.
    class Araba
    {
        public string Marka { get; set; }
        public Motor Motor { get; private set; }

        public Araba(string marka, Motor motor)
        {
            Marka = marka;
            Motor = motor;
        }

        public void Calistir()
        {
            Console.WriteLine($"{Marka} marka araba çalıştırılıyor...");
            Motor.Calistir();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Motor motor1 = new Motor("1.6 TDI", 115);
            Araba araba1 = new Araba("Volkswagen", motor1);

            araba1.Calistir();
        }
    }
}
