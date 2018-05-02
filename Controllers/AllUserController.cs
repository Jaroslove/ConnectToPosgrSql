using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.DependencyInjection;


namespace FirstWeb.Controllers{
    public class AllUserController  : Controller{
        [HttpGet]
        public JsonResult Index(){
            var optionsBuilder = new DbContextOptionsBuilder<MyMvcContext>();
            var options = optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FirstWeb.Db;Username=Jroslove;Password=Jroslove").Options;
            using(var db = new MyMvcContext()){
                var users = db.Users.ToList();
                return Json(users);
            }
        }
    }
}