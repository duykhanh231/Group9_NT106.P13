using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace BattleShipServer
{
    
    class AsynchronousSocketListener
    {
        
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        public AsynchronousSocketListener() { }

        public static void StartListening()
        {
            
            byte[] bytes = new Byte[1024];

            
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            int i = 0;
            Console.WriteLine("Choose server IPv4 address:");
            foreach (var item in ipHostInfo.AddressList)
            {
                Console.WriteLine(i + " - " + item);
                i++;
            }
            do
            {
                Console.Write("Type: ");
                i = (int)(Console.ReadKey().KeyChar) - 48;
                Console.WriteLine();
            } while (i < 0 || i >= ipHostInfo.AddressList.Count());

            IPAddress ipAddress = ipHostInfo.AddressList[i];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

           
            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                Console.WriteLine("Server is running (" + ipAddress + ")");
                while (true)
                {
                    
                    allDone.Reset();

                                  
                    listener.BeginAccept(new AsyncCallback(AcceptCallback),listener);

                   
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            
            allDone.Set();

           
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            int bytesRead = 0;

            
            bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    
                    Console.WriteLine("Read {0} bytes from socket. \nData : {1}",
                        content.Length, content);

                    string messageBits = Utilities.getBinaryMessage(content);
                    
                    int bits8 = Convert.ToInt32(messageBits.Substring(0, 8), 2);
                    
                    string[] parameters = content.Split(' ');
                    string nick = String.Empty;
                    string IPport = String.Empty;
                    string port = String.Empty;
                    string enemyNick = String.Empty;
                    string players = String.Empty;
                    bool result = false;
                    string whoSent = "";
                    string whomSent = "";
                    switch (bits8)
                    {
                        case 0:
                            {
                                
                                whoSent = parameters[1];
                               
                                whomSent = parameters[2];

                                if (Program.loggedplayingNicks.ContainsKey(whomSent))
                                {
                                    
                                    if (!Program.whowhomSentStart.Contains(whomSent + whoSent) && !Program.whowhomSentGiveUp.Contains(whomSent + whoSent))
                                    {
                                        Program.whowhomSentStart.Add(whoSent + whomSent);
                                        state.buffer = new byte[1024];
                                        state.sb = new StringBuilder();
                                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                        new AsyncCallback(ReadCallback), state);
                                        break;
                                    }
                                    else if (Program.whowhomSentStart.Contains(whomSent + whoSent))
                                    {
                                       
                                        if (Program.loggedplayingNicks.ContainsKey(whoSent))
                                        {
                                            Send(Program.loggedplayingNicks[whoSent], ((char)16).ToString() + " <EOF>");
                                        }
                                        if (Program.loggedplayingNicks.ContainsKey(whomSent))
                                        {
                                            Send(Program.loggedplayingNicks[whomSent], ((char)0).ToString() + " <EOF>");
                                        }
                                        
                                        Program.whowhomSentStart.Remove(whomSent + whoSent);
                                        state.buffer = new byte[1024];
                                        state.sb = new StringBuilder();
                                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                        new AsyncCallback(ReadCallback), state);
                                        break;

                                    }
                                    else if (Program.whowhomSentGiveUp.Contains(whomSent + whoSent))
                                    {
                                        if (Program.loggedplayingNicks.ContainsKey(whoSent))
                                        {
                                            Send(Program.loggedplayingNicks[whoSent], ((char)17).ToString() + " <EOF>");
                                        }
                                        Program.whowhomSentGiveUp.Remove(whomSent + whoSent);
                                    }
                                }
                                else if (Program.loggedplayingNicks.ContainsKey(whoSent))
                                {
                                    Send(Program.loggedplayingNicks[whoSent], ((char)17).ToString() + " <EOF>");
                                    Program.loggedNicks.Add(whoSent, Program.loggedplayingNicks[whoSent]);
                                    Program.loggedplayingNicks.Remove(whoSent);
                                }
                                else if (Program.loggedNicks.ContainsKey(whoSent))
                                {
                                    Send(Program.loggedNicks[whoSent], ((char)17).ToString() + " <EOF>");
                                }
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 1:
                            {
                                nick = parameters[1];
                                enemyNick = parameters[2];

                                if (Program.loggedplayingNicks.ContainsKey(nick))
                                {
                                    if (!Program.loggedNicks.ContainsKey(nick))
                                    {
                                        Program.loggedNicks.Add(nick, Program.loggedplayingNicks[nick]);
                                        Program.loggedplayingNicks.Remove(nick);
                                    }
                                }
                                if (Program.loggedplayingNicks.ContainsKey(enemyNick))
                                {
                                    if (!Program.loggedNicks.ContainsKey(enemyNick))
                                    {
                                        Program.loggedNicks.Add(enemyNick, Program.loggedplayingNicks[enemyNick]);
                                        Program.loggedplayingNicks.Remove(enemyNick);
                                        Send(Program.loggedNicks[enemyNick], ((char)1).ToString() + " <EOF>");
                                    }
                                }
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 2: 
                            { 
                                
                                whoSent = parameters[1];
                                
                                whomSent = parameters[2];
                                
                                if (!Program.whowhomSentStart.Contains(whomSent + whoSent) && !Program.whowhomSentGiveUp.Contains(whomSent + whoSent))
                                {
                                    Program.whowhomSentGiveUp.Add(whoSent + whomSent);
                                    if (Program.loggedplayingNicks.ContainsKey(whoSent))
                                    {
                                        if (!Program.loggedNicks.ContainsKey(whoSent))
                                        {
                                            Program.loggedNicks.Add(whoSent, Program.loggedplayingNicks[whoSent]);
                                            Program.loggedplayingNicks.Remove(whoSent);
                                            Send(Program.loggedNicks[whoSent], ((char)10).ToString() + " <EOF>");
                                        }
                                    }
                                    state.buffer = new byte[1024];
                                    state.sb = new StringBuilder();
                                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                    new AsyncCallback(ReadCallback), state);
                                    break;
                                }
                                else if (Program.whowhomSentStart.Contains(whomSent + whoSent))
                                {
                                    
                                    if (Program.loggedplayingNicks.ContainsKey(whomSent))
                                    {
                                        Send(Program.loggedplayingNicks[whomSent], ((char)9).ToString() + " <EOF>");
                                    }
                                    
                                    Program.whowhomSentStart.Remove(whomSent + whoSent);

                                    
                                    if (Program.loggedplayingNicks.ContainsKey(whomSent))
                                    {
                                        if (!Program.loggedNicks.ContainsKey(whomSent))
                                        {
                                            Program.loggedNicks.Add(whoSent, Program.loggedplayingNicks[whomSent]);
                                            Program.loggedplayingNicks.Remove(whomSent);                                         
                                        }
                                    }
                                    if (Program.loggedplayingNicks.ContainsKey(whoSent))
                                    {
                                        if (!Program.loggedNicks.ContainsKey(whoSent))
                                        {
                                            Program.loggedNicks.Add(whoSent, Program.loggedplayingNicks[whoSent]);
                                            Program.loggedplayingNicks.Remove(whoSent);
                                            Send(Program.loggedNicks[whoSent], ((char)10).ToString() + " <EOF>");
                                        }
                                    }
                                    state.buffer = new byte[1024];
                                    state.sb = new StringBuilder();
                                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                    new AsyncCallback(ReadCallback), state);
                                    break;
                                }
                                else if (Program.whowhomSentGiveUp.Contains(whomSent + whoSent))
                                {
                                    Program.whowhomSentGiveUp.Remove(whomSent + whoSent);
                                    if (Program.loggedplayingNicks.ContainsKey(whoSent))
                                    {
                                        if (!Program.loggedNicks.ContainsKey(whoSent))
                                        {
                                            Program.loggedNicks.Add(whoSent, Program.loggedplayingNicks[whoSent]);
                                            Program.loggedplayingNicks.Remove(whoSent);
                                            Send(Program.loggedNicks[whoSent], ((char)10).ToString() + " <EOF>");
                                        }
                                        
                                    }
                                }
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 3: 
                            {


                                break;
                            }
                        case 4: 
                            {
                                enemyNick = parameters[1];
                                if (Program.loggedplayingNicks.ContainsKey(enemyNick))
                                {
                                    string message = ((char)4).ToString() + " <EOF>";
                                    Send(Program.loggedplayingNicks[enemyNick], message);
                                }
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 5: 
                            {
                                enemyNick = parameters[1];
                                if (Program.loggedplayingNicks.ContainsKey(enemyNick))
                                {
                                    string message = ((char)5).ToString() +  " <EOF>";
                                    Send(Program.loggedplayingNicks[enemyNick], message);
                                }
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 6:
                            {
                                enemyNick = parameters[1];
                                string x = parameters[2];
                                string y = parameters[3];
                                if (Program.loggedplayingNicks.ContainsKey(enemyNick))
                                {
                                    string message = ((char)6).ToString() +" " + x +" " + y + " <EOF>";
                                    Send(Program.loggedplayingNicks[enemyNick], message);
                                }
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 7:
                            {
                                
                                nick = parameters[1];
                                
                                if (Program.enemiesoffers.ContainsKey(nick))
                                {
                                    
                                    string enemiesString ="";
                                    foreach (var item in Program.enemiesoffers[nick])
                                    {
                                        enemiesString += item + " ";
                                    }
                                    string message = ((char)7).ToString() + " " + enemiesString + "<EOF>";
                                    Send(handler, message);
                                }
                                else
                                {
                                    Send(handler, ((char)7).ToString() + " <EOF>");
                                }
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 8:
                            {
                                
                                nick = parameters[1];
                                
                                enemyNick = parameters[2];
                                bool nickOffers = false;
                                if (Program.enemiesoffers.ContainsKey(nick))
                                {
                                    if (Program.enemiesoffers[nick].Contains(enemyNick))
                                    {
                                        Send(handler, ((char)10).ToString() + " <EOF>");
                                        nickOffers = true;
                                    }
                                }
                                if (nickOffers == false)
                                {
                                    if (Program.enemiesoffers.ContainsKey(enemyNick))
                                    {
                                        Program.enemiesoffers[enemyNick].Add(nick);
                                    }
                                    else
                                    {
                                        Program.enemiesoffers.Add(enemyNick, new List<string>() { nick });
                                    }
                                }
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 9: 
                            {
                                Send(handler, ((char)10).ToString() + " <EOF>");

                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 10: 
                            {
                                Send(handler, ((char)10).ToString() + " <EOF>");

                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 11: 
                            {
                                
                                nick = parameters[1];
                               
                                IPport = handler.RemoteEndPoint.ToString().Split(':')[0]; 
                                
                                port = parameters[2];
                                IPport += ":" + port;
                                
                                if (Program.loggedNicks.ContainsKey(nick)) 
                                {
                                    
                                    Send(handler, ((char)9).ToString() + " <EOF>");
                                }
                                else 
                                {
                                    
                                    Program.loggedNicks.Add(nick, handler);
                                    
                                    Send(handler, ((char)10).ToString() + " <EOF>");
                                }

                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 12: 
                            {
                                nick = parameters[1];
                                enemyNick = parameters[2];              
                                
                                if (Program.enemiesoffers.ContainsKey(nick))
                                {
                                    if (nick != enemyNick) 
                                    {
                                        if (Program.enemiesoffers[nick].Contains(enemyNick))
                                        {
                                            if (Program.loggedNicks.ContainsKey(enemyNick))
                                            {
                                                Send(Program.loggedNicks[enemyNick], ((char)10).ToString() + " <EOF>");
                                                Program.loggedplayingNicks.Add(nick, Program.loggedNicks[nick]);
                                                Program.loggedplayingNicks.Add(enemyNick, Program.loggedNicks[enemyNick]);
                                                if (Program.enemiesoffers.ContainsKey(enemyNick))
                                                {
                                                    
                                                    foreach (var item in Program.enemiesoffers[enemyNick])
                                                    {
                                                        
                                                        if (Program.loggedNicks.ContainsKey(item))
                                                        {
                                                            Send(Program.loggedNicks[item], ((char)9).ToString() + " <EOF>");
                                                        }
                                                    }
                                                }
                                                Program.loggedNicks.Remove(nick);
                                                Program.loggedNicks.Remove(enemyNick);
                                            }
                                            else
                                            {
                                               
                                                Send(Program.loggedNicks[nick], ((char)17).ToString() + " <EOF>");
                                            }
                                            Program.enemiesoffers[nick].Remove(enemyNick);
                                            
                                        }
                                    }
                                    foreach (var item in Program.enemiesoffers[nick])
                                    {
                                        if (Program.loggedNicks.ContainsKey(item))
                                        {
                                            Send(Program.loggedNicks[item], ((char)9).ToString() + " <EOF>");
                                        }                                     
                                    }
                                    Program.enemiesoffers[nick].Clear(); 
                                }
                                
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }

                        case 13: 
                            {
                                
                                nick = parameters[1];
                               
                                result = Program.loggedNicks.ContainsKey(nick);
                                if (result == false) 
                                {                          
                                    Send(handler, ((char)12).ToString() + " <EOF>");
                                }
                                else
                                {
                                    
                                    players = "";
                                   
                                    foreach (var item in Program.loggedNicks)
                                    {
                                        
                                        if (!item.Key.Equals(nick))
                                            players += item.Key + ";" + item.Value.LocalEndPoint + " ";
                                    }
                                    if (players == "") 
                                    {
                                        Send(handler, ((char)12).ToString() + " <EOF>");
                                    }
                                    else 
                                    {
                                        players += "<EOF>";
                                        players = ((char)12).ToString()+" " + players;

                                        
                                        Send(handler, players);
                                    }
                                }

                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                        case 14:
                            {
                                whoSent = parameters[1];
                                
                                whomSent = parameters[2];
                                

                               
                                if (Program.loggedNicks.ContainsKey(whoSent) ==true)
                                {
                                    
                                    Program.loggedNicks.Remove(whoSent);
                                }
                                if (Program.loggedplayingNicks.ContainsKey(whoSent) == true)
                                {
                                    Program.loggedplayingNicks.Remove(whoSent);
                                }

                                if (Program.enemiesoffers.ContainsKey(whoSent))
                                {
                                   
                                    foreach (var item in Program.enemiesoffers[whoSent])
                                    {
                                        
                                        if (Program.loggedNicks.ContainsKey(item))
                                        {
                                            Send(Program.loggedNicks[item], ((char)9).ToString() + " <EOF>");
                                        }
                                    }
                                }

                                handler.Shutdown(SocketShutdown.Both);
                                handler.Close();
                                break;
                            }
                        case 15:
                            {
                                nick = parameters[1];
                                enemyNick = parameters[2];

                                if (Program.loggedplayingNicks.ContainsKey(nick))
                                {
                                    if (!Program.loggedNicks.ContainsKey(nick))
                                    {
                                        Program.loggedNicks.Add(nick, Program.loggedplayingNicks[nick]);
                                        Program.loggedplayingNicks.Remove(nick);
                                    }
                                }
                                if (Program.loggedplayingNicks.ContainsKey(enemyNick))
                                {
                                    if (!Program.loggedNicks.ContainsKey(enemyNick))
                                    {
                                        Program.loggedNicks.Add(enemyNick, Program.loggedplayingNicks[enemyNick]);
                                        Program.loggedplayingNicks.Remove(enemyNick);
                                        Send(Program.loggedNicks[enemyNick], ((char)17).ToString() + " <EOF>");
                                    }
                                }
                                state.buffer = new byte[1024];
                                state.sb = new StringBuilder();
                                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                                new AsyncCallback(ReadCallback), state);
                                break;
                            }
                    }
                }

            }
            else
            {
                
                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
            }
        }

        private static void Send(Socket handler, String data)
        {
          
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                
                Socket handler = (Socket)ar.AsyncState;

                
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
