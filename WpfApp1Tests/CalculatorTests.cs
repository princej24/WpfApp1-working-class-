using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace WpfApp1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private double actualoutcome;


        // arrangr 

        // act 

        // assert 

        [TestMethod()]
        public void addTestsuccess ()
        {

            // arrange
            Calculator calc = new Calculator();
            double number1 = 2;
            double number2 = 2;
            double expected = 4;

            double outcome = calc.add(number1, number2);


            Assert.AreEqual(expected ,outcome );
            // Assert.Fail();

           
        }


        [TestMethod()]
        public void AddTestFail()
        {
            Calculator calc = new Calculator();

            double number1 = 2;
                
            double number2 = 2;

            double notexpected = 4;


            // act 
            double actual = calc.add(number1, number2);
            // assert 
            Assert.AreNotEqual(notexpected, actual);


            double outcome = calc.add(number1, number2);



        }

        public void multiplyTestSuccess()
        {
            Calculator calculator = new Calculator();   
            double number1 = 2;
                double number2 = 2;
                double expected = 50 ;


            double outcome = multiply (number1, number2);
            Assert.AreEqual(expected ,outcome );
        }

        private double multiply(double number1, double number2)
        {
            throw new NotImplementedException();
        }

        public void multiplyTestFail()
        {
            Calculator calculator = new Calculator();
            double number1 = 2;
            double number2 = 2;
            double expected = 50;


            double actual = multiply(number1, number2);
            Assert.AreEqual(expected, actual );
        }
    }
}