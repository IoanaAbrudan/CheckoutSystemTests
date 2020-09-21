Feature: CalculateOrders
	In order to test checkout system
	As a tester
	I want the order to be calculated corectly

Scenario: Check order for group of 4 people
	Given there is a order 4 startes 4 mains and 4 drinks 
	When the order is sent to endpoint
	Then the order is calculated corectly

Scenario: Check order for group of 2 people
	Given there is a order 1 startes 2 mains and 0 drinks 
	And the order is sent to endpoint
	And the order has been updated with 0 startes 2 mains and 0 drinks
	When the order is sent to endpoint
	Then the order is calculated corectly

Scenario: Check order for group of 4 people and canceled order
	Given there is a order 4 startes 4 mains and 4 drinks 
	And the order is sent to endpoint
	And the order has been updated with 3 startes 3 mains and 3 drinks
	When the order is sent to endpoint
	Then the order is calculated corectly
