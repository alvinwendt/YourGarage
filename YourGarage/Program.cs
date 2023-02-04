namespace YourGarage
{
    internal class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            List<Aircraft> allAircrafts = new List<Aircraft> { new F16(), new WrightFlyer() };

            // With a single `foreach`, have each vehicle Fly()
            foreach (var aircraft in allAircrafts)
            {
                aircraft.Flying();
             }

            // Build a collection of all vehicles that operate on roads
            List<Car> allCars = new List<Car> { new NissanLeaf(), new Ferrari() };
            // With a single `foreach`, have each road vehicle Drive()

            foreach (Car car in allCars)
            {
                car.Driving();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            List<Watercraft> allWaterCraft = new List<Watercraft> { new Titanic(), new Mayflower() };

            foreach (Watercraft watercraft in allWaterCraft)
            {
                watercraft.Embarking();
            }
        }
    }
}