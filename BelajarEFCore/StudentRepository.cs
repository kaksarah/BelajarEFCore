using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarEFCore
{

    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _schoolDbContext;

        public StudentRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public void Delete(Students students)
        {
            _schoolDbContext.Students.Remove(students);
            _schoolDbContext.SaveChanges();
        }

        public List<Students> findAll()
        {
            return _schoolDbContext.Students.ToList();
        }

        public Students? findById(int id)
        {
            return _schoolDbContext.Students.FirstOrDefault(students => students.StudentId.Equals(id));
        }

        public void Save(Students students)
        {
            _schoolDbContext.Students.Add(students);
            _schoolDbContext.SaveChanges();
        }

        public void Update(Students students)
        {
            _schoolDbContext.Students.Update(students);
            _schoolDbContext.SaveChanges();
        }
    }
}
