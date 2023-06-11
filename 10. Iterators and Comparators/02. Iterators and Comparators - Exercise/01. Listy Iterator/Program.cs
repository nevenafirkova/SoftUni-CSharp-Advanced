﻿using ListyIterator;

//INPUT
List<string> items = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .ToList();

//ACTION
ListyIterator<string> listyIterator = new(items);

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    switch(command)
    {
        case "Move":
            Console.WriteLine(listyIterator.Move());
            break;

        case "HasNext":
            Console.WriteLine(listyIterator.HasNext());
            break;

        case "Print":
            listyIterator.Print();
            break;
    }
}