namespace myKEP
{
    partial class Form2
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
            this.reqDelLabel = new System.Windows.Forms.Label();
            this.listOptionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ATLabel = new System.Windows.Forms.Label();
            this.ATText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reqDelLabel
            // 
            this.reqDelLabel.AutoSize = true;
            this.reqDelLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqDelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqDelLabel.Location = new System.Drawing.Point(270, 30);
            this.reqDelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reqDelLabel.Name = "reqDelLabel";
            this.reqDelLabel.Size = new System.Drawing.Size(305, 45);
            this.reqDelLabel.TabIndex = 36;
            this.reqDelLabel.Text = "Προβολή αιτήσεων";
            this.reqDelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listOptionButton
            // 
            this.listOptionButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listOptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listOptionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.listOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listOptionButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listOptionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.listOptionButton.Location = new System.Drawing.Point(311, 254);
            this.listOptionButton.Margin = new System.Windows.Forms.Padding(0);
            this.listOptionButton.Name = "listOptionButton";
            this.listOptionButton.Size = new System.Drawing.Size(218, 35);
            this.listOptionButton.TabIndex = 49;
            this.listOptionButton.Text = "Προβολή αιτήσεων πολίτη";
            this.listOptionButton.UseVisualStyleBackColor = false;
            this.listOptionButton.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(311, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 35);
            this.button1.TabIndex = 50;
            this.button1.Text = "Προβολή όλων";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // ATLabel
            // 
            this.ATLabel.AutoSize = true;
            this.ATLabel.BackColor = System.Drawing.Color.Transparent;
            this.ATLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATLabel.Location = new System.Drawing.Point(307, 183);
            this.ATLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ATLabel.Name = "ATLabel";
            this.ATLabel.Size = new System.Drawing.Size(157, 21);
            this.ATLabel.TabIndex = 52;
            this.ATLabel.Text = "Αριθμός Ταυτότητας";
            this.ATLabel.Visible = false;
            // 
            // ATText
            // 
            this.ATText.BackColor = System.Drawing.SystemColors.Window;
            this.ATText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATText.Location = new System.Drawing.Point(311, 206);
            this.ATText.Margin = new System.Windows.Forms.Padding(2);
            this.ATText.Name = "ATText";
            this.ATText.Size = new System.Drawing.Size(218, 29);
            this.ATText.TabIndex = 51;
            this.ATText.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 631);
            this.Controls.Add(this.ATLabel);
            this.Controls.Add(this.ATText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listOptionButton);
            this.Controls.Add(this.reqDelLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reqDelLabel;
        private System.Windows.Forms.Button listOptionButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ATLabel;
        private System.Windows.Forms.TextBox ATText;
    }
}