using System;
using System.Collections.Generic;
using userlogin.Models;

namespace userlogin {
  class App {
    Dictionary<string, User> Users { get; set; }
    bool LoggedIn { get; set; } = false;

    public App () {
      Users = new Dictionary<string, User> ();
      User mark = new User ("mark", "password");
      User jake = new User ("jake", "password2");
      Users.Add (mark.Name, mark);
      Users.Add (jake.Name, jake);
    }

    public void Run () {
      System.Console.WriteLine ("Welcome!");
      while (!LoggedIn) {
        System.Console.Write ("Username: ");
        string name = Console.ReadLine ().ToLower ();
        Console.Write ("Password:");
        string password = Console.ReadLine ();
        LoggedIn = Login (name, password);
        if (LoggedIn) { continue; }
        Console.Clear ();

        System.Console.WriteLine ("Invalid Creds. Try Again");
      }
      System.Console.WriteLine ("Successfull Login");
    }

    private bool Login (string name, string password) {
      return Users.ContainsKey (name) && Users[name].ValidatePassword (password);
    }

  }

}