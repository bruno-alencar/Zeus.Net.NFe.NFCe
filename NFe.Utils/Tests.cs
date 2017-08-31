//using DFe.Classes.Entidades;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace NFe.Utils
//{
//    public class Tests
//    {
//        [Fact]
//        public void NFeVerifyInstances()
//        {
//            // Arrange 
//            var tasks = new List<Task>();
//            var size = 4;
//            Estado[] states = { Estado.AC, Estado.AM, Estado.AP, Estado.SP };

//            //var test = new
//            //{
//            //    State = StateClass.AC,
//            //    SleepTime = 1000
//            //};

//            //var count = 0;
//            //// Act
//            //foreach(var state in states) {
//            //    Task.Run(() =>
//            //    {
//            //        CreateInstance(state);
//            //        Thread.Sleep(int.Parse((size-count).ToString("0000")));
//            //    }
//            //    );
//            //    count++;
//            //    Console.WriteLine(state.ToString());
//            //}

//            Task.Run(() =>
//            {
//                CreateInstance(states[0]);
//                Thread.Sleep(10000);


//                // Arrange
//                Assert.NotNull(ConfiguracaoServico.Instancia.cUF);
//                Assert.Equal(ConfiguracaoServico.Instancia.cUF, states[0]);
//            }
//            );

//            Task.Run(() =>
//            {
//                CreateInstance(states[1]);
//                Thread.Sleep(2000);

//                // Arrange
//                Assert.NotNull(ConfiguracaoServico.Instancia.cUF);
//                Assert.Equal(ConfiguracaoServico.Instancia.cUF, states[1]);
//            }
//            );

//            Task.Run(() =>
//            {
//                CreateInstance(states[2]);
//                Thread.Sleep(0000);

//                // Arrange
//                Assert.NotNull(ConfiguracaoServico.Instancia.cUF);
//                Assert.Equal(ConfiguracaoServico.Instancia.cUF, states[2]);
//            }
//            );

//            Task.Run(() =>
//            {
//                CreateInstance(states[3]);
//                Thread.Sleep(3000);

//                // Arrange
//                Assert.NotNull(ConfiguracaoServico.Instancia.cUF);
//                Assert.Equal(ConfiguracaoServico.Instancia.cUF, states[3]);
//            }
//            );

//            Thread.Sleep(11000);

//            Assert.NotNull(ConfiguracaoServico.Instancia.cUF);
//            Assert.Equal(ConfiguracaoServico.Instancia.cUF, states[3]);
//        }
//    }
//}
