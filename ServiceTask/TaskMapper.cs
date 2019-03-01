using AutoMapper;
using ServiceTask.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksProject.ViewModel;

namespace ServiceTask
{
    public class TaskMapper
    {
        public static void MapperConfig()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Task, TaskDto>();
                cfg.CreateMap<TaskDto, Task>();
                cfg.CreateMap<TaskDto, TaskViewModel>();
                cfg.CreateMap<TaskViewModel, TaskDto>();
            });
        }
    }
}
