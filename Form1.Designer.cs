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
            this.newReqLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.typeManu = new System.Windows.Forms.ComboBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.addressText = new System.Windows.Forms.TextBox();
            this.reqEnterButton = new System.Windows.Forms.Button();
            this.reqEditButton = new System.Windows.Forms.Button();
            this.reqEditLabel = new System.Windows.Forms.Label();
            this.prevDateLabel = new System.Windows.Forms.Label();
            this.listOption = new System.Windows.Forms.ComboBox();
            this.listOptionButton = new System.Windows.Forms.Button();
            this.reqDelLabel = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.reqIDLabel = new System.Windows.Forms.Label();
            this.reqIDText = new System.Windows.Forms.TextBox();
            this.DelByATButton = new System.Windows.Forms.Button();
            this.ATLabel = new System.Windows.Forms.Label();
            this.ATText = new System.Windows.Forms.TextBox();
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
            this.emailLabel.Visible = false;
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
            this.surnameLabel.Visible = false;
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
            this.phoneLabel.Visible = false;
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
            this.nameLabel.Visible = false;
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
            this.emailText.Visible = false;
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
            this.phoneText.Visible = false;
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
            this.surnameText.Visible = false;
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
            this.nameText.Visible = false;
            // 
            // newReqLabel
            // 
            this.newReqLabel.AutoSize = true;
            this.newReqLabel.BackColor = System.Drawing.Color.Transparent;
            this.newReqLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newReqLabel.Location = new System.Drawing.Point(3, 18);
            this.newReqLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newReqLabel.Name = "newReqLabel";
            this.newReqLabel.Size = new System.Drawing.Size(190, 45);
            this.newReqLabel.TabIndex = 22;
            this.newReqLabel.Tag = "";
            this.newReqLabel.Text = "Νέα αίτηση";
            this.newReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newReqLabel.Visible = false;
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
            this.typeLabel.Visible = false;
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
            this.addressLabel.Visible = false;
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
            this.dobLabel.Visible = false;
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
            this.typeManu.Visible = false;
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(608, 43);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(152, 20);
            this.dobPicker.TabIndex = 24;
            this.dobPicker.Visible = false;
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
            this.addressText.Visible = false;
            // 
            // reqEnterButton
            // 
            this.reqEnterButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reqEnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reqEnterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reqEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqEnterButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqEnterButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reqEnterButton.Location = new System.Drawing.Point(608, 277);
            this.reqEnterButton.Margin = new System.Windows.Forms.Padding(0);
            this.reqEnterButton.Name = "reqEnterButton";
            this.reqEnterButton.Size = new System.Drawing.Size(182, 35);
            this.reqEnterButton.TabIndex = 29;
            this.reqEnterButton.Text = "Καταχώριση";
            this.reqEnterButton.UseVisualStyleBackColor = false;
            this.reqEnterButton.Visible = false;
            // 
            // reqEditButton
            // 
            this.reqEditButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reqEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reqEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reqEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqEditButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqEditButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reqEditButton.Location = new System.Drawing.Point(608, 331);
            this.reqEditButton.Margin = new System.Windows.Forms.Padding(0);
            this.reqEditButton.Name = "reqEditButton";
            this.reqEditButton.Size = new System.Drawing.Size(182, 35);
            this.reqEditButton.TabIndex = 30;
            this.reqEditButton.Text = "Ενημέρωση";
            this.reqEditButton.UseVisualStyleBackColor = false;
            this.reqEditButton.Visible = false;
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
            this.reqEditLabel.Visible = false;
            // 
            // prevDateLabel
            // 
            this.prevDateLabel.AutoSize = true;
            this.prevDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.prevDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevDateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.prevDateLabel.Location = new System.Drawing.Point(604, 65);
            this.prevDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prevDateLabel.Name = "prevDateLabel";
            this.prevDateLabel.Size = new System.Drawing.Size(123, 17);
            this.prevDateLabel.TabIndex = 32;
            this.prevDateLabel.Text = "(Καταγεγραμμένη: )";
            this.prevDateLabel.Visible = false;
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
            this.listOption.Visible = false;
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
            this.listOptionButton.Visible = false;
            // 
            // reqDelLabel
            // 
            this.reqDelLabel.AutoSize = true;
            this.reqDelLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqDelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqDelLabel.Location = new System.Drawing.Point(515, 523);
            this.reqDelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reqDelLabel.Name = "reqDelLabel";
            this.reqDelLabel.Size = new System.Drawing.Size(294, 45);
            this.reqDelLabel.TabIndex = 35;
            this.reqDelLabel.Text = "Διαγραφή αίτησης";
            this.reqDelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reqDelLabel.Visible = false;
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delButton.Location = new System.Drawing.Point(16, 440);
            this.delButton.Margin = new System.Windows.Forms.Padding(0);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(182, 35);
            this.delButton.TabIndex = 44;
            this.delButton.Text = "Διαγραφή";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Visible = false;
            // 
            // reqIDLabel
            // 
            this.reqIDLabel.AutoSize = true;
            this.reqIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqIDLabel.Location = new System.Drawing.Point(12, 386);
            this.reqIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reqIDLabel.Name = "reqIDLabel";
            this.reqIDLabel.Size = new System.Drawing.Size(129, 21);
            this.reqIDLabel.TabIndex = 43;
            this.reqIDLabel.Text = "Κωδικός αίτησης";
            this.reqIDLabel.Visible = false;
            // 
            // reqIDText
            // 
            this.reqIDText.BackColor = System.Drawing.SystemColors.Window;
            this.reqIDText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqIDText.Location = new System.Drawing.Point(16, 409);
            this.reqIDText.Margin = new System.Windows.Forms.Padding(2);
            this.reqIDText.Name = "reqIDText";
            this.reqIDText.Size = new System.Drawing.Size(182, 29);
            this.reqIDText.TabIndex = 42;
            this.reqIDText.Visible = false;
            // 
            // DelByATButton
            // 
            this.DelByATButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DelByATButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelByATButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelByATButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelByATButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DelByATButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelByATButton.Location = new System.Drawing.Point(113, 544);
            this.DelByATButton.Margin = new System.Windows.Forms.Padding(0);
            this.DelByATButton.Name = "DelByATButton";
            this.DelByATButton.Size = new System.Drawing.Size(182, 57);
            this.DelByATButton.TabIndex = 47;
            this.DelByATButton.Text = "Προβολή αιτήσεων \r\nγια διαγραφή\r\n";
            this.DelByATButton.UseVisualStyleBackColor = false;
            this.DelByATButton.Visible = false;
            // 
            // ATLabel
            // 
            this.ATLabel.AutoSize = true;
            this.ATLabel.BackColor = System.Drawing.Color.Transparent;
            this.ATLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATLabel.Location = new System.Drawing.Point(109, 487);
            this.ATLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ATLabel.Name = "ATLabel";
            this.ATLabel.Size = new System.Drawing.Size(157, 21);
            this.ATLabel.TabIndex = 46;
            this.ATLabel.Text = "Αριθμός Ταυτότητας";
            this.ATLabel.Visible = false;
            // 
            // ATText
            // 
            this.ATText.BackColor = System.Drawing.SystemColors.Window;
            this.ATText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATText.Location = new System.Drawing.Point(113, 510);
            this.ATText.Margin = new System.Windows.Forms.Padding(2);
            this.ATText.Name = "ATText";
            this.ATText.Size = new System.Drawing.Size(182, 29);
            this.ATText.TabIndex = 45;
            this.ATText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 631);
            this.Controls.Add(this.DelByATButton);
            this.Controls.Add(this.ATLabel);
            this.Controls.Add(this.ATText);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.reqIDLabel);
            this.Controls.Add(this.reqIDText);
            this.Controls.Add(this.reqDelLabel);
            this.Controls.Add(this.listOptionButton);
            this.Controls.Add(this.listOption);
            this.Controls.Add(this.prevDateLabel);
            this.Controls.Add(this.reqEditLabel);
            this.Controls.Add(this.reqEditButton);
            this.Controls.Add(this.reqEnterButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.typeManu);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.newReqLabel);
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
        private System.Windows.Forms.Label newReqLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.ComboBox typeManu;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Button reqEnterButton;
        private System.Windows.Forms.Button reqEditButton;
        private System.Windows.Forms.Label reqEditLabel;
        private System.Windows.Forms.Label prevDateLabel;
        private System.Windows.Forms.ComboBox listOption;
        private System.Windows.Forms.Button listOptionButton;
        private System.Windows.Forms.Label reqDelLabel;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label reqIDLabel;
        private System.Windows.Forms.TextBox reqIDText;
        private System.Windows.Forms.Button DelByATButton;
        private System.Windows.Forms.Label ATLabel;
        private System.Windows.Forms.TextBox ATText;
    }
}

