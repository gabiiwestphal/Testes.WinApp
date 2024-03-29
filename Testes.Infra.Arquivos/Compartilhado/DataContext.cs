﻿using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Testes.Dominio.ModuloDisciplina;
using Testes.Dominio.ModuloMateria;
using Testes.Dominio.ModuloQuestao;
using Testes.Dominio.ModuloTeste;

namespace Testes.Infra.Arquivos.Compartilhado.Serializador
{
    public class DataContext
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Disciplinas = new List<Disciplina>();

            Materias = new List<Materia>();

            Questoes = new List<QuestaoObjetiva>();

            Testes = new List<Teste>();
        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Disciplina> Disciplinas { get; set; }
        
        public List<Materia> Materias { get; set; }

        public List<QuestaoObjetiva> Questoes { get; set; }

        public List<Teste> Testes { get; set; }

        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Disciplinas.Any())
                this.Disciplinas.AddRange(ctx.Disciplinas);

            if (ctx.Materias.Any())
                this.Materias.AddRange(ctx.Materias);

            if (ctx.Questoes.Any())
                this.Questoes.AddRange(ctx.Questoes);

            if (ctx.Testes.Any())
                this.Testes.AddRange(ctx.Testes);
        }
    }
}