namespace ProjetArduinoCommPC1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnEnvoi = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerGetSerial = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDataUDPToSend = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLEDClignote = new System.Windows.Forms.Button();
            this.btnTourServo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnServo180 = new System.Windows.Forms.Button();
            this.btnServo120 = new System.Windows.Forms.Button();
            this.btnServo60 = new System.Windows.Forms.Button();
            this.btnServo0 = new System.Windows.Forms.Button();
            this.btnLED = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(201, 26);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(58, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port UDP :";
            // 
            // btnEnvoi
            // 
            this.btnEnvoi.Enabled = false;
            this.btnEnvoi.Location = new System.Drawing.Point(323, 51);
            this.btnEnvoi.Name = "btnEnvoi";
            this.btnEnvoi.Size = new System.Drawing.Size(58, 23);
            this.btnEnvoi.TabIndex = 3;
            this.btnEnvoi.Text = "Envoi";
            this.btnEnvoi.UseVisualStyleBackColor = true;
            this.btnEnvoi.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(411, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stStatus
            // 
            this.stStatus.Name = "stStatus";
            this.stStatus.Size = new System.Drawing.Size(312, 17);
            this.stStatus.Text = "Electronique Appliquée © Jonathan W. 2eme IS 2017-2018";
            // 
            // timerGetSerial
            // 
            this.timerGetSerial.Interval = 2000;
            this.timerGetSerial.Tick += new System.EventHandler(this.timerGetSerial_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDataUDPToSend);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.tbIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.btnEnvoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration de liaison avec l\'ESP8266";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(323, 22);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(58, 23);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "< Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Envoyer le contenu d\'un paquet au choix :";
            // 
            // tbDataUDPToSend
            // 
            this.tbDataUDPToSend.Location = new System.Drawing.Point(213, 53);
            this.tbDataUDPToSend.Name = "tbDataUDPToSend";
            this.tbDataUDPToSend.Size = new System.Drawing.Size(104, 20);
            this.tbDataUDPToSend.TabIndex = 10;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(265, 24);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(52, 20);
            this.tbPort.TabIndex = 11;
            this.tbPort.Text = "4210";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(78, 23);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 10;
            this.tbIP.Text = "192.168.201.2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP de l\'ESP :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLEDClignote);
            this.groupBox2.Controls.Add(this.btnTourServo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnServo180);
            this.groupBox2.Controls.Add(this.btnServo120);
            this.groupBox2.Controls.Add(this.btnServo60);
            this.groupBox2.Controls.Add(this.btnServo0);
            this.groupBox2.Controls.Add(this.btnLED);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contrôle de l\'ESP8266";
            // 
            // btnLEDClignote
            // 
            this.btnLEDClignote.Enabled = false;
            this.btnLEDClignote.Location = new System.Drawing.Point(134, 19);
            this.btnLEDClignote.Name = "btnLEDClignote";
            this.btnLEDClignote.Size = new System.Drawing.Size(60, 23);
            this.btnLEDClignote.TabIndex = 20;
            this.btnLEDClignote.Text = "Clignoter";
            this.btnLEDClignote.UseVisualStyleBackColor = true;
            this.btnLEDClignote.Click += new System.EventHandler(this.btnLEDClignote_Click);
            // 
            // btnTourServo
            // 
            this.btnTourServo.Enabled = false;
            this.btnTourServo.Location = new System.Drawing.Point(9, 77);
            this.btnTourServo.Name = "btnTourServo";
            this.btnTourServo.Size = new System.Drawing.Size(185, 23);
            this.btnTourServo.TabIndex = 19;
            this.btnTourServo.Text = "Servo tour complet progressif";
            this.btnTourServo.UseVisualStyleBackColor = true;
            this.btnTourServo.Click += new System.EventHandler(this.btnTourServo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Faire un tour complet de 0 à 180 °";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Position manuelle du Servo 0° à 180°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Contrôle de la LED";
            // 
            // btnServo180
            // 
            this.btnServo180.Enabled = false;
            this.btnServo180.Location = new System.Drawing.Point(152, 48);
            this.btnServo180.Name = "btnServo180";
            this.btnServo180.Size = new System.Drawing.Size(42, 23);
            this.btnServo180.TabIndex = 15;
            this.btnServo180.Text = "180°";
            this.btnServo180.UseVisualStyleBackColor = true;
            this.btnServo180.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnServo120
            // 
            this.btnServo120.Enabled = false;
            this.btnServo120.Location = new System.Drawing.Point(104, 48);
            this.btnServo120.Name = "btnServo120";
            this.btnServo120.Size = new System.Drawing.Size(42, 23);
            this.btnServo120.TabIndex = 14;
            this.btnServo120.Text = "120°";
            this.btnServo120.UseVisualStyleBackColor = true;
            this.btnServo120.Click += new System.EventHandler(this.btnServo120_Click);
            // 
            // btnServo60
            // 
            this.btnServo60.Enabled = false;
            this.btnServo60.Location = new System.Drawing.Point(57, 48);
            this.btnServo60.Name = "btnServo60";
            this.btnServo60.Size = new System.Drawing.Size(42, 23);
            this.btnServo60.TabIndex = 13;
            this.btnServo60.Text = "60°";
            this.btnServo60.UseVisualStyleBackColor = true;
            this.btnServo60.Click += new System.EventHandler(this.btnServo60_Click);
            // 
            // btnServo0
            // 
            this.btnServo0.Enabled = false;
            this.btnServo0.Location = new System.Drawing.Point(9, 48);
            this.btnServo0.Name = "btnServo0";
            this.btnServo0.Size = new System.Drawing.Size(42, 23);
            this.btnServo0.TabIndex = 12;
            this.btnServo0.Text = "0°";
            this.btnServo0.UseVisualStyleBackColor = true;
            this.btnServo0.Click += new System.EventHandler(this.btnServo0_Click);
            // 
            // btnLED
            // 
            this.btnLED.Enabled = false;
            this.btnLED.Location = new System.Drawing.Point(9, 19);
            this.btnLED.Name = "btnLED";
            this.btnLED.Size = new System.Drawing.Size(119, 23);
            this.btnLED.TabIndex = 11;
            this.btnLED.Text = "Allumer/Eteindre LED";
            this.btnLED.UseVisualStyleBackColor = true;
            this.btnLED.Click += new System.EventHandler(this.btnLED_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Contrôle ESP8266 via paquet UDP ";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnEnvoi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stStatus;
        private System.Windows.Forms.Timer timerGetSerial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDataUDPToSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnServo180;
        private System.Windows.Forms.Button btnServo120;
        private System.Windows.Forms.Button btnServo60;
        private System.Windows.Forms.Button btnServo0;
        private System.Windows.Forms.Button btnLED;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnTourServo;
        private System.Windows.Forms.Button btnLEDClignote;
    }
}

