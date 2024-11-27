using System;
using erce_net_core;

namespace erce_network_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ağ simülatörünü başlatıyoruz
                var simulation = new simulation_manager();
                simulation.run_simulation();
                Console.WriteLine("Simulation completed successfully.");
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi verilir
                Console.WriteLine($"An error occurred during the simulation: {ex.Message}");
            }
        }
    }
}
