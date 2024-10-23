using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Result<T>
    {
        public T ItemResult { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
