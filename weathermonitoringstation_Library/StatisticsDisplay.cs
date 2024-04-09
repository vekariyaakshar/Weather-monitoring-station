namespace weathermontitoringsystem_Library
{
    /// <summary>
    /// Represents a display element focused on showing statistical information about weather conditions,
    /// such as minimum, maximum, and average temperatures, by implementing the IDisplay interface.
    /// This class subscribes to updates from Weather_Data to compute and display these statistics.
    /// </summary>
    public class Statistics_Display : IDisplay
    {
        private Weather_Data weatherData;

        /// <summary>
        /// Initializes a new instance of the Statistics_Display class, subscribing to the weatherData's update events
        /// to calculate and display weather statistics.
        /// </summary>
        /// <param name="weatherData">The Weather_Data object this display will use to gather weather information.</param>
        public Statistics_Display(Weather_Data weatherData)
        {
            this.weatherData = weatherData;
            // Subscription to weatherData's events would typically be done here.
            // For example: weatherData.UpdateEvent += OnWeatherDataUpdated;
        }

        // Given that your provided code snippet is incomplete, I'll assume there's a method that gets called to display the statistics.
        /// <summary>
        /// Displays the statistical weather information, including minimum, maximum, and average temperatures.
        /// </summary>
        public void Display()
        {
            // Assuming minTemperature, maxTemperature, and averageTemperature are calculated or updated elsewhere within this class,
            // the implementation here would display those statistics. Example:
            Console.WriteLine("Weather Statistics:");
            // Console.WriteLine($"Max Temperature: {maxTemperature}°C");
            // Console.WriteLine($"Min Temperature: {minTemperature}°C");
            // Console.WriteLine($"Avg Temperature: {averageTemperature}°C");
            Console.WriteLine();
        }
    }
}
