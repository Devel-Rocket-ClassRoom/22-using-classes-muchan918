using System;

class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, {Name}입니다. {Age}살입니다.");
    }
    public Person()
    {

    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void SetFriend(Person friend)
    {
        friend.PrintFriendInfo(this);
    }

    public void PrintFriendInfo(Person person)
    {
        Console.WriteLine($"{Name}의 친구는 {person.Name}입니다.");
    }
}