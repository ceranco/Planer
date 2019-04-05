using System;
using System.Collections.Generic;
using System.Text;

namespace GlfwDotNet
{
    /// <summary>
    /// Function signature for mouse button callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that received the event.</param>
    /// <param name="button">The mouse button that was pressed or released.</param>
    /// <param name="action">One of <see cref="InputAction.Press"/> or <see cref="InputAction.Release"/>.</param>
    /// <param name="mods">Bit field describing which modifier keys were held down.</param>
    public unsafe delegate void mouseButtonCallback(Window* window, MouseButton button, InputAction action, ModifierKeys mods);

    /// <summary>
    /// Function signature for cursor position callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that received the event.</param>
    /// <param name="xPosition">The new cursor x-coordinate, relative to the left edge of the client area.</param>
    /// <param name="yPosition">The new cursor y-coordinate, relative to the top edge of the client area.</param>
    public unsafe delegate void cursorPositionCallback(Window* window, double xPosition, double yPosition);

    /// <summary>
    /// Function signature for cursor enter/leave callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that received the event.</param>
    /// <param name="entered">
    /// <see langword="true"/> if the cursor entered the window's 
    /// client area, or <see langword="false"/> if it left it.
    /// </param>
    public unsafe delegate void cursorEnterCallback(Window* window, bool entered);

    /// <summary>
    /// Function signature for scroll callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that received the event.</param>
    /// <param name="xOffset">The scroll offset along the x-axis.</param>
    /// <param name="yOffset">The scroll offset along the y-axis.</param>
    public unsafe delegate void scrollCallback(Window* window, double xOffset, double yOffset);

    /// <summary>
    /// Function signature for keyboard key callback functions.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that received the event.</param>
    /// <param name="key">The keyboard key that was pressed or released.</param>
    /// <param name="scancode">The system-specific scancode of the key.</param>
    /// <param name="action">The <see cref="InputAction"/> taken.</param>
    /// <param name="mods">Bit field describing which modifier keys were held down.</param>
    public unsafe delegate void keyCallback(Window* window, Key key, int scancode, int action, ModifierKeys mods);

    /// <summary>
    /// Function signature for file drop callbacks.
    /// </summary>
    /// <param name="window">The <see cref="Window"/> that received the event.</param>
    /// <param name="count">The number of dropped files.</param>
    /// <param name="paths">The UTF-8 encoded file and/or directory path names.</param>
    public unsafe delegate void dropCallback(Window* window, int count, string[] paths);

    /// <summary>
    /// The literal values used for input functions.
    /// </summary>
    public static class InputLiterals
    {
        const int Cursor = 0x00033001;
        const int CursorDisabled = 0x00034003;
        const int CursorHidden = 0x00034002;
        const int CursorNormal = 0x00034001;

        const int StickyKeys = 0x00033002;
        const int StickyMouseButtons = 0x00033003;

        const int Enabled = 1;
        const int Disabled = 0;
    }


    public partial interface IGlfw
    {
        /// <summary>
        /// <para>This function returns the value of an input option for the specified window.</para>
        /// The mode must be one of <see cref="InputLiterals.Cursor"/>, 
        /// <see cref="InputLiterals.StickyKeys"/> or <see cref="InputLiterals.StickyMouseButtons"/>.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to query.</param>
        /// <param name="mode">One of <see cref="InputLiterals.Cursor"/>, 
        /// <see cref="InputLiterals.StickyKeys"/> or <see cref="InputLiterals.StickyMouseButtons"/>.</param>
        /// <returns>
        /// <para>
        /// For <see cref="InputLiterals.Cursor"/>: <see cref="InputLiterals.CursorNormal"/>, 
        /// <see cref="InputLiterals.CursorHidden"/> or <see cref="InputLiterals.CursorDisabled"/>.
        /// </para>
        /// <para>
        /// For <see cref="InputLiterals.StickyKeys"/>: <see cref="InputLiterals.Enabled"/> 
        /// or <see cref="InputLiterals.Disabled"/>.
        /// </para>
        /// <para>
        /// For <see cref="InputLiterals.StickyMouseButtons"/>: <see cref="InputLiterals.Enabled"/> 
        /// or <see cref="InputLiterals.Disabled"/>.
        /// </para>
        /// </returns>
        unsafe int GetInputMode(Window* window, int mode);

        /// <summary>
        /// <para>Sets an input mode option for the specified window.</para>
        /// The mode must be one of <see cref="InputLiterals.Cursor"/>, 
        /// <see cref="InputLiterals.StickyKeys"/> or <see cref="InputLiterals.StickyMouseButtons"/>.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose input mode to set.</param>
        /// <param name="mode">One of <see cref="InputLiterals.Cursor"/>, 
        /// <see cref="InputLiterals.StickyKeys"/> or <see cref="InputLiterals.StickyMouseButtons"/>.</param>
        /// <param name="value">
        /// <para>The new value of the specified input mode:</para>
        /// For <see cref="InputLiterals.Cursor"/>: <see cref="InputLiterals.CursorNormal"/>, 
        /// <see cref="InputLiterals.CursorHidden"/> or <see cref="InputLiterals.CursorDisabled"/>.
        /// <para>
        /// For <see cref="InputLiterals.StickyKeys"/>: <see cref="InputLiterals.Enabled"/> 
        /// or <see cref="InputLiterals.Disabled"/>.
        /// </para>
        /// <para>
        /// For <see cref="InputLiterals.StickyMouseButtons"/>: <see cref="InputLiterals.Enabled"/> 
        /// or <see cref="InputLiterals.Disabled"/>.
        /// </para>
        /// </param>
        unsafe void SetInputMode(Window* window, int mode, int value);

        /// <summary>
        /// <para>Returns the last state reported for the specified key to the specified window.</para>
        /// The returned state is one of <see cref="InputAction.Press"/> or <see cref="InputAction.Release"/>.
        /// The higher-level action <see cref="InputAction.Repeat"/> is only reported to the key callback.
        /// </summary>
        /// <remarks>
        /// If the <see cref="InputLiterals.StickyKeys"/> input mode is enabled, this function returns 
        /// <see cref="InputAction.Press"/> the first time you call it for a key that was pressed, 
        /// even if that key has already been released.
        /// 
        /// Do not use this function to implement text input.
        /// </remarks>
        /// <param name="window">The <see cref="Window"/> to query.</param>
        /// <param name="key">The desired keyboard key. <see cref="Key.Unknown"/> 
        /// is not a valid key for this function.</param>
        /// <returns>One of <see cref="InputAction.Press"/> or <see cref="InputAction.Release"/>.</returns>
        unsafe int GetKey(Window* window, Key key);

        /// <summary>
        /// <para>Returns the last state reported for the specified mouse button to the specified window.</para>
        /// The returned state is one of <see cref="InputAction.Press"/> or <see cref="InputAction.Release"/>.
        /// </summary>
        /// <remarks>
        /// If the <see cref="InputLiterals.StickyMouseButtons"/> input mode is enabled, this function returns 
        /// <see cref="InputAction.Press"/> the first time you call it for a mouse button that was pressed, 
        /// even if that mouse button has already been released.
        /// </remarks>
        /// <param name="window">The <see cref="Window"/> to query.</param>
        /// <param name="button">The desired mouse button.</param>
        /// <returns>One of <see cref="InputAction.Press"/> or <see cref="InputAction.Release"/>.</returns>
        unsafe int GetMouseButton(Window* window, MouseButton button);

        /// <summary>
        /// <para>
        /// Returns the position of the cursor, in screen coordinates, relative 
        /// to the upper-left corner of the client area of the specified window.
        /// </para>
        /// If the cursor is disabled (with <see cref="InputLiterals.CursorDisabled"/>) then the 
        /// cursor position is unbounded and limited only by <see cref="double.MinValue"/> 
        /// and <see cref="double.MaxValue"/>.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to query.</param>
        /// <param name="xPosition">The cursor x-coordinate, relative to the left edge of the client area.</param>
        /// <param name="yPosition">The cursor y-coordinate, relative to the to top edge of the client area.</param>
        unsafe void GetCursorPos(Window* window, out double xPosition, out double yPosition);

        /// <summary>
        /// <para>
        /// Sets the position, in screen coordinates, of the cursor 
        /// relative to the upper-left corner of the client area of the specified window.
        /// </para>
        /// The window must have input focus.
        /// If the window does not have input focus when this function is called, it fails silently.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> to query.</param>
        /// <param name="xPosition">The desired x-coordinate, relative to the left edge of the client area.</param>
        /// <param name="yPosition">The desired y-coordinate, relative to the top edge of the client area.</param>
        unsafe void SetCursorPos(Window* window, double xPosition, double yPosition);

        /// <summary>
        /// Sets the key callback of the specified window, 
        /// which is called when a key is pressed, repeated or released.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose callback to set.</param>
        /// <param name="callback">The new <see cref="keyCallback"/>, or 
        /// <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="keyCallback"/>, or <see langword="null"/> 
        /// if no callback was set or the library had not been initialized.</returns>
        unsafe keyCallback SetKeyCallback(Window* window, keyCallback callback);

        /// <summary>
        /// Sets the mouse button callback of the specified window, 
        /// which is called when a mouse button is pressed or released.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose callback to set.</param>
        /// <param name="callback">The new <see cref="mouseButtonCallback"/>, or 
        /// <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="mouseButtonCallback"/>, or <see langword="null"/> 
        /// if no callback was set or the library had not been initialized.</returns>
        unsafe mouseButtonCallback SetMouseButtonCallback(Window* window, mouseButtonCallback callback);

        /// <summary>
        /// <para>Sets the <see cref="cursorPositionCallback"/> of the specified window, which is called when the cursor is moved.</para>
        /// The callback is provided with the position, in screen coordinates, relative to the upper-left corner of the client area of the window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose callback to set.</param>
        /// <param name="callback">The new <see cref="cursorPositionCallback"/>, or 
        /// <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="cursorPositionCallback"/>, or <see langword="null"/> 
        /// if no callback was set or the library had not been initialized.</returns>
        unsafe cursorPositionCallback SetCursorPosCallback(Window* window, cursorPositionCallback callback);

        /// <summary>
        /// Sets the <see cref="cursorEnterCallback"/> of the specified window, which is called when 
        /// the cursor enters or leaves the client area of the window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose callback to set.</param>
        /// <param name="callback">The new <see cref="cursorEnterCallback"/>, or 
        /// <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="cursorEnterCallback"/>, or <see langword="null"/> 
        /// if no callback was set or the library had not been initialized.</returns>
        unsafe cursorEnterCallback SetCursorEnterCallback(Window* window, cursorPositionCallback callback);

        /// <summary>
        /// sets the <see cref="scrollCallback"/> of the specified window, which is called 
        /// when a scrolling device is used, such as a mouse wheel or scrolling area of a touchpad.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose callback to set.</param>
        /// <param name="callback">The new <see cref="scrollCallback"/>, or 
        /// <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="scrollCallback"/>, or <see langword="null"/> 
        /// if no callback was set or the library had not been initialized.</returns>
        unsafe scrollCallback SetScrollCallback(Window* window, scrollCallback callback);

        /// <summary>
        /// Sets the file drop callback of the specified window, which is 
        /// called when one or more dragged files are dropped on the window.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> whose callback to set.</param>
        /// <param name="callback">The new <see cref="dropCallback"/>, or 
        /// <see langword="null"/> to remove the currently set callback.</param>
        /// <returns>The previously set <see cref="dropCallback"/>, or <see langword="null"/> 
        /// if no callback was set or the library had not been initialized.</returns>
        unsafe dropCallback SetDropCallback(Window* window, dropCallback callback);

        /// <summary>
        /// <para>Gets the contents of the system clipboard, if it contains or is convertible to a UTF-8 encoded string.</para>
        /// If the clipboard is empty or if its contents cannot be converted, 
        /// <see langword="null"/> is returned and a <see cref="ErrorCode.FormatUnavailable"/> error is generated.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> that will request the clipboard contents.</param>
        /// <returns>The contents of the clipboard as a UTF-8 encoded 
        /// string, or <see langword="null"/> if an error occurred.</returns>
        unsafe string GetClipboardString(Window* window);

        /// <summary>
        /// Sets the system clipboard to the specified, UTF-8 encoded string.
        /// </summary>
        /// <param name="window">The <see cref="Window"/> that will own the clipboard contents.</param>
        /// <param name="str">A UTF-8 encoded string.</param>
        unsafe void SetClipboardString(Window* window, string str);

        
    }
}
