using SummaAgents.BusinessObjects;

namespace SummaAgents.Services
{
    public class AgentCFactory : IAgentsFactory
    {
        public IAgents CreateAgent()
        {
            return new AgentC();
        }
    }
}
