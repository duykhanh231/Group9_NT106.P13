using System.Net.Sockets;
using System.Net;
using System.Text;

public class GameServer
{

    static string connectString = "Data Source=localhost;Initial Catalog=Users;User ID=sa;Password=120274Az#";
    public static void Main(string[] args)
    {
        int port = 2508;

        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPEndPoint ipe = new IPEndPoint(IPAddress.Any, port);
        socket.Bind(ipe);
        socket.Listen();

        Console.WriteLine("Choose server IPv4 address: \n");
        Console.WriteLine("1. 192.168.218.97");
        Console.WriteLine("2. 10.45.124.88");
        Console.WriteLine("3. 172.30.99.86");
        Console.WriteLine("4. 192.168.218.224");

        string type = Console.ReadLine();

        if (type == "1")
        {
            Console.WriteLine("Server is listening on 192.168.218.97");
        }
        else if (type == "2")
        {
            Console.WriteLine("Server is listening on 10.45.124.88");
        }
        else if (type == "3")
        {
            Console.WriteLine("Server is listening on 172.30.99.86");
        }
        else if (type == "4")
        {
            Console.WriteLine("Server is listening on 192.168.218.224");
        }
        else
        {
            Console.WriteLine("Please choose server to play game!");
        }


        while (true)
        {
            Socket client = socket.Accept();
            Console.WriteLine("Connect Successful");

            Thread thread = new Thread(() => HandleClient(client));
            thread.IsBackground = true;
            thread.Start();
        }
    }

    public static void HandleClient(Socket client)
    {
        try
        {
            byte[] receive = new byte[1024];
            int bytesRead = client.Receive(receive);
            string receivedMessage = Encoding.UTF8.GetString(receive, 0, bytesRead);

            string[] parts = receivedMessage.Split('|');
            if (parts.Length < 1)
            {
                Console.WriteLine("Invalid message format received.");
                return;
            }

            if (parts[0] == "LOGIN")
            {
                Login(client, parts);
            }
            else if (parts[0] == "REGISTER")
            {
                Register(client, parts);
            }
            else if (parts[0] == "PASSWORD_RESET")
            {
                PasswordReset(client, parts);
            }
            else if (parts[0] == "CHANGE_PASSWORD")
            {
                ChangePassword(client, parts);
            }
            else
            {
                Console.WriteLine("Invalid message type received.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in HandleClient: " + ex.Message);
        }
    }
}
