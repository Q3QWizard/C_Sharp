using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _63_PartialMethods
{
    public partial class SampelPartialClass
    {
        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod Invoked");
        }
    }
}
