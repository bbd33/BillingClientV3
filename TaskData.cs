using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingClientV3
{
    class TaskData:Entities
    {
        public int ID { set; get; }
        public string Command { set; get; }
        public int RecepientID { set; get; }
        public int IsComplete { set; get; }
        public DateTime UpdatedOn { set; get; }
    }

    class TaskDatas : List<TaskData>
    { 
    
    }
}
