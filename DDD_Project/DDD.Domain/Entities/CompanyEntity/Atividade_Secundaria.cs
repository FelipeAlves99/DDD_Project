using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities.CompanyEntity
{
    public class Atividade_Secundaria
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }

        public int EmpresaId { get; set; }
        public Company Empresa { get; set; }
    }
}
