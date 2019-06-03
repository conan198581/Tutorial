using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial.Web.Models;

namespace Tutorial.Web.Service
{
    public class InMemoryService : IRepository<Student>
    {
        public IEnumerable<Student> Students { get; set; }
        public InMemoryService()
        {
            Students= new List<Student>() {
                new Student{ Id=1,FirstName="Kim",LastName="Taeyeon",Birthday=new DateTime(1989,3,9)},
                new Student{ Id=2,FirstName="Lim",LastName="Soojeon",Birthday=new DateTime(1979,7,11)},
                new Student{ Id=3,FirstName="Kim",LastName="Zhongmin",Birthday=new DateTime(1979,9,24)}
            };
        }
        public IEnumerable<Student> GetAll()
        {
            var stuList = Students;
            return stuList;
        }

        public Student GetById(int id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Student s)
        {
            var stulist = Students.ToList();
            stulist.Add(s);
            Students = stulist;
            

        }
        

    }
}
