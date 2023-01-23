namespace myKEP
{
    partial class Form2
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
            this.reqEnterButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.typeManu = new System.Windows.Forms.ComboBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.addressText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newReqLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
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
            this.reqEnterButton.Location = new System.Drawing.Point(315, 521);
            this.reqEnterButton.Margin = new System.Windows.Forms.Padding(0);
            this.reqEnterButton.Name = "reqEnterButton";
            this.reqEnterButton.Size = new System.Drawing.Size(182, 35);
            this.reqEnterButton.TabIndex = 71;
            this.reqEnterButton.Text = "Καταχώριση";
            this.reqEnterButton.UseVisualStyleBackColor = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.typeLabel.Location = new System.Drawing.Point(450, 339);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(113, 21);
            this.typeLabel.TabIndex = 70;
            this.typeLabel.Text = "Τύπος αίτησης";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressLabel.Location = new System.Drawing.Point(450, 234);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(242, 42);
            this.addressLabel.TabIndex = 69;
            this.addressLabel.Text = "Διεύθυνση κατοικίας\r\n(Νομός, Πόλη, Οδός, Αριθμός, ΤΚ)\r\n";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dobLabel.Location = new System.Drawing.Point(450, 155);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(164, 21);
            this.dobLabel.TabIndex = 68;
            this.dobLabel.Text = "Ημερομηνία γέννησης";
            // 
            // typeManu
            // 
            this.typeManu.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.typeManu.FormattingEnabled = true;
            this.typeManu.Items.AddRange(new object[] {
            "Μεταβίβαση οχήματος",
            "Έναρξη εργασιών επιχείρησης",
            "Πιστοποιητικό γάμου",
            "Αποποίηση κληρονομιάς",
            "Διαγραφή από μητρώο",
            "Νέο μισθωτήριο κατοικίας"});
            this.typeManu.Location = new System.Drawing.Point(454, 364);
            this.typeManu.Margin = new System.Windows.Forms.Padding(2);
            this.typeManu.Name = "typeManu";
            this.typeManu.Size = new System.Drawing.Size(218, 25);
            this.typeManu.TabIndex = 67;
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(454, 178);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(152, 20);
            this.dobPicker.TabIndex = 66;
            // 
            // addressText
            // 
            this.addressText.BackColor = System.Drawing.SystemColors.Window;
            this.addressText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressText.Location = new System.Drawing.Point(454, 278);
            this.addressText.Margin = new System.Windows.Forms.Padding(2);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(238, 29);
            this.addressText.TabIndex = 65;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailLabel.Location = new System.Drawing.Point(197, 395);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 21);
            this.emailLabel.TabIndex = 64;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameLabel.Location = new System.Drawing.Point(197, 155);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 21);
            this.nameLabel.TabIndex = 63;
            this.nameLabel.Text = "\'Ονομα";
            // 
            // newReqLabel
            // 
            this.newReqLabel.AutoSize = true;
            this.newReqLabel.BackColor = System.Drawing.Color.Transparent;
            this.newReqLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newReqLabel.Location = new System.Drawing.Point(307, 40);
            this.newReqLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newReqLabel.Name = "newReqLabel";
            this.newReqLabel.Size = new System.Drawing.Size(190, 45);
            this.newReqLabel.TabIndex = 62;
            this.newReqLabel.Tag = "";
            this.newReqLabel.Text = "Νέα αίτηση";
            this.newReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameLabel.Location = new System.Drawing.Point(197, 235);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(76, 21);
            this.surnameLabel.TabIndex = 61;
            this.surnameLabel.Text = "Επώνυμο";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneLabel.Location = new System.Drawing.Point(197, 315);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(83, 21);
            this.phoneLabel.TabIndex = 60;
            this.phoneLabel.Text = "Τηλέφωνο";
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.Window;
            this.emailText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailText.Location = new System.Drawing.Point(201, 418);
            this.emailText.Margin = new System.Windows.Forms.Padding(2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(149, 29);
            this.emailText.TabIndex = 59;
            // 
            // phoneText
            // 
            this.phoneText.BackColor = System.Drawing.SystemColors.Window;
            this.phoneText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneText.Location = new System.Drawing.Point(201, 338);
            this.phoneText.Margin = new System.Windows.Forms.Padding(2);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(149, 29);
            this.phoneText.TabIndex = 58;
            // 
            // surnameText
            // 
            this.surnameText.BackColor = System.Drawing.SystemColors.Window;
            this.surnameText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameText.Location = new System.Drawing.Point(201, 258);
            this.surnameText.Margin = new System.Windows.Forms.Padding(2);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(149, 29);
            this.surnameText.TabIndex = 57;
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.Window;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameText.Location = new System.Drawing.Point(201, 178);
            this.nameText.Margin = new System.Windows.Forms.Padding(2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(149, 29);
            this.nameText.TabIndex = 56;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 631);
            this.Controls.Add(this.reqEnterButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.typeManu);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.newReqLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reqEnterButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.ComboBox typeManu;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label newReqLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox nameText;
    }
}