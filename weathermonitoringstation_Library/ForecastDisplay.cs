namespace weathermontitoringsystem_Library
{
    /// <summary>
    /// Represents a display element that forecasts weather conditions,
    /// implementing the IDisplay interface. This class subscribes to updates from
    /// WeatherData to provide future weather condition forecasts.
    /// </summary>
    public class Forecast_Display : IDisplay
    {
        private WeatherData weatherData;

        /// <summary>
        /// Initializes a new instance of the Forecast_Display class, subscribing to the weatherData's update events to forecast weather conditions.
        /// </summary>
        /// <param name="weatherData">The WeatherData object this display will use to forecast future conditions.</param>
        public Forecast_Display(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            // Subscribe to weatherData's events. This is typically done by registering a method of this class
            // with an event on the weatherData object. For example: weatherData.UpdateEvent += UpdateForecast;
        }

        // Assuming there's a method like this, based on your incomplete snippet:
        /// <summary>
        /// Updates the weather forecast based on the latest data from the WeatherData object.
        /// </summary>
        // public void UpdateForecast()
        // {
        //     // Implementation for updating the forecast based on weatherData
        // }
    }
}
