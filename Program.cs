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
            // konstruktor statyczny moment
            Kebus.Connect();

            ApplicationConfiguration.Initialize();
            if (MessageBox.Show("Debug?", "кебус", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Run(new FormDBDebug());
            else
                Application.Run(new PositionSelector());
        }
    }
}