namespace myKEP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.avatarPB = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.addText = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.list = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.PictureBox();
            this.editText = new System.Windows.Forms.Label();
            this.listText = new System.Windows.Forms.Label();
            this.delText = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
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
            this.welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 21.91304F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.welcome.Location = new System.Drawing.Point(378, 95);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(276, 94);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Καλώς ορίσατε \r\nστο myKEP";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcome.Click += new System.EventHandler(this.welcomeText_Click);
            // 
            // addText
            // 
            this.addText.AutoSize = true;
            this.addText.BackColor = System.Drawing.Color.Transparent;
            this.addText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addText.Location = new System.Drawing.Point(320, 237);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(259, 40);
            this.addText.TabIndex = 2;
            this.addText.Text = "Προσθήκη αίτησης";
            this.addText.Click += new System.EventHandler(this.addText_Click);
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
            // editText
            // 
            this.editText.AutoSize = true;
            this.editText.BackColor = System.Drawing.Color.Transparent;
            this.editText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editText.Location = new System.Drawing.Point(320, 300);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(289, 80);
            this.editText.TabIndex = 10;
            this.editText.Text = "Επεξεργασία αίτησης\r\n\r\n";
            this.editText.Click += new System.EventHandler(this.editText_Click);
            // 
            // listText
            // 
            this.listText.AutoSize = true;
            this.listText.BackColor = System.Drawing.Color.Transparent;
            this.listText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listText.Location = new System.Drawing.Point(320, 365);
            this.listText.Name = "listText";
            this.listText.Size = new System.Drawing.Size(263, 80);
            this.listText.TabIndex = 11;
            this.listText.Text = "Προβολή αιτήσεων\r\n\r\n";
            this.listText.Click += new System.EventHandler(this.listText_Click);
            // 
            // delText
            // 
            this.delText.AutoSize = true;
            this.delText.BackColor = System.Drawing.Color.Transparent;
            this.delText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delText.Location = new System.Drawing.Point(320, 430);
            this.delText.Name = "delText";
            this.delText.Size = new System.Drawing.Size(255, 80);
            this.delText.TabIndex = 12;
            this.delText.Text = "Διαγραφή αίτησης\r\n\r\n";
            this.delText.Click += new System.EventHandler(this.delText_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::myKEP.Properties.Resources.icons8_go_back_80;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(28, 541);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(60, 60);
            this.back.TabIndex = 13;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // myKEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 625);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delText);
            this.Controls.Add(this.listText);
            this.Controls.Add(this.editText);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.list);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.addText);
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
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox avatarPB;
        public System.Windows.Forms.Label welcome;
        public System.Windows.Forms.PictureBox add;
        public System.Windows.Forms.PictureBox delete;
        public System.Windows.Forms.PictureBox list;
        public System.Windows.Forms.PictureBox edit;
        public System.Windows.Forms.Label editText;
        public System.Windows.Forms.Label listText;
        public System.Windows.Forms.Label delText;
        public System.Windows.Forms.Label addText;
        public System.Windows.Forms.PictureBox back;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

