namespace Circulo
{
    partial class Form1
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
            this.Pcb = new System.Windows.Forms.PictureBox();
            this.Btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // Pcb
            // 
            this.Pcb.Location = new System.Drawing.Point(12, 47);
            this.Pcb.Name = "Pcb";
            this.Pcb.Size = new System.Drawing.Size(600, 400);
            this.Pcb.TabIndex = 0;
            this.Pcb.TabStop = false;
            this.Pcb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pcb_MouseClick);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(12, 12);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(596, 23);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "Iniciar";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 456);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Pcb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pcb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pcb;
        private System.Windows.Forms.Button Btn1;
    }
}

