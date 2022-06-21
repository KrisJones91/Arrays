// See https://aka.ms/new-console-template for more information

Boolean valid = false;
string inputValue;

Console.Write("Enter a value: ");
Console.WriteLine("Select the Data type to validate the input you have entered");
Console.WriteLine("Press (1) for String");
Console.WriteLine("Press (2) for Integer");
Console.WriteLine("Press (3) for Boolean");

Console.Write("Enter: ");

int inputValueType = Convert.ToInt32(Console.ReadLine());

switch (inputType)
{
    case 1:
        //check for string
        valid = isAllAlphabetic(inputValue);
        inputValueType = "String";
        break;
    case 2:
        //check for integer
        int returnValue = 0;
        valid = int.TryParse(inputValue, out returnValue);
        inputValueType = "Integer";
        break;
    case 3:
        //check for boolean
        bool returnFlag = false;
        valid = bool.TryParse(inputValue, out returnFlag);
        inputValueType = "Boolean";
        break;
    default:
        Console.WriteLine("Not able to detect the input type, something went wrong.");
        break;
}





static bool isAllAlphabetic(string value)
{
    foreach (char c in value)
    {
        if (!char.IsLetter(c))
            return false;

    }
    return true;
}




