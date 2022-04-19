/*using System;//if: if statement test the condition it is execute if the condition is true.

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            if (num%2 ==0) {
                Console.WriteLine("the number id even");
            }
        }
    }
}*/

/*using System;
//if else: if-else statement also test the condition it is execute if the 
//condition is true then execute if otherwish else

    class Program
    {
        static void Main(string[] args)
        {
            int num = 21;
            if (num % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else {
                Console.WriteLine("the number is odd");
            }
        }
    }
*/

//if-else-if: it is ladder statement execute one condition from multiple statement.
/*using System;

class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num>=0 || num<= 50 )
        {
            Console.WriteLine("fail");
        }
        else if(num>=50 ||num<=65 )
        {
            Console.WriteLine("pass");
        }
    }
}*/
//switch statement: it is used when we have multiple choice and we have to pic only 
//one choice only one option.Break statement is essentially with every case to avoid unnesary complexcity
//Defoult statement will be execute only if non of the case are mached. in this we have to check in equality also 
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the num");
        int num = Convert.ToInt32(Console.ReadLine());
        switch (num){
           case 10:  Console.WriteLine(10); break; 
           case 20: Console.WriteLine(20);break;
           case 40: Console.WriteLine(40);break;

           default: Console.WriteLine("not 10,20,40");
           break;
        }

    }
}
*/

//Keywords: is the simple english words haveing predifind meaning in c# programming 
//keyword can not be modified, keyword also called as resurved words, all keywords are 
//in lower case, we can not use keyword as the name of variable ,method and class or any other 
//iddentifier, true, false and null is not a keyword but it is resurve word or litteral
//ex: using, public class, static , void ,int etc.

//iddentifier are the name that will be use to identify that programming element like
//class, method, enumm, delegtes variable. Rules: iddentifier can contain the alphanumeric
//digits and two special symbols is _,@, iddentifier 1st leter shoud be alphabet or @,_
//keyword or resurev keywords can't be used as an iddentifier.

//variable: variable is the container that hold to used the data, memory will be allocated 
//for variable while executing the programming, value of variable can we changed then number 
//of time during program execution , there are two type of variable

//Primitive variable:  varible declear with primitive data type called primitive vriable 
//Refrence Variable: variable declare with user data type are called as a reference variables

/*using System;

class Program
{
    static void Main(string[] args)
    {
        int a;//vriable, it is local varible be need to initalize before used
        //Console.WriteLine(a);//we can't this, before we have to initalize, it will throw CTE
        Console.WriteLine("hello");
        Console.ReadLine();

    }
}*/
/*
using System;

class Program
{
    int a = 30; //goloble or instance or non-static varible or refrence variable

    static int b = 40; //static variable
    
    static void Main(string[] args)
    {
        int i=10;//local or primitive variable
        //defoult value of the primitive variable depends on primitive data type
        //primitive variable hold valid liter as the memory allocation

        Program obj = new Program();
        //object is a refrence variable :variable is declare with user data type
        // user write expilicity,it always 8byte of memory will be allocated
        //always null value assigned as defoult value for reference varible

        Console.WriteLine(obj.a);// initalize through the object in non-static

        //Console.WriteLine(a);//goloble or instance or non-static
        //non- static :we can't initalized directly we have to create the obj

       // Console.WriteLine(b);//satic 
        Console.WriteLine(Program.b);
        //static: member we can access directly or by  class name 

        Console.WriteLine(i);//local
        //local variable:variable we can initalize directly through variable name

        Console.ReadLine();

    }
}*/

/*using System;

class Program
{
    public const int i = 100; //we can difine constant using const keyword
     //by defoult it is static //implicity 
    //automatical writen CLR static const
   // value of const we can't change and modified during program execution
  //it is complie time constant, it is also called as final variable 
 //it can't use static keyworde, it is declear insied the class or method also

    public static readonly int j = 200;// we can defined readonly using readonly keyword
   // the user have to writen explicite write static keyword, 
  //or it is used with static keyword , it is run time constant 
 // the value of readonly can we changed or modified during program execution 
    readonly int k = 300;
// it can declare insied the class we can assign value in constructer.

    Program()//it is constructer
    {
        k= 400;// we can't change the static keywored value in costructed
    }
    static void Main(string[] args)
    {
        const int a = 99;
        Console.WriteLine(a);
        Console.WriteLine(i);
        Console.WriteLine(j);
        Program obj = new Program();
        Console.WriteLine(obj.k);
        // we can only initialized through the object becouse it is non static member 
        Console.ReadLine();

    }
}*/
/*using System;//literal

class Program
{
    // literal are the actual value of a variable.
    //literal will be assign to variable or constant
    //literal used to perform any opration 
    //constant value are called as literal
    static void Main(string[] args)
    {
        //literal are six type
        byte b = 255;
        short s = 32767;
        int i1 = 2147483647;//integer literal
                            // integer literal are 4 type
                            //1.Decimal,2.octal: it must start with 0,
        //3.Hexadecimal,4.Binary litrals.
        long L = 9223372036854775807;
        Decimal d = 79228162514264337593543950335M;//max value 
        bool b1 = true;// boolean literal
        bool b2 = false;
        char ch = 'a';//character literal
        string s1 = "Sonam";//string literal
        float f = 3.40282347E+38F; //floating literal
        int i2;// null literal
        Console.ReadLine();

    }
}*/

/*using System;//var

class Program
{
   
    static void Main(string[] args)
    {
       // var age1;// we have to initalize the value 
        var age = 45;//litral is 45
        
                     //var is a keywords using var keywords we can difine the varible 
                     //at the time of variable declareation it should be initize otherwise it will throw compile time error.
                     //using var keyword we can declare only local variable 
                     //it can't use for properties
                     //var keyword as used in compile time and its support inteligens
                     //once variable declare using var or initalized with some litteral then we can't change other litteral.

        //age = "20";
        //age = 'a';
        //age = true;
        //age = false;


        var isFemale = true;//literal is boolean type 
        isFemale = false;

        var address = "Vidisha";
        address = "Bhopal";

        

        Console.ReadLine();

    }
}*/

/*using System;//Dynamic

    class Program
    {
    dynamic Lname = "Sahu";
    //using dynamic keyword we can declare goloble variable also.
   
    // var Fname = "Sonam";//we can't not difined goloble variable using var
    static void Main(string[] args)
        {
        dynamic age;
        //dynamic is a keyword using dynamic keyword we can defined the variable
        age = 20;
        //once variable declare using dynamic or initalized with some litral then 
        //we can change the other literal.
            
        }
    }
  */  
