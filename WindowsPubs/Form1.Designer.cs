namespace WindowsPubs
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
            this.gridAuthors = new System.Windows.Forms.DataGridView();
            this.gridPublishers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPublishers = new System.Windows.Forms.Label();
            this.btnBuscarA = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoP = new System.Windows.Forms.Label();
            this.lblCiudadP = new System.Windows.Forms.Label();
            this.txtCiudadP = new System.Windows.Forms.TextBox();
            this.txtEstadoP = new System.Windows.Forms.TextBox();
            this.btnMostrarP = new System.Windows.Forms.Button();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.lblPaisP = new System.Windows.Forms.Label();
            this.txtPaisP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAuthors
            // 
            this.gridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthors.Location = new System.Drawing.Point(-4, 112);
            this.gridAuthors.Name = "gridAuthors";
            this.gridAuthors.Size = new System.Drawing.Size(816, 341);
            this.gridAuthors.TabIndex = 0;
            // 
            // gridPublishers
            // 
            this.gridPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublishers.Location = new System.Drawing.Point(818, 112);
            this.gridPublishers.Name = "gridPublishers";
            this.gridPublishers.Size = new System.Drawing.Size(831, 341);
            this.gridPublishers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Authors";
            // 
            // lblPublishers
            // 
            this.lblPublishers.AutoSize = true;
            this.lblPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishers.Location = new System.Drawing.Point(1380, 81);
            this.lblPublishers.Name = "lblPublishers";
            this.lblPublishers.Size = new System.Drawing.Size(113, 25);
            this.lblPublishers.TabIndex = 3;
            this.lblPublishers.Text = "Publishers";
            // 
            // btnBuscarA
            // 
            this.btnBuscarA.Location = new System.Drawing.Point(85, 83);
            this.btnBuscarA.Name = "btnBuscarA";
            this.btnBuscarA.Size = new System.Drawing.Size(120, 23);
            this.btnBuscarA.TabIndex = 4;
            this.btnBuscarA.Text = "Buscar";
            this.btnBuscarA.UseVisualStyleBackColor = true;
            this.btnBuscarA.Click += new System.EventHandler(this.btnBuscarA_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(231, 83);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarTodos.TabIndex = 6;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(85, 57);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(120, 20);
            this.txtEstado.TabIndex = 7;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(85, 25);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(120, 20);
            this.txtCiudad.TabIndex = 8;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(23, 31);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 9;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 63);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // lblEstadoP
            // 
            this.lblEstadoP.AutoSize = true;
            this.lblEstadoP.Location = new System.Drawing.Point(822, 62);
            this.lblEstadoP.Name = "lblEstadoP";
            this.lblEstadoP.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoP.TabIndex = 16;
            this.lblEstadoP.Text = "Estado";
            // 
            // lblCiudadP
            // 
            this.lblCiudadP.AutoSize = true;
            this.lblCiudadP.Location = new System.Drawing.Point(819, 30);
            this.lblCiudadP.Name = "lblCiudadP";
            this.lblCiudadP.Size = new System.Drawing.Size(40, 13);
            this.lblCiudadP.TabIndex = 15;
            this.lblCiudadP.Text = "Ciudad";
            // 
            // txtCiudadP
            // 
            this.txtCiudadP.Location = new System.Drawing.Point(881, 24);
            this.txtCiudadP.Name = "txtCiudadP";
            this.txtCiudadP.Size = new System.Drawing.Size(120, 20);
            this.txtCiudadP.TabIndex = 14;
            // 
            // txtEstadoP
            // 
            this.txtEstadoP.Location = new System.Drawing.Point(881, 56);
            this.txtEstadoP.Name = "txtEstadoP";
            this.txtEstadoP.Size = new System.Drawing.Size(120, 20);
            this.txtEstadoP.TabIndex = 13;
            // 
            // btnMostrarP
            // 
            this.btnMostrarP.Location = new System.Drawing.Point(1027, 82);
            this.btnMostrarP.Name = "btnMostrarP";
            this.btnMostrarP.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarP.TabIndex = 12;
            this.btnMostrarP.Text = "Mostrar Todos";
            this.btnMostrarP.UseVisualStyleBackColor = true;
            this.btnMostrarP.Click += new System.EventHandler(this.btnMostrarP_Click);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(881, 82);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(120, 23);
            this.btnBuscarP.TabIndex = 11;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // lblPaisP
            // 
            this.lblPaisP.AutoSize = true;
            this.lblPaisP.Location = new System.Drawing.Point(1143, 28);
            this.lblPaisP.Name = "lblPaisP";
            this.lblPaisP.Size = new System.Drawing.Size(27, 13);
            this.lblPaisP.TabIndex = 18;
            this.lblPaisP.Text = "Pais";
            // 
            // txtPaisP
            // 
            this.txtPaisP.Location = new System.Drawing.Point(1007, 25);
            this.txtPaisP.Name = "txtPaisP";
            this.txtPaisP.Size = new System.Drawing.Size(120, 20);
            this.txtPaisP.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 450);
            this.Controls.Add(this.lblPaisP);
            this.Controls.Add(this.txtPaisP);
            this.Controls.Add(this.lblEstadoP);
            this.Controls.Add(this.lblCiudadP);
            this.Controls.Add(this.txtCiudadP);
            this.Controls.Add(this.txtEstadoP);
            this.Controls.Add(this.btnMostrarP);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnBuscarA);
            this.Controls.Add(this.lblPublishers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPublishers);
            this.Controls.Add(this.gridAuthors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublishers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAuthors;
        private System.Windows.Forms.DataGridView gridPublishers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPublishers;
        private System.Windows.Forms.Button btnBuscarA;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoP;
        private System.Windows.Forms.Label lblCiudadP;
        private System.Windows.Forms.TextBox txtCiudadP;
        private System.Windows.Forms.TextBox txtEstadoP;
        private System.Windows.Forms.Button btnMostrarP;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Label lblPaisP;
        private System.Windows.Forms.TextBox txtPaisP;
    }
}

