using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_api_p2.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Content{ get; set; }=string.Empty;
        public int? StockId { get; set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;

        public Stock? Stock { get; set; }
    }
}