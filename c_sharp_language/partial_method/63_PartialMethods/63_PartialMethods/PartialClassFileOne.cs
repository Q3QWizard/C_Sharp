using System;

namespace _63_PartialMethods
{
    public partial class SampelPartialClass
    {
        partial void SamplePartialMethod();

        public void PublicMethod()  // if you want you can add this method definition in the partial class where partial method decleration resides
        {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }
    }
}
