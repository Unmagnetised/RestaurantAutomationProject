
namespace restoranDeneme2
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
            this.button1 = new System.Windows.Forms.Button();
            this.masaNoTxt = new System.Windows.Forms.Label();
            this.numberOfTableTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(123, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // masaNoTxt
            // 
            this.masaNoTxt.AutoSize = true;
            this.masaNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masaNoTxt.Location = new System.Drawing.Point(87, 9);
            this.masaNoTxt.Name = "masaNoTxt";
            this.masaNoTxt.Size = new System.Drawing.Size(204, 24);
            this.masaNoTxt.TabIndex = 1;
            this.masaNoTxt.Text = "Enter the # of Tables";
            // 
            // numberOfTableTxt
            // 
            this.numberOfTableTxt.Location = new System.Drawing.Point(123, 44);
            this.numberOfTableTxt.Name = "numberOfTableTxt";
            this.numberOfTableTxt.Size = new System.Drawing.Size(130, 20);
            this.numberOfTableTxt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 137);
            this.Controls.Add(this.numberOfTableTxt);
            this.Controls.Add(this.masaNoTxt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label masaNoTxt;
        private System.Windows.Forms.TextBox numberOfTableTxt;
    }
}

