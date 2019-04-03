namespace GlfwDotNet
{
    public class Window
    {
        private unsafe readonly IGlfw.Window* handle;

        static Window()
        {
            IGlfw.Init();
        }

        public Window(int width, int height, string title)
        {
            unsafe
            {
                handle = IGlfw.CreateWindow(width, height, title, null, null);
            }
        }

        public bool ShouldClose
        {
            get
            {
                unsafe
                {
                    return IGlfw.WindowShouldClose(handle) == 1;
                }
            }
        }

        public static void PollEvents()
        {
            IGlfw.PollEvents();
        }

        public void SwapBuffers()
        {
            unsafe
            {
                IGlfw.SwapBuffers(handle);
            }
        }
    }
}
