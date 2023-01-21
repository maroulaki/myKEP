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
            this.surnameText = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listOptionButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reqDelLabel
            // 
            this.reqDelLabel.AutoSize = true;
            this.reqDelLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqDelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqDelLabel.Location = new System.Drawing.Point(270, 40);
            this.reqDelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reqDelLabel.Name = "reqDelLabel";
            this.reqDelLabel.Size = new System.Drawing.Size(294, 45);
            this.reqDelLabel.TabIndex = 36;
            this.reqDelLabel.Text = "Διαγραφή αίτησης";
            this.reqDelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameText
            // 
            this.surnameText.BackColor = System.Drawing.SystemColors.Window;
            this.surnameText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameText.Location = new System.Drawing.Point(150, 257);
            this.surnameText.Margin = new System.Windows.Forms.Padding(2);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(182, 29);
            this.surnameText.TabIndex = 37;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameLabel.Location = new System.Drawing.Point(145, 230);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(157, 25);
            this.surnameLabel.TabIndex = 38;
            this.surnameLabel.Text = "Κωδικός αίτησης";
            this.surnameLabel.Click += new System.EventHandler(this.surnameLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(505, 257);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 29);
            this.textBox1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(500, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Αριθμός Ταυτότητας";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // listOptionButton
            // 
            this.listOptionButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listOptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listOptionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.listOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listOptionButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listOptionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.listOptionButton.Location = new System.Drawing.Point(150, 315);
            this.listOptionButton.Margin = new System.Windows.Forms.Padding(0);
            this.listOptionButton.Name = "listOptionButton";
            this.listOptionButton.Size = new System.Drawing.Size(182, 35);
            this.listOptionButton.TabIndex = 41;
            this.listOptionButton.Text = "Διαγραφή";
            this.listOptionButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(505, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 57);
            this.button1.TabIndex = 42;
            this.button1.Text = "Προβολή αιτήσεων \r\nγια διαγραφή\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listOptionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.surnameText);
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
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listOptionButton;
        private System.Windows.Forms.Button button1;
    }
}