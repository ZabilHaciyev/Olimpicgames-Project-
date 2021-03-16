using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
    public class Athlet
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public int Score { get; set; }
        virtual public SportType SportType { get; set; }
        virtual public Gender Gender { get; set; }
        virtual public List<Medal> Medals { get; set; }
    }
}
