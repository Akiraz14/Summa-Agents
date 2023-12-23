using SummaAgents.Services;

namespace SummaAgents.BusinessObjects
{
    public class AgentA : IAgents
    {
        public double getMedia(double[] realNums)
        {
            // Mean

            double sum = 0;
            foreach (double x in realNums)
            { sum += x; }

            return sum / realNums.Length;
        }

        public string getStaircase(int steps)
        {
            string staircase = "";
            for (var i = 1; i <= steps; i++)
            {
                staircase += new string(' ', steps - i) + new string('#', i) + "\r\n";
            }
            return staircase;
        }
    }
}
