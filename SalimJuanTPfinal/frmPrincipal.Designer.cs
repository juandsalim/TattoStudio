namespace SalimJuanTPfinal
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agengaDeTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosPorProfesionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profecionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProfecionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProfecionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProfesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.profecionalesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(632, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "MenuStrip";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado Clientes ADM";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem1
            // 
            this.listadoDeClientesToolStripMenuItem1.Name = "listadoDeClientesToolStripMenuItem1";
            this.listadoDeClientesToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.listadoDeClientesToolStripMenuItem1.Text = "Listado Clientes";
            this.listadoDeClientesToolStripMenuItem1.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem1_Click);
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaTurnoToolStripMenuItem,
            this.agengaDeTurnosToolStripMenuItem,
            this.turnosPorProfesionalToolStripMenuItem});
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // agregaTurnoToolStripMenuItem
            // 
            this.agregaTurnoToolStripMenuItem.Name = "agregaTurnoToolStripMenuItem";
            this.agregaTurnoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.agregaTurnoToolStripMenuItem.Text = "Agregar Turno";
            this.agregaTurnoToolStripMenuItem.Click += new System.EventHandler(this.agregaTurnoToolStripMenuItem_Click);
            // 
            // agengaDeTurnosToolStripMenuItem
            // 
            this.agengaDeTurnosToolStripMenuItem.Name = "agengaDeTurnosToolStripMenuItem";
            this.agengaDeTurnosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.agengaDeTurnosToolStripMenuItem.Text = "Agenda de Turnos";
            this.agengaDeTurnosToolStripMenuItem.Click += new System.EventHandler(this.agengaDeTurnosToolStripMenuItem_Click);
            // 
            // turnosPorProfesionalToolStripMenuItem
            // 
            this.turnosPorProfesionalToolStripMenuItem.Name = "turnosPorProfesionalToolStripMenuItem";
            this.turnosPorProfesionalToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.turnosPorProfesionalToolStripMenuItem.Text = "Turnos por Profesional";
            this.turnosPorProfesionalToolStripMenuItem.Click += new System.EventHandler(this.turnosPorProfesionalToolStripMenuItem_Click);
            // 
            // profecionalesToolStripMenuItem
            // 
            this.profecionalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProfecionalToolStripMenuItem,
            this.listadoDeProfecionalesToolStripMenuItem,
            this.listadoDeProfesionalesToolStripMenuItem});
            this.profecionalesToolStripMenuItem.Name = "profecionalesToolStripMenuItem";
            this.profecionalesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.profecionalesToolStripMenuItem.Text = "Profesionales";
            // 
            // nuevoProfecionalToolStripMenuItem
            // 
            this.nuevoProfecionalToolStripMenuItem.Name = "nuevoProfecionalToolStripMenuItem";
            this.nuevoProfecionalToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.nuevoProfecionalToolStripMenuItem.Text = "Nuevo Profesional";
            this.nuevoProfecionalToolStripMenuItem.Click += new System.EventHandler(this.nuevoProfecionalToolStripMenuItem_Click);
            // 
            // listadoDeProfecionalesToolStripMenuItem
            // 
            this.listadoDeProfecionalesToolStripMenuItem.Name = "listadoDeProfecionalesToolStripMenuItem";
            this.listadoDeProfecionalesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.listadoDeProfecionalesToolStripMenuItem.Text = "Listado Profesionales ADM";
            this.listadoDeProfecionalesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProfecionalesToolStripMenuItem_Click);
            // 
            // listadoDeProfesionalesToolStripMenuItem
            // 
            this.listadoDeProfesionalesToolStripMenuItem.Name = "listadoDeProfesionalesToolStripMenuItem";
            this.listadoDeProfesionalesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.listadoDeProfesionalesToolStripMenuItem.Text = "Listado de Profesionales";
            this.listadoDeProfesionalesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProfesionalesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.reportesToolStripMenuItem.Text = "Administracion";
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            this.reportesToolStripMenuItem1.Click += new System.EventHandler(this.reportesToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SalimJuanTPfinal.Properties.Resources.wallpaperbetter_com_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "frmPrincipal";
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agengaDeTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profecionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProfecionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProfecionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosPorProfesionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProfesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
    }
}



