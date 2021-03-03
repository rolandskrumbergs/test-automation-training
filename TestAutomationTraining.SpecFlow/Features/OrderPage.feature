Feature: OrderPage
	Simple calculator for adding two numbers

@mytag
Scenario: Open Create new order page
	Given I have navigated to orders page
	And clicked create new button
	Then order form is visible