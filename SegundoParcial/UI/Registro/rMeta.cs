using SegundoParcial.BLL;
using SegundoParcial.DAL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial.UI.Registro
{
    public partial class rMeta : Form
    {
        RepositoryBase<Meta> repositorio;
        public rMeta()
        {
            InitializeComponent();
        }


        public Meta LlenarClase()
        {
            Meta meta = new Meta()
            {
                MetaId = Convert.ToInt32(IDnumericUpDown.Value),
                Descripcion = DescripcionTextBox.Text,
                Cuotas = Convert.ToSingle(CuotasnumericUpDown.Value)
            };
            return meta;
        }

        public void LLenarCampo(Meta meta)
        {
            IDnumericUpDown.Value = meta.MetaId;
            DescripcionTextBox.Text = meta.Descripcion;
            CuotasnumericUpDown.Value = Convert.ToDecimal(meta.Cuotas);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            repositorio = new RepositoryBase<Meta>();
            bool paso = false;
            Meta meta;
            Contexto contexto = new Contexto();


            meta = LlenarClase();
            try
            {
                if (IDnumericUpDown.Value == 0)
                    paso = repositorio.Guardar(meta);

                if (paso)
                {
                    MessageBox.Show("Se Guardo Exitosamente", "Imformacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se Gurdo!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
