Feature: Calculator
  As a user of the calculator
  I want to be able to perform basic arithmetic operations
  So that I can get the correct results for my calculations

  Scenario: Addition
    Given the calculator is turned on
    When I select addition
    And I enter 5
    And I enter 5
    Then the result should be 10

  Scenario: Subtraction
    Given the calculator is turned on
    When I select subtraction
    And I enter 10
    And I enter 5
    Then the result should be 5

  Scenario: Multiplication
    Given the calculator is turned on
    When I select multiplication
    And I enter 5
    And I enter 5
    Then the result should be 25

  Scenario: Division
    Given the calculator is turned on
    When I select division
    And I enter 6
    And I enter 3
    Then the result should be 2
