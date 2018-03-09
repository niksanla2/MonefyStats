using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonefyStats.Bussines;
using MonefyStats.Bussines.Models;
using NUnit.Framework;
using System;
using MonefyStats.UnitTest.Assets;

namespace MonefyStats.UnitTest
{
    [TestFixture]
    public class MonefyTransactionTest
    {
        [Test]
        public void ConvertFromString_Success()
        {
            //Arrange
            var exptectedMonefyTransaction = MonefyTransactionAssert.TransactionsAssert[0];
            var str = exptectedMonefyTransaction.ToStringCsv();
            //Act
            var resultMonefyTransaction = MonefyTransaction.ConvertFromString(str);
            //Assert
            resultMonefyTransaction.Should().BeEquivalentTo(exptectedMonefyTransaction);
        }
    }
}
