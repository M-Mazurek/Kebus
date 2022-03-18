namespace Kebus
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            if (MessageBox.Show("Добро пожаловать в кебус!", "кебус", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Run(new FormDBDebug());
            else
                Application.Run(new Form1());
        }
    }
}