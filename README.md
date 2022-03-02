# PlanYourJourney (C# - Specflow - Selenium)

This repository contains automated test cases to validate the Journey Planner functionality.
1.	Verify that a valid journey can be planned using the widget. (A valid journey will consist of a valid locations entered into the widget)
2.	Verify that the widget is unable to provide results when an invalid journey is planned. (An invalid journey will consist of 1 or more invalid locations entered into the widget). 
3.	Verify that the widget is unable to plan a journey if no locations are entered into the widget. 
4.	On the Journey results page, verify that a journey can be amended by using the “Edit Journey” button.
5.	Verify that the “Recents” tab on the widget displays a list of recently planned journeys. 


## *Requirements*

1. Git or Command Prompt - Terminal
2. Visual Studio Community 2022 - Version 17.1.0
3. Microsoft.NET SDK 6.0.200(x64) from Visual Studio
4. Specflow for Visual Studio 2022 Extension

## *Set up and Running tests*

1. Open a terminal
2. Clone the repo 'git clone git@github.com:Nimiya/PlanYourJourney.git'
3. Navigate to the reposiyory folder
4. Open the project 'PlanYourJourney' in Visual Studio IDE
5. Run (Double click) the file PlanYourJourney.sln
6. Install all the dependencies
7. Open PlanYourJourney\Features\JourneyPlanner.feature
8. Click on Build -> Build Solution (Ctrl+Shift+B)
9. Once the Build is succeeded, Click on Test -> Test Explorer
10. Click on Run all tests in View


## *Framework Design*

Nimiya Joseph


