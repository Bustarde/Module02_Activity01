using Module02_Activity01.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module02_Activity01.ViewModel
{
    class TaskViewModel
    {
        // Create a link between Model and ViewModel 
        // Add 'using (projet name).Model; 
       public TaskModel TaskModelSet { get; set; }

       public TaskViewModel()
        {
            TaskModelSet = new TaskModel()
            {
                Subjectcode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3
            };
        }
    }
}
