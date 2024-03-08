﻿
using System;
interface Animal
{
    public void Size()
    {
        Console.WriteLine("Animal is huge.");
    }
}
interface Carnivorous
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating meat.");
    }
}

class Lion : Animal, Carnivorous
{
    public void Size()
    {
        Console.WriteLine("The size of the lion is huge.");
    }
    public void Eat()
    {
        Console.WriteLine("The lion is a carnivore.");
    }
}

class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine("Bird is flying.");
    }
}

class Eagle : Bird
{
    public void Hunt()
    {
        Console.WriteLine("Eagle is hunting.");
    }
}

class Penguin : Bird
{
    public void Swim()
    {
        Console.WriteLine("Penguin is swimming.");
    }
}


// multi-level inheritance
class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Mammal is running.");
    }
}

class Horse : Mammal
{
    public void Gallop()
    {
        Console.WriteLine("Horse is galloping.");
    }
}


interface I1
{
    void Method1();
}

interface I2
{
    void Method2();
}

class MyClass : I1, I2
{
    public void Method1()
    {
        Console.WriteLine("Method1 is called.");
    }

    public void Method2()
    {
        Console.WriteLine("Method2 is called.");
    }
}

