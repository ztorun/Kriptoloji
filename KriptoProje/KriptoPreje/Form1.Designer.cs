namespace KriptoPreje
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
            this.button2 = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.encryptedtxt = new System.Windows.Forms.TextBox();
            this.cryptedtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pureText = new System.Windows.Forms.TextBox();
            this.Asal2txt = new System.Windows.Forms.TextBox();
            this.Asal1txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.etxt = new System.Windows.Forms.TextBox();
            this.dtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.qntxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(70, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 88);
            this.button2.TabIndex = 23;
            this.button2.Text = "Encryption";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Crypte_Click);
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randomButton.Location = new System.Drawing.Point(423, 26);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(117, 41);
            this.randomButton.TabIndex = 22;
            this.randomButton.Text = "Random Generate";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // encryptedtxt
            // 
            this.encryptedtxt.Location = new System.Drawing.Point(381, 312);
            this.encryptedtxt.Name = "encryptedtxt";
            this.encryptedtxt.ReadOnly = true;
            this.encryptedtxt.Size = new System.Drawing.Size(204, 20);
            this.encryptedtxt.TabIndex = 20;
            // 
            // cryptedtxt
            // 
            this.cryptedtxt.Location = new System.Drawing.Point(381, 271);
            this.cryptedtxt.Name = "cryptedtxt";
            this.cryptedtxt.ReadOnly = true;
            this.cryptedtxt.Size = new System.Drawing.Size(204, 20);
            this.cryptedtxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Text to be encrypted";
            // 
            // pureText
            // 
            this.pureText.Location = new System.Drawing.Point(250, 219);
            this.pureText.Name = "pureText";
            this.pureText.Size = new System.Drawing.Size(174, 20);
            this.pureText.TabIndex = 16;
            // 
            // Asal2txt
            // 
            this.Asal2txt.Location = new System.Drawing.Point(274, 26);
            this.Asal2txt.Name = "Asal2txt";
            this.Asal2txt.Size = new System.Drawing.Size(111, 20);
            this.Asal2txt.TabIndex = 15;
            this.Asal2txt.TextChanged += new System.EventHandler(this.Asal2txt_TextChanged);
            this.Asal2txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Asal2txt_KeyPress);
            // 
            // Asal1txt
            // 
            this.Asal1txt.Location = new System.Drawing.Point(130, 26);
            this.Asal1txt.Name = "Asal1txt";
            this.Asal1txt.Size = new System.Drawing.Size(111, 20);
            this.Asal1txt.TabIndex = 14;
            this.Asal1txt.TextChanged += new System.EventHandler(this.Asal1txt_TextChanged);
            this.Asal1txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Asal1txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Prime Numbers";
            // 
            // etxt
            // 
            this.etxt.Location = new System.Drawing.Point(130, 29);
            this.etxt.Name = "etxt";
            this.etxt.Size = new System.Drawing.Size(111, 20);
            this.etxt.TabIndex = 26;
            this.etxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.etxt_KeyPress);
            // 
            // dtxt
            // 
            this.dtxt.Location = new System.Drawing.Point(435, 168);
            this.dtxt.Name = "dtxt";
            this.dtxt.ReadOnly = true;
            this.dtxt.Size = new System.Drawing.Size(100, 20);
            this.dtxt.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qntxt
            // 
            this.qntxt.Location = new System.Drawing.Point(130, 60);
            this.qntxt.Name = "qntxt";
            this.qntxt.ReadOnly = true;
            this.qntxt.Size = new System.Drawing.Size(111, 20);
            this.qntxt.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.qntxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.randomButton);
            this.groupBox1.Controls.Add(this.Asal1txt);
            this.groupBox1.Controls.Add(this.Asal2txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 97);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Numbers or Random Generate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "T(n):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.etxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 63);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Key Number or  Random Generate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Public Key (e):";
            // 
            // dlbl
            // 
            this.dlbl.AutoSize = true;
            this.dlbl.Location = new System.Drawing.Point(438, 146);
            this.dlbl.Name = "dlbl";
            this.dlbl.Size = new System.Drawing.Size(95, 13);
            this.dlbl.TabIndex = 34;
            this.dlbl.Text = "Private Key (d):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Text to be encrypted:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Decrypted:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Encrypted:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(597, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dlbl);
            this.Controls.Add(this.dtxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.encryptedtxt);
            this.Controls.Add(this.cryptedtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pureText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "RSA Algorithm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.TextBox encryptedtxt;
        private System.Windows.Forms.TextBox cryptedtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pureText;
        private System.Windows.Forms.TextBox Asal2txt;
        private System.Windows.Forms.TextBox Asal1txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox etxt;
        private System.Windows.Forms.TextBox dtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox qntxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

