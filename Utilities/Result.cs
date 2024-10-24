using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Result<T>
    {
        public T Items { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; }
    }
}
