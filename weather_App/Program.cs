namespace weathermonitoringsystem.App
{
    /// <summary>
    /// Represents the entry point for the weather monitoring system application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point for the weather monitoring system application.
        /// </summary>
        /// <param name="args">Command-line arguments provided to the application.</param>
        static void Main(string[] args)
        {
            // Create a Weather_Station instance to manage weather-related functionalities
            Weather_Station weatherStation = new Weather_Station();

            // Create display objects
            IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions");
            IDisplay statisticsDisplay = weatherStation.CreateDisplay("Statistics");
            IDisplay forecastDisplay = weatherStation.CreateDisplay("Forecast");

            // Display weather information
            currentConditionsDisplay.Display();
            statisticsDisplay.Display();
            forecastDisplay.Display();
        }
    }
}





