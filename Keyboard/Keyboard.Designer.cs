namespace Keyboard
{
    partial class Keyboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keyboard));
            this.label9 = new System.Windows.Forms.Label();
            this.lbCaption = new System.Windows.Forms.Label();
            this.lblCoords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(30, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Message:";
            // 
            // lbCaption
            // 
            this.lbCaption.Location = new System.Drawing.Point(27, 29);
            this.lbCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(978, 46);
            this.lbCaption.TabIndex = 23;
            this.lbCaption.Text = "Press any key on an attached keyboard to see details of the input device and the " +
    "key(s) you pressed.";
            // 
            // lblCoords
            // 
            this.lblCoords.AutoSize = true;
            this.lblCoords.Location = new System.Drawing.Point(94, 114);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(51, 20);
            this.lblCoords.TabIndex = 25;
            this.lblCoords.Text = "label1";
            // 
            // Keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 497);
            this.Controls.Add(this.lblCoords);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Keyboard";
            this.Text = "Raw Keyboard Input";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Keyboard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCaption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCoords;
    }
}

