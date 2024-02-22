using Business.Concrete;
using Entities.Concrete;
using System;


namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
        SelamVer(isim: "Murat");
        SelamVer(isim: "Engin");
        SelamVer(isim: "Ahmet");
        SelamVer();

        int sonuc = Topla(3,5);

        //Diziler / Arrays

        

        Person person1 = new Person();
        person1.FirstName = "ENGİN";
        person1.LastName = "DEMIROG";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 123;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();
    }
    //resharper
    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }
    static int Topla(int sayi1, int sayi2)
    {
        int sonuc = sayi1+sayi2;
        Console.WriteLine("Toplam : "+ sonuc);
        return sonuc;
    }
}