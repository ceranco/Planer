using AdvancedDLSupport;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace GlfwDotNet
{
    /// <summary>
    /// Generic function pointer used for returning client API function 
    /// pointers without forcing a cast from a regular pointer.
    /// </summary>
    public delegate void glProc();

    /// <summary>
    /// The interface of the GLFW library.
    /// </summary>
    public partial interface IGlfw
    {
        /// <summary>
        /// <para>
        ///  Makes the OpenGL or OpenGL ES context of the specified window current on the calling thread. 
        /// </para>
        ///  A context can only be made current on a single thread at a time and 
        ///  each thread can have only a single current context at a time.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose context to make current, 
        /// or <see langword="null"/> to detach the current context.</param>
        unsafe void MakeContextCurrent(Window* window);

        /// <summary>
        /// Gets the window whose OpenGL or OpenGL ES context is current on the calling thread.
        /// </summary>
        /// <returns>The <see cref="Window"/> whose context is current, 
        /// or <see langword="null"/> if no window's context is current.</returns>
        unsafe Window* GetCurrentContext();

        /// <summary>
        /// <para>
        /// Sets the swap interval for the current OpenGL or OpenGL ES context, i.e.the 
        /// number of screen updates to wait from the time glfwSwapBuffers was called 
        /// before swapping the buffers and returning. 
        /// </para>
        /// This is sometimes called vertical synchronization, vertical retrace synchronization or just vsync.
        /// </summary>
        /// <param name="interval">The minimum number of screen updates to wait 
        /// for until the buffers are swapped by <see cref="SwapBuffers"/>.</param>        
        void SwapInterval(int interval);

        /// <summary>
        /// <para>
        /// Checks whether the specified API extension is supported by the current OpenGL or OpenGL ES context.
        /// </para>
        /// It searches both for client API extension and context creation API extensions.
        /// </summary>
        /// <param name="extension">The ASCII encoded name of the extension.</param>
        /// <returns><see langword="true"/> if the extension is available,
        /// <see langword="false"/> if otherwise</returns>
        bool ExtensionSupported(string extension);

        /// <summary>
        /// Returns the address of the specified OpenGL or OpenGL ES core 
        /// or extension function, if it is supported by the current context.
        /// </summary>
        /// <param name="procname">The ASCII encoded name of the function.</param>
        /// <returns>he address of the function, or <see langword="null"/> if an error occurred.</returns>
        glProc GetProcAddress(string procname);
    }
}
