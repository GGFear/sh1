// File:    Teacher.cs
// Author:  is7327
// Created: вторник, 20 ноября 2018 г. 09:22:14
// Purpose: Definition of Class Teacher

using System;

public class Teacher
{
   private string subject;
   private int qualification;
   private string name;
    private string surname;

         public Teacher()
    {
        subject = "";
        qualification = 0;
        name = "";
        surname = "";
     
        Console.WriteLine("Teacher was created (default)");
    }

    public Teacher(string s, int q, string n, string sn)
    {
        subject = s;
        qualification = q;
        name = n;
        surname = sn;
   
        Console.WriteLine("Teacher was created (initialization)");
    }

    public Teacher(Teacher previousTeacher)
    {
        subject = previousTeacher.subject;
        qualification = previousTeacher.qualification;
        name = previousTeacher.name;
        surname = previousTeacher.surname;
        Console.WriteLine("Teacher created (copy)");
    }
    ~Teacher()
    {
        Console.WriteLine("Teacher was destructed");
    }
    public int create_course()
    {
        // TODO: implement
        return 0;
    }

    public void checkexam()
   {
      throw new NotImplementedException();
   }
   
   public void checktests()
   {
      throw new NotImplementedException();
   }
   
   public void checkhw()
   {
      throw new NotImplementedException();
   }
   
   public void helpstudents()
   {
      throw new NotImplementedException();
   }
   
   public void createprograme()
   {
      throw new NotImplementedException();
   }

}