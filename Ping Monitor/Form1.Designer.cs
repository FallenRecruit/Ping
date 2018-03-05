namespace Ping_Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ping44Lab = new System.Windows.Forms.Label();
            this.pingLauntelLab = new System.Windows.Forms.Label();
            this.pingMirrorLab = new System.Windows.Forms.Label();
            this.tOutMi = new System.Windows.Forms.Label();
            this.ping88Lab = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tOutLt = new System.Windows.Forms.Label();
            this.tOut44 = new System.Windows.Forms.Label();
            this.tOut88 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.averageTimer = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.avLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "8.8.8.8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 11);
            this.label2.TabIndex = 1;
            this.label2.Text = "8.8.4.4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 11);
            this.label3.TabIndex = 2;
            this.label3.Text = "launtel.net.au";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 11);
            this.label4.TabIndex = 3;
            this.label4.Text = "mirror.launtel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(149, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 11);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timeouts";
            // 
            // ping44Lab
            // 
            this.ping44Lab.AutoSize = true;
            this.ping44Lab.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ping44Lab.ForeColor = System.Drawing.Color.Lime;
            this.ping44Lab.Location = new System.Drawing.Point(121, 35);
            this.ping44Lab.Name = "ping44Lab";
            this.ping44Lab.Size = new System.Drawing.Size(12, 11);
            this.ping44Lab.TabIndex = 6;
            this.ping44Lab.Text = "0";
            this.ping44Lab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pingLauntelLab
            // 
            this.pingLauntelLab.AutoSize = true;
            this.pingLauntelLab.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingLauntelLab.ForeColor = System.Drawing.Color.Lime;
            this.pingLauntelLab.Location = new System.Drawing.Point(121, 48);
            this.pingLauntelLab.Name = "pingLauntelLab";
            this.pingLauntelLab.Size = new System.Drawing.Size(12, 11);
            this.pingLauntelLab.TabIndex = 7;
            this.pingLauntelLab.Text = "0";
            this.pingLauntelLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pingMirrorLab
            // 
            this.pingMirrorLab.AutoSize = true;
            this.pingMirrorLab.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingMirrorLab.ForeColor = System.Drawing.Color.Lime;
            this.pingMirrorLab.Location = new System.Drawing.Point(121, 62);
            this.pingMirrorLab.Name = "pingMirrorLab";
            this.pingMirrorLab.Size = new System.Drawing.Size(12, 11);
            this.pingMirrorLab.TabIndex = 8;
            this.pingMirrorLab.Text = "0";
            this.pingMirrorLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tOutMi
            // 
            this.tOutMi.AutoSize = true;
            this.tOutMi.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOutMi.ForeColor = System.Drawing.Color.Lime;
            this.tOutMi.Location = new System.Drawing.Point(166, 61);
            this.tOutMi.Name = "tOutMi";
            this.tOutMi.Size = new System.Drawing.Size(12, 11);
            this.tOutMi.TabIndex = 9;
            this.tOutMi.Text = "0";
            this.tOutMi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ping88Lab
            // 
            this.ping88Lab.AutoSize = true;
            this.ping88Lab.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ping88Lab.ForeColor = System.Drawing.Color.Lime;
            this.ping88Lab.Location = new System.Drawing.Point(121, 22);
            this.ping88Lab.Name = "ping88Lab";
            this.ping88Lab.Size = new System.Drawing.Size(12, 11);
            this.ping88Lab.TabIndex = 10;
            this.ping88Lab.Text = "0";
            this.ping88Lab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(115, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 11);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ping";
            // 
            // tOutLt
            // 
            this.tOutLt.AutoSize = true;
            this.tOutLt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOutLt.ForeColor = System.Drawing.Color.Lime;
            this.tOutLt.Location = new System.Drawing.Point(166, 48);
            this.tOutLt.Name = "tOutLt";
            this.tOutLt.Size = new System.Drawing.Size(12, 11);
            this.tOutLt.TabIndex = 12;
            this.tOutLt.Text = "0";
            this.tOutLt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tOut44
            // 
            this.tOut44.AutoSize = true;
            this.tOut44.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOut44.ForeColor = System.Drawing.Color.Lime;
            this.tOut44.Location = new System.Drawing.Point(166, 35);
            this.tOut44.Name = "tOut44";
            this.tOut44.Size = new System.Drawing.Size(12, 11);
            this.tOut44.TabIndex = 13;
            this.tOut44.Text = "0";
            this.tOut44.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tOut88
            // 
            this.tOut88.AutoSize = true;
            this.tOut88.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOut88.ForeColor = System.Drawing.Color.Lime;
            this.tOut88.Location = new System.Drawing.Point(166, 22);
            this.tOut88.Name = "tOut88";
            this.tOut88.Size = new System.Drawing.Size(12, 11);
            this.tOut88.TabIndex = 14;
            this.tOut88.Text = "0";
            this.tOut88.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 11);
            this.label7.TabIndex = 15;
            this.label7.Text = "Host";
            // 
            // averageTimer
            // 
            this.averageTimer.Enabled = true;
            this.averageTimer.Tick += new System.EventHandler(this.averageTimer_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(225, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Average";
            // 
            // avLab
            // 
            this.avLab.AutoSize = true;
            this.avLab.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.avLab.ForeColor = System.Drawing.Color.Lime;
            this.avLab.Location = new System.Drawing.Point(249, 35);
            this.avLab.Name = "avLab";
            this.avLab.Size = new System.Drawing.Size(18, 16);
            this.avLab.TabIndex = 17;
            this.avLab.Text = "0";
            this.avLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(313, 84);
            this.Controls.Add(this.avLab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tOut88);
            this.Controls.Add(this.tOut44);
            this.Controls.Add(this.tOutLt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ping88Lab);
            this.Controls.Add(this.tOutMi);
            this.Controls.Add(this.pingMirrorLab);
            this.Controls.Add(this.pingLauntelLab);
            this.Controls.Add(this.ping44Lab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ping44Lab;
        private System.Windows.Forms.Label pingLauntelLab;
        private System.Windows.Forms.Label pingMirrorLab;
        private System.Windows.Forms.Label tOutMi;
        private System.Windows.Forms.Label ping88Lab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tOutLt;
        private System.Windows.Forms.Label tOut44;
        private System.Windows.Forms.Label tOut88;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer averageTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label avLab;
    }
}

