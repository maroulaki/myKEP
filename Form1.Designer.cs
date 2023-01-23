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
            this.back = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.homePanel = new System.Windows.Forms.Panel();
            this.delText = new System.Windows.Forms.Label();
            this.listText = new System.Windows.Forms.Label();
            this.editText = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.PictureBox();
            this.list = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.PictureBox();
            this.addText = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.avatarPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).BeginInit();
            this.SuspendLayout();
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
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.Transparent;
            this.homePanel.Controls.Add(this.delText);
            this.homePanel.Controls.Add(this.listText);
            this.homePanel.Controls.Add(this.editText);
            this.homePanel.Controls.Add(this.edit);
            this.homePanel.Controls.Add(this.list);
            this.homePanel.Controls.Add(this.delete);
            this.homePanel.Controls.Add(this.add);
            this.homePanel.Controls.Add(this.addText);
            this.homePanel.Controls.Add(this.welcome);
            this.homePanel.Controls.Add(this.avatarPB);
            this.homePanel.Location = new System.Drawing.Point(226, 12);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(394, 574);
            this.homePanel.TabIndex = 48;
            // 
            // delText
            // 
            this.delText.AutoSize = true;
            this.delText.BackColor = System.Drawing.Color.Transparent;
            this.delText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delText.Location = new System.Drawing.Point(108, 441);
            this.delText.Name = "delText";
            this.delText.Size = new System.Drawing.Size(218, 70);
            this.delText.TabIndex = 22;
            this.delText.Text = "Διαγραφή αίτησης\r\n\r\n";
            // 
            // listText
            // 
            this.listText.AutoSize = true;
            this.listText.BackColor = System.Drawing.Color.Transparent;
            this.listText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listText.Location = new System.Drawing.Point(108, 376);
            this.listText.Name = "listText";
            this.listText.Size = new System.Drawing.Size(226, 70);
            this.listText.TabIndex = 21;
            this.listText.Text = "Προβολή αιτήσεων\r\n\r\n";
            // 
            // editText
            // 
            this.editText.AutoSize = true;
            this.editText.BackColor = System.Drawing.Color.Transparent;
            this.editText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editText.Location = new System.Drawing.Point(108, 311);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(246, 70);
            this.editText.TabIndex = 20;
            this.editText.Text = "Επεξεργασία αίτησης\r\n\r\n";
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BackgroundImage = global::myKEP.Properties.Resources.edit;
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Location = new System.Drawing.Point(41, 311);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(42, 42);
            this.edit.TabIndex = 19;
            this.edit.TabStop = false;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.Transparent;
            this.list.BackgroundImage = global::myKEP.Properties.Resources.list;
            this.list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list.Location = new System.Drawing.Point(41, 376);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(42, 42);
            this.list.TabIndex = 18;
            this.list.TabStop = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BackgroundImage = global::myKEP.Properties.Resources.trash;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Location = new System.Drawing.Point(41, 441);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(42, 42);
            this.delete.TabIndex = 17;
            this.delete.TabStop = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImage = global::myKEP.Properties.Resources.add;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Location = new System.Drawing.Point(41, 246);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(42, 42);
            this.add.TabIndex = 16;
            this.add.TabStop = false;
            // 
            // addText
            // 
            this.addText.AutoSize = true;
            this.addText.BackColor = System.Drawing.Color.Transparent;
            this.addText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addText.Location = new System.Drawing.Point(108, 248);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(223, 35);
            this.addText.TabIndex = 15;
            this.addText.Text = "Προσθήκη αίτησης";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 21.91304F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.welcome.Location = new System.Drawing.Point(166, 106);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(236, 82);
            this.welcome.TabIndex = 14;
            this.welcome.Text = "Καλώς ορίσατε \r\nστο myKEP";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatarPB
            // 
            this.avatarPB.BackColor = System.Drawing.Color.Transparent;
            this.avatarPB.BackgroundImage = global::myKEP.Properties.Resources.icons8_contact_info_100;
            this.avatarPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarPB.Location = new System.Drawing.Point(5, 49);
            this.avatarPB.Margin = new System.Windows.Forms.Padding(0);
            this.avatarPB.Name = "avatarPB";
            this.avatarPB.Size = new System.Drawing.Size(158, 151);
            this.avatarPB.TabIndex = 13;
            this.avatarPB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 631);
            this.Controls.Add(this.back);
            this.Controls.Add(this.homePanel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "myKEP";
            this.Load += new System.EventHandler(this.myKEP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox back;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel homePanel;
        public System.Windows.Forms.Label delText;
        public System.Windows.Forms.Label listText;
        public System.Windows.Forms.Label editText;
        public System.Windows.Forms.PictureBox edit;
        public System.Windows.Forms.PictureBox list;
        public System.Windows.Forms.PictureBox delete;
        public System.Windows.Forms.PictureBox add;
        public System.Windows.Forms.Label addText;
        public System.Windows.Forms.Label welcome;
        public System.Windows.Forms.PictureBox avatarPB;
    }
}

