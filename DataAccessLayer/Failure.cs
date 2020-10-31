using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Failure
    {
        public int Id { get; set; }
        public int Id_Username { get; set; }
        public int Id_TypeOfFailure { get; set; }
        public int Id_City { get; set; }
        public DateTime BeginOfFailure { get; set; }
        public DateTime? EndOfFailure { get; set; } 
        public string AdditionalDescription { get; set; }
    }
}
