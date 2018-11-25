﻿using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante.UI.Consulta
{
    public partial class ConsultaProducto : Form
    {
        private List<Producto> articulos = new List<Producto>();
        public ConsultaProducto()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Producto> repositorio;
            repositorio = new RepositoryBase<Producto>();
            var listado = new List<Producto>();
            int id;
            if (CriteriotextBox.Text.Trim().Length >= 0)
            {

                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Id


                        {
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = RepositoryBase.GetList(p => p.IDArticulos == id);

                            if (RepositoryBase.GetList(listado).Count() == 0)
                            {
                                MessageBox.Show("Este Articulo no Exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        }

                    case 1://Descripcion
                        if (Validar(1))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Validar(3))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            listado = repositoryBase.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                            if (repositoryBase.GetList(listado).Count() == 0)
                            {
                                MessageBox.Show("Descripcion no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        }
                    case 2: //Importe
                        if (Validar(1))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Validar(2))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            float importe = Convert.ToSingle(CriteriotextBox.Text);
                            listado = repositoryBase.GetList(p => p.Costo == importe);
                            if (repositoryBase.GetList(listado).Count() == 0)
                            {
                                MessageBox.Show("Importe no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;


                        }
                    case 3://Ganancia
                        if (Validar(1))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Validar(2))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            float Ganancia = Convert.ToSingle(CriteriotextBox.Text);
                            listado = repositoryBase.GetList(p => p.Ganancia == Ganancia);
                            if (repositoryBase.GetList(listado).Count() == 0)
                            {

                                MessageBox.Show("Ganancia no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;

                    case 4://precio

                        if (Validar(1))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Validar(2))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            float precio = Convert.ToSingle(CriteriotextBox.Text);
                            listado = repositoryBase.GetList(p => p.Precio == precio);

                            if (repositoryBase.GetList(listado).Count() == 0)
                            {

                                MessageBox.Show("Precio no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;

                    case 5: //Cantidad

                        if (Validar(1))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Validar(2))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            int Cantidad = Convert.ToInt32(CriteriotextBox.Text);
                            listado = repositoryBase.GetList(p => p.Cantidad == Cantidad);
                            if (repositoryBase.GetList(listado).Count() == 0)
                            {

                                MessageBox.Show("Precio no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;

                    case 6: //Itebis
                        if (Validar(1))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Validar(2))
                        {
                            MessageBox.Show("Llenar Campo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            float itebis = Convert.ToSingle(CriteriotextBox.Text);
                            listado = repositoryBase.GetList(p => p.Itebis == itebis);
                            if (repositoryBase.GetList(listado).Count() == 0)
                            {

                                MessageBox.Show("Precio no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;
                    case 7://todo
                        listado = x => true;
                        break;
                }
            }
            else
            {
                listado = repositoryBase.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
            CriteriotextBox.Clear();
            errorProvider1.Clear();
        }
    }
}