using Business.Concrete;
using Entities.Concrete;
using System;
namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "BEYZA";
            person1.LastName = "ÇEVRİM";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 33931483666;

            //List<string> Names = new List<string> { "beyza", "aslı", "merve" };
            //Names.Add("selin");
            //Names.Add("ceyda");
            //foreach (string name in Names)
            //{
            //    Console.WriteLine(name);
            //}

        

            PttManager pttmanager = new PttManager(new PersonManager());
            pttmanager.GiveMask(person1);


        }

        static void SayHi()
        {
            Console.WriteLine("merhaba");
        }

     
    }

    public class MyList
    {
        //Liste görevi gören bir class yaz. ödev.

        //public string[] Names = new string[1];
        //Names[0] = null;

        //public int SizeOfNames = 1;
        //public void Add(string name)
        //{
        //    string[] MoveNames = new string[SizeOfNames];
        //    foreach(string _name in Names)
        //    {
        //        MoveNames[]
        //    }
        //    string[] names = new string[SizeOfNames + 1];
        //    SizeOfNames++;
        //    names[SizeOfNames - 1] = name;
        //}
    }

    //public class Citizen
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }

    //    public int YearOfBirth { get; set; }
    //    public long TcNo { get; set; }
    //}
}