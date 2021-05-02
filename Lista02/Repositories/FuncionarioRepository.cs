using Lista02.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lista02.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            var path = $"c:\\temp\\funcionario_{funcionario.IdFuncionario}.json";
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            using (var streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(json);
            }

        }
    }
}


