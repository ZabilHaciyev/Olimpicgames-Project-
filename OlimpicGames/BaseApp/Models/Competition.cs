using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public bool IsFinal { get; set; }
        public DateTime StartTime { get; set; }
        public virtual SportType SportType { get; set; }
        public virtual List<Athlet> Athlets  { get; set; }
    }
}
