namespace OVTool
{
    partial class SendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMail));
            this.btnSenden = new System.Windows.Forms.Button();
            this.tbEmailEmpfaenger = new System.Windows.Forms.TextBox();
            this.lblEmailEmpfaenger = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.tbBetreff = new System.Windows.Forms.TextBox();
            this.lblBetreff = new System.Windows.Forms.Label();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSenden
            // 
            this.btnSenden.Location = new System.Drawing.Point(342, 367);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(75, 23);
            this.btnSenden.TabIndex = 0;
            this.btnSenden.Text = "Senden";
            this.btnSenden.UseVisualStyleBackColor = true;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // tbEmailEmpfaenger
            // 
            this.tbEmailEmpfaenger.Location = new System.Drawing.Point(139, 30);
            this.tbEmailEmpfaenger.Name = "tbEmailEmpfaenger";
            this.tbEmailEmpfaenger.Size = new System.Drawing.Size(186, 20);
            this.tbEmailEmpfaenger.TabIndex = 6;
            // 
            // lblEmailEmpfaenger
            // 
            this.lblEmailEmpfaenger.AutoSize = true;
            this.lblEmailEmpfaenger.Location = new System.Drawing.Point(6, 33);
            this.lblEmailEmpfaenger.Name = "lblEmailEmpfaenger";
            this.lblEmailEmpfaenger.Size = new System.Drawing.Size(127, 13);
            this.lblEmailEmpfaenger.TabIndex = 5;
            this.lblEmailEmpfaenger.Text = "Email-Adresse Empfänger";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(6, 113);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 9;
            this.lblText.Text = "Text";
            // 
            // tbBetreff
            // 
            this.tbBetreff.Location = new System.Drawing.Point(139, 66);
            this.tbBetreff.Name = "tbBetreff";
            this.tbBetreff.Size = new System.Drawing.Size(186, 20);
            this.tbBetreff.TabIndex = 8;
            // 
            // lblBetreff
            // 
            this.lblBetreff.AutoSize = true;
            this.lblBetreff.Location = new System.Drawing.Point(6, 69);
            this.lblBetreff.Name = "lblBetreff";
            this.lblBetreff.Size = new System.Drawing.Size(38, 13);
            this.lblBetreff.TabIndex = 7;
            this.lblBetreff.Text = "Betreff";
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(139, 110);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(255, 218);
            this.rtbText.TabIndex = 10;
            this.rtbText.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmailEmpfaenger);
            this.groupBox1.Controls.Add(this.tbBetreff);
            this.groupBox1.Controls.Add(this.lblEmailEmpfaenger);
            this.groupBox1.Controls.Add(this.rtbText);
            this.groupBox1.Controls.Add(this.lblBetreff);
            this.groupBox1.Controls.Add(this.lblText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 349);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMail";
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSenden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendMail";
            this.Text = "E-Mail versenden";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSenden;
        private System.Windows.Forms.TextBox tbEmailEmpfaenger;
        private System.Windows.Forms.Label lblEmailEmpfaenger;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbBetreff;
        private System.Windows.Forms.Label lblBetreff;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}