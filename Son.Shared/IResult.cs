using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Son.Shared
{
    public interface IResult
    {
        ResultStatus ResultStatus { get;  }
        string Message { get; }
        Exception Exception { get;  }
    }
}
