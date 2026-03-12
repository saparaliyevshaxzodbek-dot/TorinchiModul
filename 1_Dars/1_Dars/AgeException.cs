namespace _1_Dars;

public class AgeException : Exception
{
    public AgeException(string message) : base(message)
    {
        Console.WriteLine("Diqqat yosh kiritishda xatolik yuz berdi!");
    }
}
