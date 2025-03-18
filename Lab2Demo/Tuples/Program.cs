var s1 = new Student("John", "Doe", 40);

var (first, last, age) = s1;

Console.WriteLine(first);
Console.WriteLine(last);
Console.WriteLine(age);

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Student(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    //This method will allow you later to assign object of this class to a tuple
    public void Deconstruct(out string first, out string last, out int age)
    {
        first = FirstName;
        last = LastName;
        age = Age;
    }
}



//Example 1- Introduction to Tuples
//int a = 12;
//int b = 18;

//var result = DivisorAndMultiplier(a,b);

//Console.WriteLine(result.Gcd);
//Console.WriteLine(result.Lcm);


//static (int Gcd, int Lcm) DivisorAndMultiplier(int a, int b)
//{
//    //don't look too much at the shitty implementation of the algorithm (chatGpd did it)
//    var orginalA = a;
//    var orginalB = b;

//    while (b != 0)
//    {
//        var temp = b;
//        b = a % b;
//        a = temp;
//    }

//    var gcd = a;
//    var lcm = orginalA * orginalB / gcd;

//    return (gcd, lcm);
//}
