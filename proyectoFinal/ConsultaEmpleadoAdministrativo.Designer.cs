namespace proyectoFinal
{
    partial class ConsultaEmpleadoAdministrativo
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
            this.Restaurarpic = new System.Windows.Forms.PictureBox();
            this.Minimizarpic = new System.Windows.Forms.PictureBox();
            this.Maximizarpic = new System.Windows.Forms.PictureBox();
            this.Cerrarpic = new System.Windows.Forms.PictureBox();
            this.MenuSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menupic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpleadoWrapper = new System.Windows.Forms.Panel();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuTileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAignatura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrarpic)).BeginInit();
            this.MenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menupic)).BeginInit();
            this.panel1.SuspendLayout();
            this.EmpleadoWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Restaurarpic
            // 
            this.Restaurarpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurarpic.Image = global::proyectoFinal.Properties.Resources.Restore_Window_2_48px;
            this.Restaurarpic.Location = new System.Drawing.Point(698, 10);
            this.Restaurarpic.Name = "Restaurarpic";
            this.Restaurarpic.Size = new System.Drawing.Size(40, 38);
            this.Restaurarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurarpic.TabIndex = 5;
            this.Restaurarpic.TabStop = false;
            this.Restaurarpic.Visible = false;
            this.Restaurarpic.Click += new System.EventHandler(this.Restaurarpic_Click);
            // 
            // Minimizarpic
            // 
            this.Minimizarpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizarpic.Image = global::proyectoFinal.Properties.Resources.Minimize_Window_2_48px;
            this.Minimizarpic.Location = new System.Drawing.Point(698, 10);
            this.Minimizarpic.Name = "Minimizarpic";
            this.Minimizarpic.Size = new System.Drawing.Size(40, 38);
            this.Minimizarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizarpic.TabIndex = 4;
            this.Minimizarpic.TabStop = false;
            this.Minimizarpic.Click += new System.EventHandler(this.Minimizarpic_Click);
            // 
            // Maximizarpic
            // 
            this.Maximizarpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizarpic.Image = global::proyectoFinal.Properties.Resources.Maximize_Window_2_48px;
            this.Maximizarpic.Location = new System.Drawing.Point(698, 10);
            this.Maximizarpic.Name = "Maximizarpic";
            this.Maximizarpic.Size = new System.Drawing.Size(40, 38);
            this.Maximizarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizarpic.TabIndex = 3;
            this.Maximizarpic.TabStop = false;
            this.Maximizarpic.Click += new System.EventHandler(this.Maximizarpic_Click);
            // 
            // Cerrarpic
            // 
            this.Cerrarpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrarpic.Image = global::proyectoFinal.Properties.Resources.Close_Window__2_48px;
            this.Cerrarpic.Location = new System.Drawing.Point(744, 10);
            this.Cerrarpic.Name = "Cerrarpic";
            this.Cerrarpic.Size = new System.Drawing.Size(40, 38);
            this.Cerrarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrarpic.TabIndex = 2;
            this.Cerrarpic.TabStop = false;
            this.Cerrarpic.Click += new System.EventHandler(this.Cerrarpic_Click);
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.MenuSuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuSuperior.Controls.Add(this.Restaurarpic);
            this.MenuSuperior.Controls.Add(this.Minimizarpic);
            this.MenuSuperior.Controls.Add(this.Maximizarpic);
            this.MenuSuperior.Controls.Add(this.Cerrarpic);
            this.MenuSuperior.Controls.Add(this.label1);
            this.MenuSuperior.Controls.Add(this.menupic);
            this.MenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(800, 58);
            this.MenuSuperior.TabIndex = 2;
            this.MenuSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuSuperior_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regresar";
            // 
            // menupic
            // 
            this.menupic.Image = global::proyectoFinal.Properties.Resources.regresar;
            this.menupic.Location = new System.Drawing.Point(19, 10);
            this.menupic.Name = "menupic";
            this.menupic.Size = new System.Drawing.Size(40, 38);
            this.menupic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menupic.TabIndex = 0;
            this.menupic.TabStop = false;
            this.menupic.Click += new System.EventHandler(this.menupic_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 392);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 195);
            this.label3.TabIndex = 0;
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.label3_Paint);
            // 
            // EmpleadoWrapper
            // 
            this.EmpleadoWrapper.BackgroundImage = global::proyectoFinal.Properties.Resources.fon2;
            this.EmpleadoWrapper.Controls.Add(this.btnEliminar);
            this.EmpleadoWrapper.Controls.Add(this.bunifuTileButton2);
            this.EmpleadoWrapper.Controls.Add(this.btnAgregar);
            this.EmpleadoWrapper.Controls.Add(this.label2);
            this.EmpleadoWrapper.Controls.Add(this.cbAignatura);
            this.EmpleadoWrapper.Controls.Add(this.label5);
            this.EmpleadoWrapper.Controls.Add(this.txtNombre);
            this.EmpleadoWrapper.Controls.Add(this.Tabla);
            this.EmpleadoWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpleadoWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadoWrapper.Location = new System.Drawing.Point(61, 58);
            this.EmpleadoWrapper.Name = "EmpleadoWrapper";
            this.EmpleadoWrapper.Size = new System.Drawing.Size(739, 392);
            this.EmpleadoWrapper.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEliminar.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEliminar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImagePosition = 21;
            this.btnEliminar.ImageZoom = 50;
            this.btnEliminar.LabelPosition = 43;
            this.btnEliminar.LabelText = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(609, 193);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 50);
            this.btnEliminar.TabIndex = 14;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.AccessibleName = "btnModificar";
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton2.Image = null;
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 43;
            this.bunifuTileButton2.LabelText = "Modificar";
            this.bunifuTileButton2.Location = new System.Drawing.Point(609, 130);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(115, 51);
            this.bunifuTileButton2.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAgregar.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAgregar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = null;
            this.btnAgregar.ImagePosition = 21;
            this.btnAgregar.ImageZoom = 50;
            this.btnAgregar.LabelPosition = 43;
            this.btnAgregar.LabelText = "Agregar";
            this.btnAgregar.Location = new System.Drawing.Point(609, 67);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 51);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Departamento:";
            // 
            // cbAignatura
            // 
            this.cbAignatura.FormattingEnabled = true;
            this.cbAignatura.Location = new System.Drawing.Point(110, 31);
            this.cbAignatura.Margin = new System.Windows.Forms.Padding(2);
            this.cbAignatura.Name = "cbAignatura";
            this.cbAignatura.Size = new System.Drawing.Size(158, 21);
            this.cbAignatura.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre del Empleado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(434, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // Tabla
            // 
            this.Tabla.AllowUserToAddRows = false;
            this.Tabla.AllowUserToDeleteRows = false;
            this.Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(7, 67);
            this.Tabla.Margin = new System.Windows.Forms.Padding(2);
            this.Tabla.Name = "Tabla";
            this.Tabla.ReadOnly = true;
            this.Tabla.RowHeadersWidth = 62;
            this.Tabla.RowTemplate.Height = 28;
            this.Tabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tabla.Size = new System.Drawing.Size(583, 292);
            this.Tabla.TabIndex = 9;
            // 
            // ConsultaEmpleadoAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmpleadoWrapper);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaEmpleadoAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaEmpleadoAdministrativo";
            ((System.ComponentModel.ISupportInitialize)(this.Restaurarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrarpic)).EndInit();
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menupic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.EmpleadoWrapper.ResumeLayout(false);
            this.EmpleadoWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Restaurarpic;
        private System.Windows.Forms.PictureBox Minimizarpic;
        private System.Windows.Forms.PictureBox Maximizarpic;
        private System.Windows.Forms.PictureBox Cerrarpic;
        private System.Windows.Forms.Panel MenuSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menupic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel EmpleadoWrapper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAignatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView Tabla;
        private Bunifu.Framework.UI.BunifuTileButton btnAgregar;
        private Bunifu.Framework.UI.BunifuTileButton btnEliminar;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private System.Windows.Forms.Label label3;
    }
}