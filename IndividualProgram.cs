// File:    IndividualProgram.cs
// Author:  is7327
// Created: вторник, 20 ноября 2018 г. 09:22:17
// Purpose: Definition of Class IndividualProgram

using System;

public class IndividualProgram
{

   private string namecourse;
   private float mark;

    public IndividualProgram()
    {
        namecourse = "";
        mark = 0;
        Console.WriteLine("Individual Program was created (default)");
    }

    public IndividualProgram(string a, float m)
    {
         namecourse = a;
         mark = m;
        Console.WriteLine("Individual Program was created (initialization)");
    }

    public IndividualProgram (IndividualProgram previousIndividualProgram)
    {
        namecourse = previousIndividualProgram.namecourse;
        mark = previousIndividualProgram.mark;
        Console.WriteLine("Individual Program created (copy)");
    }
    ~IndividualProgram()
    {
        Console.WriteLine("Individual Program was destructed");
    }

    public void create()
   {
      throw new NotImplementedException();
   }
   
   public void pass()
   {
      throw new NotImplementedException();
   }

}