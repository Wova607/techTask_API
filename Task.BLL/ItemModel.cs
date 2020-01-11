using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task.BLL
{
    /// <summary>
    /// Model for our entitty 
    /// </summary>
    public class ItemModel
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
    }
}
