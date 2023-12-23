using SummaAgents.BusinessObjects;

namespace SummaAgents.Services
{
    public class AgentAFactory : IAgentsFactory
    {
        public IAgents CreateAgent()
        {
            return new AgentA();
        }
    }
}
