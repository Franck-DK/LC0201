//MIS 3033 003
//Feb 1, 2024
//Franck D K
//113537021

//delegate: a key word to define a functiom type
//class to define a new datatype
using f1;

Console.WriteLine("delegate");

Student stu1;

bool CheckAge(Student stu)
{
    if(stu.age > 20)
    {
        return true;
    }
    else 
    { 
        return false; 
    }
}

bool CheckGrade(Student stu)// Check grade is greater than or equal to 80
{
    if (stu.grade >= 80)
    {
        return true;
    }
    else
    {
        return false;
    }
}

FunctionType1 funType1Card;
funType1Card = CheckAge;

stu1 = new Student();
stu1.name = "tom";
stu1.age = 20;
stu1.grade = 90;
stu1.weight = 128.9;

Console.WriteLine(funType1Card(stu1));



List<Student> stuList;
stuList = new List<Student>();
Student stu;

stu = new Student() { name = "aiden", age = 19, weight = 120.8, grade = 90.8 };
stuList.Add(stu);

stu = new Student() { name = "tom", age = 25, weight = 130.8, grade = 69.8 };
stuList.Add(stu);

stu = new Student() { name = "rose", age = 28, weight = 160.8, grade = 70.8 };
stuList.Add(stu);

stu = new Student() { name = "emily", age = 18, weight = 110.8, grade = 80.8 };
stuList.Add(stu);

stu = new Student() { name = "jackie", age = 30, weight = 100.8, grade = 75.8 };
stuList.Add(stu);

stu = new Student() { name = "masha", age = 23, weight = 180.8, grade = 88.8 };
stuList.Add(stu);

stu = new Student() { name = "dav", age = 19, weight = 170.8, grade = 92.8 };
stuList.Add(stu);


//define a delegate at the end of the code
delegate bool FunctionType1(Student stu); //we defined a function type









