Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);


Dog neighboursDog = new Dog("Good girl");


Console.WriteLine($"My dogs name is {myDog._name}");
Console.WriteLine($"My neighbours dogs name is {neighboursDog._name}.");

myDog.Rename("Bad Boy");
Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
} 

myDog.WagTail();
class Dog
{
    public string _name;
    public int _levelOfHapiness; 


    public Dog(string name) 
    {
        _name = name; 
        _levelOfHapiness = 0;
    }

    public string Name
    {
        get { return _name; } 
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");

    } 

    public int LevelOfHapiness()
    {
        Console.WriteLine("Woof-woof!"); 


    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}



