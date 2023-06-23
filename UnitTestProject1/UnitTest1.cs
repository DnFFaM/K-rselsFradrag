using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KørselsFradrag;

namespace KørselsFradragTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void UdenBro()
        {
            double kilometer = 150;
            double dage = 1;
            int choice = 0;
            Beregn beregn = new Beregn(kilometer, dage, choice);

            // Act
            double result = beregn.KF();

            // Assert
            Assert.AreEqual(239,76, result);

        }
        [TestMethod]
        public void UdenBroM10Dage()
        {
            double kilometer = 150;
            double dage = 10;
            int choice = 0;
            Beregn beregn = new Beregn(kilometer, dage, choice);

            // Act
            double result = beregn.KF();

            // Assert
            Assert.AreEqual(239, 76, result);

        }
        [TestMethod]
        public void MedBro1()
        {
            double kilometer = 150;
            double dage = 1;
            int choice = 1;
            Beregn beregn = new Beregn(kilometer, dage, choice);

            // Act
            double result = beregn.KF();

            // Assert
            Assert.AreEqual(259,76, result);

        }
        [TestMethod]
        public void MedBro1M10Dage()
        {
            double kilometer = 150;
            double dage = 10;
            int choice = 2;
            Beregn beregn = new Beregn(kilometer, dage, choice);

            // Act
            double result = beregn.KF();

            // Assert
            Assert.AreEqual(239, 76, result);

        }
        [TestMethod]
        public void MedBro2()
        {
            double kilometer = 150;
            double dage = 1;
            int choice = 2;
            Beregn beregn = new Beregn(kilometer, dage, choice);

            // Act
            double result = beregn.KF();

            // Assert
            Assert.AreEqual(239, 76, result);

        }
        [TestMethod]
        public void MedBro2M10Dage()
        {
            double kilometer = 150;
            double dage = 10;
            int choice = 2;
            Beregn beregn = new Beregn(kilometer, dage, choice);

            // Act
            double result = beregn.KF();

            // Assert
            Assert.AreEqual(239, 76, result);

        }
    }
}
