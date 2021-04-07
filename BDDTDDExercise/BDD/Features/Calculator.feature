Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](BDD/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@AddTwoNumbers
Scenario: Add two numbers
	Given the first number is 11
	And the second number is 12
	When the two numbers are added
	Then the result should be 23

@AddMultipleNumbers
Scenario Outline: Add two numbers2
Given the first number is <First>
And the second number is <Second> 
When the two numbers are added
Then the result should be <Result>

Examples:
    | First | Second | Result |
    | 50    | 70     | 120    |
    | 30    | 40     | 70     |
    | 60    | 30     | 90     |


@MultipleNumbers
Scenario Outline: Multiply two numbers
Given the first number is <First>
And the second number is <Second> 
When the two numbers are multiply
Then the result should be <Result>

Examples:
    | First | Second | Result |
    | 6     | 2      | 12     |
    | 5     | 3      | 15     |
    | -2    | 3      | -6     |
    | 2     | -3     | -6     |
    | -2    | -3     |  6     |

@SubstractNumbers
Scenario Outline: Substract two numbers
Given the first number is <First>
And the second number is <Second> 
When the two numbers are substracted
Then the result should be <Result>

Examples:
    | First | Second | Result |
    | 50    | 20     | 30     |
    | -30   | 40     | -70    |
    | 60    | -30    | 90     |