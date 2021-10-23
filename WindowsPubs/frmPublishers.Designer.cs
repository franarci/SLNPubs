namespace WindowsPubs
{
    partial class frmPublishers
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
            this.lblPublishers = new System.Windows.Forms.Label();
            this.gridPublishers = new System.Windows.Forms.DataGridView();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPublishers
            // 
            this.lblPublishers.AutoSize = true;
            this.lblPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishers.Location = new System.Drawing.Point(757, 38);
            this.lblPublishers.Name = "lblPublishers";
            this.lblPublishers.Size = new System.Drawing.Size(113, 25);
            this.lblPublishers.TabIndex = 22;
            this.lblPublishers.Text = "Publishers";
            // 
            // gridPublishers
            // 
            this.gridPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublishers.Location = new System.Drawing.Point(39, 99);
            this.gridPublishers.Name = "gridPublishers";
            this.gridPublishers.Size = new System.Drawing.Size(831, 341);
            this.gridPublishers.TabIndex = 21;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(350, 16);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 30;
            this.lblPais.Text = "Pais";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(214, 13);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(120, 20);
            this.txtPais.TabIndex = 29;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(29, 50);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 28;
            this.lblEstado.Text = "Estado";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(26, 18);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 27;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(88, 12);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(120, 20);
            this.txtCiudad.TabIndex = 26;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(88, 44);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(120, 20);
            this.txtEstado.TabIndex = 25;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(234, 70);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(112, 23);
            this.btnMostrarTodos.TabIndex = 24;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(88, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 23);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(385, 72);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cbCiudad.TabIndex = 31;
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblPublishers);
            this.Controls.Add(this.gridPublishers);
            this.Name = "frmPublishers";
            this.Text = "frmPublishers";
            this.Load += new System.EventHandler(this.frmPublishers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPublishers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPublishers;
        private System.Windows.Forms.DataGridView gridPublishers;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbCiudad;
    }
}