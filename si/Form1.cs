using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace si
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombres, apellidos, dni;
            decimal salario;
            dni = txtDni.Text;
            nombres = txtNombres.Text;
            if (txtNombres.Text.Length>20)
            {
                MessageBox.Show($@"Error el nombre:{txtNombres.Text} Tiene muchas letras","Mesaje de error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            apellidos = txtApellidos.Text;
            if (txtApellidos.Text.Length > 20)
            {
                MessageBox.Show($@"Error el nombre:{txtApellidos.Text} Tiene muchas letras", "Mesaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show($@"Error el salario:{txtSalario.Text} no se pudo convertir", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Class1 emp = new Class1()
            {
                Id = 1,
                DNI = dni,
                Nombres = nombres,
                Apellidos = apellidos,
                Salario = salario,
            };
            MessageBox.Show($@"
                            DNI:{emp.DNI}{Environment.NewLine}
                            Nombre:{emp.Nombres}{Environment.NewLine}
                            Apellidos:{emp.Apellidos}{Environment.NewLine}
                            Salario:{emp.Salario}{Environment.NewLine}");
        }
        private void CleanTexbox()
        {
            txtDni.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtSalario.Text = string.Empty;

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar>=32&& e.KeyChar<47)|| (e.KeyChar >= 58 && e.KeyChar < 255))
            {
                MessageBox.Show("Solo números","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar < 43)|| (e.KeyChar >= 58 && e.KeyChar < 255) || (e.KeyChar >= 45 && e.KeyChar < 47))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar < 57)
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar < 57)
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }
    }
}
