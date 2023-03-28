using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Pingador
{
    public class Pinger
    {
        private string addressToPing = "www.google.com"; // or any other address you want to ping
        private Ping pingSender = new Ping();
        private PingOptions options = new PingOptions();

        private string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

        public void Ping_andLog()
        {
            // Use the default Ttl value which is 128,
            // but you can increase or decrease this value as needed.
            options.Ttl = 128;

            // Create a buffer of 32 bytes of data to be transmitted.

            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Ping the address and get the response time.
            PingReply reply = pingSender.Send(addressToPing, 120, buffer, options);

            // Log the response time to a file.
            //StreamWriter file = new StreamWriter("log.txt", true);
            StreamWriter file = new StreamWriter("C:\\Users\\oani_\\OneDrive\\Área de Trabalho\\logNET.txt", true);

            file.WriteLine($"{DateTime.Now} \t {addressToPing} | {reply.RoundtripTime}ms");

            file.Close();
        }
    }
}