using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Son.Shared
{
    public interface IDataResult<out T>:IResult
    {
        //out olmasının sebebi return'de değer verebilelim diye?
        T Data { get;}

    }
}
