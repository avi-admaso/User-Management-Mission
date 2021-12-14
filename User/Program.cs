using User;

List<Student> students = new List<Student>();
Menu();
string fileName ;
void addUsers()
{
    try
    {
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("add name");
        string theName = Console.ReadLine();
        Console.WriteLine("add last name");
        string theLastName = Console.ReadLine();
        Console.WriteLine("add birth year");
        int theBirthYear = int.Parse(Console.ReadLine());
        Console.WriteLine("add mail");
        string mail = Console.ReadLine();
        Console.WriteLine("add grade");
        string theGrade = Console.ReadLine();
        Student userOne = new Student(theName, theLastName, theBirthYear, mail, theGrade);
        Console.WriteLine(userOne.printUser());
        //students.Sort();
        students.Add(userOne);
        addToFile(userOne);
        saveFileByName(userOne);
        
    }
    }
    catch (FormatException)
    {
        Console.WriteLine("Wrong input type");
        addUsers();
    }

}

void addToFile(Student students)
{
    try
    {
    FileStream HighSchool = new FileStream($@"c:\test\Students.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(HighSchool))
    {
        writer.WriteLine($"student name : {students.FirstName}, student last name : {students.LastName}, student birthe year:{students.BirthYear}, student mail{students.Mail}");
    };
    }
    catch (ArgumentException)
    {

        Console.WriteLine("somthing wrong with the argument");
    }
    addToFile(students);
}
void readFromFile()
{
    try
    {
    FileStream HighSchool = new FileStream($@"c:\test\Students.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(HighSchool))
    {
        Console.WriteLine(reader.ReadToEnd());
    };
    }
    catch (Exception)
    {

        Console.WriteLine("oops somthing wrong");
        readFromFile();
    }

}
void saveFileByName (Student students)
{
    try
    {
    FileStream HighSchool = new FileStream($@"c:\test\{students.FirstName}.txt", FileMode.Create);
    using (StreamWriter writer = new StreamWriter(HighSchool))
    {
        writer.WriteLine($"student name : {students.FirstName}, student last name : {students.LastName}, student birthe year:{students.BirthYear}, student mail{students.Mail}");
    };
    }
    catch (ArgumentException)
    {
        Console.WriteLine("somthing wrong with the argument");

    }

}
void writeFileByNaMe(string fileName)
{
    try
    {
    for (int i = 0; i < students.Count; i++)
        if (students[i].FirstName == fileName)
        {
            {
                Console.WriteLine($"STUDENT NAME: {students[i].FirstName} STUDENT LAST NAME: {students[i].LastName} BIRTH YEAR: {students[i].BirthYear} STUDENT MAIL: {students[i].Mail} STUDENT GRADE: {students[i].grade}");
            }
        }
    }
    catch (ArgumentException)
    {

        Console.WriteLine("somthing wrong with the argument");
    }

}
void deleteStudent(string fileName)
{
    try
    {
    for (int i = 0; i < students.Count; i++)
        if (students[i].FirstName == fileName)
        {
            students[i] = null;
        }
    }
    catch (ArgumentException)
    {

        Console.WriteLine("somthing wrong with the argument");
    }

}

//addUsers();

void Menu()
{
    try
    {

        Console.WriteLine("to add student press 1");
        Console.WriteLine("to edit student details press 2");
        Console.WriteLine("to delete student press 3");
        Console.WriteLine("to show some student press 4");
        Console.WriteLine("to Print student press 5");
        int userChoice = int.Parse(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                addUsers();
                break;
            case 2:
                break;
            case 3:
                Console.WriteLine("put student name");
                fileName = Console.ReadLine();
                deleteStudent(fileName);
                break;
            case 4:
                Console.WriteLine("put student name");
                fileName = Console.ReadLine();
                writeFileByNaMe(fileName);
                break;

        }
        
    }
    
            catch (FormatException)
    {
        Console.WriteLine("Wrong input type");
        Menu();
    }

    Menu();
}
Menu();

