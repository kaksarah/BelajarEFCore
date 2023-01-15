using BelajarEFCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarEFCore.Repositories
{
    public interface IStudentRepository
    {
        void Save(Students students);
        Students? findById(int id);
        List<Students> findAll();
        void Update(Students students);
        void Delete(Students students);

    }
}
