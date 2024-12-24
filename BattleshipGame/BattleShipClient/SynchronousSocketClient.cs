using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipClient
{
    class SynchronousSocketClient
    {
        
        public Socket socket;
        
        byte[] bytes;
        
        private byte[] byteData = new byte[1024];
        
        bool iAmReady = false;
        
        bool iamBusy = false; 
        public SynchronousSocketClient(string AddressIP)
        {
            IPEndPoint serverRemoteEP = new IPEndPoint(IPAddress.Parse(AddressIP), 11000);

            
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            try
            {
                socket.Connect(serverRemoteEP);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                throw;
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
                throw;
            }
        }
        public string Receive()
        {
            bytes = new byte[1024];
            int bytesRec = 0;
            string answer = string.Empty;
            try
            {
                while (!answer.Contains("<EOF>"))
                {
                    
                    bytesRec = socket.Receive(bytes);
                    answer += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                throw;
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
                throw;
            }
            return answer;
        }
        public void Send(String data)
        {
            try
            {
                
                byte[] msg = Encoding.ASCII.GetBytes(data);

                
                int bytesSent = socket.Send(msg);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                throw;
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
                throw;
            }
        }

        public void Disconnect()
        {
            try
            {
                
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                throw;
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
                throw;
            }
        }
    
    }
}
