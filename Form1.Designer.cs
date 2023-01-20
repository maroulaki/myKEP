namespace myKEP
{
    partial class myKEP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myKEP));
            this.avatarPB = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.list = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarPB
            // 
            this.avatarPB.BackColor = System.Drawing.Color.Transparent;
            this.avatarPB.BackgroundImage = global::myKEP.Properties.Resources.icons8_contact_info_100;
            this.avatarPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarPB.Location = new System.Drawing.Point(217, 38);
            this.avatarPB.Margin = new System.Windows.Forms.Padding(0);
            this.avatarPB.Name = "avatarPB";
            this.avatarPB.Size = new System.Drawing.Size(158, 151);
            this.avatarPB.TabIndex = 0;
            this.avatarPB.TabStop = false;
            this.avatarPB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 21.91304F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.welcome.Location = new System.Drawing.Point(378, 95);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(268, 94);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Καλώς ορίσατε \r\nστο myKEP";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Προσθήκη αίτησης";
            this.label2.Click += new System.EventHandler(this.addText_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImage = global::myKEP.Properties.Resources.add;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Location = new System.Drawing.Point(253, 235);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(42, 42);
            this.add.TabIndex = 6;
            this.add.TabStop = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BackgroundImage = global::myKEP.Properties.Resources.trash;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Location = new System.Drawing.Point(253, 430);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(42, 42);
            this.delete.TabIndex = 7;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.Transparent;
            this.list.BackgroundImage = global::myKEP.Properties.Resources.list;
            this.list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list.Location = new System.Drawing.Point(253, 365);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(42, 42);
            this.list.TabIndex = 8;
            this.list.TabStop = false;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BackgroundImage = global::myKEP.Properties.Resources.edit;
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Location = new System.Drawing.Point(253, 300);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(42, 42);
            this.edit.TabIndex = 9;
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 80);
            this.label1.TabIndex = 10;
            this.label1.Text = "Επεξεργασία αίτησης\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.editText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 80);
            this.label3.TabIndex = 11;
            this.label3.Text = "Προβολή αιτήσεων\r\n\r\n";
            this.label3.Click += new System.EventHandler(this.listText_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 80);
            this.label4.TabIndex = 12;
            this.label4.Text = "Διαγραφή αίτησης\r\n\r\n";
            this.label4.Click += new System.EventHandler(this.delText_Click);
            // 
            // myKEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 625);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.list);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.avatarPB);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "myKEP";
            this.Text = "myKEP";
            this.Load += new System.EventHandler(this.myKEP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarPB;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox add;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox list;
        private System.Windows.Forms.PictureBox edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

