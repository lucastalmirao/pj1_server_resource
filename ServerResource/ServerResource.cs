using System;
using System.Net.Sockets;

public class ServerResource
{
    string serverIp = "127.0.0.1";
    int serverPort = 7173;
    TcpClient server;

    public ServerResource()
    {
        try
        {
            Console.WriteLine("Establishing connection to Main Server...");
            server = new TcpClient(serverIp, serverPort);
            Console.WriteLine("Connection established");

            /*NetworkStream stream = client.GetStream();

            // Exemplo de envio de dados para o servidor
            string dataToSend = "Olá, servidor!";
            byte[] data = System.Text.Encoding.ASCII.GetBytes(dataToSend);
            stream.Write(data, 0, data.Length);

            // Receber resposta do servidor
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string response = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Resposta do servidor: " + response);

            client.Close();*/
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error connecting on server: " + ex.Message);
        }
    }
}
