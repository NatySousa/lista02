using System;
using System.Collections.Generic;


namespace Lista02.Entities
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Departamento Departamento { get; set; }

    }
}
