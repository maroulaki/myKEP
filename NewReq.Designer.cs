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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReq));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.reqEnterButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.typeField = new System.Windows.Forms.ComboBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.addressField = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newReqLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.ATLabel = new System.Windows.Forms.Label();
            this.ATField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reqEnterButton
            // 
            this.reqEnterButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reqEnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reqEnterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reqEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqEnterButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqEnterButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reqEnterButton.Location = new System.Drawing.Point(298, 515);
            this.reqEnterButton.Margin = new System.Windows.Forms.Padding(0);
            this.reqEnterButton.Name = "reqEnterButton";
            this.reqEnterButton.Size = new System.Drawing.Size(215, 43);
            this.reqEnterButton.TabIndex = 55;
            this.reqEnterButton.Text = "Καταχώριση";
            this.reqEnterButton.UseVisualStyleBackColor = false;
            this.reqEnterButton.Click += new System.EventHandler(this.reqEnterButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.typeLabel.Location = new System.Drawing.Point(447, 305);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(144, 28);
            this.typeLabel.TabIndex = 54;
            this.typeLabel.Text = "Τύπος αίτησης";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressLabel.Location = new System.Drawing.Point(447, 184);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(297, 50);
            this.addressLabel.TabIndex = 53;
            this.addressLabel.Text = "Διεύθυνση κατοικίας\r\n(Νομός, Πόλη, Οδός, Αριθμός, ΤΚ)\r\n";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dobLabel.Location = new System.Drawing.Point(446, 108);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(214, 28);
            this.dobLabel.TabIndex = 52;
            this.dobLabel.Text = "Ημερομηνία γέννησης";
            // 
            // typeField
            // 
            this.typeField.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.typeField.FormattingEnabled = true;
            this.typeField.Items.AddRange(new object[] {
            "Μεταβίβαση οχήματος",
            "Έναρξη εργασιών επιχείρησης",
            "Πιστοποιητικό γάμου",
            "Αποποίηση κληρονομιάς",
            "Διαγραφή από μητρώο",
            "Νέο μισθωτήριο κατοικίας"});
            this.typeField.Location = new System.Drawing.Point(451, 333);
            this.typeField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(289, 29);
            this.typeField.TabIndex = 51;
            this.typeField.SelectedIndexChanged += new System.EventHandler(this.typeManu_SelectedIndexChanged);
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(452, 136);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(201, 23);
            this.dobPicker.TabIndex = 50;
            // 
            // addressField
            // 
            this.addressField.BackColor = System.Drawing.SystemColors.Window;
            this.addressField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressField.Location = new System.Drawing.Point(451, 236);
            this.addressField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(316, 33);
            this.addressField.TabIndex = 49;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailLabel.Location = new System.Drawing.Point(139, 403);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 28);
            this.emailLabel.TabIndex = 48;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameLabel.Location = new System.Drawing.Point(139, 108);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 28);
            this.nameLabel.TabIndex = 47;
            this.nameLabel.Text = "\'Ονομα";
            // 
            // newReqLabel
            // 
            this.newReqLabel.AutoSize = true;
            this.newReqLabel.BackColor = System.Drawing.Color.Transparent;
            this.newReqLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newReqLabel.Location = new System.Drawing.Point(289, 9);
            this.newReqLabel.Name = "newReqLabel";
            this.newReqLabel.Size = new System.Drawing.Size(224, 51);
            this.newReqLabel.TabIndex = 46;
            this.newReqLabel.Tag = "";
            this.newReqLabel.Text = "Νέα αίτηση";
            this.newReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameLabel.Location = new System.Drawing.Point(139, 206);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(97, 28);
            this.surnameLabel.TabIndex = 45;
            this.surnameLabel.Text = "Επώνυμο";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneLabel.Location = new System.Drawing.Point(139, 305);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(106, 28);
            this.phoneLabel.TabIndex = 44;
            this.phoneLabel.Text = "Τηλέφωνο";
            // 
            // emailField
            // 
            this.emailField.BackColor = System.Drawing.SystemColors.Window;
            this.emailField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailField.Location = new System.Drawing.Point(144, 431);
            this.emailField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(197, 33);
            this.emailField.TabIndex = 43;
            // 
            // phoneField
            // 
            this.phoneField.BackColor = System.Drawing.SystemColors.Window;
            this.phoneField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneField.Location = new System.Drawing.Point(144, 333);
            this.phoneField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(197, 33);
            this.phoneField.TabIndex = 42;
            // 
            // surnameField
            // 
            this.surnameField.BackColor = System.Drawing.SystemColors.Window;
            this.surnameField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameField.Location = new System.Drawing.Point(144, 234);
            this.surnameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(197, 33);
            this.surnameField.TabIndex = 41;
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.SystemColors.Window;
            this.nameField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameField.Location = new System.Drawing.Point(144, 136);
            this.nameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(197, 33);
            this.nameField.TabIndex = 40;
            // 
            // ATLabel
            // 
            this.ATLabel.AutoSize = true;
            this.ATLabel.BackColor = System.Drawing.Color.Transparent;
            this.ATLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATLabel.Location = new System.Drawing.Point(447, 403);
            this.ATLabel.Name = "ATLabel";
            this.ATLabel.Size = new System.Drawing.Size(200, 28);
            this.ATLabel.TabIndex = 65;
            this.ATLabel.Text = "Αριθμός Ταυτότητας";
            this.ATLabel.Click += new System.EventHandler(this.ATLabel_Click);
            // 
            // ATField
            // 
            this.ATField.BackColor = System.Drawing.SystemColors.Window;
            this.ATField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATField.Location = new System.Drawing.Point(451, 431);
            this.ATField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ATField.Name = "ATField";
            this.ATField.Size = new System.Drawing.Size(241, 33);
            this.ATField.TabIndex = 64;
            // 
            // NewReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 582);
            this.Controls.Add(this.ATLabel);
            this.Controls.Add(this.ATField);
            this.Controls.Add(this.reqEnterButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.newReqLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.typeField);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewReq";
            this.Text = "myKEP";
            this.Load += new System.EventHandler(this.myKEP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button reqEnterButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.ComboBox typeField;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label newReqLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label ATLabel;
        private System.Windows.Forms.TextBox ATField;
    }
}

