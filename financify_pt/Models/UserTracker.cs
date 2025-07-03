using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financify_pt
{
    public class UserTracker
    {
        public int Id { get; set; }
        public int IdTracker { get; set; }
        public int IdUser { get; set; }
        public int IsOwner { get; set; }
    }
}
