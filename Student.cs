// File:    Student.cs
// Author:  is7327
// Created: вторник, 20 ноября 2018 г. 09:22:11
// Purpose: Definition of Class Student

using System;

public class Student
{
    public string Name { get { return name; } set { name = value; } }
    public string Surame { get { return surname; } set { surname = value; } }
    public int Rating { get { return rating; } set { rating = value; } }

   private string name;
   private string surname;
   private int rating;

   public System.Collections.ArrayList individualprogram { get; set; }

    public Student()
    {
        name = "";
        surname = "";
        rating = 0;

        individualprogram = new System.Collections.ArrayList();
        IndividualProgram newIndividualProgram = new IndividualProgram();
       
        Console.WriteLine("Student was created (default)");
    }

    public Student(string n, string sn, int r, string na, float ma)
    {

        name = n;
        surname = sn;
        rating = r;

        individualprogram = new System.Collections.ArrayList();
        IndividualProgram newIndividualProgram = new IndividualProgram(na, ma);
        

        Console.WriteLine("Student was created (initialization)");
    }

    public Student(Student previousStudent)
    {
        name = previousStudent.name;
        surname = previousStudent.surname;
        rating = previousStudent.rating;

        individualprogram = previousStudent.individualprogram;
      
        Console.WriteLine("Student created (copy)");
    }
    ~Student()
    {
        Console.WriteLine("Student was destructed");
    }
    public int enter_university()
    {
        // TODO: implement
        return 0;
    }

    public void examination()
   {
      throw new NotImplementedException();
   }
   
   public void dohw()
   {
      throw new NotImplementedException();
   }
   
   public void getmark()
   {
      throw new NotImplementedException();
   }
   
   //public IndividualProgram individualProgram;

}

