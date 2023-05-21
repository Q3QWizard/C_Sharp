using System;

namespace AssemblyOne
{
    class Class2
    {
       
            public void SampleMethod()
            {
                AssemblyOneClass1 A1 = new AssemblyOneClass1();
                Console.WriteLine(A1.ID);

                Console.ReadLine();
            }

       
    }
}

/*
Internal and Protected Internal

A member with internal access modifier is available any where with in the containing assembly.
It's a compile time error to access, an internal member from outside the containing assembly.

Protected internal members can be accessed by any code n the assembly in which it is declared, or
from within a derived class in another assembly. It is combination of protected and internal. If 
you have understood protected and internal, this should be very easy to follow.

Access Modifier						Accessibility

Private								Only with in the containing class

public								Anywhere, No restrictions.

Protected							With in the containing types and the types derived from the containing type. 

Protected Internal					Anywhere with in the containing assembly, and from within a derived class in any another assembly.


In .net if you compile a project a assembly is generated. In .net there are assemblies of two types
	1. executables
	2. dll
	
usually a console application generate a .exe, windows application generate a .exe.
But where as a web application a class library generate .dll

Assembly contains the intermediate language of your project source code. So all your 
projects classes methods structures etc. will be compiled and intermediate language
is generate and it is packaged into assembly.

Assembly is the smallest unit of deployment of a .net application. It can be a dll or an exe.
There are mainly two types to it:

Private Assembly: The dll or exe which is sole property of one application only. It is generally stored in application root folder

Public/Shared assembly: It is a dll which can be used by multiple applications at a time. A shared assembly is stored in GAC i.e Global Assembly Cache.

Sounds difficult? Naa....
GAC is simply C:\Windows\Assembly folder where you can find the public assemblies/dlls of all the softwares installed in your PC.
 */
