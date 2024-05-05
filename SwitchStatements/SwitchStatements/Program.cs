﻿// See https://aka.ms/new-console-template for more information

//Switch Statement on Types

using System.Runtime.CompilerServices;

List<object> testObjects = GetValueTypeObjects();
int count = 1;
foreach (object obj in testObjects)
{
    Console.Write($"Object [{count}] is type of: ");
    switch (obj)
    {        
        case bool:
            Console.Write("Bool");            
            break;
        case long:
            Console.Write("Long");            
            break;
        default:
            Console.Write(obj.GetType().FullName);
            break;
    }
    Console.WriteLine($" with Value: {obj.ToString()}");
    count++;
}

List<object> GetValueTypeObjects()
{
    bool b = true;
    byte bits = 8;
    char c = 'c';
    decimal m = 10.0m;
    double d = 2.0d;
    float f = 15.2f;
    long l = long.MaxValue;
    int i = 1;

    List<object> testObjects = new List<object> { b, bits,c, m, d, f, l, i, 32 /* is Default Int32*/};
    return testObjects;
}

