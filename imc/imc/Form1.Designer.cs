namespace imc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlibras = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpies = new System.Windows.Forms.TextBox();
            this.txtkilos = new System.Windows.Forms.TextBox();
            this.txtmetros = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Name = "label4";
            // 
            // lblpeso
            // 
            resources.ApplyResources(this.lblpeso, "lblpeso");
            this.lblpeso.ForeColor = System.Drawing.Color.Blue;
            this.lblpeso.Name = "lblpeso";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Fuchsia;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Fuchsia;
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Fuchsia;
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtlibras
            // 
            resources.ApplyResources(this.txtlibras, "txtlibras");
            this.txtlibras.Name = "txtlibras";
            // 
            // txtnombre
            // 
            resources.ApplyResources(this.txtnombre, "txtnombre");
            this.txtnombre.Name = "txtnombre";
            // 
            // txtpies
            // 
            resources.ApplyResources(this.txtpies, "txtpies");
            this.txtpies.Name = "txtpies";
            // 
            // txtkilos
            // 
            resources.ApplyResources(this.txtkilos, "txtkilos");
            this.txtkilos.Name = "txtkilos";
            this.txtkilos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmetros
            // 
            resources.ApplyResources(this.txtmetros, "txtmetros");
            this.txtmetros.Name = "txtmetros";
            this.txtmetros.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btncalcular
            // 
            resources.ApplyResources(this.btncalcular, "btncalcular");
            this.btncalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            resources.ApplyResources(this.btnlimpiar, "btnlimpiar");
            this.btnlimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsalir
            // 
            resources.ApplyResources(this.btnsalir, "btnsalir");
            this.btnsalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtimc
            // 
            resources.ApplyResources(this.txtimc, "txtimc");
            this.txtimc.Name = "txtimc";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtmetros);
            this.Controls.Add(this.txtkilos);
            this.Controls.Add(this.txtpies);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtlibras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblpeso;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtlibras;
        private TextBox txtnombre;
        private TextBox txtpies;
        private TextBox txtkilos;
        private TextBox txtmetros;
        private Button btncalcular;
        private Button btnlimpiar;
        private Button btnsalir;
        private TextBox txtimc;
    }
}