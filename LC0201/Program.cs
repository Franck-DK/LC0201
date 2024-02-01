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
stu1.Name = "tom";
stu1.age = 20;
stu1.grade = 90;
stu1.weight = 128.9;

Console.WriteLine(funType1Card(stu1));

//define a delegate at the end of the code
delegate bool FunctionType1(Student stu); //we defined a function type