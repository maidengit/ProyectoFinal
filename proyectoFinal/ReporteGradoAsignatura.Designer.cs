namespace proyectoFinal
{
    partial class ReporteGradoAsignatura
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
            this.btngenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbalumno = new System.Windows.Forms.ComboBox();
            this.cbgrado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbsemestre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.Image = global::proyectoFinal.Properties.Resources.Educacio1;
            this.btngenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngenerar.Location = new System.Drawing.Point(225, 259);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(92, 23);
            this.btngenerar.TabIndex = 36;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Asignatura:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Grado:";
            // 
            // cbalumno
            // 
            this.cbalumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbalumno.ForeColor = System.Drawing.Color.Black;
            this.cbalumno.FormattingEnabled = true;
            this.cbalumno.Location = new System.Drawing.Point(45, 148);
            this.cbalumno.Margin = new System.Windows.Forms.Padding(2);
            this.cbalumno.Name = "cbalumno";
            this.cbalumno.Size = new System.Drawing.Size(253, 23);
            this.cbalumno.TabIndex = 32;
            this.cbalumno.Text = "Seleccione una asignatura";
            // 
            // cbgrado
            // 
            this.cbgrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgrado.ForeColor = System.Drawing.Color.Black;
            this.cbgrado.FormattingEnabled = true;
            this.cbgrado.Location = new System.Drawing.Point(45, 87);
            this.cbgrado.Margin = new System.Windows.Forms.Padding(2);
            this.cbgrado.Name = "cbgrado";
            this.cbgrado.Size = new System.Drawing.Size(253, 23);
            this.cbgrado.TabIndex = 31;
            this.cbgrado.Text = "Seleccione un grado";
            this.cbgrado.SelectedIndexChanged += new System.EventHandler(this.cbgrado_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::proyectoFinal.Properties.Resources.Cancelar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(132, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Semestre:";
            // 
            // cbsemestre
            // 
            this.cbsemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsemestre.ForeColor = System.Drawing.Color.Black;
            this.cbsemestre.FormattingEnabled = true;
            this.cbsemestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbsemestre.Location = new System.Drawing.Point(45, 208);
            this.cbsemestre.Margin = new System.Windows.Forms.Padding(2);
            this.cbsemestre.Name = "cbsemestre";
            this.cbsemestre.Size = new System.Drawing.Size(253, 23);
            this.cbsemestre.TabIndex = 37;
            this.cbsemestre.Text = "Seleccione un semestre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-68, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 59);
            this.panel1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(79, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "REPORTE CALIFICACIONES POR MATERIA";
            // 
            // ReporteGradoAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbsemestre);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbalumno);
            this.Controls.Add(this.cbgrado);
            this.Controls.Add(this.button1);
            this.Name = "ReporteGradoAsignatura";
            this.Text = "ReporteCalificacionesPorMateria";
            this.Load += new System.EventHandler(this.ReporteGradoAsignatura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbalumno;
        private System.Windows.Forms.ComboBox cbgrado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbsemestre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}