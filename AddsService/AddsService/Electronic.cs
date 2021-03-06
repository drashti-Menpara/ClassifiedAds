namespace AddsService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Electronic
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public byte[] Image1 { get; set; }

        public byte[] Image2 { get; set; }

        public byte[] Image3 { get; set; }

        public string SellarName { get; set; }

        public string SellarContact { get; set; }

        public string SellarAddress { get; set; }
    }
}
