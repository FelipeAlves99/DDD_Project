using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Entities.CompanyEntity
{
    public class Company
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Tipo { get; set; }
        public string Abertura { get; private set; }
        public string Nome { get; private set; }
        public string Fantasia { get; private set; }
        public string Porte { get; private set; }
        public IList<Atividade_Principal> Atividade_Principal { get; private set; }
        public IList<Atividade_Secundaria> Atividades_Secundarias { get; private set; }
        public string Natureza_Juridica { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Municipio { get; private set; }
        public string Uf { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Efr { get; private set; }
        public string Situacao { get; private set; }
        public string Data_Situacao { get; private set; }
        public string Motivo_situacao { get; private set; }
        public string Situacao_Especial { get; private set; }
        public string Data_Situacao_Especial { get; private set; }

        public IList<Order> Orders { get; private set; }

        //validations
    }
}
