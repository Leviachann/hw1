
namespace part2ofhw1
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
            this.dontclick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dontclick
            // 
            this.dontclick.Location = new System.Drawing.Point(316, 112);
            this.dontclick.Name = "dontclick";
            this.dontclick.Size = new System.Drawing.Size(75, 23);
            this.dontclick.TabIndex = 0;
            this.dontclick.Text = "Do not Click";
            this.dontclick.UseVisualStyleBackColor = true;
            this.dontclick.Click += new System.EventHandler(this.dontclick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dontclick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dontclick;
    }
}

