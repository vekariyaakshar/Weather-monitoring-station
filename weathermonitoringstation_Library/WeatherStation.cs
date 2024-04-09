namespace weathermontitoringsystem_Library
{
    /// <summary>
    /// Represents a weather station in the weather monitoring system.
    /// This class is responsible for creating display elements based on the specified display type.
    /// </summary>
    public class Weather_Station
    {
        /// <summary>
        /// Creates a display element based on the specified display type.
        /// </summary>
        /// <param name="displayType">The type of display to create.</param>
        /// <returns>An instance of the IDisplay interface representing the created display element.</returns>
        public IDisplay CreateDisplay(string displayType)
        {
            // Obtain the singleton instance of Weather_Data
            Weather_Data weatherData = Weather_Data.Instance;

            switch (displayType)
            {
                // Case statements for different display types would go here
                // For example:
                // case "current":
                //     return new CurrentConditions_Display(weatherData);
                // case "forecast":
                //     return new Forecast_Display(weatherData);
                // case "statistics":
                //     return new Statistics_Display(weatherData);
                // default:
                //     throw new ArgumentException("Invalid display type", nameof(displayType));
                default:
                    throw new ArgumentException("Invalid display type", nameof(displayType));
            }
        }
    }
}
