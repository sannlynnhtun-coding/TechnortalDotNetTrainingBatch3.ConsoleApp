using TechnortalDotNetTrainingBatch3.ConsoleApp;

//Student student = new Student(1, "mg mg", new DateTime(2000, 1, 1));
////student.StudentNo = 1;
////student.StudentName = "John Doe";   

//Student student2 = new Student(2, "zaw zaw", new DateTime(2000, 1, 1));

//Student student3 = new Student();
////student2.StudentNo = 2;
////student2.StudentName = "John Doe 2";
////student2.DateOfBirth = new DateTime(2000, 1, 1);


//Console.WriteLine(student.StudentName);
//Console.WriteLine(student2.StudentName);

//Wallet wallet = new Wallet();
//wallet.Name = "Mg Mg";
//wallet.MobileNo = "09123456789";
//wallet.amount = 1000;
////wallet.Balance = 5000;
//wallet.SetBalance(30000);
////wallet.ShowBalance();
//Animal animal = new Animal();

//EnumUserType userType = EnumUserType.Guest;
//switch (userType)
//{
//    case EnumUserType.Guest:
//        break;

//    case EnumUserType.User:
//        break;

//    case EnumUserType.Admin:
//        break;
   
//    case EnumUserType.SuperAdmin:
//        break;

//    case EnumUserType.None:
//    default:
//        break;
//}

//string userType2 = string.Empty;
//switch (userType2)
//{
//    default:
//        break;
//}

string writeText = "Hello World!";  // Create a text string
File.WriteAllText("collin.txt", writeText);  // Create a file and write the content of writeText to it


Console.Read();

public abstract class Animal
{
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

public class Dog : Animal
{
    public override void animalSound()
    {
        throw new NotImplementedException();
    }
}

public interface ITransfer
{
    void Transfer(string fromMobileNo, string toMobileNo, decimal amount);
    void TransactionHistory(string mobileNo);
}

public class Wallet : ITransfer
{
    public void TransactionHistory(string mobileNo)
    {
        throw new NotImplementedException();
    }

    public void Transfer(string fromMobileNo, string toMobileNo, decimal amount)
    {
        throw new NotImplementedException();
    }
}

public class Bank : ITransfer
{
    //public void TransactionHistory(string mobileNo)
    //{
    //    throw new NotImplementedException();
    //}

    //public void Transfer(string fromMobileNo, string toMobileNo, decimal amount)
    //{
    //    throw new NotImplementedException();
    //}
    public void TransactionHistory(string mobileNo)
    {
        throw new NotImplementedException();
    }

    public void Transfer(string fromMobileNo, string toMobileNo, decimal amount)
    {
        throw new NotImplementedException();
    }
}

public enum EnumUserType
{
    None,
    Guest,
    User,
    Admin,
    SuperAdmin
}