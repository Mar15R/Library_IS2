using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS2.Lib
{
    public class Result<T>
    {
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsSuccess => ErrorMessage == null;
        public string InnerExceptionMessage { get; set; }
    }
}
