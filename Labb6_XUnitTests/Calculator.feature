Feature: Calculator
  As a user of the calculator
  I want to be able to perform basic arithmetic operations
  So that I can get the correct results for my calculations

  Scenario: Addition
    Given the calculator is turned on
    When I enter 5
    And I enter 5
    And I press add
    Then the result should be 10

  Scenario: Subtraction
    Given the calculator is turned on
    When I enter 10
    And I enter 5
    And I press subtract
    Then the result should be 5

  Scenario: Multiplication
    Given the calculator is turned on
    When I enter 5
    And I enter 5
    And I press multiply
    Then the result should be 25

  Scenario: Division
    Given the calculator is turned on
    When I enter 6
    And I enter 3
    And I press divide
    Then the result should be 2

  Scenario: Division by zero
    Given the calculator is turned on
    When I enter 6
    And I enter 0
    And I press divide
    Then an error message should be displayed saying "Division by zero is not allowed."
