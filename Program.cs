using EnumReturnString.Enums;
using static EnumReturnString.Methods.EnumMethods<System.Enum>;



public class Program
{
    public static void Main()
    {
        //Way 1 with dispaly attribute
        Console.WriteLine(ToDisplayString(ConnectionStrings.SqlServer_));   

        //Way 2 with description attribute
        Console.WriteLine((ToDescriptionString(Colors.Green)));
    }

}
 



