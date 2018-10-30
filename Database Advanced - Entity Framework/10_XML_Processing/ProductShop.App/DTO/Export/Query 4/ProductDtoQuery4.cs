﻿using System.Xml.Serialization;

namespace ProductShop.App.DTO.Export
{
    [XmlType("product")]
    public class ProductDtoQuery4
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}
