namespace WindowsFormsApplication1
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
            this.CatchMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatchMeButton
            // 
            this.CatchMeButton.Location = new System.Drawing.Point(394, 210);
            this.CatchMeButton.Name = "CatchMeButton";
            this.CatchMeButton.Size = new System.Drawing.Size(68, 51);
            this.CatchMeButton.TabIndex = 0;
            this.CatchMeButton.Text = "Цъкни Тук !";
            this.CatchMeButton.UseVisualStyleBackColor = true;
            this.CatchMeButton.LocationChanged += new System.EventHandler(this.CatchMeButton_LocationChanged);
            this.CatchMeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CatchMeButton_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 553);
            this.Controls.Add(this.CatchMeButton);
            this.Name = "Form1";
            this.Text = "Генератор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CatchMeButton;
    }
}

