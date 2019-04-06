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

                unsafe
                {
                    if (!glfw.Init())
                    {
                        return;
                    }

                    glfw.WindowHint(WindowHint.Context.ContextVersionMajor, 3);
                    glfw.WindowHint(WindowHint.Context.ContextVersionMinor, 0);

                    var window = glfw.CreateWindow(640, 480, "Simple example");
                    if (window == null)
                    {
                        glfw.Terminate();
                        return;
                    }

                    
                    glfw.MakeContextCurrent(window);
                    glfw.SwapInterval(1);

                    while (!glfw.WindowShouldClose(window))
                    {
                        glfw.SwapBuffers(window);
                        glfw.PollEvents();
                    }
                    glfw.DestroyWindow(window);
                    glfw.Terminate();
                }

            }
        }
    }
}
