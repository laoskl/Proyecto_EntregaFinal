namespace Versionprueba
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Versionprueba.Properties.Resources.pexels_gdtography_950241;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(666, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2minimizar
            // 
            this.pictureBox2minimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2minimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2minimizar.Image")));
            this.pictureBox2minimizar.Location = new System.Drawing.Point(810, 12);
            this.pictureBox2minimizar.Name = "pictureBox2minimizar";
            this.pictureBox2minimizar.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2minimizar.TabIndex = 22;
            this.pictureBox2minimizar.TabStop = false;
            this.pictureBox2minimizar.Click += new System.EventHandler(this.pictureBox2minimizar_Click);
            // 
            // pictureBox1cerrar
            // 
            this.pictureBox1cerrar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1cerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1cerrar.Image")));
            this.pictureBox1cerrar.Location = new System.Drawing.Point(846, 12);
            this.pictureBox1cerrar.Name = "pictureBox1cerrar";
            this.pictureBox1cerrar.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1cerrar.TabIndex = 21;
            this.pictureBox1cerrar.TabStop = false;
            this.pictureBox1cerrar.Click += new System.EventHandler(this.pictureBox1cerrar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 500);
            this.Controls.Add(this.pictureBox2minimizar);
            this.Controls.Add(this.pictureBox1cerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2minimizar;
        private System.Windows.Forms.PictureBox pictureBox1cerrar;
    }
}