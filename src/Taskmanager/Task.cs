using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taskmanager
{
    public class Task
    {
        private int id;
        private string discription;
        private bool completed;

        public int Id { set { id = value; } get { return id; } }
        public string Discription { set; get; }
        public bool Completed { set; get; }


        public Task(int id, string discription, bool completed)
        {
            Id = id;
            Discription = discription;
            Completed = completed;
        }
    }
}