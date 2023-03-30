using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using System;
using FluentAssertions;
using System.Threading;
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
            var Command = new Comandos();   //No exemplo dado, a palavra-chave "var" está sendo usada para declarar uma nova variável chamada "command", e está sendo inicializada com uma nova instância da classe "Commands".
            Command.AcessaAmazon(_url);

            //string expectedMensagem = "Estou com sorte";
            //Thread.Sleep(5000); // Espera 5 segundos para o navegador carregar a página
            //string actualTitle = navegador.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[2]")).GetAttribute("value");
            //actualTitle.Should().Be(expectedMensagem);


        }

        public void Dispose()
        {
            // Fecha o navegador ao final do teste
            navegador.Quit();
        }
    }
}