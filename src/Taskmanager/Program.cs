using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskmanager
{
    internal class Program
    {
        public static void main(String[] args)
        {
            Taskmanager manager = new Taskmanager();
            manager.addTask("Learn Java");
            manager.addTask("Write Code");
            manager.showTasks();

            manager.markTaskAsCompleted(1);
            manager.showCompletedTasks();
        }
    }
}
