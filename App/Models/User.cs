namespace userlogin.Models {
  class User {
    public string Name { get; set; }

    string Password { get; set; }

    public bool ValidatePassword (string creds) {
      return creds == Password;
    }

    public User (string name, string password) {
      Name = name;
      Password = password;
    }
  }
}