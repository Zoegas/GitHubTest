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

            Console.WriteLine(p.GetName() + " " + p.GetLenght());
            Console.Read();
        }
    }
}
