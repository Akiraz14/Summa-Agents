using SummaAgents.Services;

namespace SummaAgents.BusinessObjects
{
    public class AgentB : IAgents
    {
        public double getMedia(double[] realNums)
        {
            // Harmonic mean

            double reciprocal = 0;
            foreach (double x in realNums)
            { reciprocal += 1 / x; }

            return Math.Round(realNums.Length / reciprocal, 2);
        }

        public string getStaircase(int steps)
        {
            string staircase = "";
            for (var i = steps; i >= 1; i--)
            {
                staircase += new string(' ', steps - i) + new string('#', i) + "\r\n";
            }
            return staircase;
        }
    }
}
