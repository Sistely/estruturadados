using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    static class Program
    {
        /**
            *  Nome: Sistely Nazareth de Sousa
            *  Matricula: CB3003884  
        **/
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
