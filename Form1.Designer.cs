namespace pryLopezEtapa3
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
            btnAuto = new Button();
            btnAvion = new Button();
            btnBarco = new Button();
            pctImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctImagen).BeginInit();
            SuspendLayout();
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(74, 381);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(94, 29);
            btnAuto.TabIndex = 0;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // btnAvion
            // 
            btnAvion.Location = new Point(314, 381);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(94, 29);
            btnAvion.TabIndex = 1;
            btnAvion.Text = "Avion";
            btnAvion.UseVisualStyleBackColor = true;
            btnAvion.Click += btnAvion_Click;
            // 
            // btnBarco
            // 
            btnBarco.Location = new Point(605, 381);
            btnBarco.Name = "btnBarco";
            btnBarco.Size = new Size(94, 29);
            btnBarco.TabIndex = 2;
            btnBarco.Text = "Barco";
            btnBarco.UseVisualStyleBackColor = true;
            btnBarco.Click += btnBarco_Click;
            // 
            // pctImagen
            // 
            pctImagen.Image = Properties.Resources.auto;
            pctImagen.Location = new Point(120, 33);
            pctImagen.Name = "pctImagen";
            pctImagen.Size = new Size(520, 323);
            pctImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pctImagen.TabIndex = 3;
            pctImagen.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pctImagen);
            Controls.Add(btnBarco);
            Controls.Add(btnAvion);
            Controls.Add(btnAuto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAuto;
        private Button btnAvion;
        private Button btnBarco;
        private PictureBox pctImagen;
    }
}
