namespace Lagerverwaltung
{
    partial class Mitarbeiter_erfassung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbt_mid = new System.Windows.Forms.TextBox();
            this.tbt_VN = new System.Windows.Forms.TextBox();
            this.tbt_NN = new System.Windows.Forms.TextBox();
            this.tbt_A = new System.Windows.Forms.TextBox();
            this.btn_eintragen = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_Verbindung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mitarbeiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "MID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nachname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aktiv";
            // 
            // tbt_mid
            // 
            this.tbt_mid.Location = new System.Drawing.Point(137, 61);
            this.tbt_mid.Name = "tbt_mid";
            this.tbt_mid.Size = new System.Drawing.Size(100, 20);
            this.tbt_mid.TabIndex = 5;
            this.tbt_mid.Visible = false;
            // 
            // tbt_VN
            // 
            this.tbt_VN.Location = new System.Drawing.Point(137, 97);
            this.tbt_VN.Name = "tbt_VN";
            this.tbt_VN.Size = new System.Drawing.Size(100, 20);
            this.tbt_VN.TabIndex = 6;
            // 
            // tbt_NN
            // 
            this.tbt_NN.Location = new System.Drawing.Point(137, 145);
            this.tbt_NN.Name = "tbt_NN";
            this.tbt_NN.Size = new System.Drawing.Size(100, 20);
            this.tbt_NN.TabIndex = 7;
            // 
            // tbt_A
            // 
            this.tbt_A.Location = new System.Drawing.Point(137, 183);
            this.tbt_A.Name = "tbt_A";
            this.tbt_A.Size = new System.Drawing.Size(100, 20);
            this.tbt_A.TabIndex = 8;
            // 
            // btn_eintragen
            // 
            this.btn_eintragen.Location = new System.Drawing.Point(12, 272);
            this.btn_eintragen.Name = "btn_eintragen";
            this.btn_eintragen.Size = new System.Drawing.Size(75, 23);
            this.btn_eintragen.TabIndex = 9;
            this.btn_eintragen.Text = "Eintragen";
            this.btn_eintragen.UseVisualStyleBackColor = true;
            this.btn_eintragen.Click += new System.EventHandler(this.btn_eintragen_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(211, 303);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(75, 23);
            this.btn_end.TabIndex = 10;
            this.btn_end.Text = "Beenden";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // btn_Verbindung
            // 
            this.btn_Verbindung.Location = new System.Drawing.Point(12, 303);
            this.btn_Verbindung.Name = "btn_Verbindung";
            this.btn_Verbindung.Size = new System.Drawing.Size(108, 23);
            this.btn_Verbindung.TabIndex = 11;
            this.btn_Verbindung.Text = "Verbindungstest";
            this.btn_Verbindung.UseVisualStyleBackColor = true;
            this.btn_Verbindung.Visible = false;
            this.btn_Verbindung.Click += new System.EventHandler(this.btn_Verbindung_Click);
            // 
            // Mitarbeiter_erfassung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 347);
            this.Controls.Add(this.btn_Verbindung);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_eintragen);
            this.Controls.Add(this.tbt_A);
            this.Controls.Add(this.tbt_NN);
            this.Controls.Add(this.tbt_VN);
            this.Controls.Add(this.tbt_mid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mitarbeiter_erfassung";
            this.Text = "Mitarbeiter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbt_mid;
        private System.Windows.Forms.TextBox tbt_VN;
        private System.Windows.Forms.TextBox tbt_NN;
        private System.Windows.Forms.TextBox tbt_A;
        private System.Windows.Forms.Button btn_eintragen;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_Verbindung;
    }
}

