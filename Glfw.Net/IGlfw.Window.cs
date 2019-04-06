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
            /// <see cref="OpenGLCompatProfile"/> or <see cref="GLFW_OPENGL_CORE_PROFILE"/>
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
    }
}
