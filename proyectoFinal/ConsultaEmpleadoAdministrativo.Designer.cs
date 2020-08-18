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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
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
            this.MenuSuperior.BackColor = System.Drawing.SystemColors.Highlight;
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
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.EmpleadoWrapper.Controls.Add(this.btnModificar);
            this.EmpleadoWrapper.Controls.Add(this.btnNuevo);
            this.EmpleadoWrapper.Controls.Add(this.label2);
            this.EmpleadoWrapper.Controls.Add(this.cbDepartamento);
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
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::proyectoFinal.Properties.Resources.iconfinder_019_14043;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(627, 138);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 25);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "   Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::proyectoFinal.Properties.Resources.iconfinder_103_14127;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(627, 90);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "   Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(110, 31);
            this.cbDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(158, 21);
            this.cbDepartamento.TabIndex = 8;
            this.cbDepartamento.TextChanged += new System.EventHandler(this.cbDepartamento_TextChanged);
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
            this.label5.Text = "NombreForm del Empleado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(434, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 20);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabla.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabla.RowTemplate.Height = 28;
            this.Tabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tabla.Size = new System.Drawing.Size(615, 292);
            this.Tabla.TabIndex = 9;
            this.Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellClick);
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
            this.Load += new System.EventHandler(this.ConsultaEmpleadoAdministrativo_Load);
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
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
    }
}