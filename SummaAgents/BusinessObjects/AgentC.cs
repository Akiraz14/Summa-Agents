using SummaAgents.BusinessObjects;
using SummaAgents.Services;

namespace SummaAgents.BusinessObjects
{
    public class AgentC : IAgents
    {
        public double getMedia(double[] realNums)
        {
            // Median

            Array.Sort(realNums);
            int median = (Int32)Math.Round((decimal)(realNums.Length / 2));

            if (realNums.Length % 2 == 0)
            {
                return (realNums[median - 1] + realNums[median]) / 2;
            }
            else
            {
                return realNums[median - 1];
            }
        }

        public string getStaircase(int steps)
        {
            string staircase = "";
            for (var i = 1; i <= steps; i++)
            {
                staircase += new string(' ', steps - i) + new string('#', i * 2 + steps - 2) + "\r\n";
            }

            for (var j = steps - 1; j >= 1; j--)
            {
                staircase += new string(' ', steps - j) + new string('#', j * 2 + steps - 2) + "\r\n";
            }

            return staircase;
        }
    }
}

public class AgentCFactory : IAgentsFactory
{
    public IAgents CreateAgent()
    {
        return new AgentC();
    }
}
