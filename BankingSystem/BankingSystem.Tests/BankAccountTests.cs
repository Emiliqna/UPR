using NUnit.Framework;
using System;
namespace BankingSystem.Tests
{
    public class BankAccountTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldSetFieldsCorrectly()
        {
            //Arrange
            int id = 123;
            decimal balance = 100;

            //Act
            BankAccount account = new BankAccount(id, balance);

            //Assert
            Assert.AreEqual(id, account.Id);
            Assert.AreEqual(balance, account.Balance);
        }

        [Test]
        public void DepositShouldIncreaseBalance()
        {
            //Arrange
            int id = 123;
            decimal balance = 100;
            BankAccount account = new BankAccount(id, balance);
            decimal depositAmount = 200;

            //Act
            account.Deposit(depositAmount);

            //Assert
            Assert.AreEqual(balance + depositAmount,
                account.Balance);
        }

        [TestCase(-200)]
        [TestCase(0)]
        public void DepositeShouldThrowException(decimal
             depositAmount)
        {
            //Arrange
            int id = 123;
            decimal balance = 100;
            BankAccount account = new BankAccount(id, balance);
          

            //Act & Assert

            Assert.Throws<InvalidOperationException>(() =>
            account.Deposit(depositAmount));
        }

    }
}