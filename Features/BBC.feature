Feature: BBC

As a BBC Legal Advisor
I want a copyright disclaimer ot be displayed in the footer on the BBC New Entertainment & Arts page
So that we are protected from legal action arising from external content

@tag1
Scenario: Entertainment & Arts Footer contains Copyright Disclaimer
	Given I am on the BBC Homepage
	When I navaigate to the Entertainment & Arts page
	Then the footer text equals Copyright © 2022 BBC. The BBC is not responsible for the content of external sites.
