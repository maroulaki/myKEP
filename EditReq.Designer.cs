namespace myKEP
{
    partial class EditReq
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
            this.reqEditButton = new System.Windows.Forms.Button();
            this.newReqLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reqEditButton
            // 
            this.reqEditButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reqEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reqEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reqEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqEditButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqEditButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reqEditButton.Location = new System.Drawing.Point(303, 515);
            this.reqEditButton.Margin = new System.Windows.Forms.Padding(0);
            this.reqEditButton.Name = "reqEditButton";
            this.reqEditButton.Size = new System.Drawing.Size(215, 43);
            this.reqEditButton.TabIndex = 81;
            this.reqEditButton.Text = "Ενημέρωση\r\n";
            this.reqEditButton.UseVisualStyleBackColor = false;
            this.reqEditButton.Click += new System.EventHandler(this.reqEditButton_Click);
            // 
            // newReqLabel
            // 
            this.newReqLabel.AutoSize = true;
            this.newReqLabel.BackColor = System.Drawing.Color.Transparent;
            this.newReqLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newReqLabel.Location = new System.Drawing.Point(213, 10);
            this.newReqLabel.Name = "newReqLabel";
            this.newReqLabel.Size = new System.Drawing.Size(394, 51);
            this.newReqLabel.TabIndex = 72;
            this.newReqLabel.Tag = "";
            this.newReqLabel.Text = "Επεξεργασία αίτησης\r\n";
            this.newReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.typeLabel.Location = new System.Drawing.Point(216, 200);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(186, 36);
            this.typeLabel.TabIndex = 83;
            this.typeLabel.Text = "Τύπος αίτησης";
            
            // 
            // typeField
            // 
            this.typeField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.typeField.FormattingEnabled = true;
            this.typeField.Items.AddRange(new object[] {
            "Μεταβίβαση οχήματος",
            "Έναρξη εργασιών επιχείρησης",
            "Πιστοποιητικό γάμου",
            "Αποποίηση κληρονομιάς",
            "Διαγραφή από μητρώο",
            "Νέο μισθωτήριο κατοικίας"});
            this.typeField.Location = new System.Drawing.Point(222, 238);
            this.typeField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(385, 33);
            this.typeField.TabIndex = 82;
            // 
            // EditReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 582);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeField);
            this.Controls.Add(this.reqEditButton);
            this.Controls.Add(this.newReqLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditReq";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reqEditButton;
        private System.Windows.Forms.Label newReqLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeField;
    }
}