using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EASocketReceiver
{
    public class SocketListener
    {
        public delegate void OnMessageDelegate(SocketMessage message);

        public OnMessageDelegate OnMessage;

        public bool IsStarted { get; set; }

        public ILogger Logger { get; set; }

        private TcpListener _listener;

        /// <summary>
        /// Paralel task.
        /// </summary>
        private Task _task;

        /// <summary>
        /// ctor
        /// </summary>
        public SocketListener()
        {
            IsStarted = false;
        }

        /// <summary>
        /// Start listening.
        /// </summary>
        public void Start(SocketListenerParams listenerParams)
        {
            if (IsStarted)
                return;

            _task = Task.Factory.StartNew(new Action<object>(ExecuteTask), listenerParams);

            IsStarted = true;
        }

        /// <summary>
        /// Stop listening.
        /// </summary>
        public void Stop()
        {
            if (!IsStarted)
                return;

            if (_listener != null)
            {
                _listener.Stop();
                _listener = null;
            }

            IsStarted = false;
        }

        /// <summary>
        /// Background thread task.
        /// </summary>
        private void ExecuteTask(object args)
        {
            SocketListenerParams listenerParams = args as SocketListenerParams;

            IPAddress ipAddress = IPAddress.Parse(listenerParams.IpAddress);

            _listener = new TcpListener(ipAddress, listenerParams.PortNo);

            _listener.Start();

            while (true)
            {
                try
                {
                    Socket client = _listener.AcceptSocket();

                    var childSocketThread = new Thread(() =>
                    {
                        byte[] data = new byte[2048];
                        int size = client.Receive(data);

                        if (size <= 0) return;

                        //MemoryStream ms = new MemoryStream(data);
                        //StreamReader sr = new StreamReader(ms);
                        //sr.ReadToEnd();
                        //string message = sr.CurrentEncoding.GetString(data.Take(size).ToArray());

                        string message = Encoding.Unicode.GetString(data.Take(size).ToArray());

                        ProcessMessage(message);

                        client.Close();
                    });
                    childSocketThread.Start();
                }
                catch (SocketException)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Socket message parsing.
        /// </summary>
        /// <param name="socketMessage"></param>
        private void ProcessMessage(string socketMessage)
        {
            if (string.IsNullOrWhiteSpace(socketMessage))
                return;

            int position = socketMessage.IndexOf('#');
            string symbol = string.Empty;
            string message = string.Empty;

            if (position > -1)
            {
                symbol = socketMessage.Substring(0, position);
                if (socketMessage.Length > (position + 1))
                    message = socketMessage.Substring(position + 1);
            }
            else
                message = socketMessage;

            if (OnMessage != null)
                OnMessage(new SocketMessage() { Symbol = symbol, Message = message });
        }
    }
}
