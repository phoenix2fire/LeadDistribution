LeadDistribution
================

Lead Distribution Application (In-Memory)

Problem satement:

You are working for a Chicago based insurance company which distributes leads gathered from its website to its network of agents.  The manufacturer has divided the city into the following regions; North, South, East and West.
Inside each territory, agents are assigned leads in a rotation.  If a new agent is hired they will go to the front of the queue for the next lead.  If an agent leaves, they are removed from the rotation. Currently there are 3 agents in the North, 4 in the South, 8 in the East and 6 in the West.
Sample lead
Name: John Doe
Territory: North
Interest: Health Insurance
Etc…

Answer: 
Territory: North
Assigned Agent: Agent 2 (Agent 1 was the last assigned in the territory)

Your job is to create the function that takes in a lead and assign it to the appropriate territory and the next dealer in line. The definition of the function signature is completely up to you. 

READ BEFORE YOU BEGIN
Please give careful consideration to 
1.  Algorithm efficiency
2.	Scaling scenarios
3.	TDD and Unit testing
4.	Long term code maintenance and business rule management.

Please refer LeadDistribution/Documents/LeadDistribution.docx for class diagrams and basic overview of solution.
