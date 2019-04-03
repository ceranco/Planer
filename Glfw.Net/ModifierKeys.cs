using System;

namespace GlfwDotNet
{
    /// <summary>
    /// Bitwise flag for the modifier keys.
    /// </summary>
    [Flags]
    public enum ModifierKeys : int
    {
        /// <summary>
        /// If this bit is set one or more Shift keys were held down.
        /// </summary>
        Shift = 1,
        /// <summary>
        /// If this bit is set one or more Control keys were held down.
        /// </summary>
        Control = 2,
        /// <summary>
        /// If this bit is set one or more Alt keys were held down.
        /// </summary>
        Alt = 4,
        /// <summary>
        /// If this bit is set one or more Super keys were held down.
        /// </summary>
        Super = 8,
    }
}
