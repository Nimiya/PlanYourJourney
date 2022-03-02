Feature: Verify Journey Planner Functionality
		Verify the given 5 scenarios to ensure that the Journey planner widget of TFL website is working as expected

@ValidJourney
Scenario: Verify that a valid journey can be planned using the widget
	Given User navigates to the Journey Planner widget
	When User enters valid locations <From> and <To> into the widget
	Then User should see the journey results
Examples: 
| From					| To									|
| Ilford Rail Station	| Stratford (London), Stratford Park	|


@InValidJourney
Scenario: Verify that the widget is unable to provide results when an invalid journey is planned
	Given User navigates to the Journey Planner widget
	When User enters invalid locations <From> and <To> into the widget
	Then User should not see the journey results
Examples: 
| From		| To		|
| ABC1234	| XYZ456	|

@Recents
Scenario: Verify that the “Recents” tab on the widget displays a list of recently planned journeys
	Given User navigates to the Journey Planner widget
	When User clicks on Recents tab
	Then User should see the list of recently planned journeys

@NoLocations
Scenario: Verify that the widget is unable to plan a journey if no locations are entered into the widget.
	Given User navigates to the Journey Planner widget
	When User doesnot enter any locations to the widget
	Then User should see error message

	
@UpdateJourney
Scenario: Verify that a journey can be amended by using the “Edit Journey” button
	Given User navigates to the Journey Planner widget
	When User enters valid locations <From> and <To> into the widget
	Then User should be able to edit the journey
Examples: 
| From					| To									|
| Ilford Rail Station	| Stratford (London), Stratford Park	| 