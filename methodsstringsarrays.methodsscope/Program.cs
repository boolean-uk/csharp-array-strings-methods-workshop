using methodsstringsarrays.methodsscope;

//methods & scope

int n = 3;
decimal m = 3.99M;
string s = "hi";
Console.WriteLine("Hello, World!" + m.ToString() + n.ToString());



//declare multiple lines
Person p1 = new Person();
p1.Name = "Nigel";
p1.Age = 21;

Console.WriteLine(p1.Age);

//call method (no return type & no params)
p1.InitializeMyAge();
Console.WriteLine(p1.Age);


p1.WakesUp();

Console.WriteLine(p1.AgeNextYear());

Console.WriteLine(p1.ageInHowManyYears(10));

//declare in one hit
Motorbike bike1 = new Motorbike()
{
    Name = "KTM 390",
    CC = "373cc"
};

Person p2 = new Person()
{
    Name = "Libby"

};

p2.JustBoughtAMotorbike(bike1);

p2.MyBike.StartMotorbike();
Console.WriteLine(p2.MyBike.Name);
Console.WriteLine(p2.WhatBikeHaveIJustBought());
