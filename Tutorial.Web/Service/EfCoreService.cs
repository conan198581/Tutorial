using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial.Web.Data;
using Tutorial.Web.Models;

namespace Tutorial.Web.Service
{
    public class EfCoreService : IRepository<Student>
    {
        public DataDbContext DataDbContext;
        public EfCoreService(DataDbContext dataDbContext)
        {
            DataDbContext = dataDbContext;
        }
        public void Add(Student student)
        {
            DataDbContext.Students.Add(student);
            DataDbContext.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            return DataDbContext.Students.ToList();
        }

        public Student GetById(int id)
        {
            return DataDbContext.Students.FirstOrDefault(x => x.Id == id);
        }
    }
}
