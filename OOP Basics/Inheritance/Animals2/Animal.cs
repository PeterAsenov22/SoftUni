using System;

public abstract class Animal
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Genger = gender;
    }

    public string Name
    {
        get => this.name;
        protected set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get => this.age;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            this.age = value;
        }
    }

    public string Genger
    {
        get => this.gender;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this.gender = value;
        }
    }

    public abstract string ProduceSound();
    public abstract string IntroduceAnimal();
}