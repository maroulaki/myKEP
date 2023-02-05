namespace myKEP
{
    partial class DelReq
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
            this.delReqPanel = new System.Windows.Forms.Panel();
            this.DelByATButton = new System.Windows.Forms.Button();
            this.ATLabel = new System.Windows.Forms.Label();
            this.ATText = new System.Windows.Forms.TextBox();
            this.delButton = new System.Windows.Forms.Button();
            this.reqIDLabel = new System.Windows.Forms.Label();
            this.reqIDText = new System.Windows.Forms.TextBox();
            this.reqDelLabel = new System.Windows.Forms.Label();
            this.delReqPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // delReqPanel
            // 
            this.delReqPanel.BackColor = System.Drawing.Color.Transparent;
            this.delReqPanel.Controls.Add(this.DelByATButton);
            this.delReqPanel.Controls.Add(this.ATLabel);
            this.delReqPanel.Controls.Add(this.ATText);
            this.delReqPanel.Controls.Add(this.delButton);
            this.delReqPanel.Controls.Add(this.reqIDLabel);
            this.delReqPanel.Controls.Add(this.reqIDText);
            this.delReqPanel.Controls.Add(this.reqDelLabel);
            this.delReqPanel.Location = new System.Drawing.Point(65, 6);
            this.delReqPanel.Margin = new System.Windows.Forms.Padding(4);
            this.delReqPanel.Name = "delReqPanel";
            this.delReqPanel.Size = new System.Drawing.Size(988, 631);
            this.delReqPanel.TabIndex = 58;
            this.delReqPanel.Visible = false;
            // 
            // DelByATButton
            // 
            this.DelByATButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DelByATButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelByATButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelByATButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelByATButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DelByATButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelByATButton.Location = new System.Drawing.Point(620, 361);
            this.DelByATButton.Margin = new System.Windows.Forms.Padding(0);
            this.DelByATButton.Name = "DelByATButton";
            this.DelByATButton.Size = new System.Drawing.Size(243, 70);
            this.DelByATButton.TabIndex = 64;
            this.DelByATButton.Text = "Προβολή αιτήσεων \r\nγια διαγραφή\r\n";
            this.DelByATButton.UseVisualStyleBackColor = false;
            // 
            // ATLabel
            // 
            this.ATLabel.AutoSize = true;
            this.ATLabel.BackColor = System.Drawing.Color.Transparent;
            this.ATLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATLabel.Location = new System.Drawing.Point(615, 290);
            this.ATLabel.Name = "ATLabel";
            this.ATLabel.Size = new System.Drawing.Size(200, 28);
            this.ATLabel.TabIndex = 63;
            this.ATLabel.Text = "Αριθμός Ταυτότητας";
            // 
            // ATText
            // 
            this.ATText.BackColor = System.Drawing.SystemColors.Window;
            this.ATText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATText.Location = new System.Drawing.Point(620, 319);
            this.ATText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ATText.Name = "ATText";
            this.ATText.Size = new System.Drawing.Size(241, 33);
            this.ATText.TabIndex = 62;
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delButton.Location = new System.Drawing.Point(127, 357);
            this.delButton.Margin = new System.Windows.Forms.Padding(0);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(243, 43);
            this.delButton.TabIndex = 61;
            this.delButton.Text = "Διαγραφή";
            this.delButton.UseVisualStyleBackColor = false;
            // 
            // reqIDLabel
            // 
            this.reqIDLabel.AutoSize = true;
            this.reqIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqIDLabel.Location = new System.Drawing.Point(121, 290);
            this.reqIDLabel.Name = "reqIDLabel";
            this.reqIDLabel.Size = new System.Drawing.Size(165, 28);
            this.reqIDLabel.TabIndex = 60;
            this.reqIDLabel.Text = "Κωδικός αίτησης";
            // 
            // reqIDText
            // 
            this.reqIDText.BackColor = System.Drawing.SystemColors.Window;
            this.reqIDText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqIDText.Location = new System.Drawing.Point(127, 319);
            this.reqIDText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reqIDText.Name = "reqIDText";
            this.reqIDText.Size = new System.Drawing.Size(241, 33);
            this.reqIDText.TabIndex = 59;
            // 
            // reqDelLabel
            // 
            this.reqDelLabel.AutoSize = true;
            this.reqDelLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqDelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqDelLabel.Location = new System.Drawing.Point(288, 16);
            this.reqDelLabel.Name = "reqDelLabel";
            this.reqDelLabel.Size = new System.Drawing.Size(350, 51);
            this.reqDelLabel.TabIndex = 58;
            this.reqDelLabel.Text = "Διαγραφή αίτησης";
            this.reqDelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DelReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 642);
            this.Controls.Add(this.delReqPanel);
            this.Name = "DelReq";
            this.Text = "DelReq";
            this.delReqPanel.ResumeLayout(false);
            this.delReqPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel delReqPanel;
        private System.Windows.Forms.Button DelByATButton;
        private System.Windows.Forms.Label ATLabel;
        private System.Windows.Forms.TextBox ATText;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label reqIDLabel;
        private System.Windows.Forms.TextBox reqIDText;
        private System.Windows.Forms.Label reqDelLabel;
    }
}