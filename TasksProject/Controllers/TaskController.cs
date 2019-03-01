using AutoMapper;
using ServiceTask.Dto;
using ServiceTask.ServicesTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksProject.ViewModel;

namespace TasksProject.Controllers
{
    public class TaskController : Controller
    {
        // Interface that call the methods
        private readonly ITaskService _taskService;
        public TaskController()
        {
            _taskService = new TaskService();//Class that is responsable to separe front and back in controller
        }
        // GET: Tasks
        public ActionResult Index()
        {
           var dto = _taskService.ListTasks();
            var viewModel = Mapper.Map<List<TaskDto>,List<TaskViewModel>>(dto);
            return View(viewModel);
        }
        //Create Task
        public void Create([Bind(Include = "Titulo,Descricao")]TaskViewModel viewModel)
        {
            viewModel.Criacao = DateTime.Now;
            viewModel.Status = false;
            viewModel.Remocao = new DateTime(1900, 01, 01);
            viewModel.Edicao = new DateTime(1900, 01, 01);
            viewModel.Conclusao = new DateTime(1900, 01, 01);
            var dto = Mapper.Map<TaskViewModel, TaskDto>(viewModel);
            _taskService.Create(dto);
        }
        //Find a Task using id into Service
        public JsonResult Search(int id)
        {
           var dto = _taskService.Search(id);
            var viewModel = Mapper.Map<TaskViewModel>(dto);
            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
        //Edit Service passing viewmodel to Service
        public void Edit(TaskViewModel viewModel)
        {
            var dto = Mapper.Map<TaskDto>(viewModel);
            _taskService.Edit(dto);
        }
        //Change the status value when you done a task
        public void SaveTask(int id)
        {
            _taskService.SaveTask(id);
        }
        //make a logic exclusion 
        public void Delete(int id)
        {
            _taskService.Delete(id);
        }
    }
}