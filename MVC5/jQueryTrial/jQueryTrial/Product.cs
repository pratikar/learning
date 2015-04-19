namespace jQueryTrial
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public int? Price { get; set; }

        public int? UnitsInStock { get; set; }
    }
}
