namespace proyectoFinal
{
    partial class ConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUsuarios));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtFiltroUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.MenuSuperior = new System.Windows.Forms.Panel();
            this.Restaurarpic = new System.Windows.Forms.PictureBox();
            this.Minimizarpic = new System.Windows.Forms.PictureBox();
            this.Maximizarpic = new System.Windows.Forms.PictureBox();
            this.Cerrarpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menupic = new System.Windows.Forms.PictureBox();
            this.filtrado = new System.Windows.Forms.ComboBox();
            this.btnCambiarContrasenia = new System.Windows.Forms.Button();
            this.gridUsuario = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.MenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrarpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menupic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(545, 116);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 30);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Refrescar datos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtFiltroUsuario
            // 
            this.txtFiltroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroUsuario.Location = new System.Drawing.Point(277, 121);
            this.txtFiltroUsuario.Name = "txtFiltroUsuario";
            this.txtFiltroUsuario.Size = new System.Drawing.Size(236, 21);
            this.txtFiltroUsuario.TabIndex = 3;
            this.txtFiltroUsuario.TextChanged += new System.EventHandler(this.txtFiltroUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar por:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(689, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuSuperior
            // 
            this.MenuSuperior.BackColor = System.Drawing.SystemColors.MenuHighlight;
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
            this.MenuSuperior.Size = new System.Drawing.Size(793, 58);
            this.MenuSuperior.TabIndex = 9;
            // 
            // Restaurarpic
            // 
            this.Restaurarpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurarpic.Image = global::proyectoFinal.Properties.Resources.Restore_Window_2_48px;
            this.Restaurarpic.Location = new System.Drawing.Point(691, 10);
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
            this.Minimizarpic.Location = new System.Drawing.Point(691, 10);
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
            this.Maximizarpic.Location = new System.Drawing.Point(691, 10);
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
            this.Cerrarpic.Location = new System.Drawing.Point(737, 10);
            this.Cerrarpic.Name = "Cerrarpic";
            this.Cerrarpic.Size = new System.Drawing.Size(40, 38);
            this.Cerrarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrarpic.TabIndex = 2;
            this.Cerrarpic.TabStop = false;
            this.Cerrarpic.Click += new System.EventHandler(this.Cerrarpic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTA DE USUARIOS";
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
            // filtrado
            // 
            this.filtrado.FormattingEnabled = true;
            this.filtrado.Items.AddRange(new object[] {
            "Usuario",
            "Nombre del empleado",
            "Departamento",
            "Estado"});
            this.filtrado.Location = new System.Drawing.Point(98, 121);
            this.filtrado.Name = "filtrado";
            this.filtrado.Size = new System.Drawing.Size(173, 21);
            this.filtrado.TabIndex = 10;
            this.filtrado.SelectedIndexChanged += new System.EventHandler(this.filtrado_SelectedIndexChanged);
            // 
            // btnCambiarContrasenia
            // 
            this.btnCambiarContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContrasenia.Location = new System.Drawing.Point(21, 64);
            this.btnCambiarContrasenia.Name = "btnCambiarContrasenia";
            this.btnCambiarContrasenia.Size = new System.Drawing.Size(144, 26);
            this.btnCambiarContrasenia.TabIndex = 12;
            this.btnCambiarContrasenia.Text = "Cambiar contraseña";
            this.btnCambiarContrasenia.UseVisualStyleBackColor = true;
            this.btnCambiarContrasenia.Click += new System.EventHandler(this.btnCambiarContrasenia_Click);
            // 
            // gridUsuario
            // 
            this.gridUsuario.AllowUserToAddRows = false;
            this.gridUsuario.AllowUserToDeleteRows = false;
            this.gridUsuario.AllowUserToOrderColumns = true;
            this.gridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuario.Location = new System.Drawing.Point(21, 161);
            this.gridUsuario.Name = "gridUsuario";
            this.gridUsuario.ReadOnly = true;
            this.gridUsuario.Size = new System.Drawing.Size(651, 300);
            this.gridUsuario.TabIndex = 13;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::proyectoFinal.Properties.Resources.iconfinder_019_14043;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(689, 207);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 30);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 486);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gridUsuario);
            this.Controls.Add(this.btnCambiarContrasenia);
            this.Controls.Add(this.filtrado);
            this.Controls.Add(this.MenuSuperior);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroUsuario);
            this.Controls.Add(this.btnConsultar);
            this.Name = "ConsultaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaUsuarios";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.SizeChanged += new System.EventHandler(this.ConsultaUsuarios_SizeChanged);
            this.MenuSuperior.ResumeLayout(false);
            this.MenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrarpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menupic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtFiltroUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel MenuSuperior;
        private System.Windows.Forms.PictureBox Restaurarpic;
        private System.Windows.Forms.PictureBox Minimizarpic;
        private System.Windows.Forms.PictureBox Maximizarpic;
        private System.Windows.Forms.PictureBox Cerrarpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menupic;
        private System.Windows.Forms.ComboBox filtrado;
        private System.Windows.Forms.Button btnCambiarContrasenia;
        private System.Windows.Forms.DataGridView gridUsuario;
        private System.Windows.Forms.Button btnEditar;
    }
}