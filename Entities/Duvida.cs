using System;
using System.Collections.Generic;
using System.Text;

namespace DuvidasApp.Entities
{
    public class Duvida
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Usuario { get; set; } = string.Empty;
        public string Pergunta { get; set; } = string.Empty;
        public string Resposta { get; set; } = string.Empty;
    }
}
