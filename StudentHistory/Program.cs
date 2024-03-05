
using System.ComponentModel;

List<string> students = new List<string>();
List<int> studentsScore = new List<int>();

bool isExit = false;
int operationID = 0;
while (!isExit)
{
    menu();
    if (!int.TryParse(Console.ReadLine(), out operationID))
    {
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine("Wrong input press any key for try again...");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.ReadLine();
        continue;
    }

    switch (operationID)
    {
        case 1:
            addStudentsInfo();
            break;
        case 2:
            showAll();
            Console.WriteLine("press any key back to menu...");
            Console.ReadLine();
            break;
        case 3:
            showAvrageScoreAllStudents();
            break;
        case 4:
            showStudentScoreWithID();
            break;
        case 5:
            isExit = true;
            break;
        default:
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("Wrong input press any key for try again...");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.ReadLine();
            break;

    }


}

void showStudentScoreWithID()
{
    if (students.Count < 1)
    {
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine("list is empty press any key back to menu...");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.ReadLine();
        return;
    }
    int studentIndex = 0;
    Console.WriteLine($"You have {students.Count} Studnets in list");
    Console.WriteLine("-------------------------");
    for (int i = 0; i < students.Count; i++)
    {
        Console.WriteLine($"{i + 1}:StudentName:{students[i]}.");
    }
    Console.WriteLine("-------------------------");
    Console.WriteLine("");
    while (studentIndex != -1)
    {
        Console.WriteLine("Plase Enter Student ID (-1 for exit)");
        if (!int.TryParse(Console.ReadLine(), out studentIndex))
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("invalid input press any key for try again...");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.ReadLine();
            continue;
        }

        else if (studentIndex -1 <= students.Count -1 && studentIndex > 0)
            Console.WriteLine($"StudentName:{students[studentIndex - 1]} || Score:{studentsScore[studentIndex - 1]}.");


    }


}

void showAvrageScoreAllStudents()
{
    if (students.Count < 1)
    {
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine("list is empty press any key back to menu...");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.ReadLine();
        return;
    }
    int avrageScore = 0;
    int sumScore = 0;

    showAll();
    for (int i = 0; i < studentsScore.Count; i++)
    {
        sumScore += studentsScore[i];
    }

    avrageScore = (sumScore / studentsScore.Count);

    Console.WriteLine("----------------------------");
    Console.Write($"The Avrage Score is:{avrageScore}\n");
    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
    Console.ReadLine();

}

void addStudentsInfo()
{
    int studentsCounter = 0, counter = 1;
    bool isValidCounter = false;
    string? name;
    int score;

    while (!isValidCounter)
    {
        Console.Write("Please Enter Students Number:");
        if (!int.TryParse(Console.ReadLine(), out studentsCounter))
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("invalid input press any key for try again...");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.ReadLine();
            continue;
        }
        isValidCounter = true;
    }

    // students = new List<string>(studentsCounter);
    // studentsScore = new List<int>(studentsCounter);

    while (studentsCounter > 0)
    {
        Console.WriteLine($"Please Enter Student {counter} Name:");
        name = Console.ReadLine();

        if (name == String.Empty)
        {
            Console.WriteLine("name can not be empty!");
            continue;
        }

        Console.WriteLine($"Please Enter {name} Score:");

        if (!int.TryParse(Console.ReadLine(), out score))
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("invalid input press any key for try again...");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.ReadLine();
            continue;
        }

        students.Add(name);
        studentsScore.Add(score);
        studentsCounter--;
        counter++;

    }
}

void showAll()
{
    Console.WriteLine($"You have {students.Count} Studnets in list");
    Console.WriteLine("-------------------------");
    for (int i = 0; i < students.Count; i++)
    {
        Console.WriteLine($"{i + 1}:StudentName:{students[i]} || Score:{studentsScore[i]}.");
    }
    Console.WriteLine("-------------------------");




}
void menu()
{
    System.Console.Clear();
    Console.WriteLine("*****************");
    Console.WriteLine("Welcome to Students History v1.0");
    Console.WriteLine("*****************");
    Console.WriteLine();
    Console.WriteLine("Choose your operation Number:");
    Console.WriteLine();
    Console.WriteLine("1.Add Students name and Score");
    Console.WriteLine("2.Show All Students and Score");
    Console.WriteLine("3.Show All Students Avarage");
    Console.WriteLine("4.Show Student Avarage by ID");
    Console.WriteLine("5.Exit by ID");
    Console.WriteLine();
    Console.Write("Please Enter your operation ID:");
}