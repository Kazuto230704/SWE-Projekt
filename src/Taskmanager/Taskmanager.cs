using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Taskmanager
{
    public class Taskmanager
    {
        private Task[] liste;
        private int Count = 0;

        public void addTask(Task task)
        {
            liste[Count] = task;
            Count++;
        }

        public void showTasks()
        {
            foreach (Task task in liste)
            {
                System.Console.WriteLine(task.ToString());
            }

        }

        public void markTaskAsCompleted(int id)
        {
            foreach (Task task in liste)
            {
                if (task.Id == id)
                {
                    task.Completed = true;
                }
            }
        }

        public void showCompletedTasks()
        {
            foreach (Task task in liste)
            {
                if (task.Completed == true)
                {
                    System.Console.WriteLine(task.ToString());
                }
            }
        }
    }
}