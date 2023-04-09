using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public User Owner { get;}

        public string Title { get;}
        public bool IsCompleted { get;}

        public Todo(User owner, string title)
        {
            owner = owner;
            Title = title;
        }
    }

   
}
