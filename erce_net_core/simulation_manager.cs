using System;
using System.Collections.Generic;

namespace erce_net_core
{
    public class simulation_manager
    {
        private readonly List<network_node> nodes;

        public simulation_manager()
        {
            nodes = new List<network_node>();
            setup_nodes();
        }

        private void setup_nodes()
        {
            for (int i = 0; i < 5; i++)
            {
                nodes.Add(new network_node(i));
            }

            foreach (var node in nodes)
            {
                foreach (var target in nodes)
                {
                    if (node.get_id() != target.get_id())
                    {
                        node.connect(target);
                    }
                }
            }
        }

        public void run_simulation()
        {
            foreach (var node in nodes)
            {
                node.send_message($"Hello from node {node.get_id()}!");
            }
        }
    }
}
