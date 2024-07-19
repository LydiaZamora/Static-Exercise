namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);

            Console.WriteLine($"Celsius {celsius} degrees");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"Fahrenheit {fahrenheit} degrees");
        }
    }
}
