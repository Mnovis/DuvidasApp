using DuvidasApp.Entities;
using DuvidasApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuvidasApp.Services
{
    public class DuvidaService
    {
        public void RealizarDuvida()
        {
            Console.WriteLine("\nBem Vindo ao SharpAI\n");

            var duvida = new Duvida();

            Console.Write("Informe o seu nome: ");
            duvida.Usuario = Console.ReadLine() ?? string.Empty;

            Console.Write("Informe a sua dúvida: ");
            duvida.Pergunta = Console.ReadLine() ?? string.Empty;

            var pergunta = $"Responda o usuário: {duvida.Usuario} que perguntou: {duvida.Pergunta}";

            var openAiHelper = new OpenAiHelper();
            duvida.Resposta = openAiHelper.GerarResposta(pergunta);

            Console.WriteLine("\nResposta:\n");
            Console.WriteLine(duvida.Resposta);
        }
    }
}
