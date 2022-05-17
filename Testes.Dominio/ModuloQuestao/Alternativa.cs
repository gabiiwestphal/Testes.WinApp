using System;

namespace Testes.Dominio.ModuloQuestao
{
    public class Alternativa
    {
        public Guid Id { get; set; }

        public string Resposta { get; set; }

        public bool Correta { get; set; }
    }
}