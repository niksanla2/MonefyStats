using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using MonefyStats.Bussines.Models;
using MonefyStats.Bussines.Services;
using MonefyStats.UnitTest.Assets;
using NUnit.Framework;

namespace MonefyStats.UnitTest
{
    [TestFixture]
    public class MonefyTransactionServiceTest
    {

        [Test]
        public void GetTransactionFromFile_Success()
        {
            //Arrange
            var sut = new MonefyTransactionService();

            var assetTransactonList = MonefyTransactionAssert.TransactionsAssert.Take(2).ToList();

            var textMessage = $"date;account;category;amount;currency;converted amount;currency;description\n" 
                + assetTransactonList[0].ToStringCsv() + "\n"
                + assetTransactonList[1].ToStringCsv() + "\n";

            var byteArray = Encoding.UTF8.GetBytes(textMessage);
            var file = new FileBussines
            {
                Content = byteArray
            };
            //Act
            var transactions = sut.GetTransactionsFromFile(file);
            //Assert
            transactions.Should().BeEquivalentTo(assetTransactonList);
        }
    }
}
