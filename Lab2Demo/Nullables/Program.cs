//For this demo we'll not discuss a relatively new feature - nullable reference types

//int age = null;  //not possible - value types (structs) cannot be null

//string name = null;

var s1 = new Student();
var s2 = new Student();

s1.Age = null;
Console.WriteLine(s1.IsAdult());

public class Student
{
    public string Name { get; set; }
    public int? Age { get; set; } //by adding this question mark, you make the value type nullable - you can assign null to it

    public bool? IsAdult()
    {
        if (Age.HasValue)
        {
            return Age.Value >= 18;
        }

        return null;
    }
}



