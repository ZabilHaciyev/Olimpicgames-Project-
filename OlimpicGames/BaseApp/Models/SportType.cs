using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
    public class SportType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual WeightLimite WeightLimite { get; set; }
        public Gender Gender { get; set; }
        public virtual List<SportType> SubSportTypes { get; set; }


    }
}
