namespace myKEP
{
    partial class EditUser
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
            this.userEditButton = new System.Windows.Forms.Button();
            this.newReqLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.emailField = new System.Windows.Forms.TextBox();
            this.addressField = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userEditButton
            // 
            this.userEditButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.userEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userEditButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.userEditButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userEditButton.Location = new System.Drawing.Point(301, 513);
            this.userEditButton.Margin = new System.Windows.Forms.Padding(0);
            this.userEditButton.Name = "userEditButton";
            this.userEditButton.Size = new System.Drawing.Size(262, 43);
            this.userEditButton.TabIndex = 79;
            this.userEditButton.Text = "Ενημέρωση";
            this.userEditButton.UseVisualStyleBackColor = false;
            this.userEditButton.Click += new System.EventHandler(this.userEditButton_Click);
            // 
            // newReqLabel
            // 
            this.newReqLabel.AutoSize = true;
            this.newReqLabel.BackColor = System.Drawing.Color.Transparent;
            this.newReqLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newReqLabel.Location = new System.Drawing.Point(224, 9);
            this.newReqLabel.Name = "editReqLabel";
            this.newReqLabel.Size = new System.Drawing.Size(429, 51);
            this.newReqLabel.TabIndex = 72;
            this.newReqLabel.Tag = "";
            this.newReqLabel.Text = "Επεξεργασία στοιχείων";
            this.newReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressLabel.Location = new System.Drawing.Point(440, 184);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(297, 50);
            this.addressLabel.TabIndex = 78;
            this.addressLabel.Text = "Διεύθυνση κατοικίας\r\n(Νομός, Πόλη, Οδός, Αριθμός, ΤΚ)\r\n";
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.SystemColors.Window;
            this.nameField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameField.Location = new System.Drawing.Point(137, 136);
            this.nameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(197, 33);
            this.nameField.TabIndex = 66;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dobLabel.Location = new System.Drawing.Point(439, 108);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(214, 28);
            this.dobLabel.TabIndex = 77;
            this.dobLabel.Text = "Ημερομηνία γέννησης";
            // 
            // surnameField
            // 
            this.surnameField.BackColor = System.Drawing.SystemColors.Window;
            this.surnameField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameField.Location = new System.Drawing.Point(137, 234);
            this.surnameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(197, 33);
            this.surnameField.TabIndex = 67;
            // 
            // phoneField
            // 
            this.phoneField.BackColor = System.Drawing.SystemColors.Window;
            this.phoneField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneField.Location = new System.Drawing.Point(137, 333);
            this.phoneField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(197, 33);
            this.phoneField.TabIndex = 68;
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(445, 136);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(201, 22);
            this.dobPicker.TabIndex = 76;
            // 
            // emailField
            // 
            this.emailField.BackColor = System.Drawing.SystemColors.Window;
            this.emailField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailField.Location = new System.Drawing.Point(137, 431);
            this.emailField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(197, 33);
            this.emailField.TabIndex = 69;
            // 
            // addressField
            // 
            this.addressField.BackColor = System.Drawing.SystemColors.Window;
            this.addressField.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressField.Location = new System.Drawing.Point(444, 236);
            this.addressField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(316, 33);
            this.addressField.TabIndex = 75;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneLabel.Location = new System.Drawing.Point(132, 305);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(106, 28);
            this.phoneLabel.TabIndex = 70;
            this.phoneLabel.Text = "Τηλέφωνο";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailLabel.Location = new System.Drawing.Point(132, 403);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 28);
            this.emailLabel.TabIndex = 74;
            this.emailLabel.Text = "Email";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameLabel.Location = new System.Drawing.Point(132, 206);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(97, 28);
            this.surnameLabel.TabIndex = 71;
            this.surnameLabel.Text = "Επώνυμο";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameLabel.Location = new System.Drawing.Point(132, 108);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 28);
            this.nameLabel.TabIndex = 73;
            this.nameLabel.Text = "\'Ονομα";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 582);
            this.Controls.Add(this.userEditButton);
            this.Controls.Add(this.newReqLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button userEditButton;
        private System.Windows.Forms.Label newReqLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}