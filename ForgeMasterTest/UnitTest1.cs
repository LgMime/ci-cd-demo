// ForgeMaster.Tests/SmithTests.cs

using Xunit;
using Moq;
using ForgeMaster; // Необхідно, щоб бачити інтерфейси та класи

public class SmithTests
{
    // Тест 1: Перевіряє, чи NorwaySmith викликає CreateSword з правильним повідомленням.
    [Fact]
    public void NorwaySmith_Calls_CreateSword_With_Correct_Message()
    {
        // Arrange (Підготовка)
        // 1. Створюємо мок-об'єкт для інтерфейсу ISwordCreateRoot
        var mockSwordCreator = new Mock<ISwordCreateRoot>();

        // 2. Створюємо NorwaySmith, передаючи йому мок-об'єкт
        var norwaySmith = new NorwaySmith(mockSwordCreator.Object);

        // Очікуваний рядок, який NorwaySmith має передати в CreateSword
        var expectedMessage = "Norway Smith is forging a sword.";

        // Act (Дія)
        norwaySmith.ForgeSword();

        // Assert (Перевірка)
        // Перевіряємо, чи метод CreateSword був викликаний рівно один раз (Times.Once()) 
        // і чи був він викликаний з очікуваним рядком (It.Is<string>(s => s == expectedMessage))
        mockSwordCreator.Verify(
            x => x.CreateSword(It.Is<string>(s => s == expectedMessage)),
            Times.Once(),
            "Norway Smith did not call CreateSword with the correct message."
        );
    }

    // Тест 2: Перевіряє, чи JapanSmith викликає CreateSword з правильним повідомленням.
    [Fact]
    public void JapanSmith_Calls_CreateSword_With_Correct_Message()
    {
        // Arrange (Підготовка)
        var mockSwordCreator = new Mock<ISwordCreateRoot>();
        var japanSmith = new JapanSmith(mockSwordCreator.Object);
        var expectedMessage = "Japan Smith is forging a sword.";

        // Act (Дія)
        japanSmith.ForgeSword();

        // Assert (Перевірка)
        // Перевіряємо, чи CreateSword був викликаний рівно один раз з очікуваним рядком
        mockSwordCreator.Verify(
            x => x.CreateSword(It.Is<string>(s => s == expectedMessage)),
            Times.Once(),
            "Japan Smith did not call CreateSword with the correct message."
        );
    }
}