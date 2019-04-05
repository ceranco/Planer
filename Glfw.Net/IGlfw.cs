using AdvancedDLSupport;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlfwDotNet
{
    /// <summary>
    /// Function signature for error callback functions.
    /// </summary>
    /// <param name="error">An error code.</param>
    /// <param name="description">A UTF-8 encoded string describing the error.</param>
    public delegate void errorCallback(ErrorCode error, string description);


    [NativeSymbols(Prefix = "glfw", SymbolTransformationMethod = SymbolTransformationMethod.Camelize)]
    public partial interface IGlfw : IDisposable
    {
        /// <summary>
        /// Initializes the GLFW library.
        /// </summary>
        /// <returns><see langword="true"/> if successful, 
        /// or <see langword="false"/> if an error occurred.</returns>
        bool Init();

        /// <summary>
        /// <para>
        /// Destroys all remaining windows and cursors, restores any modified gamma ramps and frees any other allocated resources.
        /// </para>
        ///  Once this function is called, you must again call <see cref="Init"/> 
        ///  successfully before you will be able to use most GLFW functions.
        /// </summary>
        void Terminate();

        /// <summary>
        /// Retrieves the major, minor and revision numbers of the GLFW library.
        /// </summary>
        /// <param name="major">The out parameter for the major version number.</param>
        /// <param name="minor">The out parameter for the minor version number.</param>
        /// <param name="rev">The out parameter for the revision number.</param>
        void GetVersion(out int major, out int minor, out int rev);

        /// <summary>
        /// <para>
        /// Gets the compile-time generated version string of the GLFW library binary.
        /// </para>
        /// It describes the version, platform, compiler and any platform-specific compile-time options. 
        /// </summary>
        /// <returns>The ASCII encoded GLFW version string.</returns>
        string GetVersionString();

        /// <summary>
        /// Sets the error callback, which is called with an error code and a 
        /// human-readable description each time a GLFW error occurs.
        /// </summary>
        /// <param name="callback">The new callback, or 
        /// <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set callback, 
        /// or <see langword="null"/> if no callback was set.</returns>
        errorCallback SetErrorCallback(errorCallback callback);
    }
}
