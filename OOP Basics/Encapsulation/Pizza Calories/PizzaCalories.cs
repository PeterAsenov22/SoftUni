namespace Pizza_Calories
{
    using System;

    public class PizzaCalories
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            if (inputParams[0] == "Pizza")
            {
                try
                {
                    var pizzaParams = inputParams;
                    var pizzaName = pizzaParams[1];
                    var pizzaToppings = int.Parse(pizzaParams[2]);

                    var pizza = new Pizza(pizzaName, pizzaToppings);
                    var doughParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    var dough = new Dough(doughParams[1].ToLower(), doughParams[2].ToLower(),
                        double.Parse(doughParams[3]));
                    pizza.Dough = dough;

                    var input = Console.ReadLine();
                    while (input != "END")
                    {
                        var toppingParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                        var topping = new Topping(toppingParams[1], double.Parse(toppingParams[2]));
                        pizza.AddTopping(topping);

                        input = Console.ReadLine();
                    }

                    Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                string input=string.Join(" ",inputParams);
                while (input!="END")
                {
                    var inputParam = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    if (inputParam[0] == "Dough")
                    {
                        try
                        {
                            var dough = new Dough(inputParam[1].ToLower(), inputParam[2].ToLower(), double.Parse(inputParam[3]));
                            Console.WriteLine($"{dough.GetCalories():F2}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                    }
                    else
                    {
                        try
                        {
                            var topping = new Topping(inputParam[1],double.Parse(inputParam[2]));
                            Console.WriteLine($"{topping.GetCalories():F2}");
                        }
                        catch (ArgumentException ex)
                        { 
                            Console.WriteLine(ex.Message);
                            return;
                        }
                    }

                    input = Console.ReadLine();
                }
            }
        }
    }
}
