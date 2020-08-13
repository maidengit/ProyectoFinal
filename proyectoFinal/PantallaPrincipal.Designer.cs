namespace proyectoFinal
{
    partial class Menú
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menú));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moduloEducativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeAsignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduloEducativoToolStripMenuItem,
            this.administraciónDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(191, 388);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moduloEducativoToolStripMenuItem
            // 
            this.moduloEducativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.asignaturasToolStripMenuItem});
            this.moduloEducativoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moduloEducativoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moduloEducativoToolStripMenuItem.Image")));
            this.moduloEducativoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moduloEducativoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.moduloEducativoToolStripMenuItem.Name = "moduloEducativoToolStripMenuItem";
            this.moduloEducativoToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
            this.moduloEducativoToolStripMenuItem.Text = "Modulo Educativo";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeEstudiantesToolStripMenuItem,
            this.calificacionesToolStripMenuItem1});
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // listadoDeEstudiantesToolStripMenuItem
            // 
            this.listadoDeEstudiantesToolStripMenuItem.Name = "listadoDeEstudiantesToolStripMenuItem";
            this.listadoDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.listadoDeEstudiantesToolStripMenuItem.Text = "Listado de Estudiantes";
            this.listadoDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEstudiantesToolStripMenuItem_Click);
            // 
            // calificacionesToolStripMenuItem1
            // 
            this.calificacionesToolStripMenuItem1.Name = "calificacionesToolStripMenuItem1";
            this.calificacionesToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.calificacionesToolStripMenuItem1.Text = "Calificaciones";
            this.calificacionesToolStripMenuItem1.Click += new System.EventHandler(this.calificacionesToolStripMenuItem1_Click);
            // 
            // asignaturasToolStripMenuItem
            // 
            this.asignaturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeAsignaturasToolStripMenuItem});
            this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asignaturasToolStripMenuItem.Text = "Asignaturas";
            // 
            // consultaDeAsignaturasToolStripMenuItem
            // 
            this.consultaDeAsignaturasToolStripMenuItem.Name = "consultaDeAsignaturasToolStripMenuItem";
            this.consultaDeAsignaturasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.consultaDeAsignaturasToolStripMenuItem.Text = "Consulta de Asignaturas";
            this.consultaDeAsignaturasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeAsignaturasToolStripMenuItem_Click);
            // 
            // administraciónDeToolStripMenuItem
            // 
            this.administraciónDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUsuariosToolStripMenuItem});
            this.administraciónDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administraciónDeToolStripMenuItem.Image")));
            this.administraciónDeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.administraciónDeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.administraciónDeToolStripMenuItem.Name = "administraciónDeToolStripMenuItem";
            this.administraciónDeToolStripMenuItem.Size = new System.Drawing.Size(182, 28);
            this.administraciónDeToolStripMenuItem.Text = "Administración de usuarios";
            // 
            // consultaDeUsuariosToolStripMenuItem
            // 
            this.consultaDeUsuariosToolStripMenuItem.Name = "consultaDeUsuariosToolStripMenuItem";
            this.consultaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaDeUsuariosToolStripMenuItem.Text = "Usuarios";
            this.consultaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUsuariosToolStripMenuItem_Click);
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 388);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menú";
            this.Text = "Pantalla Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moduloEducativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeAsignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuariosToolStripMenuItem;
    }
}