.assembly StaticMethodInInterface{}
.assembly extern mscorlib {}
.module StaticMethodInInterface.dll

.namespace DLLibrary
{    
    // ----------------------------- Interface -----------------------------------
    .class interface public abstract auto ansi StaticMethodInInterface.IInterface
    {
       .method public hidebysig static void  Method() cil managed
       {
            // Code size       13 (0xd)
            .maxstack  8
   
            IL_0000:  nop
            IL_0001:  ldstr  "Hello from Interface!"
            IL_0006:  call   void [mscorlib]System.Console::WriteLine(string)
            IL_000b:  nop
            IL_000c:  ret

       } // End of method IInterface::Method
    }
}