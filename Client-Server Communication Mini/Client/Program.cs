using System;
using System.IO;
using System.IO.Pipes;
using System.Text;

class Program
{
    static void Main()
    {
        using (var pipeClient = new NamedPipeClientStream(".", "MyPipe", PipeDirection.In))
        {
            Console.WriteLine("Connecting to pipe...");
            pipeClient.Connect();

            Console.WriteLine("Connected. Waiting for message...");
            byte[] buffer = new byte[1024];
            int bytesRead = pipeClient.Read(buffer, 0, buffer.Length);

            string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine($"Received message: {receivedMessage}");

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
