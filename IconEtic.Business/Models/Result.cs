using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconEtic.Business.Models
{
    public class Result<TResultType>
    {
        public List<string> ErrorMessages { get; set; }
        public bool IsList { get; set; }
        public bool IsOk { get; set; }
        public List<TResultType> List { get; set; }
        public TResultType SingleObject { get; set; }
    }
}
