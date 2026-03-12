namespace _4_1_Vaziyfa;

public class InvalidEmailException : Exception
{
    public InvalidEmailException(string UserEmail) : base(UserEmail)
    {
        
    }
}
