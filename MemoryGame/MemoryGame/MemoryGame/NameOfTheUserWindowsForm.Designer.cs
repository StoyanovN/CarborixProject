namespace MemoryGame
{
    partial class NameOfTheUserWindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameOfTheUserWindowsForm));
            this.lblEnterYourName = new System.Windows.Forms.Label();
            this.txtBoxPlayerName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterYourName
            // 
            this.lblEnterYourName.AutoSize = true;
            this.lblEnterYourName.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterYourName.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnterYourName.Location = new System.Drawing.Point(795, 141);
            this.lblEnterYourName.Name = "lblEnterYourName";
            this.lblEnterYourName.Size = new System.Drawing.Size(398, 76);
            this.lblEnterYourName.TabIndex = 0;
            this.lblEnterYourName.Text = "Enter Your Name";
            // 
            // txtBoxPlayerName
            // 
            this.txtBoxPlayerName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxPlayerName.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPlayerName.Location = new System.Drawing.Point(808, 258);
            this.txtBoxPlayerName.MaxLength = 120;
            this.txtBoxPlayerName.Name = "txtBoxPlayerName";
            this.txtBoxPlayerName.Size = new System.Drawing.Size(382, 43);
            this.txtBoxPlayerName.TabIndex = 1;
            this.txtBoxPlayerName.TextChanged += new System.EventHandler(this.txtBoxPlayerName_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(1032, 571);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 58);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameOfTheUserWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1259, 654);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxPlayerName);
            this.Controls.Add(this.lblEnterYourName);
            this.Name = "NameOfTheUserWindowsForm";
            this.Text = "NameOfTheUserWindowsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterYourName;
        private System.Windows.Forms.TextBox txtBoxPlayerName;
        private System.Windows.Forms.Button btnBack;
    }
}