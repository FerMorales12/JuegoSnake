namespace GameSnake
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
            this.components = new System.ComponentModel.Container();
            this.pantalla = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CooX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CooY = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.bucle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(53, 97);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(500, 280);
            this.pantalla.TabIndex = 0;
            this.pantalla.TabStop = false;
            this.pantalla.Click += new System.EventHandler(this.pantalla_Click);
            this.pantalla.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pantalla_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // CooX
            // 
            this.CooX.AutoSize = true;
            this.CooX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CooX.Location = new System.Drawing.Point(95, 35);
            this.CooX.Name = "CooX";
            this.CooX.Size = new System.Drawing.Size(30, 31);
            this.CooX.TabIndex = 3;
            this.CooX.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y:";
            // 
            // CooY
            // 
            this.CooY.AutoSize = true;
            this.CooY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CooY.Location = new System.Drawing.Point(195, 34);
            this.CooY.Name = "CooY";
            this.CooY.Size = new System.Drawing.Size(30, 31);
            this.CooY.TabIndex = 5;
            this.CooY.Text = "0";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Cursor = System.Windows.Forms.Cursors.Default;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(463, 35);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(30, 31);
            this.score.TabIndex = 6;
            this.score.Text = "0";
            // 
            // bucle
            // 
            this.bucle.Enabled = true;
            this.bucle.Tick += new System.EventHandler(this.bucle_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 424);
            this.Controls.Add(this.score);
            this.Controls.Add(this.CooY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CooX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pantalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pantalla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CooX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CooY;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer bucle;
    }
}

