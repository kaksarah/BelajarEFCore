namespace BelajarEFCore;

public class Program
{
    public static void Main(string[] args)
    {
        var context = new SchoolDbContext();

        var budi = new Students
        {
            StudentName = "Budi",
            StudentAge = 15
        };

        context.Students.Add(budi);
        context.SaveChanges();
    }
}
