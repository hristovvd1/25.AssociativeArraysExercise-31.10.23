namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> resources = new Dictionary<string, double>();

            string resource;
            double quantity;

            while ((resource = Console.ReadLine()) != "stop")
            {
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }

                quantity = double.Parse(Console.ReadLine());
                resources[resource] += quantity;
            }

            foreach (KeyValuePair<string, double> pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
