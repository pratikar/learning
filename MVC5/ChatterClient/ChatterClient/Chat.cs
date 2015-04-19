using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatterClient
{
    public partial class Chat
    {
        public int Id { get; set; }


        public string SenderId { get; set; }


        public string ReceiverId { get; set; }

        public string ChatContent { get; set; }

        public DateTime SendTime { get; set; }

        public DateTime ReadTime { get; set; }

        public bool IsDelivered { get; set; }
    }
}
