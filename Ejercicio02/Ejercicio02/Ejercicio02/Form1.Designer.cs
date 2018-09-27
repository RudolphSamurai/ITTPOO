namespace Ejercicio02
{
    partial class FormPizarra
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
            this.ButtonCrear = new System.Windows.Forms.Button();
            this.ButtonLimpiar = new System.Windows.Forms.Button();
            this.ButtonMover = new System.Windows.Forms.Button();
            this.PictureBoxPizarra = new System.Windows.Forms.PictureBox();
            this.TextBoxX = new System.Windows.Forms.TextBox();
            this.TextBoxY = new System.Windows.Forms.TextBox();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPizarra)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCrear
            // 
            this.ButtonCrear.Location = new System.Drawing.Point(633, 36);
            this.ButtonCrear.Name = "ButtonCrear";
            this.ButtonCrear.Size = new System.Drawing.Size(103, 23);
            this.ButtonCrear.TabIndex = 0;
            this.ButtonCrear.Text = "&Crear Globo";
            this.ButtonCrear.UseVisualStyleBackColor = true;
            this.ButtonCrear.Click += new System.EventHandler(this.ButtonCrear_Click);
            // 
            // ButtonLimpiar
            // 
            this.ButtonLimpiar.Location = new System.Drawing.Point(633, 90);
            this.ButtonLimpiar.Name = "ButtonLimpiar";
            this.ButtonLimpiar.Size = new System.Drawing.Size(103, 23);
            this.ButtonLimpiar.TabIndex = 1;
            this.ButtonLimpiar.Text = "&Limpiar Pizarra";
            this.ButtonLimpiar.UseVisualStyleBackColor = true;
            this.ButtonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // ButtonMover
            // 
            this.ButtonMover.Location = new System.Drawing.Point(633, 140);
            this.ButtonMover.Name = "ButtonMover";
            this.ButtonMover.Size = new System.Drawing.Size(103, 23);
            this.ButtonMover.TabIndex = 2;
            this.ButtonMover.Text = "&Mover Globo";
            this.ButtonMover.UseVisualStyleBackColor = true;
            // 
            // PictureBoxPizarra
            // 
            this.PictureBoxPizarra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureBoxPizarra.Location = new System.Drawing.Point(69, 36);
            this.PictureBoxPizarra.Name = "PictureBoxPizarra";
            this.PictureBoxPizarra.Size = new System.Drawing.Size(415, 359);
            this.PictureBoxPizarra.TabIndex = 3;
            this.PictureBoxPizarra.TabStop = false;
            // 
            // TextBoxX
            // 
            this.TextBoxX.Location = new System.Drawing.Point(633, 192);
            this.TextBoxX.Name = "TextBoxX";
            this.TextBoxX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxX.TabIndex = 3;
            // 
            // TextBoxY
            // 
            this.TextBoxY.Location = new System.Drawing.Point(633, 231);
            this.TextBoxY.Name = "TextBoxY";
            this.TextBoxY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxY.TabIndex = 4;
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(577, 198);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(14, 13);
            this.LabelX.TabIndex = 6;
            this.LabelX.Text = "X";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(580, 243);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(14, 13);
            this.LabelY.TabIndex = 7;
            this.LabelY.Text = "Y";
            // 
            // FormPizarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.TextBoxY);
            this.Controls.Add(this.TextBoxX);
            this.Controls.Add(this.PictureBoxPizarra);
            this.Controls.Add(this.ButtonMover);
            this.Controls.Add(this.ButtonLimpiar);
            this.Controls.Add(this.ButtonCrear);
            this.Name = "FormPizarra";
            this.Text = "Crear Globo";
            this.Load += new System.EventHandler(this.FormPizarra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPizarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCrear;
        private System.Windows.Forms.Button ButtonLimpiar;
        private System.Windows.Forms.Button ButtonMover;
        private System.Windows.Forms.PictureBox PictureBoxPizarra;
        private System.Windows.Forms.TextBox TextBoxX;
        private System.Windows.Forms.TextBox TextBoxY;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;
    }
}

