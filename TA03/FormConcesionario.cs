using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA03.Services;
using TA03.Entities;

namespace TA03
{
    public partial class FormConcesionario : Form
    {
        private ConcesionarioSer concesionarioSer = new ConcesionarioSer();
        public FormConcesionario()
        {
            InitializeComponent();
        }
        private void MostrarConcesionario(List<Entities.Concesionario> concesionarios)
        {
            dgConce.DataSource = null;
            if(concesionarios.Count == 0)
            {
                return;
            }
            else
            {
                dgConce.DataSource = concesionarios;
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            //Validación de campos
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "") 
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Concesionario conce = new Concesionario()
            {
                Codigo = textBox1.Text,
                Cliente = textBox2.Text,
                Direccion = textBox3.Text,
                Tipo = textBox4.Text,
                Marca = textBox5.Text,
                Precio = double.Parse(textBox7.Text),

            };
            //Registrar
            bool registrado = concesionarioSer.Regitrar(conce);
            if (!registrado)
            {
                MessageBox.Show("El codigo ya existe");
                return;
            }

            //Mostrar

            MostrarConcesionario(concesionarioSer.ListarTodo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgConce.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            String codigo = dgConce.SelectedRows[0].Cells[0].Value.ToString();

            //Eliminamos
            concesionarioSer.Eliminar(codigo);

            MostrarConcesionario(concesionarioSer.ListarTodo());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
