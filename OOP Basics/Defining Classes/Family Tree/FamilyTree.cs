namespace Family_Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FamilyTree
    {
        public static void Main()
        {
            var persons = new List<Person>();
            var wantedPerson = Console.ReadLine();
            var wantedPersonParams = wantedPerson.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();
            string wantedPersonName = string.Empty;
            string wantedPersonBirthday = string.Empty;
            if (wantedPersonParams.Length == 2)
            {
                wantedPersonName = $"{wantedPersonParams[0]} {wantedPersonParams[1]}";
            }
            else
            {
                wantedPersonBirthday = wantedPerson;
            }

            var input = Console.ReadLine();
            while (input != "End")
            {
                if (input.Contains('-'))
                {
                    var inputParams = input.Split(new []{'-'},StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();
                    if (!inputParams[0].Contains('/') && !inputParams[1].Contains('/'))
                    {
                        Person firstPerson;
                        Person secondPerson;
                        var nameParams1 = inputParams[0].Split(' ').Select(x => x.Trim()).ToArray();
                        var name1 = $"{nameParams1[0]} {nameParams1[1]}";
                        var nameParams2 = inputParams[1].Split(' ').Select(x => x.Trim()).ToArray();
                        var name2 = $"{nameParams2[0]} {nameParams2[1]}";
                        if (persons.Any(x => x.Name == name1))
                        {
                            firstPerson = persons.First(x => x.Name == name1);
                        }
                        else
                        {
                            var person = new Person();
                            person.Name = name1;
                            persons.Add(person);
                            firstPerson = person;
                        }

                        if (persons.Any(x => x.Name == name2))
                        {
                            secondPerson = persons.First(x => x.Name == name2);
                        }
                        else
                        {
                            var person = new Person();
                            person.Name = name2;
                            persons.Add(person);
                            secondPerson = person;
                        }

                        firstPerson.Children.Add(secondPerson);
                        secondPerson.Parents.Add(firstPerson);
                    }
                    else if (!inputParams[0].Contains('/') && inputParams[1].Contains('/'))
                    {
                        Person firstPerson;
                        Person secondPerson;
                        var nameParams = inputParams[0].Split(' ').Select(x => x.Trim()).ToArray();
                        var name = $"{nameParams[0]} {nameParams[1]}";
                        if (persons.Any(x => x.Name == name))
                        {
                            firstPerson = persons.First(x => x.Name == name);
                        }
                        else
                        {
                            var person = new Person();
                            person.Name = name;
                            persons.Add(person);
                            firstPerson = person;
                        }

                        if (persons.Any(x => x.Birthday == inputParams[1]))
                        {
                            secondPerson = persons.First(x => x.Birthday == inputParams[1]);
                        }
                        else
                        {
                            var person = new Person();
                            person.Birthday = inputParams[1];
                            persons.Add(person);
                            secondPerson = person;
                        }

                        firstPerson.Children.Add(secondPerson);
                        secondPerson.Parents.Add(firstPerson);
                    }
                    else if (!inputParams[1].Contains('/') && inputParams[0].Contains('/'))
                    {
                        Person firstPerson;
                        Person secondPerson;
                        var nameParams = inputParams[1].Split(' ').Select(x => x.Trim()).ToArray();
                        var name = $"{nameParams[0]} {nameParams[1]}";

                        if (persons.Any(x => x.Name == name))
                        {
                            secondPerson = persons.First(x => x.Name == name);
                        }
                        else
                        {
                            var person = new Person();
                            person.Name = name;
                            persons.Add(person);
                            secondPerson = person;
                        }

                        if (persons.Any(x => x.Birthday == inputParams[0]))
                        {
                            firstPerson = persons.First(x => x.Birthday == inputParams[0]);
                        }
                        else
                        {
                            var person = new Person();
                            person.Birthday = inputParams[0];
                            persons.Add(person);
                            firstPerson = person;
                        }

                        firstPerson.Children.Add(secondPerson);
                        secondPerson.Parents.Add(firstPerson);
                    }
                    else if (inputParams[0].Contains('/') && inputParams[1].Contains('/'))
                    {
                        Person firstPerson;
                        Person secondPerson;
                        if (persons.Any(x => x.Name == inputParams[0]))
                        {
                            firstPerson = persons.First(x => x.Birthday == inputParams[0]);
                        }
                        else
                        {
                            var person = new Person();
                            person.Birthday = inputParams[0];
                            persons.Add(person);
                            firstPerson = person;
                        }

                        if (persons.Any(x => x.Birthday == inputParams[1]))
                        {
                            secondPerson = persons.First(x => x.Birthday == inputParams[1]);
                        }
                        else
                        {
                            var person = new Person();
                            person.Birthday = inputParams[1];
                            persons.Add(person);
                            secondPerson = person;
                        }

                        firstPerson.Children.Add(secondPerson);
                        secondPerson.Parents.Add(firstPerson);
                    }
                }
                else
                {
                    var inputParams = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();
                    var name = $"{inputParams[0]} {inputParams[1]}";
                    var birthday = inputParams[2];

                    if (persons.Any(x => x.Name == name) && persons.Any(x => x.Birthday == birthday))
                    {
                        var person = persons.First(x => x.Name == name || x.Birthday == birthday);
                        if (person.Birthday == null)
                        {
                            var personWithBirthday = persons.First(x => x.Birthday == birthday);
                            person.Birthday = personWithBirthday.Birthday;
                            foreach (var parent in personWithBirthday.Parents)
                            {
                                person.Parents.Add(parent);
                            }
                            foreach (var child in personWithBirthday.Children)
                            {
                                person.Children.Add(child);
                            }

                            persons.Remove(personWithBirthday);
                        }
                        else
                        {
                            var personWithName = persons.First(x => x.Name == name);
                            person.Name = personWithName.Name;
                            foreach (var parent in personWithName.Parents)
                            {
                                person.Parents.Add(parent);
                            }
                            foreach (var child in personWithName.Children)
                            {
                                person.Children.Add(child);
                            }

                            persons.Remove(personWithName);
                        }
                    }
                    else if (persons.Any(x => x.Name == name))
                    {
                        var person = persons.First(x => x.Name == name);
                        person.Birthday = birthday;
                    }
                    else
                    {
                        var person = persons.First(x => x.Birthday == birthday);
                        person.Name = name;
                    }
                }

                input = Console.ReadLine();
            }

            Person personTree;
            if (wantedPersonName != string.Empty)
            {
                personTree = persons.First(x => x.Name == wantedPersonName);
            }
            else
            {
                personTree = persons.First(x => x.Birthday == wantedPersonBirthday);
            }

            Console.WriteLine($"{personTree.Name} {personTree.Birthday}");
            Console.WriteLine("Parents:");
            foreach (var parent in personTree.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }
            Console.WriteLine("Children:");
            foreach (var child in personTree.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }
    }
}
