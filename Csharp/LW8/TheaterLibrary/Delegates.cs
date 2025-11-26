using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterLibrary
{
    public delegate void TheaterAddedHandler(Theater t);

    public delegate bool TheaterValidator(Theater t);
}
