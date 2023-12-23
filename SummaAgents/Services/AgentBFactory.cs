using SummaAgents.BusinessObjects;

namespace SummaAgents.Services
{
    public class AgentBFactory : IAgentsFactory
    {
        public IAgents CreateAgent()
        {
            return new AgentB();
        }
    }
}
