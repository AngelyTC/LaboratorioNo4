
namespace LaboratorioNo4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAdelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAtrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másVisitadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másRecientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSeleccionadoEnComboboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegadorToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegadorToolStripMenuItem
            // 
            this.navegadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.haciaAdelanteToolStripMenuItem,
            this.haciaAtrásToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.navegadorToolStripMenuItem.Name = "navegadorToolStripMenuItem";
            this.navegadorToolStripMenuItem.Size = new System.Drawing.Size(116, 32);
            this.navegadorToolStripMenuItem.Text = "Navegador";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // haciaAdelanteToolStripMenuItem
            // 
            this.haciaAdelanteToolStripMenuItem.Name = "haciaAdelanteToolStripMenuItem";
            this.haciaAdelanteToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.haciaAdelanteToolStripMenuItem.Text = "Hacia Adelante";
            this.haciaAdelanteToolStripMenuItem.Click += new System.EventHandler(this.haciaAdelanteToolStripMenuItem_Click);
            // 
            // haciaAtrásToolStripMenuItem
            // 
            this.haciaAtrásToolStripMenuItem.Name = "haciaAtrásToolStripMenuItem";
            this.haciaAtrásToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.haciaAtrásToolStripMenuItem.Text = "Hacia Atrás";
            this.haciaAtrásToolStripMenuItem.Click += new System.EventHandler(this.haciaAtrásToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.másVisitadasToolStripMenuItem,
            this.másRecientesToolStripMenuItem,
            this.eliminarSeleccionadoEnComboboxToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // másVisitadasToolStripMenuItem
            // 
            this.másVisitadasToolStripMenuItem.Name = "másVisitadasToolStripMenuItem";
            this.másVisitadasToolStripMenuItem.Size = new System.Drawing.Size(401, 34);
            this.másVisitadasToolStripMenuItem.Text = "Más Visitadas";
            this.másVisitadasToolStripMenuItem.Click += new System.EventHandler(this.másVisitadasToolStripMenuItem_Click);
            // 
            // másRecientesToolStripMenuItem
            // 
            this.másRecientesToolStripMenuItem.Name = "másRecientesToolStripMenuItem";
            this.másRecientesToolStripMenuItem.Size = new System.Drawing.Size(401, 34);
            this.másRecientesToolStripMenuItem.Text = "Más Recientes";
            this.másRecientesToolStripMenuItem.Click += new System.EventHandler(this.másRecientesToolStripMenuItem_Click);
            // 
            // eliminarSeleccionadoEnComboboxToolStripMenuItem
            // 
            this.eliminarSeleccionadoEnComboboxToolStripMenuItem.Name = "eliminarSeleccionadoEnComboboxToolStripMenuItem";
            this.eliminarSeleccionadoEnComboboxToolStripMenuItem.Size = new System.Drawing.Size(401, 34);
            this.eliminarSeleccionadoEnComboboxToolStripMenuItem.Text = "Eliminar Seleccionado en combobox";
            this.eliminarSeleccionadoEnComboboxToolStripMenuItem.Click += new System.EventHandler(this.eliminarSeleccionadoEnComboboxToolStripMenuItem_Click);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(60, 56);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(535, 28);
            this.cmbBuscar.TabIndex = 1;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(633, 56);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(68, 28);
            this.btnIr.TabIndex = 2;
            this.btnIr.Text = "IR";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(60, 105);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1066, 496);
            this.webBrowser1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1382, 647);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Navegador Web";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAdelanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAtrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másVisitadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másRecientesToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem eliminarSeleccionadoEnComboboxToolStripMenuItem;
    }
}

