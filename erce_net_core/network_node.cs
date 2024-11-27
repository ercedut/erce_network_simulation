using System;
using System.Collections.Generic;

namespace erce_net_core
{
    public class network_node
    {
        private readonly int id;
        private readonly List<network_node> connections;

        public network_node(int node_id)
        {
            id = node_id;
            connections = new List<network_node>();
        }

        public int get_id()
        {
            return id;
        }

        public void connect(network_node target)
        {
            connections.Add(target);
        }

        public void send_message(string message)
        {
            Console.WriteLine($"Node {id} is sending: {message}");
            foreach (var connection in connections)
            {
                connection.receive_message(message, this);
            }
        }

        public void receive_message(string message, network_node sender)
        {
            Console.WriteLine($"Node {id} received: '{message}' from Node {sender.get_id()}");
        }
    }
}
