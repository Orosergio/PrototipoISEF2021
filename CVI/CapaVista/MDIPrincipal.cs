
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaVista
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;
     
        public MDIPrincipal()
        {
            InitializeComponent();    
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            

        }

        //Herramientas De Seguridad--------------------------------
        private void cambioDeContrasenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimiendoAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void asignacionPerfilYAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void asignacionDeAplicacionAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //--------------------------------------------------------------

        //Menu Mantenimiento Proveedores-Seguridad
        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //Mantenimiento Clientes -- Y Con seguridad.
        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void mantenimientoEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoPaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void mantenimientoDepartamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoMunicipioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoLineaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mantenimientoMarcaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void mantenimientoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void mantenimientoBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void movimientoDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void visualizarMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoBodegaABodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mantenimientoExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void compraDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void impresionComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void estadoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void abonoCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
       
        }

        private void moverABodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void reciboDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
    }
}
