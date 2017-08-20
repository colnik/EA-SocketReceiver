using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASocketReceiver
{
    public class SocketMessage
    {
        /// <summary>
        /// ctor
        /// </summary>
        public SocketMessage()
        {
        }

        public string Symbol { get; set; }
        public string Message { get; set; }

        /// <summary>
        /// toString
        /// </summary>
        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Symbol))
                return Message;
            else
                return string.Format("{0}: {1}", Symbol, Message);
        }
    }
}
