namespace defibrillator
{
    partial class foForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLekeres = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lbMegjelenit = new System.Windows.Forms.ListBox();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnUjadat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X koordináta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y koordináta:";
            // 
            // btnLekeres
            // 
            this.btnLekeres.Location = new System.Drawing.Point(152, 154);
            this.btnLekeres.Name = "btnLekeres";
            this.btnLekeres.Size = new System.Drawing.Size(144, 31);
            this.btnLekeres.TabIndex = 2;
            this.btnLekeres.Text = "Adatok lekérése";
            this.btnLekeres.UseVisualStyleBackColor = true;
            this.btnLekeres.Click += new System.EventHandler(this.btnLekeres_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(175, 35);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(189, 26);
            this.tbX.TabIndex = 3;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(175, 93);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(189, 26);
            this.tbY.TabIndex = 4;
            // 
            // lbMegjelenit
            // 
            this.lbMegjelenit.FormattingEnabled = true;
            this.lbMegjelenit.ItemHeight = 20;
            this.lbMegjelenit.Location = new System.Drawing.Point(83, 213);
            this.lbMegjelenit.Name = "lbMegjelenit";
            this.lbMegjelenit.Size = new System.Drawing.Size(334, 244);
            this.lbMegjelenit.TabIndex = 5;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(351, 483);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(102, 36);
            this.btnKilepes.TabIndex = 6;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnUjadat
            // 
            this.btnUjadat.Location = new System.Drawing.Point(38, 483);
            this.btnUjadat.Name = "btnUjadat";
            this.btnUjadat.Size = new System.Drawing.Size(162, 36);
            this.btnUjadat.TabIndex = 7;
            this.btnUjadat.Text = "Új adat megadása";
            this.btnUjadat.UseVisualStyleBackColor = true;
            this.btnUjadat.Click += new System.EventHandler(this.btnUjadat_Click);
            // 
            // foForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 531);
            this.Controls.Add(this.btnUjadat);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.lbMegjelenit);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.btnLekeres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "foForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defibrillátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLekeres;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.ListBox lbMegjelenit;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnUjadat;
    }
}

