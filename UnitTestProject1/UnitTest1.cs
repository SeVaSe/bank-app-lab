using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Correct_Credit_Work_Test()
        {
            double endBalance = 24.00;
            BankAccount account = new BankAccount("Роман Абрамовиич", 11.00);

            account.Credit(13.00);
            double actualBalance = account.Balance;

            Assert.AreEqual(endBalance, actualBalance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), BankAccount.CreditAmountLessThanZeroMessage)]
        public void InCorrect_Credit_Otric_Test()
        {
            BankAccount account = new BankAccount("Петров Петя", 121);

            account.Credit(-1);
        }
    }
}
