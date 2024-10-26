namespace ProyectoFinalSS.Formularios
{
    partial class Catedratico
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
            this.controlCursos = new System.Windows.Forms.TabControl();
            this.tabCursos = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gridCursos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiploma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSeguimiento = new System.Windows.Forms.TabPage();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.gridSeguimiento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.controlCursos.SuspendLayout();
            this.tabCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCursos)).BeginInit();
            this.tabSeguimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeguimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // controlCursos
            // 
            this.controlCursos.AccessibleDescription = "Cursos";
            this.controlCursos.Controls.Add(this.tabCursos);
            this.controlCursos.Controls.Add(this.tabSeguimiento);
            this.controlCursos.Location = new System.Drawing.Point(4, 2);
            this.controlCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlCursos.Name = "controlCursos";
            this.controlCursos.SelectedIndex = 0;
            this.controlCursos.Size = new System.Drawing.Size(847, 553);
            this.controlCursos.TabIndex = 0;
            // 
            // tabCursos
            // 
            this.tabCursos.Controls.Add(this.btnLimpiar);
            this.tabCursos.Controls.Add(this.btnGuardar);
            this.tabCursos.Controls.Add(this.gridCursos);
            this.tabCursos.Controls.Add(this.label5);
            this.tabCursos.Controls.Add(this.txtNombre);
            this.tabCursos.Controls.Add(this.label4);
            this.tabCursos.Controls.Add(this.txtDescripcion);
            this.tabCursos.Controls.Add(this.label3);
            this.tabCursos.Controls.Add(this.txtDiploma);
            this.tabCursos.Controls.Add(this.label2);
            this.tabCursos.Location = new System.Drawing.Point(4, 25);
            this.tabCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCursos.Name = "tabCursos";
            this.tabCursos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCursos.Size = new System.Drawing.Size(839, 524);
            this.tabCursos.TabIndex = 0;
            this.tabCursos.Text = "Cursos";
            this.tabCursos.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(389, 466);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 34);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(279, 466);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 34);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gridCursos
            // 
            this.gridCursos.AllowUserToDeleteRows = false;
            this.gridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCursos.Location = new System.Drawing.Point(7, 255);
            this.gridCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCursos.Name = "gridCursos";
            this.gridCursos.ReadOnly = true;
            this.gridCursos.RowHeadersWidth = 51;
            this.gridCursos.RowTemplate.Height = 24;
            this.gridCursos.Size = new System.Drawing.Size(825, 194);
            this.gridCursos.TabIndex = 9;
            this.gridCursos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCursos_CellEnter_1);
            this.gridCursos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridCursos_DataBindingComplete);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(325, 96);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(325, 146);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(271, 22);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diploma";
            // 
            // txtDiploma
            // 
            this.txtDiploma.Location = new System.Drawing.Point(325, 199);
            this.txtDiploma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiploma.Name = "txtDiploma";
            this.txtDiploma.Size = new System.Drawing.Size(271, 22);
            this.txtDiploma.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crear curso";
            // 
            // tabSeguimiento
            // 
            this.tabSeguimiento.Controls.Add(this.btnOrdenar);
            this.tabSeguimiento.Controls.Add(this.btnRefrescar);
            this.tabSeguimiento.Controls.Add(this.gridSeguimiento);
            this.tabSeguimiento.Controls.Add(this.label1);
            this.tabSeguimiento.Location = new System.Drawing.Point(4, 25);
            this.tabSeguimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSeguimiento.Name = "tabSeguimiento";
            this.tabSeguimiento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSeguimiento.Size = new System.Drawing.Size(839, 524);
            this.tabSeguimiento.TabIndex = 1;
            this.tabSeguimiento.Text = "Seguimiento";
            this.tabSeguimiento.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(604, 68);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(207, 28);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar por porcentaje ASC";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(21, 64);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(101, 32);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // gridSeguimiento
            // 
            this.gridSeguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeguimiento.Location = new System.Drawing.Point(21, 113);
            this.gridSeguimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSeguimiento.Name = "gridSeguimiento";
            this.gridSeguimiento.RowHeadersWidth = 51;
            this.gridSeguimiento.RowTemplate.Height = 24;
            this.gridSeguimiento.Size = new System.Drawing.Size(789, 382);
            this.gridSeguimiento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrar cursos";
            // 
            // Catedratico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 554);
            this.Controls.Add(this.controlCursos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Catedratico";
            this.Text = "Catedratico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Catedratico_FormClosed);
            this.controlCursos.ResumeLayout(false);
            this.tabCursos.ResumeLayout(false);
            this.tabCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCursos)).EndInit();
            this.tabSeguimiento.ResumeLayout(false);
            this.tabSeguimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeguimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl controlCursos;
        private System.Windows.Forms.TabPage tabCursos;
        private System.Windows.Forms.TabPage tabSeguimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiploma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView gridCursos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView gridSeguimiento;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnOrdenar;
    }
}