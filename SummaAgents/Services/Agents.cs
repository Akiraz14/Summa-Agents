namespace SummaAgents.Services
{
    public class Agents
    {

        private readonly IAgentsFactory _agentsFactory;

        public Agents(IAgentsFactory agentsFactory)
        {
            _agentsFactory = agentsFactory;
        }

        /// <summary>
        /// Find the mean, harmonic mean or median of a real number' list.
        /// </summary>
        /// <param name="agentType">Agent type.</param>
        /// <param name="realNums">List of real numbers.</param>
        /// <returns>Mean, harmonic mean or Median result.</returns>
        public double getMedia(double[] realNums)
        {
            var agent = _agentsFactory.CreateAgent();
            return agent.getMedia(realNums);
        }

        /// <summary>
        /// Get a string representing a staircase.
        /// </summary>
        /// <param name="agentType">Agent type.</param>
        /// <param name="stairs">Number of stairs.</param>
        /// <returns>A string representation of a staircase.</returns>
        public string getStaircase(int steps)
        {
            var agent = _agentsFactory.CreateAgent();
            return agent.getStaircase(steps);
        }
    }
}
