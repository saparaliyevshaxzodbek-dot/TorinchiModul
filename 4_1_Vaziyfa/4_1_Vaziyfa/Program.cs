namespace _4_1_Vaziyfa;

internal class Program
{
    static void Main(string[] args)
    {
        //2-misol

        //while (true)
        //{
        //    Console.Write("Son kiriting :");
        //    var num = int.Parse(Console.ReadLine());
        //    int res;

        //    try
        //    {
        //        res = 25 / num;
        //        Console.WriteLine("Res :" + res);
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine("Sonni nolga bolib bolmaydi!");
        //        Console.WriteLine(ex.Message);
        //        res = 0;
        //    }

        //}

        //3-misol

        //while (true)
        //{
        //    try
        //    {
        //        Console.Write("Son kiriting :");
        //        var num = int.Parse(Console.ReadLine());
        //    }
        //    catch(FormatException ex)
        //    {
        //        Console.WriteLine("Son kiritilmadi boshqa tip kiritildi!");
        //        Console.WriteLine(ex.Message);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Sonni nolga bolib bolmaydi!");
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //4-misol

        //while (true)
        //{
        //    try
        //    {
        //        Console.Write("Izmingizni kiriting : ");
        //        string name = Console.ReadLine();
        //        if(string.IsNullOrEmpty(name)) 
        //        {
        //            throw new NameException("Iltimos Ismingizni  kiriting!");
        //        }

        //        Console.WriteLine( "Salom :" + name);
        //        break;
        //    }
        //    catch (NameException ex)
        //    {
        //        Console.WriteLine("Iltimos Isim kiriting!");
        //        Console.WriteLine(ex.Message); 
        //    }

        //}

        //5-misol

        //while (true)
        //{
        //    try
        //    {
        //        Console.Write("Izmingizni kiriting : ");
        //        string name = Console.ReadLine();
        //        if (string.IsNullOrEmpty(name))
        //        {
        //            throw new NameException("Iltimos Ismingizni  kiriting!");
        //        }

        //        Console.WriteLine("Salom :" + name);
        //        break;
        //    }
        //    catch (NameException ex)
        //    {
        //        Console.WriteLine("Iltimos Isim kiriting!");
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Operation finished");
        //    }

        //}

        //6-misol
        try
        {
            Console.Write("Email kiriting : ");
            string UserEmail = Console.ReadLine();

            ValidateEmail(UserEmail);
            Console.WriteLine("Email qabul qilindi");

        }
        catch (InvalidEmailException ex)
        {
            Console.WriteLine("Notogri Email kiritildi !");
            Console.WriteLine(ex.Message);
        }




    }

    static void ValidateEmail(string email)
    {
        if( !email.Contains("@"))
        {
            throw new InvalidEmailException ("Email hato kiritilgan !");
        }
    }
}
