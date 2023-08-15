using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4.reutilizaveis
{
    public class ExibeForm
    {
        public static void ExibirFormularioEmPainel(Form formulario, Panel painel)
        {          
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            painel.Controls.Clear();
            painel.Controls.Add(formulario);
            formulario.Show();
        }

    }
}
