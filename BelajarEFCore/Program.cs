using BelajarEFCore.Entities;
using BelajarEFCore.Repositories;

namespace BelajarEFCore;

public class Program
{
    public static void Main(string[] args)
    {
        // ini instance dari class SchoolDbContext yang digunakan untuk mengakses dan mengelola basis data
        var context = new SchoolDbContext();
        IStudentRepository studentRepository = new StudentRepository(context);

        Console.WriteLine("1. Tambah Student");
        Console.WriteLine("2. Tampilkan Student By Id");
        Console.WriteLine("3. Tampilkan Semua Student");
        Console.WriteLine("4. Update Student");
        Console.WriteLine("5. Delete Student");

        Console.WriteLine("Pilih Menu");
        var option = Console.ReadLine();

        
        switch (option)
        {
            case "1":
                Console.Write("Input Name : ");
                string name = Console.ReadLine();
                Console.Write("Input Age : ");
                int age = int.Parse(Console.ReadLine());
                var student = new Students
                {
                    StudentName = name,
                    StudentAge = age
                };
                studentRepository.Save(student);
                break;
            case "2":
                Console.Write("Input Student Id : ");
                int id = int.Parse(Console.ReadLine());
                var studentFound = studentRepository.findById(id);
                Console.WriteLine($"Name : {studentFound.StudentName}, Age : {studentFound.StudentAge}");
                break;
            case "3":
                var student2 = context.Students.ToList();
                foreach(var s in student2)
                {
                    Console.WriteLine(s);
                }
                break;
            case "4":
                Console.Write("Input Id : ");
                int id2 = int.Parse(Console.ReadLine());
                var student3 = studentRepository.findById(id2);
                Console.Write("Input New Name: ");
                student3.StudentName = Console.ReadLine();
                Console.Write("Input New Age : ");
                student3.StudentAge = int.Parse(Console.ReadLine());
                studentRepository.Update(student3);
                break;
            case "5":
                Console.Write("Input Id : ");
                int id3 = int.Parse(Console.ReadLine());
                var student4 = studentRepository.findById(id3);
                studentRepository.Delete(student4);
                break;

        }

        //var budi = new Students // instance class entitas yang mewakili table Students(kata ke 4) di basis data
        //{
        //    StudentName = "shirin",
        //    StudentAge = 4
        //};

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
