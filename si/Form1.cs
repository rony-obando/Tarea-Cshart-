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
            Class1 emp = new Class1()
            {
                Id = 1,
                DNI="001-190903-1044L",
                Nombres="Rony Alberto",
                Apellidos="Obando Rodriguez",
                Salario=7500,
            };
            MessageBox.Show($@" Id:{emp.Id}{Environment.NewLine}
                            DNI:{emp.DNI}{Environment.NewLine}
                            Nombre:{emp.Nombres}{Environment.NewLine}
                            Apellidos:{emp.Apellidos}{Environment.NewLine}
                            Salario:{emp.Salario}{Environment.NewLine}");
        }

      
    }
}
