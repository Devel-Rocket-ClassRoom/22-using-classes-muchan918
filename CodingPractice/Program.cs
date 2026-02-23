using System;

ClassName.MemberName();

string square = Square.GetName();
Console.WriteLine(square);

MyFirstClass.StaticMethod();
MyFirstClass my = new MyFirstClass();
my.InstanceMethod();

Person person1 = new Person();
person1.Name = "홍길동";
person1.Age = 25;
person1.Introduce();

Person person2 = new Person();
person2.Name = "김철수";
person2.Age = 30;
person2.Introduce();

Point point1 = new Point();
point1.X = 10;
point1.Y = 20;

Point point2 = point1;
point2.X = 100;

Console.WriteLine($"point1.X = {point1.X}");
Console.WriteLine($"point2.X = {point2.X}");

PointStruct ps1 = new PointStruct();
ps1.X = 10;
PointStruct ps2 = new PointStruct();
ps2.X = 20;
Console.WriteLine($"구조체: ps1.X = {ps1.X}, ps2.X = {ps2.X}");

Point pc1 = new Point();
pc1.X = 10;
Point pc2 = pc1;
pc2.X = 100;
Console.WriteLine($"클래스: pc1.X = {pc1.X}, pc2.X = {pc2.X}");

Calculator calc = new Calculator();
Console.WriteLine($"3 + 5 = {calc.Add(3, 5)}");
Console.WriteLine($"3 * 5 = {calc.Multiply(3, 5)}");

Player player1 = new Player();
player1.ShowInfo();

Player player2 = new Player("용사", 150);
player2.ShowInfo();


Stock stock = new Stock();
stock.CurrentPrice = 30;
Console.WriteLine($"주가: {stock.CurrentPrice}");

Product product = new Product();
product.Name = "노트북";
product.Price = 150000;
Console.WriteLine($"{product.Name}: {product.Price}원 (수량: {product.Quantity})");


Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"반지름: {circle.Radius}, 넓이: {circle.Area:F2}");


Monster monster1 = new Monster();
monster1.Name = "고블린";
monster1.Health = 50;

// 개체 생성 방법 2: 개체 이니셜라이저
Monster monster2 = new Monster
{
    Name = "오크",
    Health = 100
};

monster1.Attack();
monster2.Attack();

Character hero = new Character
{
    Name = "용사",
    Level = 10,
    Job = "전사"
};

Console.WriteLine($"{hero.Name} - Lv.{hero.Level} {hero.Job}");

Random random = new Random();

Console.WriteLine($"임의의 정수: {random.Next()}");
Console.WriteLine($"0 ~ 4: {random.Next(5)}");
Console.WriteLine($"1 ~ 9: {random.Next(1, 10)}");
Console.WriteLine($"0.0 ~ 1.0: {random.NextDouble():F4}");


Console.WriteLine("주사위를 5번 굴립니다:");
for (int i = 0; i < 5; i++)
{
    int dice = random.Next(1, 7);
    Console.WriteLine($"  {i + 1}번째: {dice}");
}

Person alice = new Person("Alice", 25);
Person bob = new Person("Bob", 30);
alice.SetFriend(bob);







struct PointStruct
{
    public int X;
    public int Y;
}
