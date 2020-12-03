namespace Lagerverwaltung
{
    partial class Mitarbeiter
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
            this.btn_erfassen = new System.Windows.Forms.Button();
            this.Bearbeiten = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_erfassen
            // 
            this.btn_erfassen.Location = new System.Drawing.Point(12, 294);
            this.btn_erfassen.Name = "btn_erfassen";
            this.btn_erfassen.Size = new System.Drawing.Size(127, 43);
            this.btn_erfassen.TabIndex = 0;
            this.btn_erfassen.Text = "Erfassen";
            this.btn_erfassen.UseVisualStyleBackColor = true;
            this.btn_erfassen.Click += new System.EventHandler(this.btn_erfassen_Click);
            // 
            // Bearbeiten
            // 
            this.Bearbeiten.Location = new System.Drawing.Point(158, 294);
            this.Bearbeiten.Name = "Bearbeiten";
            this.Bearbeiten.Size = new System.Drawing.Size(127, 43);
            this.Bearbeiten.TabIndex = 1;
            this.Bearbeiten.Text = "Bearbeiten";
            this.Bearbeiten.UseVisualStyleBackColor = true;
            this.Bearbeiten.Click += new System.EventHandler(this.Bearbeiten_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(447, 395);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(127, 43);
            this.btn_end.TabIndex = 2;
            this.btn_end.Text = "Beenden";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Laden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(562, 260);
            this.dataGridView1.TabIndex = 5;
            // 
            // Mitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.Bearbeiten);
            this.Controls.Add(this.btn_erfassen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mitarbeiter";
            this.Text = "Mitarbeiter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_erfassen;
        private System.Windows.Forms.Button Bearbeiten;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}