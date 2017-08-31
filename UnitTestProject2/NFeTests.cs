using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DFe.Classes.Entidades;
using System.Threading.Tasks;
using System.Threading;
using NFe.Utils;

namespace Nfe.Tests
{
    [TestClass]
    public class NFeTests
    {
        public class ConfigurationTests
        {
            public Estado State { get; set; }
            public TimeSpan SleepTime { get; set; }
        }

        [TestMethod]
        public void NFeConfiguracaoService_WhenTryCallAsynchronously_ReturnsTheSameInstance()
        {
            var configuration1 = new ConfigurationTests { State = Estado.AC, SleepTime = TimeSpan.FromSeconds(10) };
            var configuration2 = new ConfigurationTests { State = Estado.AM, SleepTime = TimeSpan.FromSeconds(2) };
            var configuration3 = new ConfigurationTests { State = Estado.AP, SleepTime = TimeSpan.FromSeconds(0) };
            var configuration4 = new ConfigurationTests { State = Estado.SP, SleepTime = TimeSpan.FromSeconds(3) };

            ConfigurationTests[] configurations = { configuration1, configuration2, configuration3, configuration4 };

            foreach (var configuration in configurations)
            {
                Task.Run(() =>
                {
                    var service = new ConfiguracaoServico();
                    service.cUF = configuration.State;

                    Thread.Sleep(configuration.SleepTime);

                    // Arrange
                    Assert.IsNotNull(service.cUF);
                    Assert.AreEqual(service.cUF, configuration.State);
                }
                );
            }

            Thread.Sleep(TimeSpan.FromSeconds(12));
        }

        [TestMethod]
        public void NFeConfiguracaoService_WhenTryCallAsynchronously_ReturnsWrongInstance()
        {
            var configuration1 = new ConfigurationTests { State = Estado.AC, SleepTime = TimeSpan.FromSeconds(10) };
            var configuration2 = new ConfigurationTests { State = Estado.AM, SleepTime = TimeSpan.FromSeconds(2) };
            var configuration3 = new ConfigurationTests { State = Estado.AP, SleepTime = TimeSpan.FromSeconds(0) };
            var configuration4 = new ConfigurationTests { State = Estado.SP, SleepTime = TimeSpan.FromSeconds(3) };

            ConfigurationTests[] configurations = { configuration1, configuration2, configuration3, configuration4 };

            foreach (var configuration in configurations)
            {
                Task.Run(() =>
                {
                    ConfiguracaoServico.Instancia.cUF = configuration.State;

                    Thread.Sleep(configuration.SleepTime);

                    // Arrange
                    Assert.IsNotNull(ConfiguracaoServico.Instancia.cUF);
                    Assert.AreEqual(ConfiguracaoServico.Instancia.cUF, configuration.State);
                }
                );
            }

            Thread.Sleep(TimeSpan.FromSeconds(12));
        }
    }
}
