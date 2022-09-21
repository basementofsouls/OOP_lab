using System;

namespace laba_2
{
    public partial class Car
    {
        private const string FLAG = "FLAG{dnNqy6T%3|z3ZOZ}";
        private readonly int CarID;

        // class properties
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public int CarPrice { get; set; }
        public string CarNumber { get; private set; }
        public string CarBrand { get; set; }
        public int CarYear { get; set; }
        public static int CarCounter { get; private set; }

        // constructors

        static Car()
        {
            CarCounter = 0;
        }

        public Car()
        {
            CarPrice = 0;
            CarModel = "Undefined";
            CarColor = "Undefined";
            CarNumber = "Undefined";
            CarBrand = "Undefined";
            CarYear = 0;
            laba_2.Car.CarCounter++;
            CarID = GetHashCode();

        }

        public Car(string carModel, string carColor, int carPrice, string carNumber, string carBrand, int carYear)
        {
            CarModel = carModel;
            CarColor = carColor;
            CarPrice = carPrice;
            CarNumber = carNumber;
            CarBrand = carBrand;
            CarYear = carYear;
            CarID = GetHashCode();
        }

        private Car(int usID)
        {
            CarPrice = 0;
            CarModel = "Undefined";
            CarColor = "Undefined";
            CarNumber = "Undefined";
            CarBrand = "Undefined";
            CarYear = 0;
        }

        // methods

        public void ShowInfo() => Console.WriteLine($"{this.ToString()}; Hashed id number: {CarID}");
        public static void ChangeBrand(out string brand, string CarBrand) => brand = CarBrand;
        public int ShowCarYear() => CarYear;
        public static Car CreateCar(int Id) => new Car(Id);

    }
}