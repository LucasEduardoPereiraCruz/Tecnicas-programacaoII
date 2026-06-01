// É uma classe modelo (Model) de exemplo. Serve só pra simular uma API de clima.

namespace TodoApi
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; } // Guarda só a data, sem hora //// Gaurda hora e data  - public DateTime Date { get; set; }

        public int TemperatureC { get; set; } // temperatura base em °C

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556); // Temperatura em Farenheit 

        public string? Summary { get; set; } // Descrição do clima - pode ser nulo string? 
    }
}
