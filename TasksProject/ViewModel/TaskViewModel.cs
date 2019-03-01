using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TasksProject.ViewModel
{
    public class TaskViewModel
    {
        [Display(Name = "Task's Number")]
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string Titulo { get; set; }
        [Display(Name = "Description")]
        public string Descricao { get; set; }
        public bool Status { get; set; }
        [Display(Name = "Created")]
        [DisplayFormat(DataFormatString ="dd/MMyyyy hh:mm:ss")]
        public DateTime Criacao { get; set; }
        [Display(Name = "Edited")]
        [DisplayFormat(DataFormatString = "dd/MMyyyy hh:mm:ss")]
        public DateTime Edicao { get; set; }
        [Display(Name = "Removed")]
        [DisplayFormat(DataFormatString = "dd/MMyyyy hh:mm:ss")]
        public DateTime Remocao { get; set; }
        [Display(Name = "Finished")]
        [DisplayFormat(DataFormatString = "dd/MMyyyy hh:mm:ss")]
        public DateTime Conclusao { get; set; }
    }
}