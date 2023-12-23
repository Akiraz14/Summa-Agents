using SummaAgents.Services;
using SummaAgents.Validators;

namespace SummaAgents
{
    public class Program
    {
        static void Main(string[] args)
        {
            IAgentsFactory factory = null;
            Agents agent = null;
            string repeat = "Y";

            while (repeat.ToUpper() == "Y" || repeat.ToUpper() == "YES")
            {
                try
                {
                    Console.WriteLine("Please enter the letter of the agent (A,B or C) and the number of the function (1 or 2) to execute spaced by comma (,):\n" +
                        "e.g. A,1 or C,2");

                    string[] data = (Console.ReadLine() ?? "").Trim().Split(",");

                    if (data.Length < 2 || !("ABC").Contains(data[0].ToUpper()) || !("12").Contains(data[1]))
                        throw new InvalidDataException();

                    double[] realNums = new double[0];
                    int steps = 0;
                    if (data[1] == "1")
                    {
                        Console.WriteLine("Please enter the list of real numbers spaced by a comma (,):\n e.g. 1,2,109,4.3,0.1, etc...");
                        var list = (Console.ReadLine() ?? "").Replace(" ", "").Trim().Split(",");
                        if (list.Length <= 0)
                            throw new InvalidDataException();

                        realNums = new double[list.Length];
                        for (int i = 0; i < list.Length; i++)
                        {
                            if (!Double.TryParse(list[i], out realNums[i]))
                            {
                                Console.WriteLine("The data entered is not correct. Execution canceled");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter the number of stairs:");
                        var stairs = Console.ReadLine();
                        if (!Int32.TryParse(stairs, out steps))
                            throw new InvalidDataException();
                    }

                    switch (data[0].ToUpper())
                    {
                        case "A":
                            factory = new AgentAFactory();
                            agent = new Agents(factory);

                            if (data[1] == "1")
                            { Console.WriteLine(agent.getMedia(realNums)); }
                            else
                            { Console.WriteLine(agent.getStaircase(steps)); }

                            break;
                        case "B":
                            factory = new AgentBFactory();
                            agent = new Agents(factory);

                            if (data[1] == "1")
                            { Console.WriteLine(agent.getMedia(realNums)); }
                            else
                            { Console.WriteLine(agent.getStaircase(steps)); }

                            break;

                        case "C":

                            factory = new AgentCFactory();
                            agent = new Agents(factory);

                            if (data[1] == "1")
                            { Console.WriteLine(agent.getMedia(realNums)); }
                            else
                            { Console.WriteLine(agent.getStaircase(steps)); }

                            break;

                        default:
                            throw new NotImplementedException();
                            break;
                    }
                }
                catch (ValidationException e)
                {
                    foreach (var error in e.ValidationErrors)
                    { Console.WriteLine(error); }
                }
                catch (Exception ex)
                { Console.WriteLine("The data entered is not correct. Execution canceled"); }
                finally
                {
                    Console.WriteLine("Do you want to choose one more time?\n" +
                        "Enter Yes or Y to choose again.");
                    var action = Console.ReadLine();
                    repeat = (action ?? "").ToString();
                }
            }
        }
    }
}
