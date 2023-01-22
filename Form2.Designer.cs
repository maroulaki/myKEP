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
            this.prevDateLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.addressText = new System.Windows.Forms.TextBox();
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
            // prevDateLabel
            // 
            this.prevDateLabel.AutoSize = true;
            this.prevDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.prevDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevDateLabel.Location = new System.Drawing.Point(631, 153);
            this.prevDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prevDateLabel.Name = "prevDateLabel";
            this.prevDateLabel.Size = new System.Drawing.Size(123, 17);
            this.prevDateLabel.TabIndex = 47;
            this.prevDateLabel.Text = "(Καταγεγραμμένη: )";
            this.prevDateLabel.Visible = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressLabel.Location = new System.Drawing.Point(471, 186);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(242, 42);
            this.addressLabel.TabIndex = 46;
            this.addressLabel.Text = "Διεύθυνση κατοικίας\r\n(Νομός, Πόλη, Οδός, Αριθμός, ΤΚ)\r\n";
            this.addressLabel.Visible = false;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dobLabel.Location = new System.Drawing.Point(471, 127);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(164, 21);
            this.dobLabel.TabIndex = 45;
            this.dobLabel.Text = "Ημερομηνία γέννησης";
            this.dobLabel.Visible = false;
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(475, 150);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(152, 20);
            this.dobPicker.TabIndex = 44;
            this.dobPicker.Visible = false;
            // 
            // addressText
            // 
            this.addressText.BackColor = System.Drawing.SystemColors.Window;
            this.addressText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressText.Location = new System.Drawing.Point(310, 362);
            this.addressText.Margin = new System.Windows.Forms.Padding(2);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(238, 29);
            this.addressText.TabIndex = 43;
            this.addressText.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 631);
            this.Controls.Add(this.prevDateLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.addressText);
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
        private System.Windows.Forms.Label prevDateLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox addressText;
    }
}