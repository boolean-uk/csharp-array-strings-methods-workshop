

Console.WriteLine("Enter a string");
string result = Console.ReadLine();

Console.WriteLine(result.ToUpper());
Console.WriteLine(result.ToLower());
Console.WriteLine(result.Trim());


//this works!
string name = "Nigel Sibbert";
Console.WriteLine(name.Substring(name.IndexOf(' '), name.Length - name.IndexOf(' ')).Trim());

//0123
//OneTwoThree
string substring = result.Substring(3, 3);
Console.WriteLine(substring);


//reverse
char[] str = result.ToCharArray();
Console.WriteLine(str.Reverse());
Array.Reverse(str);
string reverse = new string(str);
Console.WriteLine(reverse);



Console.WriteLine($"you entered: {result}");



//more array
string[] nameArray = { "Nigel", "Stitch", "Lola" };


for(int i = 0; i < nameArray.Length; i++)
{
    Console.WriteLine(i);
}

foreach(string s in nameArray)
{
    Console.WriteLine(s);
}

