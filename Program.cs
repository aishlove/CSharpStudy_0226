using System;

namespace CSharpStudy_0226
{   

    #region 로컬함수
    // 람다식과 더불어 프로그래머에게 코드를 간추릴 수 있는 또 하나의 옵션.
    class MainApp
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if(arr[i] <65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i]+32);
            }
            return new string(arr);
        }
        static void Main(string [] args)
        {
            System.Console.WriteLine(ToLowerString("Hello!"));
            System.Console.WriteLine(ToLowerString("Good Morning!"));
            System.Console.WriteLine(ToLowerString("This is C#."));
        }
    }
    #endregion


    #region 연습문제
    class MainApp
    {
        static double Square(double arg)
        {
            double output;
            // 구현
            output = arg * arg;
            // string 형변환
           // string s_output = output.ToString();
            return output;
        }
        

        static void Main(string[] args)
        {
            System.Console.WriteLine("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            System.Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
    #endregion

#region  연습문제 2
namespace Ex6_2
{
    class MainApp
    {
        public static void Main()
        {
            double mean = 0;
            Mean(1,2,3,4,5);
            System.Console.WriteLine("평균 : {0}", mean);

            double Mean(double a, double b, double c, double d, double e)
        
            {

                mean = (a + b+ c + d+ e )/5;
                return mean;
            }    

        }
 
    }
}
#endregion

#region  클래스
namespace Constructor
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()  // 종료자
        {
            System.Console.WriteLine($"{Name} : 잘가");
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            System.Console.WriteLine($"{Name} : 야옹");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat("키티", "하얀색");
            Kitty.Meow();
            System.Console.WriteLine($"{Kitty.Name} : {Kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            System.Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
} 
#endregion

#region 정적 static

class Global
{
    public static int Count = 0;
}

class ClassA
{
    public ClassA()
    {
        Global.Count++;
    }
}

class ClassB
{
    public ClassB()
    {
        Global.Count++;
    }
}

class MainApp
{
    static void Main()
    {
        System.Console.WriteLine($"Global.Count : {Global.Count}");

        new ClassA();
        new ClassA();
        new ClassB();
        new ClassB();
        
        System.Console.WriteLine($"Global.Count : {Global.Count}");
    }
}  
#endregion

}
