using System;

namespace UI
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            UIManager uIManager = new UIManager();

           uIManager.StartGame();
        }
    }
}
