// See https://aka.ms/new-console-template for more information
using FirstDBproject.Data;
using FirstDBproject.Model;




AppDBContext appDBContext1 = new AppDBContext();

//List<Teacher> teachers = new List<Teacher>()
//{
//    new Teacher()
//    {
//        LastName = "Bahriddin",
//        FirstName = "Abdusalomov",
//        Age = 21,
//        Adress = "Farg'ona viloyati"

//    },
//    new Teacher()
//{
//    LastName = "Hayotbahrom",
//    FirstName = "Nuriddinov",
//    Age = 22,
//    Adress = "Andijon viloyati"

//    },
//    new Teacher()
//    {
//        LastName = "Shokir",
//        FirstName = "Nabiyev",
//        Age = 23,
//        Adress = "Toshkent shahar",

//    }

//};
//appDBContext1.Teachers.AddRange(teachers);

//appDBContext1.SaveChanges();

Student student1 = new Student();


List<Student> students = new List<Student>()
{
    new Student()
    {
        Id = 1,
        LastName = "Sarvar",
        FirstName = "Gulomjonov",
        Year = 2003,
        Adress = "Andijon viloyati"
    },
    new Student()
    {
        Id = 1,
        LastName = "Anvar",
        FirstName = "shodmonov",
        Year = 2005,
        Adress = "Namangan viloyati"
    }
};


AppDBContext appDBContext = new AppDBContext();


appDBContext.Students.AddRange(students);
appDBContext.SaveChanges();
