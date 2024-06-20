using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        Random rnd = new Random();
        int num = rnd.NextInt(0, 100);

        public Task(string discription)
        {

            Id = num;
            Discription = discription;
            Completed = false;
        }
    }
}