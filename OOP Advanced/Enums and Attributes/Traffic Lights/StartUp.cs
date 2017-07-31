namespace Traffic_Lights
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var trafficLight = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentLights = trafficLight.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var newTrafficLight = new StringBuilder();

                for (int j = 0; j < currentLights.Length; j++)
                {
                    Lights currentLight = (Lights)Enum.Parse(typeof(Lights), currentLights[j]);
                    Lights nextLight = 
                        (Lights) Enum.ToObject(typeof(Lights), ((int) currentLight + 1) % 3);
                    newTrafficLight.Append($"{nextLight} ");
                }

                Console.WriteLine(newTrafficLight.ToString().Trim());
                trafficLight = newTrafficLight.ToString().Trim();
            }
        }
    }
}
