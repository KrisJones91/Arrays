// See https://aka.ms/new-console-template for more information
int[] grades = new int[5];

grades[0] = 20;
grades[1] = 26;
grades[2] = 54;
grades[3] = 16;
grades[4] = 3;

Console.WriteLine("grades at index 0: {0}", grades[0]);
string input = Console.ReadLine();

grades[0] = int.Parse(input);
Console.WriteLine("Grades at index 0: {0}", grades[0]);
Console.ReadLine();


// another way of initializing an array
int[] gradesOfMathStudentsA = { 20, 30, 40, 50, 60 };

//third way of initializing an array
int[] gradesOfMathStudentsB = new int[] { 15, 21, 35, 80, 90 };
Console.WriteLine("Length of grades in class A: {0}", gradesOfMathStudentsA.Length);
Console.ReadKey();
