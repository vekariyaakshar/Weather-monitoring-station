namespace weathermontitoringsystem_Library
{
    /// <summary>
    /// Defines a display element interface for the weather monitoring system.
    /// Implementers of this interface are responsible for displaying weather information.
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        /// Displays the current weather conditions or forecasts.
        /// This method should be implemented by classes to show specific weather data in a user-friendly manner.
        /// </summary>
        void Display();
    }
}
