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

    /// <summary>
    /// Hints that can be set before the creation of 
    /// a window and context and their viable values. 
    /// </summary>
    public static class WindowHint
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public const int DontCare = -1;

        public const int NoApi = 0;
        public const int OpenGLApi = 0x00030001;
        public const int OpenglESApi = 0x00030002;

        public const int OpenGLAnyProfile = 0;
        public const int OpenGLCompatProfile = 0x00032002;
        public const int OpenglCoreProfile = 0x00032001;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// Hints that can be set before the creation of 
        /// a window and context that affect the window itelf. 
        /// </summary>
        public enum Window : int
        {
            /// <summary>
            /// Specifies whether the windowed mode window will be resizable by the user.
            /// </summary>
            Resizable = 0x00020003,
            /// <summary>
            /// Specifies whether the windowed mode window will be initially visible.
            /// </summary>
            Visible = 0x00020004,
            /// <summary>
            /// Specifies whether the windowed mode window will 
            /// have window decorations such as a border, a close widget, etc.
            /// </summary>
            Decorated = 0x00020005,
            /// <summary>
            /// Specifies whether the windowed mode window will be given input focus when created.
            /// </summary>
            Focused = 0x00020001,
            /// <summary>
            /// Specifies whether the full screen window will automatically 
            /// iconify and restore the previous video mode on input focus loss. 
            /// </summary>
            AutoIconify = 0x00020006,
            /// <summary>
            /// Specifies whether the windowed mode window will be floating above 
            /// other regular windows, also called topmost or always-on-top. 
            /// </summary>
            Floating = 0x00020007,
            /// <summary>
            /// Specifies whether the windowed mode window will be maximized when created.
            /// </summary>
            Maximized = 0x00020008,
        }

        /// <summary>
        /// Hints that can be set before the creation of 
        /// a window and context that affect the framebuffer. 
        /// </summary>
        public enum Framebuffer
        {
            /// <summary>
            /// <para>Specifies the desired bit depths of the red component of the default framebuffer.</para>
            /// Supported values are 0 to <see cref="int.MaxValue"/> or <see cref="DontCare"/>.
            /// </summary>
            RedBits = 0x00021001,
            /// <summary>
            /// <para>Specifies the desired bit depths of the green component of the default framebuffer.</para>
            /// Supported values are 0 to <see cref="int.MaxValue"/> or <see cref="DontCare"/>.
            /// </summary>
            GreenBits = 0x00021002,
            /// <summary>
            /// <para>Specifies the desired bit depths of the blue component of the default framebuffer.</para>
            /// Supported values are 0 to <see cref="int.MaxValue"/> or <see cref="DontCare"/>.
            /// </summary>
            BlueBits = 0x00021003,
            /// <summary>
            /// <para>Specifies the desired bit depths of the alpha component of the default framebuffer.</para>
            /// Supported values are 0 to <see cref="int.MaxValue"/> or <see cref="DontCare"/>.
            /// </summary>
            AlphaBits = 0x00021004,
            /// <summary>
            /// <para>Specifies the desired bit depths of the depth component of the default framebuffer.</para>
            /// Supported values are 0 to <see cref="int.MaxValue"/> or <see cref="DontCare"/>.
            /// </summary>
            DepthBits = 0x00021005,
            /// <summary>
            /// <para>Specifies the desired bit depths of the stencil component of the default framebuffer.</para>
            /// Supported values are 0 to <see cref="int.MaxValue"/> or <see cref="DontCare"/>.
            /// </summary>
            StencilBits = 0x00021006,
            /// <summary>
            /// <para>Specifies the desired number of auxiliary buffers.</para>
            /// Supported values are 0 to <see cref="int.MaxValue"/> or <see cref="DontCare"/>.
            /// </summary>
            AuxBuffers = 0x0002100B,
            /// <summary>
            /// <para>
            /// Specifies the desired number of samples to use for multisampling. 
            /// Zero disables multisampling.
            /// </para>
            /// Supported values are 0 to <see cref="int.MaxValue"/> or <see cref="DontCare"/>.
            /// </summary>
            Samples = 0x0002100D,
        }

        /// <summary>
        /// Hints that can be set before the creation of 
        /// a window and context that affect the context. 
        /// </summary>
        public enum Context : int
        {
            /// <summary>
            /// <para>Specifies which client API to create the context for.</para>
            /// Supported values are <see cref="OpenGLApi"/>, 
            /// <see cref="OpenglESApi"/> or <see cref="NoApi"/>.
            /// </summary>
            ClientApi = 0x00022001,
            /// <summary>
            /// <para>
            /// Specifies the client API major version that the 
            /// created context must be compatible with.
            /// </para>
            /// Supported values are any valid major version number of the chosen client API
            /// </summary>
            ContextVersionMajor = 0x00022002,
            /// <summary>
            /// <para>
            /// Specifies the client API minor version that the 
            /// created context must be compatible with.
            /// </para>
            /// Supported values are any valid minor version number of the chosen client API
            /// </summary>
            ContextVersionMinor = 0x00022003,
            /// <summary>
            /// <para>Specifies which OpenGL profile to create the context for.</para>
            /// Suppored values are <see cref="OpenGLAnyProfile"/>, 
            /// <see cref="OpenGLCompatProfile"/> or <see cref="OpenglCoreProfile"/>
            /// </summary>
            OpenglProfile = 0x00022008,
        }

    }


    public partial interface IGlfw
    {
        /// <summary>
        /// Resets all window hints to their default values.
        /// </summary>
        void DefaultWindowHints();

        /// <summary>
        /// <para>Sets hints for the next call to <see cref="CreateWindow"/>.</para>
        /// The hints, once set, retain their values until changed by a call to 
        /// <see cref="WindowHint(WindowHint.Window, bool)"/> or <see cref="DefaultWindowHints"/>, or until the library is terminated.
        /// </summary>
        /// <param name="hint">The window hint to set.</param>
        /// <param name="value">The new value of the window hint.</param>
        void WindowHint(WindowHint.Window hint, bool value);
        /// <summary>
        /// <para>Sets hints for the next call to <see cref="CreateWindow"/>.</para>
        /// The hints, once set, retain their values until changed by a call to 
        /// <see cref="WindowHint(WindowHint.Framebuffer, int)"/> or <see cref="DefaultWindowHints"/>, or until the library is terminated.
        /// </summary>
        /// <param name="hint">The window hint to set.</param>
        /// <param name="value">The new value of the window hint.</param>
        void WindowHint(WindowHint.Framebuffer hint, int value);
        /// <summary>
        /// <para>Sets hints for the next call to <see cref="CreateWindow"/>.</para>
        /// The hints, once set, retain their values until changed by a call to 
        /// <see cref="WindowHint(WindowHint.Context, int)"/> or <see cref="DefaultWindowHints"/>, or until the library is terminated.
        /// </summary>
        /// <param name="hint">The window hint to set.</param>
        /// <param name="value">The new value of the window hint.</param>
        void WindowHint(WindowHint.Context hint, int value);

        /// <summary>
        /// Creates a window and its associated OpenGL or OpenGL ES context.
        /// Most of the options controlling how the window and its context should be created are specified with window hints.
        /// </summary>
        /// <param name="width">The desired width, in screen coordinates, of the window. This must be greater than zero.</param>
        /// <param name="height">The desired height, in screen coordinates, of the window. This must be greater than zero.</param>
        /// <param name="title">The initial, UTF-8 encoded window title.</param>
        /// <param name="monitor">The monitor to use for full screen mode, or <see langword="null"/> for windowed mode.</param>
        /// <param name="share">The window whose context to share resources with, or <see langword="null"/> to not share resources.</param>
        /// <returns>The handle of the created window, or <see langword="null"/> if an error occurred.</returns>
        unsafe Window* CreateWindow(int width, int height, string title, Monitor* monitor = null, Window* share = null);

        /// <summary>
        /// <para>Destroys the specified window and its context.</para>
        /// On calling this function, no further callbacks will be called for that window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to destroy.</param>
        unsafe void DestroyWindow(Window* window);

        /// <summary>
        /// Gets the value of the close flag of the specified window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to query.</param>
        /// <returns>The value of the close flag.</returns>
        unsafe bool WindowShouldClose(Window* window);

        /// <summary>
        /// <para>Sets the value of the close flag of the specified window.</para>
        /// This can be used to override the user's attempt to close the window, or to signal that it should be closed.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose flag to change.</param>
        /// <param name="value">The new value.</param>
        unsafe void SetWindowShouldClose(Window* window, int value);

        /// <summary>
        /// This function sets the window title, encoded as UTF-8, of the specified window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose title to change.</param>
        /// <param name="title">The UTF-8 encoded window title.</param>
        unsafe void SetWindowTitle(Window* window, string title);

        /// <summary>
        /// Retrieves the size, in screen coordinates, of the client area of the specified window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose size to retrieve.</param>
        /// <param name="width">The width, in screen coordinates, of the client area.</param>
        /// <param name="height">The height, in screen coordinates, of the client area.</param>
        unsafe void GetWindowSize(Window* window, out int width, out int height);

        /// <summary>
        /// Sets the size, in screen coordinates, of the client area of the specified window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to resize.</param>
        /// <param name="width">The desired width, in screen coordinates, of the window client area.</param>
        /// <param name="height">The desired height, in screen coordinates, of the window client area.</param>
        unsafe void SetWindowSize(Window* window, int width, int height);

        /// <summary>
        /// Iconifies(minimizes) the specified <see cref="Window"/> if it was previously restored.
        /// If the window is already iconified, this function does nothing.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to iconify.</param>
        unsafe void IconifyWindow(Window* window);

        /// <summary>
        /// Restores the specified window if it was previously iconified(minimized) or maximized.
        /// If the window is already restored, this function does nothing.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to restore.</param>
        unsafe void RestoreWindow(Window* window);

        /// <summary>
        /// Maximizes the specified window if it was previously not maximized.
        /// If the window is already maximized, this function does nothing.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to maximize.</param>
        unsafe void MaximizeWindow(Window* window);

        /// <summary>
        /// Makes the specified window visible if it was previously hidden.
        /// If the window is already visible or is in full screen mode, this function does nothing.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to make visible.</param>
        unsafe void ShowWindow(Window* window);

        /// <summary>
        /// Hides the specified window if it was previously visible.
        /// If the window is already hidden or is in full screen mode, this function does nothing.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to hide.</param>
        unsafe void HideWindow(Window* window);

        /// <summary>
        /// Brings the specified window to front and sets input focus.
        /// The window should already be visible and not iconified.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to give input focus.</param>
        unsafe void FocusWindow(Window* window);

        /// <summary>
        /// Swaps the front and back buffers of the specified window when rendering with OpenGL or OpenGL ES.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose buffers to swap.</param>
        unsafe void SwapBuffers(Window* window);

        /// <summary>
        /// <para>Sets the position callback of the specified window, which is called when the window is moved.</para>
        /// The callback is provided with the screen position of the upper-left corner of the client area of the window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose <see cref="windowPositionCallback"/> to set.</param>
        /// <param name="callback">The new <see cref="windowPositionCallback"/>, 
        /// or <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="windowPositionCallback"/>, or 
        /// <see langword="null"/> if no callback was set or the library had not been initialized.</returns>
        unsafe windowPositionCallback SetWindowPosCallback(Window* window, windowPositionCallback callback);

        /// <summary>
        /// <para>Sets the size callback of the specified window, which is called when the window is resized.</para>
        /// The callback is provided with the size, in screen coordinates, of the client area of the window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose <see cref="windowSizeCallback"/> to set.</param>
        /// <param name="callback">The new <see cref="windowSizeCallback"/>, 
        /// or <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="windowSizeCallback"/>, or 
        /// <see langword="null"/> if no callback was set or the library had not been initialized.</returns>
        unsafe windowSizeCallback SetWindowSizeCallback(Window* window, windowSizeCallback callback);
        
        /// <summary>
        /// Sets the close callback of the specified window, which is called when the user attempts to close 
        /// the window, for example by clicking the close widget in the title bar.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose <see cref="windowCloseCallback"/> to set.</param>
        /// <param name="callback">The new <see cref="windowCloseCallback"/>, 
        /// or <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="windowCloseCallback"/>, or 
        /// <see langword="null"/> if no callback was set or the library had not been initialized.</returns>
        unsafe windowCloseCallback SetWindowCloseCallback(Window* window, windowCloseCallback callback);

        /// <summary>
        /// Sets the refresh callback of the specified window, which is called when the client area of the window needs to be redrawn, 
        /// for example if the window has been exposed after having been covered by another window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose <see cref="windowRefreshCallback"/> to set.</param>
        /// <param name="callback">The new <see cref="windowRefreshCallback"/>, 
        /// or <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="windowRefreshCallback"/>, or 
        /// <see langword="null"/> if no callback was set or the library had not been initialized.</returns>
        unsafe windowRefreshCallback SetWindowRefreshCallback(Window* window, windowRefreshCallback callback);

        /// <summary>
        /// Sets the focus callback of the specified window, which is called when the window gains or loses input focus.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose <see cref="windowFocusCallback"/> to set.</param>
        /// <param name="callback">The new <see cref="windowFocusCallback"/>, 
        /// or <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="windowFocusCallback"/>, or 
        /// <see langword="null"/> if no callback was set or the library had not been initialized.</returns>
        unsafe windowFocusCallback SetWindowFocusCallback(Window* window, windowFocusCallback callback);

        /// <summary>
        /// Sets the iconification callback of the specified window, which is called when the window is iconified or restored.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose <see cref="windowIconifyCallback"/> to set.</param>
        /// <param name="callback">The new <see cref="windowIconifyCallback"/>, 
        /// or <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="windowIconifyCallback"/>, or 
        /// <see langword="null"/> if no callback was set or the library had not been initialized.</returns>
        unsafe windowIconifyCallback SetWindowIconifyCallback(Window* window, windowIconifyCallback callback);

        /// <summary>
        /// Sets the framebuffer resize callback of the specified window, which is called
        /// when the framebuffer of the specified window is resized.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose <see cref="framebufferSizeCallback"/> to set.</param>
        /// <param name="callback">The new <see cref="framebufferSizeCallback"/>, 
        /// or <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="framebufferSizeCallback"/>, or 
        /// <see langword="null"/> if no callback was set or the library had not been initialized.</returns>
        unsafe framebufferSizeCallback SetFramebufferSizeCallback(Window* window, framebufferSizeCallback callback);

        /// <summary>
        /// <para>Processes only those events that are already in the event queue and then returns immediately.</para>
        /// Processing events will cause the window and input callbacks associated with those events to be called.
        /// </summary>
        void PollEvents();

        /// <summary>
        /// Puts the calling thread to sleep until at least one event is available in the event queue.
        /// Once one or more events are available, it behaves exactly like <see cref="PollEvents"/>.
        /// </summary>
        void WaitEvents();

        /// <summary>
        /// Puts the calling thread to sleep until at least one event is available in the event 
        /// queue, or until the specified timeout is reached. 
        /// If one or more events are available, it behaves exactly like <see cref="PollEvents"/>.
        /// </summary>
        /// <param name="timeout">The maximum amount of time, in seconds, to wait.</param>
        void WaitEventsTimeout(double timeout);

        /// <summary>
        /// Posts an empty event from the current thread to the event queue, 
        /// causing <see cref="WaitEvents"/> or <see cref="WaitEventsTimeout(double)"/> to return.
        /// </summary>
        void PostEmptyEvent();

    }
}
