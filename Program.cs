// See https://aka.ms/new-console-template for more information

/*//Query Synthax
//Step1: Data Source
List<int> integerList = new List<int>()
{
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};



//Step2: Query
//LINQ Query using Query Syntax to fetch all numbers which are > 5
var QuerySyntax = from obj in integerList //Data Source
                  where obj > 5 //Condition
                  select obj; //Selection

//Step3: Execution
foreach (var item in QuerySyntax)
{
    Console.Write(item + " ");
}

//An example of defered execution, here the previous result become our data source
var newSynthax = from x in QuerySyntax // initialiaztion or datasource
                 where x % 2 == 0 //condition or filter
                 select x; // Selection

foreach (var item in newSynthax)
{
    Console.WriteLine(item + " ");
}*/


//Method Synthax
////Step1: Data Source
//List<int> integerList = new List<int>()
//{
//   1, 2, 3, 4, 5, 6, 7, 8, 9, 10
//};

////Step2: Query
////LINQ Query using Query Syntax to fetch all numbers which are > 5
//var QuerySyntax = integerList.Where(obj => obj > 5).ToList();


////Step3: Execution
//foreach (var item in QuerySyntax)
//{
//    Console.Write(item + " ");
//}

//List<string> nameList = new List<string>()
//{
//   "fghj", "asdfghj", "qwertyu", "asdfghjklkjh", "oiu", "zxcvb", "as", "g", "oiuyt", "awrt"
//};

//var newName = from x in nameList where x.Length >= 5 select x;

//foreach (var item in newName)
//{
//    Console.WriteLine(item);
//}

//var nName = nameList.Where(x => x.Length >= 5).ToList();
//foreach(var item in nName)
//{
//    Console.WriteLine(item + " ");
//}

//var naName = nameList.Where(x => x.Length >= 5 && x.StartsWith('a')).ToList();
//foreach(var item in naName)
//{
//    Console.WriteLine(item + " ");
//}

//char start = 'a';

//var hName = (from obj in nameList where obj.Length >= 5 && obj[0] == start select obj).ToList();//Mixed Syntax

//foreach (var item in hName)
//{
//    Console.WriteLine(item + " ");
//}


////Mixed Synthax
////Data Source
//List<int> ntegerList = new List<int>()
//            {
//                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
//            };

////LINQ Query using Mixed Syntax
//var MethodSyntax = (from obj in  ntegerList // initialization
//                    where obj > 5 // condition
//                    select obj).Sum(); // execution

////Execution
//Console.Write("Sum Is : " + MethodSyntax);
//Console.WriteLine("Hello, World!");



using LinqueryExample;

List<Employee> employees = new List<Employee>
{
    new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000  ,Language =  new List<string>{"Java" ,"C#" , "Ruby" } },
    new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 ,Language =  new List<string>{"Java" ,"F#" , "Ruby" } },
    new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 , Language =  new List<string>{"Java" ,"C#" , "JavaScript" } },
    new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 , Language =  new List<string>{"Java" ,"C#" , "VB" } },
    new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 , Language =  new List<string>{"Java" ,"C#" , "Phyton" } },
    new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000  , Language = new List < string > { "Java", "C", "Ruby" }}
};

var result4 = employees.SelectMany(a => a.Language);


var filteredResult = (from emp in employees select emp.ID);
var res = employees.Select(a => a.ID);
// Data Transfer using Concrete class
var res2 = employees.Select(a => new EmployeeDto { Id = a.ID});
var result = from emp in employees select new EmployeeDto 
{ 
    Id = emp.ID , 
    FullName = emp.FirstName + emp.LastName 
};
// Anonymous class
var res3 = employees.Select(a => new
{
    Agbado = a.ID,
    Name = a.LastName,
    Age = a.Salary
}); ;
var result2 = from emp in employees select new  { Agbado = emp.ID };

/*foreach(var emp in employees)
{
    foreach(var item in emp.Language)
    {
        Console.WriteLine(item);
    }
}*/
/*List<string> languages = new List<string>();
foreach(var item in employees)
{
    foreach(var lan in item.Language)
    {
        if(!languages.Contains(lan))
        {
            languages.Add(lan);
        }
    }
}
foreach(var language in languages)
{
    Console.WriteLine(language);
}*/


HashSet<string> languages = new HashSet<string>();
foreach (var item in employees)
{
    foreach (var lan in item.Language)
    {
        languages.Add(lan);
    }
}

foreach (var langage in result4)
{
    Console.WriteLine(langage);
}


public class EmployeeDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
}
//foreach (var employee in employees.Select(a => a.ID))
//{
//    Console.WriteLine($"{employee.FirstName} \t{employee.LastName}");
//}




