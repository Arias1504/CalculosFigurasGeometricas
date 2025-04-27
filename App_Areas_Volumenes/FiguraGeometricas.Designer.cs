namespace App_Areas_Volumenes
{
    partial class FiguraGeometricas
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
            this.label1 = new System.Windows.Forms.Label();
            this.imgFigura = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupEsfera = new System.Windows.Forms.GroupBox();
            this.txtRadioEsfera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupCilindro = new System.Windows.Forms.GroupBox();
            this.txtRadioCilindro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlturaCilindro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupParale = new System.Windows.Forms.GroupBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.groupResultado = new System.Windows.Forms.GroupBox();
            this.lblRtaVolumen = new System.Windows.Forms.Label();
            this.lblRtaArea = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbFiguras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFigura)).BeginInit();
            this.groupEsfera.SuspendLayout();
            this.groupCilindro.SuspendLayout();
            this.groupParale.SuspendLayout();
            this.groupResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁLCULOS FIGURAS GEOMÉTRICAS 3D";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgFigura
            // 
            this.imgFigura.Location = new System.Drawing.Point(165, 66);
            this.imgFigura.Name = "imgFigura";
            this.imgFigura.Size = new System.Drawing.Size(136, 127);
            this.imgFigura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFigura.TabIndex = 1;
            this.imgFigura.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(192, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupEsfera
            // 
            this.groupEsfera.Controls.Add(this.txtRadioEsfera);
            this.groupEsfera.Controls.Add(this.label2);
            this.groupEsfera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEsfera.Location = new System.Drawing.Point(132, 230);
            this.groupEsfera.Name = "groupEsfera";
            this.groupEsfera.Size = new System.Drawing.Size(448, 75);
            this.groupEsfera.TabIndex = 11;
            this.groupEsfera.TabStop = false;
            this.groupEsfera.Visible = false;
            // 
            // txtRadioEsfera
            // 
            this.txtRadioEsfera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadioEsfera.Location = new System.Drawing.Point(158, 25);
            this.txtRadioEsfera.Name = "txtRadioEsfera";
            this.txtRadioEsfera.Size = new System.Drawing.Size(190, 24);
            this.txtRadioEsfera.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radio:";
            // 
            // groupCilindro
            // 
            this.groupCilindro.Controls.Add(this.txtRadioCilindro);
            this.groupCilindro.Controls.Add(this.label4);
            this.groupCilindro.Controls.Add(this.txtAlturaCilindro);
            this.groupCilindro.Controls.Add(this.label3);
            this.groupCilindro.Location = new System.Drawing.Point(130, 329);
            this.groupCilindro.Name = "groupCilindro";
            this.groupCilindro.Size = new System.Drawing.Size(448, 84);
            this.groupCilindro.TabIndex = 12;
            this.groupCilindro.TabStop = false;
            this.groupCilindro.Visible = false;
            // 
            // txtRadioCilindro
            // 
            this.txtRadioCilindro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadioCilindro.Location = new System.Drawing.Point(160, 17);
            this.txtRadioCilindro.Name = "txtRadioCilindro";
            this.txtRadioCilindro.Size = new System.Drawing.Size(190, 24);
            this.txtRadioCilindro.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Radio:";
            // 
            // txtAlturaCilindro
            // 
            this.txtAlturaCilindro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlturaCilindro.Location = new System.Drawing.Point(160, 53);
            this.txtAlturaCilindro.Name = "txtAlturaCilindro";
            this.txtAlturaCilindro.Size = new System.Drawing.Size(190, 24);
            this.txtAlturaCilindro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Altura:";
            // 
            // groupParale
            // 
            this.groupParale.Controls.Add(this.txtLadoC);
            this.groupParale.Controls.Add(this.label7);
            this.groupParale.Controls.Add(this.txtLadoA);
            this.groupParale.Controls.Add(this.label5);
            this.groupParale.Controls.Add(this.txtLadoB);
            this.groupParale.Controls.Add(this.label6);
            this.groupParale.Location = new System.Drawing.Point(131, 430);
            this.groupParale.Name = "groupParale";
            this.groupParale.Size = new System.Drawing.Size(447, 125);
            this.groupParale.TabIndex = 13;
            this.groupParale.TabStop = false;
            this.groupParale.Visible = false;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoC.Location = new System.Drawing.Point(159, 92);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(190, 24);
            this.txtLadoC.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lado C:";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoA.Location = new System.Drawing.Point(159, 20);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(190, 24);
            this.txtLadoA.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lado A:";
            // 
            // txtLadoB
            // 
            this.txtLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoB.Location = new System.Drawing.Point(159, 56);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(190, 24);
            this.txtLadoB.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lado B:";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 209);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(670, 18);
            this.lblMensaje.TabIndex = 14;
            this.lblMensaje.Text = "label10";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupResultado
            // 
            this.groupResultado.Controls.Add(this.lblRtaVolumen);
            this.groupResultado.Controls.Add(this.lblRtaArea);
            this.groupResultado.Controls.Add(this.label9);
            this.groupResultado.Controls.Add(this.label8);
            this.groupResultado.Location = new System.Drawing.Point(131, 614);
            this.groupResultado.Name = "groupResultado";
            this.groupResultado.Size = new System.Drawing.Size(448, 87);
            this.groupResultado.TabIndex = 15;
            this.groupResultado.TabStop = false;
            this.groupResultado.Visible = false;
            // 
            // lblRtaVolumen
            // 
            this.lblRtaVolumen.AutoSize = true;
            this.lblRtaVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtaVolumen.Location = new System.Drawing.Point(286, 50);
            this.lblRtaVolumen.Name = "lblRtaVolumen";
            this.lblRtaVolumen.Size = new System.Drawing.Size(54, 18);
            this.lblRtaVolumen.TabIndex = 15;
            this.lblRtaVolumen.Text = "label11";
            // 
            // lblRtaArea
            // 
            this.lblRtaArea.AutoSize = true;
            this.lblRtaArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtaArea.Location = new System.Drawing.Point(286, 16);
            this.lblRtaArea.Name = "lblRtaArea";
            this.lblRtaArea.Size = new System.Drawing.Size(54, 18);
            this.lblRtaArea.TabIndex = 14;
            this.lblRtaArea.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Volumen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Área:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(389, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbFiguras
            // 
            this.cbFiguras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiguras.FormattingEnabled = true;
            this.cbFiguras.Items.AddRange(new object[] {
            "Esfera",
            "Cilindro",
            "Paralelepípedo"});
            this.cbFiguras.Location = new System.Drawing.Point(335, 111);
            this.cbFiguras.Name = "cbFiguras";
            this.cbFiguras.Size = new System.Drawing.Size(145, 26);
            this.cbFiguras.TabIndex = 16;
            this.cbFiguras.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FiguraGeometricas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 737);
            this.Controls.Add(this.cbFiguras);
            this.Controls.Add(this.groupResultado);
            this.Controls.Add(this.groupCilindro);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupParale);
            this.Controls.Add(this.groupEsfera);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgFigura);
            this.Controls.Add(this.label1);
            this.Name = "FiguraGeometricas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FiguraGeometricas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFigura)).EndInit();
            this.groupEsfera.ResumeLayout(false);
            this.groupEsfera.PerformLayout();
            this.groupCilindro.ResumeLayout(false);
            this.groupCilindro.PerformLayout();
            this.groupParale.ResumeLayout(false);
            this.groupParale.PerformLayout();
            this.groupResultado.ResumeLayout(false);
            this.groupResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgFigura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupEsfera;
        private System.Windows.Forms.TextBox txtRadioEsfera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupCilindro;
        private System.Windows.Forms.TextBox txtRadioCilindro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlturaCilindro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupParale;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.GroupBox groupResultado;
        private System.Windows.Forms.Label lblRtaVolumen;
        private System.Windows.Forms.Label lblRtaArea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbFiguras;
    }
}

