using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TesteAmazon;
using AcessAmazon;


namespace AcessAmazon
{
    public class Comandos : IDisposable

    {
        public IWebDriver Navegador { get; private set; }

        public Comandos()
        {
            Navegador = GetNavegador();
        }

        public IWebDriver GetNavegador()
        {
            string pathDriver = Config.Patch;
            ChromeOptions chromeoptions = new ChromeOptions();

            bool headless = Convert.ToBoolean(Config.headless);//definir se um navegador Chrome deve ser executado em modo "headless" (sem interface gr�fica) ou n�o.
            if (headless)
                chromeoptions.AddArguments("--headless");

            Navegador = new ChromeDriver(pathDriver, chromeoptions);
            Navegador.Manage().Window.Maximize();
            Navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30); //definindo o tempo limite de espera impl�cita para a busca de elementos na p�gina.
            return Navegador;
        }


        public void AcessaAmazon(string _url)
        {
            Navegador.Navigate().GoToUrl(_url);
        }

        public void Dispose()
        {
            Navegador.Quit();
            Navegador.Dispose();
        }
    }

}
