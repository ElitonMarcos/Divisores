using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System;
using Divisores.Controllers;

namespace TesteDivisores
{
    public class DivisorControllerTests
    {
        [Theory]
        [InlineData(45, new int[] { 1, 3, 5, 9, 15, 45 })]
        [InlineData(10, new int[] { 1, 2, 5, 10 })]
        [InlineData(13, new int[] { 1, 13 })]
        public void GetDivisores_RetornaDivisoresCorretos(int numero, int[] divisoresEsperados)
        {
            // Arrange
            var controller = new DivisorController();

            // Act
            var result = controller.GetDivisores(numero);

            // Assert
            Assert.Equal(divisoresEsperados, result);
        }

        [Theory]
        [InlineData(45, new int[] { 3, 5 })]
        [InlineData(10, new int[] { 2, 5 })]
        [InlineData(13, new int[] { 13 })]
        public void GetDivisoresPrimos_RetornaDivisoresPrimos(int numero, int[] divisoresPrimosEsperados)
        {
            // Arrange
            var controller = new DivisorController();

            // Act
            var result = controller.GetDivisoresPrimos(numero);

            // Assert
            Assert.Equal(divisoresPrimosEsperados, result);
        }
        


        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        public void Primo_RetornaTrueParaPrimos(int numero)
        {
            // Arrange
            var controller = new DivisorController();

            // Act
            bool result = controller.Primo(numero);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(15)]
        public void Primo_RetornaFalsoParaPrimos(int numero)
        {
            // Arrange
            var controller = new DivisorController();

            // Act
            bool result = controller.Primo(numero);

            // Assert
            Assert.False(result);
        }
    }
}