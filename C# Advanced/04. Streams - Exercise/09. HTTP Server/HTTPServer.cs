using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace _09.HTTP_Server
{
    public class HTTPServer
    {
        private const int PortNumber = 8081;
        public static void Main()
        {
            Console.WriteLine("Starting server...");
            var server = new TcpListener(IPAddress.Any, PortNumber);
            server.Start();
            Console.WriteLine("Server started.");
            Console.WriteLine($"Server is listening on port {PortNumber}");

            byte[] bytes = new byte[4096];
            byte[] buffer = new byte[4096];
            string data = null;

            while (true)
            {
                Console.WriteLine("Waiting for a connection...");
                var client = server.AcceptTcpClient();
                Console.WriteLine("Connected!");

                data = null;

                using (NetworkStream stream = client.GetStream())
                {
                    stream.Read(bytes, 0, bytes.Length);
                    data = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    var getRequestRegexPattern = @"GET\s+(.*?)\s+HTTP\/1.1";

                    var requestPath = Regex.Matches(data, getRequestRegexPattern)[0].Groups[1].ToString();
                    var htmlPath = string.Empty;

                    if (requestPath == "/")
                    {
                        htmlPath = "../../HTML/index.html";
                    }
                    else if (requestPath == "/info")
                    {
                        htmlPath = "../../HTML/info.html";
                    }
                    else
                    {
                        htmlPath = "../../HTML/error.html";
                    }

                    var response = "HTTP/1.1 200 OK Content-Type: text/html \r\n\r\n";
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);

                    stream.Write(responseBytes, 0, responseBytes.Length);

                    var sb = new StringBuilder();
                    using (StreamReader reader = new StreamReader(htmlPath))
                    {
                        var line = reader.ReadLine();
                        while (line != null)
                        {
                            sb.Append(line);
                            line = reader.ReadLine();
                        }
                    }

                    var replacedHtml = string.Format(sb.ToString(), DateTime.Now.ToString(CultureInfo.InvariantCulture),
                        Environment.ProcessorCount);

                    buffer = Encoding.UTF8.GetBytes(replacedHtml);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
