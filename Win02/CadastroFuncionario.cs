using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win02;
using Win02.Modelo;
using System.ComponentModel.DataAnnotations;

namespace Win02
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SalvarAction(object sender, EventArgs e)
        {
            //1- mover os dados para a classe funcionario
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Salario = decimal.Parse(txtSalario.Text);
            funcionario.Sexo = (rbMasculino.Checked) ? "M" : "F";
            funcionario.TipoContrato = (rbCLT.Checked) ? "CLT" :(rbPJ.Checked) ? "PJ" : "AUT";
            funcionario.DataCadastro = DateTime.Now;

            //2 - validar os dados
            List<ValidationResult> listErrors = new List<ValidationResult>();

            ValidationContext contexto = new ValidationContext(funcionario);

            Validator.TryValidateObject(funcionario, contexto, listErrors, true);

            bool validado = Validator.TryValidateObject(funcionario, contexto, listErrors, true);

            if(validado)
            {

            }

            
            //salvar os dados

            //fechar e atualizar a tela principal
        }
    }
}
