using System;
using Xunit;
using TechTalk.SpecFlow;

namespace ExamRQE
{
    [Binding]
    public class SpecFlowFeature1Steps
        
    {
        private int number;
        private int number2;
        private int result;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            number = (int)p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p1)
        {
            number2 = (int)p1;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = number + number2;
        }
        
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = number - number2;
        }
        
        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = number * number2;
        }
        
        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = number / number2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = result;
            Assert.Equal(expected, actual);
        }
    }
}
