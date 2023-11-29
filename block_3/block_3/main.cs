using System;
using System.Reflection;
class Program
{
    static void Main()
    {
        string dllFileName = "LibTempConverter.dll";

        Assembly assembly = Assembly.LoadFrom(dllFileName);

        object converterInstance = Activator.CreateInstance(assembly.GetType("TemperatureConverterLibrary.TemperatureConverter"));

        Console.Write("Temperature in Celsius: ");
        double celsiusValue;
        if (!double.TryParse(Console.ReadLine(), out celsiusValue))
        {
            Console.WriteLine("Incorrect answer. Be kind, enter a numeric value.");
            return;
        }

        MethodInfo methodInfo = converterInstance.GetType().GetMethod("CelsiusToFahrenheit");
        double fahrenheitValue = (double)methodInfo.Invoke(converterInstance, new object[] { celsiusValue });

        Console.WriteLine($"{celsiusValue} degrees Celsius = {fahrenheitValue} degrees Fahrenheit");

        Console.ReadLine();
    }
}