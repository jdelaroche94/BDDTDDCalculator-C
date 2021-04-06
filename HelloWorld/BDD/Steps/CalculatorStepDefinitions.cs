using TechTalk.SpecFlow;
using FluentAssertions;

namespace BDD.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly HelloWorldCore.Program _calculator = new HelloWorldCore.Program();
        private int _number1;
        private int _number2;
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            //calculator = new HelloWorldCore.Program();
           // result = 0;

        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            _number1 = number;
            //_scenarioContext.Pending();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            _number2 = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            _result = _calculator.AddTwoNumbers(_number1, _number2);
         
        }

        [When("the two numbers are multiply")]
        public void WhenTheTwoNumbersAreMultiply()
        {
            //TODO: implement act (action) logic
            _result = _calculator.MultiplyTwoNumbers(_number1, _number2);

        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            _result = _calculator.SubstractTwoNumbers(_number1, _number2);
        }



        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            _result.Should().Be(result);
            //_scenarioContext.Pending();
        }
    }
}
