using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo.Model
{
    class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public List<TaskCost> TaskCostList { get; set; }

        public Task()
        {
            TaskID = 0;
            TaskName = "";
            TaskCostList = new List<TaskCost>();
        }
        
        public int AddTaskCost(TaskCost taskCost)
        {
            return 0;
        }

    }
    
    class TaskCost
    {
        public decimal Cost { get; set; }
        public decimal Percentage { get; set; }
    }
}
