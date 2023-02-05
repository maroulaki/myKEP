namespace myKEP
{
    partial class PopupAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupAT));
            this.OK = new System.Windows.Forms.Button();
            this.Response = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.OK.Location = new System.Drawing.Point(70, 109);
            this.OK.Margin = new System.Windows.Forms.Padding(0);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(217, 31);
            this.OK.TabIndex = 59;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            // 
            // Response
            // 
            this.Response.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Response.Location = new System.Drawing.Point(70, 61);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(217, 33);
            this.Response.TabIndex = 58;
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.desc.Location = new System.Drawing.Point(22, 14);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(339, 25);
            this.desc.TabIndex = 57;
            this.desc.Text = "Συμπληρώστε τον Αριθμό Ταυτότητας";
            // 
            // PopupAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 155);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.desc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopupAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button OK;
        public System.Windows.Forms.TextBox Response;
        private System.Windows.Forms.Label desc;
    }
}