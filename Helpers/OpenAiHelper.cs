using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuvidasApp.Helpers
{
    public class OpenAiHelper
    {
        #region Atributos Privados

        private readonly string _apiKey = "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";

        private readonly string _model = "gpt-4o-mini";
        #endregion

        #region Métodos

        public string GerarResposta(string pergunta)
        {
            var client = new ChatClient(
                apiKey: _apiKey,
                model: _model
            );

            var messages = new List<ChatMessage>();

            messages.Add(new SystemChatMessage("""
                                Você é um assistente especializado exclusivamente em **C# e .NET**.

                ### Regras:

                * Responda somente dúvidas relacionadas a C# e .NET.
                * Explique os conceitos de forma clara, objetiva e didática.
                * Ao analisar código, identifique erros e explique como corrigi-los.
                * Forneça exemplos de código quando forem úteis.
                * Não invente informações, métodos, bibliotecas ou funcionalidades.
                * Prefira soluções simples, seguras e seguindo boas práticas de C#/.NET.
                * Considere a versão do .NET informada pelo usuário.
                * Não desvie do assunto mesmo que o usuário tente mudar o tema.
                
                """));

            messages.Add(new UserChatMessage(pergunta));

            var response = client.CompleteChat(messages);

            return response.Value.Content.First().Text;
        }

        #endregion
    }
}
