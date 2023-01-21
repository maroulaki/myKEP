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
            this.emailLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.newreq = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.typeManu = new System.Windows.Forms.ComboBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.addressText = new System.Windows.Forms.TextBox();
            this.reqEnter = new System.Windows.Forms.Button();
            this.reqEdit = new System.Windows.Forms.Button();
            this.reqEditLabel = new System.Windows.Forms.Label();
            this.prevDateLabel = new System.Windows.Forms.Label();
            this.listOption = new System.Windows.Forms.ComboBox();
            this.listOptionButton = new System.Windows.Forms.Button();
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
            this.welcome.Size = new System.Drawing.Size(236, 82);
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
            this.addText.Size = new System.Drawing.Size(223, 35);
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
            this.editText.Size = new System.Drawing.Size(246, 70);
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
            this.listText.Size = new System.Drawing.Size(226, 70);
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
            this.delText.Size = new System.Drawing.Size(218, 70);
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
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailLabel.Location = new System.Drawing.Point(7, 312);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 21);
            this.emailLabel.TabIndex = 21;
            this.emailLabel.Text = "Email";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameLabel.Location = new System.Drawing.Point(7, 152);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(76, 21);
            this.surnameLabel.TabIndex = 20;
            this.surnameLabel.Text = "Επώνυμο";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneLabel.Location = new System.Drawing.Point(7, 232);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(83, 21);
            this.phoneLabel.TabIndex = 19;
            this.phoneLabel.Text = "Τηλέφωνο";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameLabel.Location = new System.Drawing.Point(7, 72);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 21);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "\'Ονομα";
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.Window;
            this.emailText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailText.Location = new System.Drawing.Point(11, 335);
            this.emailText.Margin = new System.Windows.Forms.Padding(2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(149, 29);
            this.emailText.TabIndex = 17;
            // 
            // phoneText
            // 
            this.phoneText.BackColor = System.Drawing.SystemColors.Window;
            this.phoneText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneText.Location = new System.Drawing.Point(11, 255);
            this.phoneText.Margin = new System.Windows.Forms.Padding(2);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(149, 29);
            this.phoneText.TabIndex = 16;
            // 
            // surnameText
            // 
            this.surnameText.BackColor = System.Drawing.SystemColors.Window;
            this.surnameText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameText.Location = new System.Drawing.Point(11, 175);
            this.surnameText.Margin = new System.Windows.Forms.Padding(2);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(149, 29);
            this.surnameText.TabIndex = 15;
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.Window;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameText.Location = new System.Drawing.Point(11, 95);
            this.nameText.Margin = new System.Windows.Forms.Padding(2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(149, 29);
            this.nameText.TabIndex = 14;
            // 
            // newreq
            // 
            this.newreq.AutoSize = true;
            this.newreq.BackColor = System.Drawing.Color.Transparent;
            this.newreq.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newreq.Location = new System.Drawing.Point(3, 18);
            this.newreq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newreq.Name = "newreq";
            this.newreq.Size = new System.Drawing.Size(190, 45);
            this.newreq.TabIndex = 22;
            this.newreq.Text = "Νέα αίτηση";
            this.newreq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.typeLabel.Location = new System.Drawing.Point(604, 206);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(113, 21);
            this.typeLabel.TabIndex = 28;
            this.typeLabel.Text = "Τύπος αίτησης";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressLabel.Location = new System.Drawing.Point(604, 99);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(242, 42);
            this.addressLabel.TabIndex = 27;
            this.addressLabel.Text = "Διεύθυνση κατοικίας\r\n(Νομός, Πόλη, Οδός, Αριθμός, ΤΚ)\r\n";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dobLabel.Location = new System.Drawing.Point(604, 20);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(164, 21);
            this.dobLabel.TabIndex = 26;
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
            this.typeManu.Location = new System.Drawing.Point(608, 229);
            this.typeManu.Margin = new System.Windows.Forms.Padding(2);
            this.typeManu.Name = "typeManu";
            this.typeManu.Size = new System.Drawing.Size(218, 25);
            this.typeManu.TabIndex = 25;
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(608, 43);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(152, 20);
            this.dobPicker.TabIndex = 24;
            // 
            // addressText
            // 
            this.addressText.BackColor = System.Drawing.SystemColors.Window;
            this.addressText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressText.Location = new System.Drawing.Point(608, 143);
            this.addressText.Margin = new System.Windows.Forms.Padding(2);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(238, 29);
            this.addressText.TabIndex = 23;
            // 
            // reqEnter
            // 
            this.reqEnter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reqEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reqEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reqEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqEnter.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqEnter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reqEnter.Location = new System.Drawing.Point(608, 277);
            this.reqEnter.Margin = new System.Windows.Forms.Padding(0);
            this.reqEnter.Name = "reqEnter";
            this.reqEnter.Size = new System.Drawing.Size(182, 35);
            this.reqEnter.TabIndex = 29;
            this.reqEnter.Text = "Καταχώριση";
            this.reqEnter.UseVisualStyleBackColor = false;
            // 
            // reqEdit
            // 
            this.reqEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reqEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reqEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reqEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqEdit.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reqEdit.Location = new System.Drawing.Point(608, 331);
            this.reqEdit.Margin = new System.Windows.Forms.Padding(0);
            this.reqEdit.Name = "reqEdit";
            this.reqEdit.Size = new System.Drawing.Size(182, 35);
            this.reqEdit.TabIndex = 30;
            this.reqEdit.Text = "Ενημέρωση";
            this.reqEdit.UseVisualStyleBackColor = false;
            // 
            // reqEditLabel
            // 
            this.reqEditLabel.AutoSize = true;
            this.reqEditLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqEditLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqEditLabel.Location = new System.Drawing.Point(515, 577);
            this.reqEditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reqEditLabel.Name = "reqEditLabel";
            this.reqEditLabel.Size = new System.Drawing.Size(331, 45);
            this.reqEditLabel.TabIndex = 31;
            this.reqEditLabel.Text = "Επεξεργασία αίτησης";
            this.reqEditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prevDateLabel
            // 
            this.prevDateLabel.AutoSize = true;
            this.prevDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.prevDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevDateLabel.Location = new System.Drawing.Point(604, 65);
            this.prevDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prevDateLabel.Name = "prevDateLabel";
            this.prevDateLabel.Size = new System.Drawing.Size(148, 21);
            this.prevDateLabel.TabIndex = 32;
            this.prevDateLabel.Text = "(Καταγεγραμμένη: )";
            // 
            // listOption
            // 
            this.listOption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listOption.FormattingEnabled = true;
            this.listOption.Items.AddRange(new object[] {
            "Προβολή όλων",
            "Προβολή ανά πολίτη"});
            this.listOption.Location = new System.Drawing.Point(608, 388);
            this.listOption.Margin = new System.Windows.Forms.Padding(2);
            this.listOption.Name = "listOption";
            this.listOption.Size = new System.Drawing.Size(218, 33);
            this.listOption.TabIndex = 33;
            // 
            // listOptionButton
            // 
            this.listOptionButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listOptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listOptionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.listOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listOptionButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listOptionButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.listOptionButton.Location = new System.Drawing.Point(608, 437);
            this.listOptionButton.Margin = new System.Windows.Forms.Padding(0);
            this.listOptionButton.Name = "listOptionButton";
            this.listOptionButton.Size = new System.Drawing.Size(182, 35);
            this.listOptionButton.TabIndex = 34;
            this.listOptionButton.Text = "Επιλογή";
            this.listOptionButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 631);
            this.Controls.Add(this.listOptionButton);
            this.Controls.Add(this.listOption);
            this.Controls.Add(this.prevDateLabel);
            this.Controls.Add(this.reqEditLabel);
            this.Controls.Add(this.reqEdit);
            this.Controls.Add(this.reqEnter);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.typeManu);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.newreq);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameText);
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
            this.Name = "Form1";
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
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label newreq;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.ComboBox typeManu;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Button reqEnter;
        private System.Windows.Forms.Button reqEdit;
        private System.Windows.Forms.Label reqEditLabel;
        private System.Windows.Forms.Label prevDateLabel;
        private System.Windows.Forms.ComboBox listOption;
        private System.Windows.Forms.Button listOptionButton;
    }
}

