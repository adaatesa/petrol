using System;
using System.Windows.Forms;

namespace PetrolOtomasyon
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Burada Form1 kullanılmalı
        }
    }
}
