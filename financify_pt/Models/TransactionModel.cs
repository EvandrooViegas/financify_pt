using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financify_pt.Models
{
    public class TransactionModel
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

        public string Type { get; set; }

        public int CreatedById {  get; set; }

        public string Description { get; set; } = null;

        public DateTime Date { get; set; }

        public int TrackerId { get; set; }
    }
}
