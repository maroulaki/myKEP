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
            this.newReqPanel = new System.Windows.Forms.Panel();
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
            this.editReqPanel = new System.Windows.Forms.Panel();
            this.reqEditButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.prevDateLabel = new System.Windows.Forms.Label();
            this.reqEditLabel = new System.Windows.Forms.Label();
            this.delReqPanel = new System.Windows.Forms.Panel();
            this.DelByATButton = new System.Windows.Forms.Button();
            this.ATLabel = new System.Windows.Forms.Label();
            this.ATText = new System.Windows.Forms.TextBox();
            this.delButton = new System.Windows.Forms.Button();
            this.reqIDLabel = new System.Windows.Forms.Label();
            this.reqIDText = new System.Windows.Forms.TextBox();
            this.reqDelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).BeginInit();
            this.newReqPanel.SuspendLayout();
            this.editReqPanel.SuspendLayout();
            this.delReqPanel.SuspendLayout();
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
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(733, 588);
            this.homePanel.TabIndex = 0;
            // 
            // delText
            // 
            this.delText.AutoSize = true;
            this.delText.BackColor = System.Drawing.Color.Transparent;
            this.delText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delText.Location = new System.Drawing.Point(236, 436);
            this.delText.Name = "delText";
            this.delText.Size = new System.Drawing.Size(255, 80);
            this.delText.TabIndex = 22;
            this.delText.Text = "Διαγραφή αίτησης\r\n\r\n";
            // 
            // listText
            // 
            this.listText.AutoSize = true;
            this.listText.BackColor = System.Drawing.Color.Transparent;
            this.listText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listText.Location = new System.Drawing.Point(236, 371);
            this.listText.Name = "listText";
            this.listText.Size = new System.Drawing.Size(263, 80);
            this.listText.TabIndex = 21;
            this.listText.Text = "Προβολή αιτήσεων\r\n\r\n";
            // 
            // editText
            // 
            this.editText.AutoSize = true;
            this.editText.BackColor = System.Drawing.Color.Transparent;
            this.editText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editText.Font = new System.Drawing.Font("Segoe UI Semilight", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editText.Location = new System.Drawing.Point(236, 306);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(289, 80);
            this.editText.TabIndex = 20;
            this.editText.Text = "Επεξεργασία αίτησης\r\n\r\n";
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.BackgroundImage = global::myKEP.Properties.Resources.edit;
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Location = new System.Drawing.Point(169, 306);
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
            this.list.Location = new System.Drawing.Point(169, 371);
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
            this.delete.Location = new System.Drawing.Point(169, 436);
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
            this.add.Location = new System.Drawing.Point(169, 241);
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
            this.addText.Location = new System.Drawing.Point(236, 243);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(259, 40);
            this.addText.TabIndex = 15;
            this.addText.Text = "Προσθήκη αίτησης";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 21.91304F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.welcome.Location = new System.Drawing.Point(294, 101);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(276, 94);
            this.welcome.TabIndex = 14;
            this.welcome.Text = "Καλώς ορίσατε \r\nστο myKEP";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatarPB
            // 
            this.avatarPB.BackColor = System.Drawing.Color.Transparent;
            this.avatarPB.BackgroundImage = global::myKEP.Properties.Resources.icons8_contact_info_100;
            this.avatarPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarPB.Location = new System.Drawing.Point(133, 44);
            this.avatarPB.Margin = new System.Windows.Forms.Padding(0);
            this.avatarPB.Name = "avatarPB";
            this.avatarPB.Size = new System.Drawing.Size(158, 151);
            this.avatarPB.TabIndex = 13;
            this.avatarPB.TabStop = false;
            // 
            // newReqPanel
            // 
            this.newReqPanel.BackColor = System.Drawing.Color.Transparent;
            this.newReqPanel.Controls.Add(this.homePanel);
            this.newReqPanel.Controls.Add(this.typeLabel);
            this.newReqPanel.Controls.Add(this.addressLabel);
            this.newReqPanel.Controls.Add(this.dobLabel);
            this.newReqPanel.Controls.Add(this.typeManu);
            this.newReqPanel.Controls.Add(this.dobPicker);
            this.newReqPanel.Controls.Add(this.addressText);
            this.newReqPanel.Controls.Add(this.emailLabel);
            this.newReqPanel.Controls.Add(this.nameLabel);
            this.newReqPanel.Controls.Add(this.newReqLabel);
            this.newReqPanel.Controls.Add(this.surnameLabel);
            this.newReqPanel.Controls.Add(this.phoneLabel);
            this.newReqPanel.Controls.Add(this.emailText);
            this.newReqPanel.Controls.Add(this.phoneText);
            this.newReqPanel.Controls.Add(this.surnameText);
            this.newReqPanel.Controls.Add(this.nameText);
            this.newReqPanel.Location = new System.Drawing.Point(106, 13);
            this.newReqPanel.Margin = new System.Windows.Forms.Padding(4);
            this.newReqPanel.Name = "newReqPanel";
            this.newReqPanel.Size = new System.Drawing.Size(728, 588);
            this.newReqPanel.TabIndex = 62;
            this.newReqPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.newReqPanel_Paint);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.typeLabel.Location = new System.Drawing.Point(365, 378);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(144, 28);
            this.typeLabel.TabIndex = 54;
            this.typeLabel.Text = "Τύπος αίτησης";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressLabel.Location = new System.Drawing.Point(365, 249);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(313, 56);
            this.addressLabel.TabIndex = 53;
            this.addressLabel.Text = "Διεύθυνση κατοικίας\r\n(Νομός, Πόλη, Οδός, Αριθμός, ΤΚ)\r\n";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.BackColor = System.Drawing.Color.Transparent;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dobLabel.Location = new System.Drawing.Point(365, 152);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(214, 28);
            this.dobLabel.TabIndex = 52;
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
            this.typeManu.Location = new System.Drawing.Point(371, 409);
            this.typeManu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeManu.Name = "typeManu";
            this.typeManu.Size = new System.Drawing.Size(289, 29);
            this.typeManu.TabIndex = 51;
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(371, 180);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(201, 23);
            this.dobPicker.TabIndex = 50;
            // 
            // addressText
            // 
            this.addressText.BackColor = System.Drawing.SystemColors.Window;
            this.addressText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressText.Location = new System.Drawing.Point(371, 303);
            this.addressText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(316, 33);
            this.addressText.TabIndex = 49;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailLabel.Location = new System.Drawing.Point(28, 447);
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
            this.nameLabel.Location = new System.Drawing.Point(28, 152);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(79, 28);
            this.nameLabel.TabIndex = 47;
            this.nameLabel.Text = "\'Ονομα";
            // 
            // newReqLabel
            // 
            this.newReqLabel.BackColor = System.Drawing.Color.Transparent;
            this.newReqLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newReqLabel.Location = new System.Drawing.Point(203, 4);
            this.newReqLabel.Name = "newReqLabel";
            this.newReqLabel.Size = new System.Drawing.Size(224, 51);
            this.newReqLabel.TabIndex = 0;
            this.newReqLabel.Tag = "";
            this.newReqLabel.Text = "Νέα αίτηση";
            this.newReqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameLabel.Location = new System.Drawing.Point(28, 250);
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
            this.phoneLabel.Location = new System.Drawing.Point(28, 349);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(106, 28);
            this.phoneLabel.TabIndex = 44;
            this.phoneLabel.Text = "Τηλέφωνο";
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.Window;
            this.emailText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailText.Location = new System.Drawing.Point(33, 475);
            this.emailText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(197, 33);
            this.emailText.TabIndex = 43;
            // 
            // phoneText
            // 
            this.phoneText.BackColor = System.Drawing.SystemColors.Window;
            this.phoneText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneText.Location = new System.Drawing.Point(33, 377);
            this.phoneText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(197, 33);
            this.phoneText.TabIndex = 42;
            // 
            // surnameText
            // 
            this.surnameText.BackColor = System.Drawing.SystemColors.Window;
            this.surnameText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surnameText.Location = new System.Drawing.Point(33, 278);
            this.surnameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(197, 33);
            this.surnameText.TabIndex = 41;
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.Window;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameText.Location = new System.Drawing.Point(33, 180);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(197, 33);
            this.nameText.TabIndex = 40;
            // 
            // editReqPanel
            // 
            this.editReqPanel.BackColor = System.Drawing.Color.Transparent;
            this.editReqPanel.Controls.Add(this.reqEditButton);
            this.editReqPanel.Controls.Add(this.label1);
            this.editReqPanel.Controls.Add(this.label2);
            this.editReqPanel.Controls.Add(this.label3);
            this.editReqPanel.Controls.Add(this.comboBox1);
            this.editReqPanel.Controls.Add(this.dateTimePicker1);
            this.editReqPanel.Controls.Add(this.textBox1);
            this.editReqPanel.Controls.Add(this.label4);
            this.editReqPanel.Controls.Add(this.label5);
            this.editReqPanel.Controls.Add(this.label6);
            this.editReqPanel.Controls.Add(this.label7);
            this.editReqPanel.Controls.Add(this.textBox2);
            this.editReqPanel.Controls.Add(this.textBox3);
            this.editReqPanel.Controls.Add(this.textBox4);
            this.editReqPanel.Controls.Add(this.textBox5);
            this.editReqPanel.Controls.Add(this.prevDateLabel);
            this.editReqPanel.Controls.Add(this.reqEditLabel);
            this.editReqPanel.Location = new System.Drawing.Point(95, 17);
            this.editReqPanel.Margin = new System.Windows.Forms.Padding(4);
            this.editReqPanel.Name = "editReqPanel";
            this.editReqPanel.Size = new System.Drawing.Size(759, 584);
            this.editReqPanel.TabIndex = 61;
            // 
            // reqEditButton
            // 
            this.reqEditButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reqEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reqEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reqEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqEditButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqEditButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reqEditButton.Location = new System.Drawing.Point(187, 519);
            this.reqEditButton.Margin = new System.Windows.Forms.Padding(0);
            this.reqEditButton.Name = "reqEditButton";
            this.reqEditButton.Size = new System.Drawing.Size(243, 43);
            this.reqEditButton.TabIndex = 69;
            this.reqEditButton.Text = "Ενημέρωση";
            this.reqEditButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(306, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 68;
            this.label1.Text = "Τύπος αίτησης";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(306, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 56);
            this.label2.TabIndex = 67;
            this.label2.Text = "Διεύθυνση κατοικίας\r\n(Νομός, Πόλη, Οδός, Αριθμός, ΤΚ)\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(306, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 28);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ημερομηνία γέννησης";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Μεταβίβαση οχήματος",
            "Έναρξη εργασιών επιχείρησης",
            "Πιστοποιητικό γάμου",
            "Αποποίηση κληρονομιάς",
            "Διαγραφή από μητρώο",
            "Νέο μισθωτήριο κατοικίας"});
            this.comboBox1.Location = new System.Drawing.Point(311, 381);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 29);
            this.comboBox1.TabIndex = 65;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 152);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 23);
            this.dateTimePicker1.TabIndex = 64;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(311, 275);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 33);
            this.textBox1.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(54, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 62;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(54, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 61;
            this.label5.Text = "\'Ονομα";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(54, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 28);
            this.label6.TabIndex = 60;
            this.label6.Text = "Επώνυμο";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(54, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 59;
            this.label7.Text = "Τηλέφωνο";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(59, 447);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 33);
            this.textBox2.TabIndex = 58;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox3.Location = new System.Drawing.Point(59, 349);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 33);
            this.textBox3.TabIndex = 57;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox4.Location = new System.Drawing.Point(59, 250);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 33);
            this.textBox4.TabIndex = 56;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox5.Location = new System.Drawing.Point(59, 152);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(197, 33);
            this.textBox5.TabIndex = 55;
            // 
            // prevDateLabel
            // 
            this.prevDateLabel.AutoSize = true;
            this.prevDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.prevDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevDateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.prevDateLabel.Location = new System.Drawing.Point(519, 152);
            this.prevDateLabel.Name = "prevDateLabel";
            this.prevDateLabel.Size = new System.Drawing.Size(148, 21);
            this.prevDateLabel.TabIndex = 53;
            this.prevDateLabel.Text = "(Καταγεγραμμένη: )";
            // 
            // reqEditLabel
            // 
            this.reqEditLabel.AutoSize = true;
            this.reqEditLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqEditLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqEditLabel.Location = new System.Drawing.Point(126, 21);
            this.reqEditLabel.Name = "reqEditLabel";
            this.reqEditLabel.Size = new System.Drawing.Size(394, 51);
            this.reqEditLabel.TabIndex = 52;
            this.reqEditLabel.Text = "Επεξεργασία αίτησης";
            this.reqEditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reqEditLabel.Click += new System.EventHandler(this.reqEditLabel_Click);
            // 
            // delReqPanel
            // 
            this.delReqPanel.BackColor = System.Drawing.Color.Transparent;
            this.delReqPanel.Controls.Add(this.DelByATButton);
            this.delReqPanel.Controls.Add(this.ATLabel);
            this.delReqPanel.Controls.Add(this.ATText);
            this.delReqPanel.Controls.Add(this.delButton);
            this.delReqPanel.Controls.Add(this.reqIDLabel);
            this.delReqPanel.Controls.Add(this.reqIDText);
            this.delReqPanel.Controls.Add(this.reqDelLabel);
            this.delReqPanel.Location = new System.Drawing.Point(106, 13);
            this.delReqPanel.Margin = new System.Windows.Forms.Padding(4);
            this.delReqPanel.Name = "delReqPanel";
            this.delReqPanel.Size = new System.Drawing.Size(733, 601);
            this.delReqPanel.TabIndex = 0;
            // 
            // DelByATButton
            // 
            this.DelByATButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DelByATButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelByATButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DelByATButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelByATButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DelByATButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelByATButton.Location = new System.Drawing.Point(361, 279);
            this.DelByATButton.Margin = new System.Windows.Forms.Padding(0);
            this.DelByATButton.Name = "DelByATButton";
            this.DelByATButton.Size = new System.Drawing.Size(243, 70);
            this.DelByATButton.TabIndex = 64;
            this.DelByATButton.Text = "Προβολή αιτήσεων \r\nγια διαγραφή\r\n";
            this.DelByATButton.UseVisualStyleBackColor = false;
            // 
            // ATLabel
            // 
            this.ATLabel.AutoSize = true;
            this.ATLabel.BackColor = System.Drawing.Color.Transparent;
            this.ATLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATLabel.Location = new System.Drawing.Point(356, 208);
            this.ATLabel.Name = "ATLabel";
            this.ATLabel.Size = new System.Drawing.Size(200, 28);
            this.ATLabel.TabIndex = 63;
            this.ATLabel.Text = "Αριθμός Ταυτότητας";
            // 
            // ATText
            // 
            this.ATText.BackColor = System.Drawing.SystemColors.Window;
            this.ATText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ATText.Location = new System.Drawing.Point(361, 237);
            this.ATText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ATText.Name = "ATText";
            this.ATText.Size = new System.Drawing.Size(241, 33);
            this.ATText.TabIndex = 62;
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delButton.Location = new System.Drawing.Point(38, 275);
            this.delButton.Margin = new System.Windows.Forms.Padding(0);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(243, 43);
            this.delButton.TabIndex = 61;
            this.delButton.Text = "Διαγραφή";
            this.delButton.UseVisualStyleBackColor = false;
            // 
            // reqIDLabel
            // 
            this.reqIDLabel.AutoSize = true;
            this.reqIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqIDLabel.Location = new System.Drawing.Point(32, 208);
            this.reqIDLabel.Name = "reqIDLabel";
            this.reqIDLabel.Size = new System.Drawing.Size(165, 28);
            this.reqIDLabel.TabIndex = 60;
            this.reqIDLabel.Text = "Κωδικός αίτησης";
            // 
            // reqIDText
            // 
            this.reqIDText.BackColor = System.Drawing.SystemColors.Window;
            this.reqIDText.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqIDText.Location = new System.Drawing.Point(38, 237);
            this.reqIDText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reqIDText.Name = "reqIDText";
            this.reqIDText.Size = new System.Drawing.Size(241, 33);
            this.reqIDText.TabIndex = 59;
            // 
            // reqDelLabel
            // 
            this.reqDelLabel.AutoSize = true;
            this.reqDelLabel.BackColor = System.Drawing.Color.Transparent;
            this.reqDelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.reqDelLabel.Location = new System.Drawing.Point(139, 0);
            this.reqDelLabel.Name = "reqDelLabel";
            this.reqDelLabel.Size = new System.Drawing.Size(350, 51);
            this.reqDelLabel.TabIndex = 58;
            this.reqDelLabel.Text = "Διαγραφή αίτησης";
            this.reqDelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::myKEP.Properties.Resources.kepbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 631);
            this.Controls.Add(this.back);
            this.Controls.Add(this.newReqPanel);
            this.Controls.Add(this.delReqPanel);
            this.Controls.Add(this.editReqPanel);
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
            this.newReqPanel.ResumeLayout(false);
            this.newReqPanel.PerformLayout();
            this.editReqPanel.ResumeLayout(false);
            this.editReqPanel.PerformLayout();
            this.delReqPanel.ResumeLayout(false);
            this.delReqPanel.PerformLayout();
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
        private System.Windows.Forms.Panel newReqPanel;
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
        private System.Windows.Forms.Panel editReqPanel;
        private System.Windows.Forms.Button reqEditButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label prevDateLabel;
        private System.Windows.Forms.Label reqEditLabel;
        private System.Windows.Forms.Panel delReqPanel;
        private System.Windows.Forms.Button DelByATButton;
        private System.Windows.Forms.Label ATLabel;
        private System.Windows.Forms.TextBox ATText;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label reqIDLabel;
        private System.Windows.Forms.TextBox reqIDText;
        private System.Windows.Forms.Label reqDelLabel;
    }
}

