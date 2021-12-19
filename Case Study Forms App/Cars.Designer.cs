namespace Case_Study_Forms_App
{
    partial class Cars
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
            this.lblMerk = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnZoek = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBJV = new System.Windows.Forms.TextBox();
            this.txtBJT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.txtPT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMerk
            // 
            this.lblMerk.AutoSize = true;
            this.lblMerk.Location = new System.Drawing.Point(64, 60);
            this.lblMerk.Name = "lblMerk";
            this.lblMerk.Size = new System.Drawing.Size(38, 15);
            this.lblMerk.TabIndex = 0;
            this.lblMerk.Text = "Merk:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(326, 60);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 15);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model:";
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(67, 79);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(100, 20);
            this.txtMerk.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(329, 79);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 3;
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(614, 98);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(114, 59);
            this.btnZoek.TabIndex = 4;
            this.btnZoek.Text = "ZOEKEN";
            this.btnZoek.UseVisualStyleBackColor = true;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(67, 179);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(661, 251);
            this.lbResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bouwjaar van:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bouwjaar tot:";
            // 
            // txtBJV
            // 
            this.txtBJV.Location = new System.Drawing.Point(67, 137);
            this.txtBJV.Name = "txtBJV";
            this.txtBJV.Size = new System.Drawing.Size(100, 20);
            this.txtBJV.TabIndex = 8;
            // 
            // txtBJT
            // 
            this.txtBJT.Location = new System.Drawing.Point(200, 137);
            this.txtBJT.Name = "txtBJT";
            this.txtBJT.Size = new System.Drawing.Size(100, 20);
            this.txtBJT.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prijs van:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prijs tot:";
            // 
            // txtPV
            // 
            this.txtPV.Location = new System.Drawing.Point(328, 137);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(100, 20);
            this.txtPV.TabIndex = 12;
            // 
            // txtPT
            // 
            this.txtPT.Location = new System.Drawing.Point(450, 137);
            this.txtPT.Name = "txtPT";
            this.txtPT.Size = new System.Drawing.Size(100, 20);
            this.txtPT.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(62, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "2dehands Auto\'s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "© Zeno Loyen";
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPT);
            this.Controls.Add(this.txtPV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBJT);
            this.Controls.Add(this.txtBJV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMerk);
            this.Name = "Cars";
            this.Text = "Cars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMerk;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBJV;
        private System.Windows.Forms.TextBox txtBJT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.TextBox txtPT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}