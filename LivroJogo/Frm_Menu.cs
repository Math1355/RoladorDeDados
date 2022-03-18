using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroJogo
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Rolar_Click(object sender, EventArgs e)
        {
            var Resultado = new Frm_Result_Dados();
            Resultado.ShowDialog();
        }
    }
}
