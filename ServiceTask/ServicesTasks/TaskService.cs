using AutoMapper;
using ServiceTask.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TasksProject.Data;
using TasksProject.Models;

namespace ServiceTask.ServicesTasks
{
    public class TaskService : ITaskService
    {
        TaskContext db = new TaskContext();
        //Base Logic with Dto
        public void Create(TaskDto dto)
        {
            var model = Mapper.Map<Task>(dto);
            db.Tasks.Add(model);
            db.SaveChanges();
        }

        public List<TaskDto> ListTasks()
        {
            var lista = db.Tasks.Where(x=> x.Remocao != null && x.Remocao.Year ==  1900).ToList();
            var dto = Mapper.Map<List<TaskDto>>(lista);
            return dto;
        }
        public TaskDto Search(int id)
        {
            var model = db.Tasks.Find(id);
            var dto = Mapper.Map<TaskDto>(model);
            return dto;
        }
        public void Edit(TaskDto dto)
        {
            Task model = db.Tasks.Find(dto.Id);
            var newModel = Mapper.Map<Task>(dto);
            model.Titulo = newModel.Titulo;
            model.Descricao = newModel.Descricao;
            model.Edicao = DateTime.Now;
            db.SaveChanges();
        }
        public void SaveTask(int id)
        {
            var task = db.Tasks.Find(id);
            task.Status = true;
            task.Conclusao = DateTime.Now;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var task = db.Tasks.Find(id);
            task.Remocao = DateTime.Now;
            db.SaveChanges();
        }
    }
}
