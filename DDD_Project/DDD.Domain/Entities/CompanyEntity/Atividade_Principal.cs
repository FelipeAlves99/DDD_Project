using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities.CompanyEntity
{
    public class Atividade_Principal
    {        
        public int Id { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
        
        public int CompanyId { get; set; }      
        public Company Company { get; set; }
    }
}
