using DesafioSouth;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class DeformarUnitTest
    {
        [Theory]
        [InlineData("South System", "TpvUI TztUfn")]
        [InlineData("Abc xyz", "Bcd yzA")]
        public void DeformarOK(string entrada, string esperado)
        {
            Assert.Equal(esperado, Deformador.Deformar(entrada));
        }

        [Theory]
        [InlineData("South System", "TpvUi SztUfn")]
        [InlineData("Abc xyz", "Bcd yza")]
        public void DeformarNOK(string entrada, string esperado)
        {
            Assert.NotEqual(esperado, Deformador.Deformar(entrada));
        }

        [Fact]
        public void DeformarNull()
        {
            Assert.Throws<ArgumentNullException>(() => Deformador.Deformar(null));
        }

        [Theory]
        [InlineData("    ")]
        [InlineData("")]
        [InlineData("           ")]
        public void DeformarEmpty(string entrada)
        {
            Assert.Throws<ArgumentException>(() => Deformador.Deformar(entrada));
        }
    }
}
