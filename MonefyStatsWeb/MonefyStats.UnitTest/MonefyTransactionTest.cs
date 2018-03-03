using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonefyStatsBussines;
using NUnit.Framework;
using System;

namespace MonefyStats.UnitTest
{
    [TestFixture]
    public class MonefyTransactionTest
    {
        [Test]
        public void ConvertFromString_Test()
        {
            //Arrange
            var str = "26/02/2018;Тинькофф Ник;Кэш Бэк;-10 000,01;RUB;20,0;EUR;Тест, тест";
            var exptectedMonefyTransaction = new MonefyTransaction()
            {
                Account = "Тинькофф Ник",
                Category = "Кэш Бэк",
                Date = new DateTime(2018, 2, 26),
                Description = "Тест, тест",
                Price = new Price
                {
                    Currency = "RUB",
                    Value = -10000.01m
                },
                ConvertedPrice = new Price
                {
                    Currency = "EUR",
                    Value = 20m
                }
            };

            //Act
            var resultMonefyTransaction = MonefyTransaction.ConvertFromString(str);
            //Assert
            resultMonefyTransaction.Should().BeEquivalentTo(exptectedMonefyTransaction);
        }
    }
}
