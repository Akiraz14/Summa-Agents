using NUnit.Framework;
using SummaAgents.Services;

namespace SummaAgents_Test.AgentsTests;

public class AgentBTest
{
    [TestCase(4)]
    public void Test_Agent_B_For_4_Success(int steps)
    {
        // Arrange
        const string expectedOutput = @"####
 ###
  ##
   #
";

        // Act
        using var consoleOutput = new ConsoleOutput();
        IAgentsFactory factory = new AgentBFactory();
        var agent = new Agents(factory);
        var actualOutput = agent.getStaircase(steps);
        //var actualOutput = consoleOutput.GetOutput();

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestCase]
    public void Test_Agent_B_For_4_Fail()
    {
        // Arrange
        const string expectedOutput = @"####
 ###
  ##
   #
";

        // Act
        using var consoleOutput = new ConsoleOutput();
        IAgentsFactory factory = new AgentBFactory();
        var agent = new Agents(factory);
        var actualOutput = agent.getStaircase(5);
        //var actualOutput = consoleOutput.GetOutput();

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}