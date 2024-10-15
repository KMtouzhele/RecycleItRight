// See https://aka.ms/new-console-template for more information
using RecycleItRight.Controller;
using RecycleItRight.Entity;

Console.WriteLine("Welcome to Recycle it Right!");

AuthenticationController authenticationController = new AuthenticationController();
Student newStudent = new Student(
    "1",
    "johndoe",
    "johndoe@google.com",
    "ThisisJohnDoe",
    "",
    "666666",
    "John",
    "Doe",
    Language.English
    );
Staff newStaff = new Staff(
    "2",
    "janedoe",
    "janedoe@hotmail.com",
    "ThisisJaneDoe",
    "",
    "777777",
    "Jane",
    "Doe"
    );
authenticationController.Register(newStudent);
authenticationController.Register(newStaff);

newStudent.ChangeLanguage(Language.Spanish);
newStudent.ChangeSecondaryEmail("johndoe2nd@hotmail.com");