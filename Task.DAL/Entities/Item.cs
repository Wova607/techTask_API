using System;
using System.Collections.Generic;
using System.Text;

namespace Task.DAL.Entities
{
    /// <summary>
    /// Model our Entity
    /// </summary>
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
    }
}
