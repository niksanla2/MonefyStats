using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MonefyStats.Bussines.Models;

namespace MonefyStats.UnitTest.Assets
{
    public static class MonefyTransactionAssert
    {
        private static readonly IFormatProvider FormatProvider = new CultureInfo("ru-RU");
        public static List<MonefyTransaction> TransactionsAssert = new List<MonefyTransaction>
        {
            new MonefyTransaction
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
            },
            new MonefyTransaction()
            {
                Account = "Тинькофф Мари",
                Category = "ЗП",
                Date = new DateTime(2018, 2, 26),
                Description = "Театр",
                Price = new Price
                {
                    Currency = "RUB",
                    Value = 10200.01m
                },
                ConvertedPrice = new Price
                {
                    Currency = "EUR",
                    Value = 2023m
                }
            }
        };

        public static string ToStringCsv(this MonefyTransaction monefyTransaction)
        {
            return $"{monefyTransaction.Date:dd/MM/yyyy};{monefyTransaction.Account};{monefyTransaction.Category};{monefyTransaction.Price.Value.ToString(FormatProvider)};{monefyTransaction.Price.Currency};{monefyTransaction.ConvertedPrice.Value.ToString(FormatProvider)};{monefyTransaction.ConvertedPrice.Currency};{monefyTransaction.Description}";
        }
    }
}
