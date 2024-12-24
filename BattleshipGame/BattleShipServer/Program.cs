﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Sockets;

namespace BattleShipServer
{
    class Program
    {
        
        public static Dictionary<string, Socket> loggedNicks = new Dictionary<string, Socket>();
        
        public static Dictionary<string, Socket> loggedplayingNicks = new Dictionary<string, Socket>();
        
        public static Dictionary<string, List<string>> enemiesoffers = new Dictionary<string, List<string>>();
        
        public static List<string> whowhomSentStart = new List<string>();
        
        public static List<string> whowhomSentGiveUp = new List<string>();
        static void Main(string[] args)
        {
            
            String thisprocessname = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
                return;

            AsynchronousSocketListener.StartListening();
        }
    }
   
}
