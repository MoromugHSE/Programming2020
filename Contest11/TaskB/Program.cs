public class Program
{
    public static void Main(string[] args)
    {
        Serializer.ReadStudents(@"..\..\..\input.txt");
        Serializer.SerializeStudents(@"..\..\..\..\TaskC\bin\Debug\netcoreapp3.1\input.bin");
    }
}