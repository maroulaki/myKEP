namespace myKEP
{
    partial class NewReq
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
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeField = new System.Windows.Forms.ComboBox();
            this.newReqButton = new System.Windows.Forms.Button();
            this.newReqLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.typeLabel.Location = new System.Drawing.Point(238, 207);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(186, 36);
            this.typeLabel.TabIndex = 87;
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
            this.typeField.Location = new System.Drawing.Point(244, 245);
            this.typeField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(385, 33);
            this.typeField.TabIndex = 86;
            // 
            // newReqButton
            // 
            this.newReqButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newReqButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newReqButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newReqButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newReqButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newReqButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newReqButton.Location = new System.Drawing.Point(325, 522);
            this.newReqButton.Margin = new System.Windows.Forms.Padding(0);
            this.newReqButton.Name = "newReqButton";
            this.newReqButton.Size = new System.Drawing.Size(215, 43);
            this.newReqButton.TabIndex = 85;
            this.newReqButton.Text = "Καταχώριση";
            this.newReqButton.UseVisualStyleBackColor = false;
            this.newReqButton.Click += new System.EventHandler(this.newReqButton_Click);
            // 
            // newReqLabel
            // 
            this.newReqLabel.AutoSize = true;
            this.newReqLabel.BackColor = System.Drawing.Color.Transparent;
            this.newReqLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newReqLabel.Location = new System.Drawing.Point(316, 9);
            this.newReqLabel.Name = "newReqLabel";
            this.newReqLabel.Size = new System.Drawing.Size(224, 51);
            this.newReqLabel.TabIndex = 84;
            this.newReqLabel.Tag = "";
            this.newReqLabel.Text = "Νέα αίτηση";
            this.newReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 582);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeField);
            this.Controls.Add(this.newReqButton);
            this.Controls.Add(this.newReqLabel);
            this.Name = "NewReq";
            this.Text = "NewReq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeField;
        private System.Windows.Forms.Button newReqButton;
        private System.Windows.Forms.Label newReqLabel;
    }
}