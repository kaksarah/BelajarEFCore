namespace BelajarEFCore;

public class Program
{
    public static void Main(string[] args)
    {
        // ini instance dari class SchoolDbContext yang digunakan untuk mengakses dan mengelola basis data
        var context = new SchoolDbContext();

        var budi = new Students // instance class entitas yang mewakili table Students(kata ke 4) di basis data
        {
            StudentName = "shirin",
            StudentAge = 4
        };

        // insert object budi ke dalam database
        //context.Students.Add(budi); // digunakan untuk menambahkan koleksi object budi ke dalam koleksi Students(kata ke 2) yang ada di context
        //context.SaveChanges(); // untuk menyimpan perubahan yg dibuat pada context (kata ke 1) ke dalam basis data

        // select students by id
        // why wear FirstOrDefault dibandingkan wear WHERE. Because, FirstOrDefault hanya me-return
        // elemen pertama dalam koleksi yg memenuhi kondisi, jika tidak ada data maka akan me-return null.
        // sementara where me-return seluruh elemen yang memenuhi kondisi.
        //var student = context.Students.FirstOrDefault(Students => Students.StudentId == 1);
        //Console.WriteLine(student.StudentName);
        //Console.WriteLine(student.StudentAge);

        //// select all students 
        //var student = context.Students.ToList();
        //foreach(var s in student)
        //{
        //    Console.WriteLine(s);
        //}

        //// update students
        //var student = context.Students.FirstOrDefault(Students => Students.StudentId == 1);
        //student.StudentAge = 2;
        //context.Students.Update(student);
        //context.SaveChanges();

        //// menghapus students by id
        //var student = context.Students.FirstOrDefault(Students => Students.StudentId == 1);
        //context.Students.Remove(student);
        //context.SaveChanges();
    }
}
