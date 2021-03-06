﻿using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante.UI.Registro
{
    public partial class RegistroCliente : Form
    {
        RepositoryBase<Cliente> repository;
        public RegistroCliente()
        {
            InitializeComponent();
            repository = new RepositoryBase<Cliente>();
        }


        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
        }

        private Cliente LlenarClase()
        {
            Cliente cliente = new Cliente();
            cliente.ClieteID = Convert.ToInt32(IDnumericUpDown.Value);
            cliente.Nombre = NombretextBox.Text;
            
            cliente.Email = EmailtextBox.Text;
            cliente.Telefono = TelefonomaskedTextBox.Text;
            
            return cliente;
        }

        public void LlenarCampo(Cliente cliente)
        {
            IDnumericUpDown.Value = cliente.ClieteID;
            NombretextBox.Text = cliente.Nombre;
            EmailtextBox.Text = cliente.Email;
            TelefonomaskedTextBox.Text = cliente.Telefono;
            
        }

        public bool ExiteEnLaDb()
        {
            RepositoryBase<Cliente> repository = new RepositoryBase<Cliente>();
            Cliente cliente = repository.Buscar((int)IDnumericUpDown.Value);
            return (cliente != null);
        }

        public bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                errorProvider1.SetError(TelefonomaskedTextBox, "Campo Vacio");
                paso = false;
            }
           
            return paso;
        }





        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }





        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            repository = new RepositoryBase<Cliente>();
            Cliente cliente;

            if (!Validar())
                return;

            cliente = LlenarClase();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repository.Guardar(cliente);
            }
            else
            {
                if (!ExiteEnLaDb())
                {
                    MessageBox.Show("No exite no se Puede modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Limpiar();
            if (paso)
            {

                MessageBox.Show("Se Guardo Con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se Puede Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void EliminarButton_Click(object sender, EventArgs e)
        {
            repository = new RepositoryBase<Cliente>();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            if (!ExiteEnLaDb())
            {
                errorProvider1.SetError(IDnumericUpDown, "Cliente no exite");
                IDnumericUpDown.Focus();
                return;
            }
            if (repository.Eliminar(id))
            {
                MessageBox.Show("Eliminado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Exite No se puede Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            //var listado = new List<Cliente>();
            repository = new RepositoryBase<Cliente>();
            int id;
            Cliente cliente = new Cliente();

            int.TryParse(IDnumericUpDown.Text, out id);
            cliente = repository.Buscar(id);

            if (cliente != null)
            {
                LlenarCampo(cliente);
                MessageBox.Show("Cliente Encotrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Cliente no Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
