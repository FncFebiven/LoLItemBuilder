using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLItemBuilder
{
    public class FinishedItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public List<SubItem> SubItems { get; set; }
    }
}
