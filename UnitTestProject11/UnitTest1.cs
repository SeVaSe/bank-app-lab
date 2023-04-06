using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject11
{
    [TestClass]
    public class UnitTest11
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


        [TestMethod]
        public void Correct_Debit_Work_Test()
        {
            double endBalance = 10.20;
            BankAccount account = new BankAccount("Джеймс Уэб", 32);

            account.Debit(21.80);
            double actualBalance = account.Balance;

            Assert.AreEqual(endBalance, actualBalance);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), BankAccount.DebitAmountLessThanZeroMessage)]
        public void InCorrect_Debit_Otric_Sum_Tests()
        {
            BankAccount account = new BankAccount("Harry Smith", 312);

            account.Debit(-123);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), BankAccount.DebitAmountExceedsBalanceMessage)]
        public void InCorrect_Debit_More_Sum_Tests()
        {
            BankAccount account = new BankAccount("Jacy Leycy", 21);

            account.Debit(2005203);
        }

    }
}

