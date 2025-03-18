//for you the differences are struts are value types and classes are reference types and there is no inheritance for structs

//other differences between structs and classes

//public struct A
//{

//}

//public struct B : A   //this is not allowed, no inheritance for structs
//{
//}

//Example 4 with Student class and Equals method
//var s1 = new Student();
//s1.Name = "John";
//s1.Age = 25;

//var s2 = new Student();
//s2.Name = "John";
//s2.Age = 25;

//Console.WriteLine(s1.Equals(s2)); //how to make it true - you need to implement (override) the Equal method

//public class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public override bool Equals(object obj)
//    {
//        //I will keep this implementation very simple
//        var other = (Student)obj;

//        return Name == other.Name && Age == other.Age;
//    }
//}

//Example 3 with Student struct and class

//var s1 = new Student();
//s1.Name = "John";
//s1.Age = 25;

//var s2 = new Student();
//s2.Name = "John";
//s2.Age = 25;

//Console.WriteLine(s1.Equals(s2)); // is it true or false

//public struct Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//To justify my simplification - string is a class but it behaves like a value type. It is immutable.



//In c# you have two types of data types: value types and reference types

//structs are value types
//classes are reference types

// Example 2 with int[]

//int[] a = [1, 2, 3];
//Console.WriteLine(a[2]); // 2
//IncrementBy2(a);
//Console.WriteLine(a[2]); // this will also be 5

//static void IncrementBy2(int[] a)
//{
//    a[2] += 2;
//    Console.WriteLine(a[2]); // 5
//}



//Example 1 with int

//int a = 10;
//Console.WriteLine(a);  // 10
//IncrementBy2(a);
//Console.WriteLine(a); // some expect to see 12 but it will be 10


//static void IncrementBy2(int a)
//{
//    a += 2;
//    Console.WriteLine(a); // 12
//}