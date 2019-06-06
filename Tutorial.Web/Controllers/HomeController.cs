using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial.Web.Models;
using Tutorial.Web.Service;
using Tutorial.Web.ViewModels;

namespace Tutorial.Web.Controllers
{
    public class HomeController:Controller
    {
        public IRepository<Student> StudentRepository { get; set; }
        public HomeController(IRepository<Student> repository)
        {
            StudentRepository = repository;
        }
        public IActionResult Index()
        {
            //string controllerName = this.ControllerContext.ActionDescriptor.ControllerName;
            //string actionName = this.ControllerContext.ActionDescriptor.ActionName;

            var stulist = StudentRepository.GetAll().Select(x => new StudentViewModel {
                Id = x.Id,
                Name = $"{x.FirstName} {x.LastName}",
                Age = DateTime.Now.Subtract(x.Birthday).Days / 365
            });
            var students = new HomeIndexViewModel { Students=stulist};
            return View(students);
        }

        public IActionResult Detail(int id)
        {
            var stuObj = StudentRepository.GetById(id);
            if (stuObj == null)
            {
                return View("Error","相关数据没有找到");
            }
            var studentViewModel = new StudentViewModel {
                Id = stuObj.Id,
                Name = $"{stuObj.FirstName} {stuObj.LastName}",
                Age = DateTime.Now.Subtract(stuObj.Birthday).Days/365
            };
            return View(studentViewModel);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Student s)
        {

            StudentRepository.Add(s);
            return RedirectToAction("index");
        }


        
    }
}
