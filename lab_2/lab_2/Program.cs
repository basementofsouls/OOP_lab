using System;

namespace laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondTask();
            ThirdTask();
            FourthTask();
        }

        public static void SecondTask()
        {
            var car1 = new Car();
            var car2 = new Car("Chevrolet", "Black", 2700, "5674OA-7", "Impala", 1967);

            Console.WriteLine(car1.Equals(car2) ? "Идентичны" : "Не идентичны");
            Console.WriteLine($"Type of car1 - {car1.GetType()}");

            car2.ShowInfo();

            Console.WriteLine("Ref and Out Parametres :");
            int car_year = car2.CarYear;
            car2.CarYear = car_year;
            Console.WriteLine(car2.CarYear);

            Car.ChangeBrand(out string brand, "Lancer");
            car2.CarBrand = brand;
            Console.WriteLine(car2.CarBrand);
        }
        public static void ThirdTask()
        {
            var Cars = new Car[4];
            Cars[0] = new Car("Mitsubishi", "Metalic", 20000, "390JJ", "Lancer", 2002);
            Cars[1] = new Car("Alfa", "Black", 4730, "0223", "Romeo", 2018);
            Cars[2] = new Car("Nissan", "Blue", 4200, "3920", "Almera", 1999);
            Cars[3] = new Car("Audi", "Red", 15800, "3920", "A6", 2001);

            foreach (var car in Cars)
                if (car.CarNumber == "0223")
                    Console.WriteLine(car.CarPrice);

            Console.WriteLine("Cars older 10 years:");
            foreach (var car in Cars)
                if (2022 - car.ShowCarYear() > 10)
                    Console.WriteLine($"{car.CarModel} : {car.CarYear}");

        }

        public static void FourthTask()
        {
            var RandomCar = new { Brand = "Renault", Model = "Laguna", Color = "Gray" };
            Console.WriteLine($"Car: {RandomCar.Brand} {RandomCar.Model} {RandomCar.Color}");
        }
      
    }
}