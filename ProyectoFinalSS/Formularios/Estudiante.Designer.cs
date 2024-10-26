namespace ProyectoFinalSS.Formularios
{
    partial class Estudiante
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCursosDisp = new System.Windows.Forms.TabPage();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.gridCursosDisp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAsignados = new System.Windows.Forms.TabPage();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.gridAsignados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCursosDisp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCursosDisp)).BeginInit();
            this.tabAsignados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCursosDisp);
            this.tabControl1.Controls.Add(this.tabAsignados);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 555);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCursosDisp
            // 
            this.tabCursosDisp.Controls.Add(this.btnAsignar);
            this.tabCursosDisp.Controls.Add(this.gridCursosDisp);
            this.tabCursosDisp.Controls.Add(this.button1);
            this.tabCursosDisp.Controls.Add(this.label1);
            this.tabCursosDisp.Location = new System.Drawing.Point(4, 22);
            this.tabCursosDisp.Name = "tabCursosDisp";
            this.tabCursosDisp.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCursosDisp.Size = new System.Drawing.Size(891, 529);
            this.tabCursosDisp.TabIndex = 0;
            this.tabCursosDisp.Text = "Cursos Disponibles";
            this.tabCursosDisp.UseVisualStyleBackColor = true;
            this.tabCursosDisp.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(753, 81);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(83, 22);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // gridCursosDisp
            // 
            this.gridCursosDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCursosDisp.Location = new System.Drawing.Point(29, 125);
            this.gridCursosDisp.Name = "gridCursosDisp";
            this.gridCursosDisp.RowHeadersWidth = 51;
            this.gridCursosDisp.Size = new System.Drawing.Size(807, 363);
            this.gridCursosDisp.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos Disponibles";
            // 
            // tabAsignados
            // 
            this.tabAsignados.Controls.Add(this.button2);
            this.tabAsignados.Controls.Add(this.btnRefrescar);
            this.tabAsignados.Controls.Add(this.gridAsignados);
            this.tabAsignados.Controls.Add(this.label2);
            this.tabAsignados.Location = new System.Drawing.Point(4, 22);
            this.tabAsignados.Name = "tabAsignados";
            this.tabAsignados.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAsignados.Size = new System.Drawing.Size(891, 529);
            this.tabAsignados.TabIndex = 1;
            this.tabAsignados.Text = "Cursos Asignados";
            this.tabAsignados.UseVisualStyleBackColor = true;
            this.tabAsignados.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(14, 56);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(76, 25);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // gridAsignados
            // 
            this.gridAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsignados.Location = new System.Drawing.Point(5, 93);
            this.gridAsignados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridAsignados.Name = "gridAsignados";
            this.gridAsignados.RowHeadersWidth = 51;
            this.gridAsignados.RowTemplate.Height = 24;
            this.gridAsignados.Size = new System.Drawing.Size(880, 410);
            this.gridAsignados.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cursos Asignados";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(807, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Completar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "Estudiante";
            this.Text = "Estudiante";
            this.tabControl1.ResumeLayout(false);
            this.tabCursosDisp.ResumeLayout(false);
            this.tabCursosDisp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCursosDisp)).EndInit();
            this.tabAsignados.ResumeLayout(false);
            this.tabAsignados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCursosDisp;
        private System.Windows.Forms.TabPage tabAsignados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridCursosDisp;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView gridAsignados;
        private System.Windows.Forms.Button button2;
    }
}