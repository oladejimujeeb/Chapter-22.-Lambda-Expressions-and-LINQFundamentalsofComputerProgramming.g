namespace Chapter_22._Lambda_Expressions_and_LINQ
{
  class Proram
  {
      static void Main(string[] args)
      {
          //Question 1
          string school = "victory";
          Console.WriteLine(school.Question1(3,4));
          
          //Question2
          IEnumerable<int> list = new List<int>{ 11, 12, 13, 14, 15, 16, 17, 18, 19 };
          Console.WriteLine("Average ="+list.Average());
          Console.WriteLine("Sum ="+list.Sum());
          
          IEnumerable<int> array = new [] { 1, 2, 3, 4, 5, 6, 7 };
          Console.WriteLine("min ="+array.Min());
          Console.WriteLine("max="+array.Max());
          
          //Question3
           Student[] stu = new Student[]
          { 
              new Student {Firstname = "Aleem", Lastname = "Salaudeen", Age =14},
              new Student {Firstname ="Adebayo",Lastname ="Sasona", Age=22},
              new Student {Firstname ="Quyyum",Lastname ="Ajibike", Age=16},
              new Student {Firstname ="Yusuf",Lastname ="Suliamon", Age=24},
          };
           
          Student.Question3(stu);
          Console.WriteLine("===========");
          //Question4
          Student.Question4(stu);
          Console.WriteLine("===========");
          //Question5
          Student.Question5(stu);
          Console.WriteLine("===========");
          Student.Question5b(stu);
          //Question6
          Question6.Linq();
          
          //Question7
          string name = "this iS a Sample sentence";
          Console.WriteLine("Question 7");
          Console.WriteLine(name.Question6());



      }
  }
}

 