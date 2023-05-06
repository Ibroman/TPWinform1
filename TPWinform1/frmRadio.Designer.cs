namespace TPWinform1
{
    partial class frmRadio
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
            this.btnAfficher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdAddition = new System.Windows.Forms.RadioButton();
            this.rdSoustraction = new System.Windows.Forms.RadioButton();
            this.rdMultiplication = new System.Windows.Forms.RadioButton();
            this.rdDivision = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(97, 94);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(167, 32);
            this.btnAfficher.TabIndex = 9;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Opération:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // rdAddition
            // 
            this.rdAddition.AutoSize = true;
            this.rdAddition.Checked = true;
            this.rdAddition.Location = new System.Drawing.Point(97, 47);
            this.rdAddition.Name = "rdAddition";
            this.rdAddition.Size = new System.Drawing.Size(63, 17);
            this.rdAddition.TabIndex = 10;
            this.rdAddition.TabStop = true;
            this.rdAddition.Text = "Addition";
            this.rdAddition.UseVisualStyleBackColor = true;
            // 
            // rdSoustraction
            // 
            this.rdSoustraction.AutoSize = true;
            this.rdSoustraction.Location = new System.Drawing.Point(179, 47);
            this.rdSoustraction.Name = "rdSoustraction";
            this.rdSoustraction.Size = new System.Drawing.Size(84, 17);
            this.rdSoustraction.TabIndex = 11;
            this.rdSoustraction.TabStop = true;
            this.rdSoustraction.Text = "Soustraction";
            this.rdSoustraction.UseVisualStyleBackColor = true;
            // 
            // rdMultiplication
            // 
            this.rdMultiplication.AutoSize = true;
            this.rdMultiplication.Location = new System.Drawing.Point(284, 45);
            this.rdMultiplication.Name = "rdMultiplication";
            this.rdMultiplication.Size = new System.Drawing.Size(86, 17);
            this.rdMultiplication.TabIndex = 12;
            this.rdMultiplication.TabStop = true;
            this.rdMultiplication.Text = "Multiplication";
            this.rdMultiplication.UseVisualStyleBackColor = true;
            // 
            // rdDivision
            // 
            this.rdDivision.AutoSize = true;
            this.rdDivision.Location = new System.Drawing.Point(389, 45);
            this.rdDivision.Name = "rdDivision";
            this.rdDivision.Size = new System.Drawing.Size(62, 17);
            this.rdDivision.TabIndex = 13;
            this.rdDivision.TabStop = true;
            this.rdDivision.Text = "Division";
            this.rdDivision.UseVisualStyleBackColor = true;
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 191);
            this.Controls.Add(this.rdDivision);
            this.Controls.Add(this.rdMultiplication);
            this.Controls.Add(this.rdSoustraction);
            this.Controls.Add(this.rdAddition);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdAddition;
        private System.Windows.Forms.RadioButton rdSoustraction;
        private System.Windows.Forms.RadioButton rdMultiplication;
        private System.Windows.Forms.RadioButton rdDivision;
    }
}