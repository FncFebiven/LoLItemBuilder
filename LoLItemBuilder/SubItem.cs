using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLItemBuilder
{
    public class SubItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public List<BasicItem> BasicItems { get; set; }
    }
}
