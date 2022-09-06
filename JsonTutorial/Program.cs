using JsonTutorial;
using static System.Console;
using System.Text.Json;


//creating new user data, by initializing instead of calling a contractor
User noah = new User
{
    Id = 1,
    Username = "nphenc",
    Password = "password",
    Firstname = "Noah",
    Lastname = "Phence",
    Phone = "411",
    Email = "nphence@gmail.com",
    IsReviewer = true,
    IsAdmin = false
};

//providing serializer options to call in the serialize statement below
JsonSerializerOptions options = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    WriteIndented = true
};

//converted the C# data to JSON for use on web applications

var json = JsonSerializer.Serialize(noah, options);

//converted the data from JSON back to C# or deserialized.

User? noahConverted = JsonSerializer.Deserialize<User>(json);

var v = 1;
