using System;
using System.IO;
using System.IO.Pipes;
using System.Text;

class Program
{
    static void Main()
    {
        using (var pipeServer = new NamedPipeServerStream("MyPipe", PipeDirection.Out))
        {
            Console.WriteLine("Waiting for connection...");
            pipeServer.WaitForConnection();

            Console.WriteLine("Connected. Enter text to send:");
            string message = Console.ReadLine();

            byte[] buffer = Encoding.UTF8.GetBytes(message);
            pipeServer.Write(buffer, 0, buffer.Length);

            Console.WriteLine("Message sent. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
