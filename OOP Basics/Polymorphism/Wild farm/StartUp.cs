namespace Wild_farm
{
    using System;
    using Wild_farm.AnimalModels;
    using Wild_farm.FoodModels;

    public class StartUp
    {
        public static void Main()
        {
            Animal animal = null;
            var input = Console.ReadLine();
            while (input!="End")
            {
                var animalParams = input.Split(new[] {' ',}, StringSplitOptions.RemoveEmptyEntries);
                if (animalParams.Length == 5)
                {
                    animal = new Cat(animalParams[1],animalParams[0],double.Parse(animalParams[2]),animalParams[3],animalParams[4]);
                }
                else
                {
                    if (animalParams[0] == "Tiger")
                    {
                        animal = new Tiger(animalParams[1],animalParams[0],double.Parse(animalParams[2]),animalParams[3]);
                    }
                    else if (animalParams[0] == "Zebra")
                    {
                        animal = new Zebra(animalParams[1], animalParams[0], double.Parse(animalParams[2]), animalParams[3]);
                    }
                    else
                    {
                        animal = new Mouse(animalParams[1], animalParams[0], double.Parse(animalParams[2]), animalParams[3]);
                    }
                }

                animal.MakeSound();
                var foodParams = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Food food = null;
                if (foodParams[0] == "Vegetable")
                {
                    food = new Vegetable(int.Parse(foodParams[1]));
                }
                else
                {
                    food = new Meat(int.Parse(foodParams[1]));
                }

                try
                {
                    animal.Eat(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine(animal.ToString());
              
                input = Console.ReadLine();
            }
        }
    }
}
