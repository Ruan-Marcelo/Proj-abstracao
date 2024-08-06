using PorjAbstracao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorjAbstracao
{
    public partial class frmABSTRACAO : Form
    {
        public frmABSTRACAO()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            Medico o_Medico = new Medico();

            o_Medico.nomeMedico = "Ricardo";
            o_Medico.telefoneMedico = 16974027438;
            o_Medico.crmMedico = 1533;
            o_Medico.especializadeMedico = "Fazer omelete";

            Console.WriteLine($"Nome do Médico:{o_Medico.nomeMedico}");
            Console.WriteLine($"Telefone do Médico: {o_Medico.telefoneMedico}");
            Console.WriteLine($"CRM do Médico: {o_Medico.crmMedico}");
            Console.WriteLine($"Especialidade do Médico: {o_Medico.especializadeMedico}");
        }
        private void btnBebe_Click(object sender, EventArgs e)
        {
            Bebe o_Bebe = new Bebe();

            o_Bebe.nomeBebe = "Amostradinho";
            o_Bebe.nascBebe = new DateTime(2024, 8, 5); 
            o_Bebe.pesoBebe = 6.50;
            o_Bebe.alturaBebe = 0.40;
            o_Bebe.nomeMaeBebe = "Noemia";
            o_Bebe.nomeMedicoBebe = "Ricardo";

            Console.WriteLine($"Nome do Bebê:{o_Bebe.nomeBebe}");
            Console.WriteLine($"Data de Nascimento do Bebê: {o_Bebe.nascBebe}");
            Console.WriteLine($"Peso que o Bebê nasceu: {o_Bebe.pesoBebe}");
            Console.WriteLine($"Altura do Bebê: {o_Bebe.alturaBebe}");
            Console.WriteLine($"Nome da Mãe do Bebê: {o_Bebe.nomeMaeBebe}");
            Console.WriteLine($"Nome do Médico do Bebê: {o_Bebe.nomeMedicoBebe}");

        }
        private void btnMae_Click(object sender, EventArgs e)
        {
            Mae o_Mae = new Mae();

            o_Mae.nomeMae = "Noemia";
            o_Mae.telefoneMae = 40028922;
            o_Mae.enderecoMae = "Rua Capitão Salomão 1533";
            o_Mae.nascMae = new DateTime(1995, 2, 25);

            Console.WriteLine($"Nome da Mãe do  Bebê:{o_Mae.nomeMae}");
            Console.WriteLine($"Data de Nascimento do Bebê: {o_Mae.telefoneMae}");
            Console.WriteLine($"Peso que o Bebê nasceu: {o_Mae.enderecoMae}");
            Console.WriteLine($"Altura do Bebê: {o_Mae.nascMae}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
