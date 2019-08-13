Feature: CBA
	 Overseas page

@mytag
Scenario: Overseas page sub topic check 
	Given I am on the home page
	When I click link to go to oversea page
	Then all of the sub topic shoule be present as expected
	#List all of the topics here as a data driven test	
	| Topic                                 |
	| 1.A mix of cash and cards             |
	| 2. Get travel insurance               |
	| 3. Review home and contents insurance |
	| 4. Check your limits                  |
	When I click netbank logon link
	Then Page 'log on to NetBank' should be opened with username and password fields
