using System;
using System.Collections.Generic;

namespace WildLife.Tracker
{
  public class Zoo
  {

    private string _type;
    private string _gender;
    private string _name;
    public Animal(string type, string gender, string name)
    {
      _type = type;
      _gender = gender;
      _name = name;
    }
  public static List<string> fluffyFriends = new List<string> {};
  
    public static void AddFluffyFriend()
    {
      Console.WriteLine("Enter the type of animal we're adding:");
      Animal.type = Console.ReadLine();
      
    }
  }
}