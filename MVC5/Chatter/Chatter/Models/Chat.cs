namespace Chatter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chat")]
    public partial class Chat
    {
        public int Id { get; set; }

        [StringLength(12)]
        public string SenderId { get; set; }

        [StringLength(12)]
        public string ReceiverId { get; set; }

        public string ChatContent { get; set; }

        public DateTime? SendTime { get; set; }

        public DateTime? ReadTime { get; set; }

        public bool? IsDelivered { get; set; }
    }
}
