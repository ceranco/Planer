using AdvancedDLSupport;
using GlfwDotNet;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string library = Environment.Is64BitOperatingSystem ?
                @"C:\Users\ceran\Desktop\glfw-3.2.1\binaries\64-bit\lib\glfw3.dll" :
                @"C:\Users\ceran\Desktop\glfw-3.2.1\binaries\32-bit\lib\glfw3.dll";

            using (var glfw = NativeLibraryBuilder.Default.ActivateInterface<IGlfw>(library))
            {
                glfw.SetErrorCallback((error, message) =>
                {
                    Console.WriteLine(message);
                });
                glfw.GetProcAddress("");
            }
        }
    }
}
