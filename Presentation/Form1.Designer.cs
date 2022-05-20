
namespace Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bntActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiantes)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvEstudiantes
            // 
            this.dtgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEstudiantes.Location = new System.Drawing.Point(37, 232);
            this.dtgvEstudiantes.Name = "dtgvEstudiantes";
            this.dtgvEstudiantes.RowTemplate.Height = 25;
            this.dtgvEstudiantes.Size = new System.Drawing.Size(680, 206);
            this.dtgvEstudiantes.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(246, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 51);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(276, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(158, 23);
            this.txtId.TabIndex = 4;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(235, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(17, 15);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Id";
            // 
            // bntAgregar
            // 
            this.bntAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntAgregar.Location = new System.Drawing.Point(3, 3);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(75, 51);
            this.bntAgregar.TabIndex = 7;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = false;
            this.bntAgregar.Click += new System.EventHandler(this.bntAgregar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(165, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 51);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular Promedio";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bntAgregar);
            this.flowLayoutPanel1.Controls.Add(this.bntActualizar);
            this.flowLayoutPanel1.Controls.Add(this.btnCalcular);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(188, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 74);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // bntActualizar
            // 
            this.bntActualizar.BackColor = System.Drawing.Color.Aqua;
            this.bntActualizar.Location = new System.Drawing.Point(84, 3);
            this.bntActualizar.Name = "bntActualizar";
            this.bntActualizar.Size = new System.Drawing.Size(75, 51);
            this.bntActualizar.TabIndex = 9;
            this.bntActualizar.Text = "Actualizar";
            this.bntActualizar.UseVisualStyleBackColor = false;
            this.bntActualizar.Click += new System.EventHandler(this.bntActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtgvEstudiantes);
            this.Name = "Form1";
            this.Text = "Servicio a Estudiante";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiantes)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEstudiantes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bntActualizar;
    }
}

