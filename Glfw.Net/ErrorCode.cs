namespace GlfwDotNet
{
    /// <summary>
    /// Various error codes for GLFW functions.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// This occurs if a GLFW function was called that 
        /// must not be called unless the library is initialized.
        /// </summary>
        /// <remarks>
        /// Application programmer error. 
        /// Initialize GLFW before calling any function that requires initialization. 
        /// </remarks>
        NotInitialized = 65537,
        /// <summary>
        /// This occurs if a GLFW function was called that needs and  operates 
        /// on the current OpenGL or OpenGL ES context but no  context is current 
        /// on the calling thread. One such function is glfwSwapInterval.
        /// </summary>
        /// <remarks>
        /// Application programmer error. 
        /// Ensure a context is current before calling functions that require a current context. 
        /// </remarks>
        NoCurrentContext = 65538,
        /// <summary>
        /// One of the arguments to the function was an invalid enum value, 
        /// for example requesting RED_BITS with glfwGetWindowAttrib.
        /// </summary>
        /// <remarks>
        /// Application programmer error.
        /// Fix the offending call.
        /// </remarks>
        InvalidEnum = 65539,
        /// <summary>
        /// One of the arguments to the function was an invalid value, 
        /// for example requesting a non-existent OpenGL or OpenGL ES version like 2.7.
        /// Requesting a valid but unavailable OpenGL or OpenGL ES version will 
        /// instead result in a VERSION_UNAVAILABLE error.
        /// </summary>
        /// <remarks>
        /// Application programmer error. 
        /// Fix the offending call. 
        /// </remarks>
        InvalidValue = 65540,
        /// <summary>
        /// A memory allocation failed.
        /// </summary>
        /// <remarks>
        /// A bug in GLFW or the underlying operating system. 
        /// Report the bug to our issue tracker. 
        /// </remarks>
        OutOfMemory = 65541,
        /// <summary>
        /// GLFW could not find support for the requested API on the system.
        /// </summary>
        /// <remarks>
        /// The installed graphics driver does not support the requested API, 
        /// or does not support it via the chosen context creation backend. 
        /// Below are a few examples.
        /// <para>
        /// Some pre-installed Windows graphics drivers do not support OpenGL. 
        /// AMD only supports OpenGL ES via EGL, while Nvidia and Intel only support it via a WGL or GLX extension. 
        /// OS X does not provide OpenGL ES at all. 
        /// The Mesa EGL, OpenGL and OpenGL ES libraries do not interface with the Nvidia binary driver.
        /// Older graphics drivers do not support Vulkan.
        /// </para>
        /// </remarks>
        ApiUnavailable = 65542,
        /// <summary>
        /// The requested OpenGL or OpenGL ES version (including any requested 
        /// context or framebuffer hints) is not available on this machine.
        /// </summary>
        /// <remarks>
        /// The machine does not support your requirements. 
        /// If your application is sufficiently flexible, downgrade your requirements and try again. 
        /// Otherwise, inform the user that their machine does not match your requirements.
        /// Future invalid OpenGL and OpenGL ES versions, for example OpenGL 4.8 if 5.0 comes 
        /// out before the 4.x series gets that far, also fail with this error and not 
        /// INVALID_VALUE, because GLFW cannot know what future versions will exist. 
        /// </remarks>
        VersionUnavailable = 65543,
        /// <summary>
        /// A platform-specific error occurred that does not match any of the more specific categories.
        /// </summary>
        /// <remarks>
        /// A bug or configuration error in GLFW, the underlying operating 
        /// system or its drivers, or a lack of required resources. 
        /// Report the issue to our issue tracker. 
        /// </remarks>
        PlatformError = 65544,
        /// <summary>
        /// If emitted during window creation, the requested pixel format is not supported.
        /// If emitted when querying the clipboard, the contents of the 
        /// clipboard could not be converted to the requested format.
        /// </summary>
        /// <remarks>
        /// If emitted during window creation, one or more hard constraints did not
        /// match any of the available pixel formats. If your application is sufficiently flexible, downgrade your requirements and try again. 
        /// Otherwise, inform the user that their machine does not match your requirements.
        /// If emitted when querying the clipboard, ignore the error or report it to the user, as appropriate. 
        /// </remarks>
        FormatUnavailable = 65545,
        /// <summary>
        /// A window that does not have an OpenGL or OpenGL ES 
        /// context was passed to a function that requires it to have one.
        /// </summary>
        /// <remarks>
        /// Application programmer error. 
        /// Fix the offending call. 
        /// </remarks>
        NoWindowContext  = 65546,
    }
}
