namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Google
    {
        public static void Main()
        {
            var persons = new List<Person>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var inputParams = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (persons.Any(x => x.Name == inputParams[0]))
                {
                    var person = persons.First(x => x.Name == inputParams[0]);
                    AddData(inputParams,person);
                }
                else
                {
                    var person = new Person();
                    person.Name = inputParams[0];
                    AddData(inputParams,person);
                    persons.Add(person);
                }

                input = Console.ReadLine();
            }

            var personName = Console.ReadLine();
            if (persons.Any(x => x.Name == personName))
            {
                var person = persons.First(x => x.Name == personName);
                Console.WriteLine(person.Name);
                Console.WriteLine("Company:");
                if (person.Company.ToString() != string.Empty)
                {
                    Console.WriteLine(person.Company.ToString());
                }
                Console.WriteLine("Car:");
                if (person.Car.ToString() != string.Empty)
                {
                    Console.WriteLine(person.Car.ToString());
                }
                Console.WriteLine("Pokemon:");
                foreach (var pokemon in person.Pokemons)
                {
                    if (pokemon.ToString() != string.Empty)
                    {
                        Console.WriteLine(pokemon.ToString());
                    }
                }
                Console.WriteLine("Parents:");
                foreach (var parent in person.Parents)
                {
                    if (parent.ToString() != string.Empty)
                    {
                        Console.WriteLine(parent.ToString());
                    }
                }
                Console.WriteLine("Children:");
                foreach (var child in person.Children)
                {
                    if (child.ToString() != string.Empty)
                    {
                        Console.WriteLine(child.ToString());
                    }
                }
            }
        }

        private static void AddData(string[] inputParams, Person person)
        {
            if (inputParams[1] == "company")
            {
                var companyName = inputParams[2];
                var companyDepartment = inputParams[3];
                var salary = double.Parse(inputParams[4]);

                var company = new Company(companyName, companyDepartment, salary);
                person.Company = company;
            }
            else if (inputParams[1] == "pokemon")
            {
                var pokemonName = inputParams[2];
                var pokemonType = inputParams[3];
                var pokemon = new Pokemon(pokemonName, pokemonType);
                person.Pokemons.Add(pokemon);
            }
            else if (inputParams[1] == "parents")
            {
                var parentName = inputParams[2];
                var parentBirthday = inputParams[3];
                var parent = new Parent(parentName,parentBirthday);
                person.Parents.Add(parent);
            }
            else if (inputParams[1] == "children")
            {
                var childName = inputParams[2];
                var childBirthday = inputParams[3];
                var child = new Child(childName, childBirthday);
                person.Children.Add(child);
            }
            else if (inputParams[1] == "car")
            {
                var carModel = inputParams[2];
                var carSpeed = int.Parse(inputParams[3]);
                var car = new Car(carModel,carSpeed);
                person.Car = car;
            }
        }
    }
}
