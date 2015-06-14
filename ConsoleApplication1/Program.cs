using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;




namespace ConsoleApplication1
{

    struct Question
    {
        string tresc;
        string odp1;
        string odp2;

        public string odp11
        {

            set { odp1 = value; }
        }
        public string odp22
        {

            set { odp2 = value; }
        }
        public string trescc
        {

            set { tresc = value; }
        }
        public string Q
        {
            get
            {
                return tresc;
            }
        }
        public string A1
        {
            get
            {
                return odp1;
            }
        }
        public string A2
        {
            get
            {
                return odp2;
            }
        }

    }

    

    class Program
    {

    


        static void Main(string[] args)
        {
            Question []quest;
            quest=new Question[10];

               quest[0].trescc = "Góra czy Gura?";
               quest[0].odp11 = "Góra";
               quest[0].odp22 = "Gura";   

               quest[1].trescc = "1*2";
               quest[1].odp11 = "2";
               quest[1].odp22 = "1";              

               quest[2].trescc = "14-8?";
               quest[2].odp11 = "6";
               quest[2].odp22 = "8";
               
                quest[3].trescc = "2+1";
               quest[3].odp11 = "4";
               quest[3].odp22 = "3";

                quest[4].trescc = "5+2";
               quest[4].odp11 = "8";
               quest[4].odp22 = "7";

            int a = 1;
            localhost.WebService1 Test = new localhost.WebService1();

            Console.WriteLine("Rozpoczynamy test:");
            int i = 0;
            while (i < 5)
            {

                Console.WriteLine(quest[i].Q);
                Console.WriteLine("1:"+quest[i].A1);
                Console.WriteLine("2:"+quest[i].A2);
                string pom = Console.ReadLine();
                Int32.TryParse(pom, out a);
                Console.WriteLine(Test.Questions(a, i));
                Console.WriteLine(" ");
                i++;
            }
            


            
            //Console.Write("2 + 4 =", myMathService.Add(2, 4));
            System.Console.ReadKey();
        }
    }
}
