namespace WindowsFormsApp2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ticketTextBox6 = new System.Windows.Forms.TextBox();
            this.garantieTextBox5 = new System.Windows.Forms.TextBox();
            this.memoireTextBox4 = new System.Windows.Forms.TextBox();
            this.disqueTextBox3 = new System.Windows.Forms.TextBox();
            this.processeurTextBox2 = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSupprimerM = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewM = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTicket = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonAffecter = new System.Windows.Forms.Button();
            this.textBoxTravailEff = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAffecterTech = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewD = new System.Windows.Forms.DataGridView();
            this.SupprimerDemande = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(30, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ticketTextBox6);
            this.tabPage1.Controls.Add(this.garantieTextBox5);
            this.tabPage1.Controls.Add(this.memoireTextBox4);
            this.tabPage1.Controls.Add(this.disqueTextBox3);
            this.tabPage1.Controls.Add(this.processeurTextBox2);
            this.tabPage1.Controls.Add(this.idTextBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajouter matériel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(217, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ticketTextBox6
            // 
            this.ticketTextBox6.Location = new System.Drawing.Point(217, 225);
            this.ticketTextBox6.Name = "ticketTextBox6";
            this.ticketTextBox6.Size = new System.Drawing.Size(103, 20);
            this.ticketTextBox6.TabIndex = 12;
            // 
            // garantieTextBox5
            // 
            this.garantieTextBox5.Location = new System.Drawing.Point(217, 183);
            this.garantieTextBox5.Name = "garantieTextBox5";
            this.garantieTextBox5.Size = new System.Drawing.Size(103, 20);
            this.garantieTextBox5.TabIndex = 11;
            // 
            // memoireTextBox4
            // 
            this.memoireTextBox4.Location = new System.Drawing.Point(217, 141);
            this.memoireTextBox4.Name = "memoireTextBox4";
            this.memoireTextBox4.Size = new System.Drawing.Size(103, 20);
            this.memoireTextBox4.TabIndex = 10;
            // 
            // disqueTextBox3
            // 
            this.disqueTextBox3.Location = new System.Drawing.Point(217, 103);
            this.disqueTextBox3.Name = "disqueTextBox3";
            this.disqueTextBox3.Size = new System.Drawing.Size(103, 20);
            this.disqueTextBox3.TabIndex = 9;
            // 
            // processeurTextBox2
            // 
            this.processeurTextBox2.Location = new System.Drawing.Point(217, 65);
            this.processeurTextBox2.Name = "processeurTextBox2";
            this.processeurTextBox2.Size = new System.Drawing.Size(103, 20);
            this.processeurTextBox2.TabIndex = 8;
            // 
            // idTextBox1
            // 
            this.idTextBox1.Location = new System.Drawing.Point(217, 30);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(103, 20);
            this.idTextBox1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ticket : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Garantie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mémoire :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disque :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Processeur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBoxSupprimerM);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supprimer matériel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(234, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSupprimerM
            // 
            this.textBoxSupprimerM.Location = new System.Drawing.Point(234, 153);
            this.textBoxSupprimerM.Name = "textBoxSupprimerM";
            this.textBoxSupprimerM.Size = new System.Drawing.Size(136, 20);
            this.textBoxSupprimerM.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dataGridViewM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(729, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulter matériels";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(312, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 53);
            this.button3.TabIndex = 1;
            this.button3.Text = "Consulter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewM
            // 
            this.dataGridViewM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewM.Location = new System.Drawing.Point(129, 37);
            this.dataGridViewM.Name = "dataGridViewM";
            this.dataGridViewM.Size = new System.Drawing.Size(482, 226);
            this.dataGridViewM.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.SupprimerDemande);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBoxTicket);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.buttonAffecter);
            this.tabPage4.Controls.Add(this.textBoxTravailEff);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.textBoxAffecterTech);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.dataGridViewD);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(729, 369);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consulter demandes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ticket :";
            // 
            // textBoxTicket
            // 
            this.textBoxTicket.Location = new System.Drawing.Point(139, 83);
            this.textBoxTicket.Name = "textBoxTicket";
            this.textBoxTicket.Size = new System.Drawing.Size(125, 20);
            this.textBoxTicket.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(151, 321);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 27);
            this.button6.TabIndex = 7;
            this.button6.Text = "Fin Demande";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonAffecter
            // 
            this.buttonAffecter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAffecter.Location = new System.Drawing.Point(151, 228);
            this.buttonAffecter.Name = "buttonAffecter";
            this.buttonAffecter.Size = new System.Drawing.Size(98, 27);
            this.buttonAffecter.TabIndex = 6;
            this.buttonAffecter.Text = "Affecter";
            this.buttonAffecter.UseVisualStyleBackColor = true;
            this.buttonAffecter.Click += new System.EventHandler(this.buttonAffecter_Click);
            // 
            // textBoxTravailEff
            // 
            this.textBoxTravailEff.Location = new System.Drawing.Point(139, 295);
            this.textBoxTravailEff.Name = "textBoxTravailEff";
            this.textBoxTravailEff.Size = new System.Drawing.Size(125, 20);
            this.textBoxTravailEff.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Travail effectuer :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Technicien :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxAffecterTech
            // 
            this.textBoxAffecterTech.Location = new System.Drawing.Point(139, 202);
            this.textBoxAffecterTech.Name = "textBoxAffecterTech";
            this.textBoxAffecterTech.Size = new System.Drawing.Size(125, 20);
            this.textBoxAffecterTech.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(419, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 58);
            this.button4.TabIndex = 1;
            this.button4.Text = "Consulter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewD
            // 
            this.dataGridViewD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewD.Location = new System.Drawing.Point(289, 24);
            this.dataGridViewD.Name = "dataGridViewD";
            this.dataGridViewD.Size = new System.Drawing.Size(402, 221);
            this.dataGridViewD.TabIndex = 0;
            // 
            // SupprimerDemande
            // 
            this.SupprimerDemande.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerDemande.Location = new System.Drawing.Point(151, 129);
            this.SupprimerDemande.Name = "SupprimerDemande";
            this.SupprimerDemande.Size = new System.Drawing.Size(98, 27);
            this.SupprimerDemande.TabIndex = 10;
            this.SupprimerDemande.Text = "Supprimer";
            this.SupprimerDemande.UseVisualStyleBackColor = true;
            this.SupprimerDemande.Click += new System.EventHandler(this.SupprimerDemande_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ticketTextBox6;
        private System.Windows.Forms.TextBox garantieTextBox5;
        private System.Windows.Forms.TextBox memoireTextBox4;
        private System.Windows.Forms.TextBox disqueTextBox3;
        private System.Windows.Forms.TextBox processeurTextBox2;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox textBoxSupprimerM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewM;
        private System.Windows.Forms.DataGridView dataGridViewD;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAffecterTech;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTicket;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonAffecter;
        private System.Windows.Forms.TextBox textBoxTravailEff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SupprimerDemande;
    }
}