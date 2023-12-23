using NUnit.Framework;
using SummaAgents.Services;

namespace SummaAgents_Test.TestCases;

[TestFixture]
public class AgentATest
{
    [TestCase(new double[] { 9, 10, 12, 13, 13, 13, 15, 15, 16, 16, 18, 22, 23, 24, 24, 25 } )]
    public void Test_Media_Success(double[] realNums)
    {
        // Arrange
        const double expectedOutput = 16.75;

        // Act
        IAgentsFactory factory = new AgentAFactory();
        var agent = new Agents(factory);
        var actualOutput = agent.getMedia(realNums);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestCase]
    public void Test_Media_Fail()
    {
        // Arrange
        const double expectedOutput = 16;

        // Act
        double[] realNums = new double[] { 9, 10, 12, 13, 13, 13, 15, 15, 16, 16, 18, 22, 23, 24, 24, 25 };
        IAgentsFactory factory = new AgentAFactory();
        var agent = new Agents(factory);
        var actualOutput = agent.getMedia(realNums);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestCase(4)]
    public void Test_Agent_A_For_4_Success(int steps)
    {
        // Arrange
        const string expectedOutput = @"   #
  ##
 ###
####
";

        // Act
        IAgentsFactory factory = new AgentAFactory();
        var agent = new Agents(factory);
        var actualOutput = agent.getStaircase(steps);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestCase]
    public void Test_Agent_A_For_4_Fail()
    {
        // Arrange
        const string expectedOutput = @"   #
  ##
 ###
####
";

        // Act
        IAgentsFactory factory = new AgentAFactory();
        var agent = new Agents(factory);
        var actualOutput = agent.getStaircase(5);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}