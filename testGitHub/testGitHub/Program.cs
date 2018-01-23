using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testGitHub
{
    public class Person
    {
        private String name;
        private int lenght;
        private String adress;
        private int age;
        private int hej;
        public void SetAdress(String NewAdress) {
            adress = NewAdress;
}                              
        public String GetAdress() {
            return adress;
}
        //test


        public void SetName(String NewName)
        {
            name = NewName;
        }
        public String GetName()
        {
            return name;
        }
        public void SetLenght (int NewLenght)
        {
            lenght = NewLenght;
        }
        public int GetLenght()
        {
            return lenght;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.SetLenght(190);
            p.SetName("Viktor");
            p.SetAdress("Lund eller malmö");


            Console.WriteLine(p.GetName() + " " + p.GetLenght() + " " + p.GetAdress());
            Console.Read();
        }
    }
}
