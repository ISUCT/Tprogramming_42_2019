using System;

public abstract class Vehicle
{
    private int age;
    public Vehicle()
    : this("Неизвестно")
    {
    }

    public Animal(string name)
        : this(name, 0)
    {
    }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            if (value >= 0 && value < 20)
            {
                this.age = value;
            }
            else
            {
                throw new System.Exception();
            }
        }
    }

    public string Name { get; set; }

    public void Aging()
    {
        this.age++;
    }

    public abstract void Voice();
}
