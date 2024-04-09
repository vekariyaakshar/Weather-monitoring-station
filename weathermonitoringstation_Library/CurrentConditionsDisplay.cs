namespace weathermontitoringsystem_Library
{
    public class CurrentConditions_Display : IDisplay
    {
        private Weather_Data weatherData;

        public CurrentConditions_Display(Weather_Data weatherData)
        {
            this.weatherData = weatherData;
        }
        public void Display()
        {
            Console.WriteLine("Current Weather Conditions:");
            Console.WriteLine($"Temperature: {weatherData.Temperature}°C");
            Console.WriteLine($"Humidity: {weatherData.Humidity}%");
            Console.WriteLine($"Wind Speed: {weatherData.WindSpeed} km/h");
            Console.WriteLine();
        }
    }
}