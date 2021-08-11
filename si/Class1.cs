using System;

namespace si
{
    public class Class1
    {

        private int id;
        private string dni;
        private string nombres;
        private string apellidos;
        private decimal salario;
        public Class1()
        {

        }
        public Class1(int id, string dni,string nombres,string apellidos,decimal salario)
        {
            this.Id = id;
            this.DNI = dni;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Salario = salario;
        }
        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string DNI
        {
            get => this.dni;
            set => this.dni = value;
        }
        public string Nombres
        {
            get => this.nombres;
            set => this.nombres = value;
        }
        public string Apellidos
        {
            get => this.apellidos;
            set => this.apellidos = value;
        }
        public decimal Salario
        {
            get => this.salario;
            set => this.salario = value;
        }
    }
    

}
