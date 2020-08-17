namespace proyectoFinal
{
    partial class RegistroUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmarContrasenia = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.errorProviderUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContrasenia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmarContrasenia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmpleadoID = new System.Windows.Forms.ErrorProvider(this.components);
            this.MenuSuperior = new System.Windows.Forms.Panel();
            this.Restaurarpic = new System.Windows.Forms.PictureBox();
            this.Minimizarpic = new System.Windows.Forms.PictureBox();
            this.Maximizarpic = new System.Windows.Forms.PictureBox();
            this.Cerrarpic = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menupic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmarContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpleadoID)).BeginInit();
            this.MenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menupic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(347, 105);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(172, 21);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.Validated += new System.EventHandler(this.txtNombreUsuario_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(347, 162);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(172, 21);
            this.txtContrasenia.TabIndex = 3;
            this.txtContrasenia.Validated += new System.EventHandler(this.txtContrasenia_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // txtConfirmarContrasenia
            // 
            this.txtConfirmarContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasenia.Location = new System.Drawing.Point(347, 222);
            this.txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            this.txtConfirmarContrasenia.Size = new System.Drawing.Size(172, 21);
            this.txtConfirmarContrasenia.TabIndex = 4;
            this.txtConfirmarContrasenia.Validated += new System.EventHandler(this.txtConfirmarContrasenia_Validated);
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(153, 105);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(172, 21);
            this.txtIdentidad.TabIndex = 1;
            this.txtIdentidad.Validated += new System.EventHandler(this.txtIdentidad_Validated);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::proyectoFinal.Properties.Resources.guardar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(429, 264);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 31);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::proyectoFinal.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(337, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Identidad Empleado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre del empleado:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(153, 162);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(172, 21);
            this.txtNombreEmpleado.TabIndex = 11;
            // 
            // errorProviderUsuario
            // 
            this.errorProviderUsuario.ContainerControl = this;
            // 
            // errorProviderContrasenia
            // 
            this.errorProviderContrasenia.ContainerControl = this;
            // 
            // errorProviderConfirmarContrasenia
            // 
            this.errorProviderConfirmarContrasenia.ContainerControl = this;
            // 
            // errorProviderEmpleadoID
            // 
            this.errorProviderEmpleadoID.ContainerControl = this;
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MenuSuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuSuperior.Controls.Add(this.Restaurarpic);
            this.MenuSuperior.Controls.Add(this.Minimizarpic);
            this.MenuSuperior.Controls.Add(this.Maximizarpic);
            this.MenuSuperior.Controls.Add(this.Cerrarpic);
            this.MenuSuperior.Controls.Add(this.label7);
            this.MenuSuperior.Controls.Add(this.menupic);
            this.MenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.MenuSuperior.Name = "MenuSuperior";
            this.MenuSuperior.Size = new System.Drawing.Size(686, 58);
            this.MenuSuperior.TabIndex = 13;
            // 
            // Restaurarpic
            // 
            this.Restaurarpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurarpic.Image = global::proyectoFinal.Properties.Resources.Restore_Window_2_48px;
            this.Restaurarpic.Location = new System.Drawing.Point(584, 10);
            this.Restaurarpic.Name = "Restaurarpic";
            this.Restaurarpic.Size = new System.Drawing.Size(40, 38);
            this.Restaurarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurarpic.TabIndex = 5;
            this.Restaurarpic.TabStop = false;
            this.Restaurarpic.Visible = false;
            // 
            // Minimizarpic
            // 
            this.Minimizarpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizarpic.Image = global::proyectoFinal.Properties.Resources.Minimize_Window_2_48px;
            this.Minimizarpic.Location = new System.Drawing.Point(584, 10);
            this.Minimizarpic.Name = "Minimizarpic";
            this.Minimizarpic.Size = new System.Drawing.Size(40, 38);
            this.Minimizarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizarpic.TabIndex = 4;
            this.Minimizarpic.TabStop = false;
            // 
            // Maximizarpic
            // 
            this.Maximizarpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizarpic.Image = global::proyectoFinal.Properties.Resources.Maximize_Window_2_48px;
            this.Maximizarpic.Location = new System.Drawing.Point(584, 10);
            this.Maximizarpic.Name = "Maximizarpic";
            this.Maximizarpic.Size = new System.Drawing.Size(40, 38);
            this.Maximizarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizarpic.TabIndex = 3;
            this.Maximizarpic.TabStop = false;
            // 
            // Cerrarpic
            // 
            this.Cerrarpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrarpic.Image = global::proyectoFinal.Properties.Resources.Close_Window__2_48px;
            this.Cerrarpic.Location = new System.Drawing.Point(630, 10);
            this.Cerrarpic.Name = "Cerrarpic";
            this.Cerrarpic.Size = new System.Drawing.Size(40, 38);
            this.Cerrarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrarpic.TabIndex = 2;
            this.Cerrarpic.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(75, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "REGISTRO DE USUARIOS";
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(153, 222);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(172, 21);
            this.txtDepartamento.TabIndex = 14;
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.MenuSuperior);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmarContrasenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreUsuario);
            this.Name = "RegistroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroUsuarios";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmarContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpleadoID)).EndInit();
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menupic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarContrasenia;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.ErrorProvider errorProviderUsuario;
        private System.Windows.Forms.ErrorProvider errorProviderContrasenia;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmarContrasenia;
        private System.Windows.Forms.ErrorProvider errorProviderEmpleadoID;
        private System.Windows.Forms.Panel MenuSuperior;
        private System.Windows.Forms.PictureBox Restaurarpic;
        private System.Windows.Forms.PictureBox Minimizarpic;
        private System.Windows.Forms.PictureBox Maximizarpic;
        private System.Windows.Forms.PictureBox Cerrarpic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox menupic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartamento;
    }
}