namespace weathermontitoringsystem_Library
{
    /// <summary>
    /// Represents a display element that can show the current weather conditions,
    /// implementing the IDisplay interface.
    /// </summary>
    public class CurrentConditions_Display : IDisplay
    {
        private Weather_Data weatherData;

        /// <summary>
        /// Initializes a new instance of the CurrentConditions_Display class with a reference to a Weather_Data object.
        /// </summary>
        /// <param name="weatherData">The Weather_Data object this display uses to show current conditions.</param>
        public CurrentConditions_Display(Weather_Data weatherData)
        {
            this.weatherData = weatherData;
        }

        /// <summary>
        /// Displays the current weather conditions to the console, including temperature, humidity, and wind speed.
        /// </summary>
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
