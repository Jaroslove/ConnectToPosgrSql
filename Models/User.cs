using Microsoft.EntityFrameworkCore;
using System;

namespace FirstWeb{

    public class User{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegisterTime {get; set;}
    }
}