using System;
using Xunit;
using NewTalents;

namespace NewTalentsTests
{
    public class CalculadoraTests
    {
        public Calculadora construirClasse(){
            string data = "01/01/2001";
            Calculadora calc = new Calculadora("01/01/2001");
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(7, 5, 2)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.multiplicar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(4, 4, 1)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calc = construirClasse();

            calc.somar(1, 3);
            calc.somar(2, 9);
            calc.somar(3, 7);
            calc.somar(4, 5);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

        // [Fact]
        // public void Test1()
        // {
        //     Calculadora calc = new Calculadora();
        //     int resultado = calc.somar(1, 2);
        //     Assert.Equal(3, resultado);
        // }

        // [Fact]
        // public void Test2()
        // {
        //     Calculadora calc = new Calculadora();
        //     int resultado = calc.somar(4, 5);
        //     Assert.Equal(9, resultado);
        // }
    }
}