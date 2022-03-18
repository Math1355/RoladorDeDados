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
    public partial class Frm_Result_Dados : Form
    {
        public Frm_Result_Dados()
        {
            InitializeComponent();

            var Rolador = new RoladorDeDados();
            Rolador.RolarDados(20, 1, 0);
            lbl_resultado.Text = "O resultado do " + Rolador.QuantidadeDados + "d" + Rolador.tipoDeDado + " foi: ";
            lbl_Valor_Dado.Text = Rolador.somaDados.ToString();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
