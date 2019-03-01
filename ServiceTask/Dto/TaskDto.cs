using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTask.Dto
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Edicao { get; set; }
        public DateTime Remocao { get; set; }
        public DateTime Conclusao { get; set; }
    }
}
