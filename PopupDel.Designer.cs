namespace myKEP
{
    partial class PopupDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupDel));
            this.desc = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.delResponse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.desc.Location = new System.Drawing.Point(104, 9);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(171, 25);
            this.desc.TabIndex = 60;
            this.desc.Text = "Επιλέξτε διαγραφή\r\n";
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OK.Location = new System.Drawing.Point(83, 115);
            this.OK.Margin = new System.Windows.Forms.Padding(0);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(217, 31);
            this.OK.TabIndex = 61;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            // 
            // delResponse
            // 
            this.delResponse.Font = new System.Drawing.Font("Segoe UI", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delResponse.FormattingEnabled = true;
            this.delResponse.Items.AddRange(new object[] {
            "Διαγραφή αίτησης",
            "Διαγραφή χρήστη"});
            this.delResponse.Location = new System.Drawing.Point(83, 64);
            this.delResponse.Name = "delResponse";
            this.delResponse.Size = new System.Drawing.Size(217, 33);
            this.delResponse.TabIndex = 62;
            // 
            // PopupDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 155);
            this.Controls.Add(this.delResponse);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.desc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopupDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label desc;
        public System.Windows.Forms.Button OK;
        public System.Windows.Forms.ComboBox delResponse;
    }
}