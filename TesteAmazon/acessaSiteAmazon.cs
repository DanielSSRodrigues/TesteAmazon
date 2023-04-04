using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using System;
using TesteAmazon;
using AcessAmazon;

namespace acessaAmazon
{
    public class acessaSiteAmazon : IDisposable
    {
        private readonly IWebDriver navegador;
        private readonly string _url;
        public acessaSiteAmazon()
        {
            _url = Config._url;
            navegador = new ChromeDriver();

        }

        [Fact]
        public void TesteAcessoAmazon()
        {
            var Command = new Comandos();   // a palavra-chave "var" está sendo usada para declarar uma nova variável chamada "command"
            Command.AcessaAmazon(_url);
           
        }

        public void Dispose()
        {
            // Fecha o navegador ao final do teste
            navegador.Quit();
        }
    }
}