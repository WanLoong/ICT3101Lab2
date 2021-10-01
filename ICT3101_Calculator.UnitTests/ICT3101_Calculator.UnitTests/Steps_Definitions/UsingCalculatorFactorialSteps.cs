using Lab2;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests.Features
{
    [Binding]
    public class UsingCalculatorFactorialSteps
    {
        private Calculator _calculator;
        private double _result;
        private Exception _actualException;
        public UsingCalculatorFactorialSteps(Calculator _calculator) // use it as ctor parameter
        {
            this._calculator = _calculator;
        }
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
           
        }
        
        [When(@"I have entered ""(.*)"" into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(int p0)
        {
            try
            {
                _result = _calculator.Factorial(p0);
            } catch (Exception ex)
            {
                _actualException = ex;
            }
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the error '(.*)' should be raised")]
        public void ThenTheErrorShouldBeRaised(string p0)
        {
            //Assert.That(_result, Throws.ArgumentException);
            Assert.AreEqual(p0, _actualException.Message);
        }


    }
}
