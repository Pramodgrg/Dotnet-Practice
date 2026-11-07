using System.Data.Common;

Console.WriteLine("==============================");
Console.WriteLine("   DEVELOPER PROFILE MAKER");
Console.WriteLine("==============================");

Console.Write("Enter your full name: ");
string name = Console.ReadLine() ?? "";

Console.Write("Enter your age: ");
string ageInput = Console.ReadLine() ?? "";

Console.Write("What language are you learning? ");
string language = Console.ReadLine() ?? "";

Console.Write("What is your target job role? ");
string role = Console.ReadLine() ?? "";

Console.Write("Are you currently a student? (yes/no): ");
string studentInput = Console.ReadLine() ?? "";

// TODO 1: Convert ageInput into an integer.
int age = 0;
if (!int.TryParse(ageInput, out age))
{
    Console.WriteLine("Invalid age entered. Defaulting to 0.");
}

// TODO 2: Determine whether studentInput means yes.
bool isStudent = studentInput.Equals("yes", StringComparison.OrdinalIgnoreCase)
    || studentInput.Equals("y", StringComparison.OrdinalIgnoreCase)
    || studentInput.Equals("true", StringComparison.OrdinalIgnoreCase);

// TODO 3: Display the completed developer profile.
Console.WriteLine();
Console.WriteLine("===== DEVELOPER PROFILE =====");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Language Learning: {language}");
Console.WriteLine($"Target Job Role: {role}");
Console.WriteLine($"Student: {(isStudent ? "Yes" : "No")}");

