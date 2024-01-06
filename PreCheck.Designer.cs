namespace MissionPlanner
{
    partial class PreCheck
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
            this.Motor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Motor
            // 
            this.Motor.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.Motor.AutoEllipsis = true;
            this.Motor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motor.ForeColor = System.Drawing.Color.Chartreuse;
            this.Motor.Location = new System.Drawing.Point(68, 56);
            this.Motor.MaximumSize = new System.Drawing.Size(125, 50);
            this.Motor.Name = "Motor";
            this.Motor.Size = new System.Drawing.Size(125, 50);
            this.Motor.TabIndex = 0;
            this.Motor.Text = "MotorTested";
            this.Motor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Motor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Motor.UseMnemonic = false;
            this.Motor.UseVisualStyleBackColor = true;
            this.Motor.CheckedChanged += new System.EventHandler(this.Motor_CheckedChanged);
            // 
            // PreCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Motor);
            this.Name = "PreCheck";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "CheckList";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox Motor;
    }
}