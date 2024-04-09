namespace weathermontitoringsystem_Library
{
    public class Forecast_Display : IDisplay
    {
        private Weather_Data weatherData;

        public Forecast_Display(Weather_Data weatherData)
        {
            this.weatherData = weatherData;
            // Subscribe to weatherData's events
        }

        public void Display()
        {
            Console.WriteLine("Weather Forecast:");
            // Implement logic to generate and display weather forecast
            Console.WriteLine("Sunny with a chance of clouds");
            Console.WriteLine();
        }
    }
}