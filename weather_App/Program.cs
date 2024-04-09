namespace weathermonitoringsystem.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather_Station weatherStation = new Weather_Station();

            // Create display objects
            IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions");
            IDisplay statisticsDisplay = weatherStation.CreateDisplay("Statistics");
            IDisplay forecastDisplay = weatherStation.CreateDisplay("Forecast");

            // Update weather data multiple times to generate temperature history
            for (int i = 0; i < 10; i++)
            {
                Weather_Data.Instance.UpdateWeatherData();
            }

            // Display weather data
            currentConditionsDisplay.Display();
            statisticsDisplay.Display();
            forecastDisplay.Display();
        }
    }
}






