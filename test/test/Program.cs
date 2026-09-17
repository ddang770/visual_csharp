namespace test
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (Form_Login form = new Form_Login())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }

            //Application.Run(new Form_Login());
            //Application.Run(new Form1());
        }
    }
}