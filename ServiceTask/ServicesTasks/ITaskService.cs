using ServiceTask.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTask.ServicesTasks
{
    //Interface that will be use at the TaskService
    public interface ITaskService
    {
        List<TaskDto> ListTasks();
        void Create(TaskDto dto);
        TaskDto Search(int id);
        void Edit(TaskDto dto);
        void SaveTask(int id);
        void Delete(int id);
    }
}
