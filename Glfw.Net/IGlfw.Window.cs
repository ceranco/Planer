using System;
using System.Collections.Generic;
using System.Text;

namespace GlfwDotNet
{
    /// <summary>
    /// Function signature for window position callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that was moved.</param>
    /// <param name="xPosition">The new x-coordinate, in screen coordinates, 
    /// of the upper-left corner of the client area of the window.</param>
    /// <param name="yPosition">The new y-coordinate, in screen coordinates, 
    /// of the upper-left corner of the client area of the window.</param>
    public unsafe delegate void windowPositionCallback(Window* window, int xPosition, int yPosition);

    /// <summary>
    /// Function signature for window size callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that was resized.</param>
    /// <param name="width">The new width, in screen coordinates, of the window.</param>
    /// <param name="height">The new height, in screen coordinates, of the window.</param>
    public unsafe delegate void windowSizeCallback(Window* window, int width, int height);

    /// <summary>
    /// Function signature for window close callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that the user attempted to close.</param>
    public unsafe delegate void windowCloseCallback(Window* window);

    /// <summary>
    /// Function signature for window refresh callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> whose content needs to be refreshed.</param>
    public unsafe delegate void windowRefreshCallback(Window* window);

    /// <summary>
    /// Function signature for window focus callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that gained or lost input focus.</param>
    /// <param name="focused"><see langword="true"/> if the window was given 
    /// input focus, or <see langword="false"/> if it lost it.</param>
    public unsafe delegate void windowFocusCallback(Window* window, bool focused);

    /// <summary>
    /// Function signature for window iconify/restore callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that was iconified or restored.</param>
    /// <param name="iconified"><see langword="true"/> if the window was 
    /// iconified, or <see langword="false"/> if it was restored.</param>
    public unsafe delegate void windowIconifyCallback(Window* window, bool iconified);

    /// <summary>
    /// Function signature for framebuffer resize callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> whose framebuffer was resized.</param>
    /// <param name="width">The new width, in pixels, of the framebuffer.</param>
    /// <param name="height">The new height, in pixels, of the framebuffer.</param>
    public unsafe delegate void framebufferSizeCallback(Window* window, int width, int height);


    public partial interface IGlfw
    {
    }
}
