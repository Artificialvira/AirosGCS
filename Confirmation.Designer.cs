namespace MissionPlanner
{
    partial class Confirmation
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
            this.lbattitude = new System.Windows.Forms.Label();
            this.llmessage = new System.Windows.Forms.Label();
            this.llongitude = new System.Windows.Forms.Label();
            this.wb_but = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbattitude
            // 
            this.lbattitude.AutoSize = true;
            this.lbattitude.Location = new System.Drawing.Point(35, 39);
            this.lbattitude.MaximumSize = new System.Drawing.Size(100, 40);
            this.lbattitude.MinimumSize = new System.Drawing.Size(64, 29);
            this.lbattitude.Name = "lbattitude";
            this.lbattitude.Size = new System.Drawing.Size(64, 29);
            this.lbattitude.TabIndex = 0;
            this.lbattitude.Text = "Lattitude";
            this.lbattitude.Click += new System.EventHandler(this.label1_Click);
            // 
            // llmessage
            // 
            this.llmessage.AutoSize = true;
            this.llmessage.Location = new System.Drawing.Point(33, 130);
            this.llmessage.MaximumSize = new System.Drawing.Size(100, 40);
            this.llmessage.MinimumSize = new System.Drawing.Size(64, 29);
            this.llmessage.Name = "llmessage";
            this.llmessage.Size = new System.Drawing.Size(64, 29);
            this.llmessage.TabIndex = 1;
            this.llmessage.Text = "Message";
            // 
            // llongitude
            // 
            this.llongitude.AutoSize = true;
            this.llongitude.Location = new System.Drawing.Point(33, 84);
            this.llongitude.MaximumSize = new System.Drawing.Size(100, 40);
            this.llongitude.MinimumSize = new System.Drawing.Size(64, 29);
            this.llongitude.Name = "llongitude";
            this.llongitude.Size = new System.Drawing.Size(66, 29);
            this.llongitude.TabIndex = 2;
            this.llongitude.Text = "Longitude";
            // 
            // wb_but
            // 
            this.wb_but.Location = new System.Drawing.Point(256, 169);
            this.wb_but.Name = "wb_but";
            this.wb_but.Size = new System.Drawing.Size(92, 32);
            this.wb_but.TabIndex = 3;
            this.wb_but.Text = "Load";
            this.wb_but.UseVisualStyleBackColor = true;
            this.wb_but.Click += new System.EventHandler(this.wb_but_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 39);
            this.label1.MaximumSize = new System.Drawing.Size(100, 40);
            this.label1.MinimumSize = new System.Drawing.Size(94, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 84);
            this.label2.MaximumSize = new System.Drawing.Size(100, 40);
            this.label2.MinimumSize = new System.Drawing.Size(94, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 130);
            this.label3.MaximumSize = new System.Drawing.Size(100, 40);
            this.label3.MinimumSize = new System.Drawing.Size(94, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 7;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wb_but);
            this.Controls.Add(this.llongitude);
            this.Controls.Add(this.llmessage);
            this.Controls.Add(this.lbattitude);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbattitude;
        private System.Windows.Forms.Label llmessage;
        private System.Windows.Forms.Label llongitude;
        private System.Windows.Forms.Button wb_but;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}