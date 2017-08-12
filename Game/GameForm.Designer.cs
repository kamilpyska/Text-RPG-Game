namespace Game
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label classLabel;
            System.Windows.Forms.Label lifeLabel;
            System.Windows.Forms.Label luckLabel;
            System.Windows.Forms.Label experienceLabel;
            System.Windows.Forms.Label levelLabel;
            System.Windows.Forms.Label weaponDamageLabel;
            System.Windows.Forms.Label helmetArmorLabel;
            System.Windows.Forms.Label breastplateArmorLabel;
            System.Windows.Forms.Label glovesArmorLabel;
            System.Windows.Forms.Label bootsArmorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.characterGroupBox = new System.Windows.Forms.GroupBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetComboBox = new System.Windows.Forms.ComboBox();
            this.powerLabel = new System.Windows.Forms.Label();
            this.armorLabel = new System.Windows.Forms.Label();
            this.characterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameDBDataSet = new Game.GameDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.characterBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.lifeValueLabel = new System.Windows.Forms.Label();
            this.dmgValueLabel = new System.Windows.Forms.Label();
            this.luckValueLabel = new System.Windows.Forms.Label();
            this.expValueLabel = new System.Windows.Forms.Label();
            this.lvlValueLabel = new System.Windows.Forms.Label();
            this.wDmgValueLabel = new System.Windows.Forms.Label();
            this.helmetValueLabel = new System.Windows.Forms.Label();
            this.breastplateValueLabel = new System.Windows.Forms.Label();
            this.glovesValueLabel = new System.Windows.Forms.Label();
            this.bootsValueLabel = new System.Windows.Forms.Label();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.mapButton = new System.Windows.Forms.Button();
            this.useButton = new System.Windows.Forms.Button();
            this.skillsComboBox = new System.Windows.Forms.ComboBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.abilityLabel = new System.Windows.Forms.Label();
            this.questButton = new System.Windows.Forms.Button();
            this.characterTableAdapter = new Game.GameDBDataSetTableAdapters.CharacterTableAdapter();
            this.tableAdapterManager = new Game.GameDBDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            classLabel = new System.Windows.Forms.Label();
            lifeLabel = new System.Windows.Forms.Label();
            luckLabel = new System.Windows.Forms.Label();
            experienceLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            weaponDamageLabel = new System.Windows.Forms.Label();
            helmetArmorLabel = new System.Windows.Forms.Label();
            breastplateArmorLabel = new System.Windows.Forms.Label();
            glovesArmorLabel = new System.Windows.Forms.Label();
            bootsArmorLabel = new System.Windows.Forms.Label();
            this.logGroupBox.SuspendLayout();
            this.characterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingNavigator)).BeginInit();
            this.characterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(172, 69);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Imię:";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new System.Drawing.Point(172, 95);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(36, 13);
            classLabel.TabIndex = 9;
            classLabel.Text = "Klasa:";
            // 
            // lifeLabel
            // 
            lifeLabel.AutoSize = true;
            lifeLabel.Location = new System.Drawing.Point(172, 121);
            lifeLabel.Name = "lifeLabel";
            lifeLabel.Size = new System.Drawing.Size(36, 13);
            lifeLabel.TabIndex = 11;
            lifeLabel.Text = "Życie:";
            // 
            // luckLabel
            // 
            luckLabel.AutoSize = true;
            luckLabel.Location = new System.Drawing.Point(172, 173);
            luckLabel.Name = "luckLabel";
            luckLabel.Size = new System.Drawing.Size(58, 13);
            luckLabel.TabIndex = 15;
            luckLabel.Text = "Szczęście:";
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Location = new System.Drawing.Point(172, 199);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new System.Drawing.Size(82, 13);
            experienceLabel.TabIndex = 17;
            experienceLabel.Text = "Doświadczenie:";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(172, 225);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(44, 13);
            levelLabel.TabIndex = 19;
            levelLabel.Text = "Poziom:";
            // 
            // weaponDamageLabel
            // 
            weaponDamageLabel.AutoSize = true;
            weaponDamageLabel.Location = new System.Drawing.Point(172, 251);
            weaponDamageLabel.Name = "weaponDamageLabel";
            weaponDamageLabel.Size = new System.Drawing.Size(84, 13);
            weaponDamageLabel.TabIndex = 21;
            weaponDamageLabel.Text = "Obrażenia broni:";
            // 
            // helmetArmorLabel
            // 
            helmetArmorLabel.AutoSize = true;
            helmetArmorLabel.Location = new System.Drawing.Point(172, 303);
            helmetArmorLabel.Name = "helmetArmorLabel";
            helmetArmorLabel.Size = new System.Drawing.Size(36, 13);
            helmetArmorLabel.TabIndex = 23;
            helmetArmorLabel.Text = "Hełm:";
            // 
            // breastplateArmorLabel
            // 
            breastplateArmorLabel.AutoSize = true;
            breastplateArmorLabel.Location = new System.Drawing.Point(172, 329);
            breastplateArmorLabel.Name = "breastplateArmorLabel";
            breastplateArmorLabel.Size = new System.Drawing.Size(60, 13);
            breastplateArmorLabel.TabIndex = 25;
            breastplateArmorLabel.Text = "Napierśnik:";
            // 
            // glovesArmorLabel
            // 
            glovesArmorLabel.AutoSize = true;
            glovesArmorLabel.Location = new System.Drawing.Point(172, 355);
            glovesArmorLabel.Name = "glovesArmorLabel";
            glovesArmorLabel.Size = new System.Drawing.Size(58, 13);
            glovesArmorLabel.TabIndex = 27;
            glovesArmorLabel.Text = "Rękawice:";
            // 
            // bootsArmorLabel
            // 
            bootsArmorLabel.AutoSize = true;
            bootsArmorLabel.Location = new System.Drawing.Point(172, 381);
            bootsArmorLabel.Name = "bootsArmorLabel";
            bootsArmorLabel.Size = new System.Drawing.Size(31, 13);
            bootsArmorLabel.TabIndex = 29;
            bootsArmorLabel.Text = "Buty:";
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.logTextBox);
            this.logGroupBox.Location = new System.Drawing.Point(28, 118);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(526, 319);
            this.logGroupBox.TabIndex = 0;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Przebieg zdarzeń:";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(10, 19);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(506, 296);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "1. Kliknij przycisk \"Dodaj nowy\" (żółty plusik), aby stworzyć nową postać.\r\n2. Po" +
    "daj swoje imię.\r\n3. Wybierz klasę.\r\n4. Naciśnij przycisk \"Szukaj przygód!\", aby " +
    "zacząć grę.";
            this.logTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logTextBox_KeyPress);
            // 
            // characterGroupBox
            // 
            this.characterGroupBox.Controls.Add(this.targetLabel);
            this.characterGroupBox.Controls.Add(this.targetComboBox);
            this.characterGroupBox.Controls.Add(this.powerLabel);
            this.characterGroupBox.Controls.Add(this.armorLabel);
            this.characterGroupBox.Controls.Add(this.characterBindingNavigator);
            this.characterGroupBox.Controls.Add(nameLabel);
            this.characterGroupBox.Controls.Add(this.nameTextBox);
            this.characterGroupBox.Controls.Add(classLabel);
            this.characterGroupBox.Controls.Add(this.classComboBox);
            this.characterGroupBox.Controls.Add(lifeLabel);
            this.characterGroupBox.Controls.Add(this.lifeValueLabel);
            this.characterGroupBox.Controls.Add(this.dmgValueLabel);
            this.characterGroupBox.Controls.Add(luckLabel);
            this.characterGroupBox.Controls.Add(this.luckValueLabel);
            this.characterGroupBox.Controls.Add(experienceLabel);
            this.characterGroupBox.Controls.Add(this.expValueLabel);
            this.characterGroupBox.Controls.Add(levelLabel);
            this.characterGroupBox.Controls.Add(this.lvlValueLabel);
            this.characterGroupBox.Controls.Add(weaponDamageLabel);
            this.characterGroupBox.Controls.Add(this.wDmgValueLabel);
            this.characterGroupBox.Controls.Add(helmetArmorLabel);
            this.characterGroupBox.Controls.Add(this.helmetValueLabel);
            this.characterGroupBox.Controls.Add(breastplateArmorLabel);
            this.characterGroupBox.Controls.Add(this.breastplateValueLabel);
            this.characterGroupBox.Controls.Add(glovesArmorLabel);
            this.characterGroupBox.Controls.Add(this.glovesValueLabel);
            this.characterGroupBox.Controls.Add(bootsArmorLabel);
            this.characterGroupBox.Controls.Add(this.bootsValueLabel);
            this.characterGroupBox.Controls.Add(this.tutorialButton);
            this.characterGroupBox.Controls.Add(this.mapButton);
            this.characterGroupBox.Controls.Add(this.useButton);
            this.characterGroupBox.Controls.Add(this.skillsComboBox);
            this.characterGroupBox.Controls.Add(this.helpButton);
            this.characterGroupBox.Controls.Add(this.abilityLabel);
            this.characterGroupBox.Controls.Add(this.questButton);
            this.characterGroupBox.Location = new System.Drawing.Point(606, 71);
            this.characterGroupBox.Name = "characterGroupBox";
            this.characterGroupBox.Size = new System.Drawing.Size(435, 411);
            this.characterGroupBox.TabIndex = 1;
            this.characterGroupBox.TabStop = false;
            this.characterGroupBox.Text = "Postać:";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(16, 147);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(25, 13);
            this.targetLabel.TabIndex = 34;
            this.targetLabel.Text = "Cel:";
            // 
            // targetComboBox
            // 
            this.targetComboBox.FormattingEnabled = true;
            this.targetComboBox.Location = new System.Drawing.Point(16, 165);
            this.targetComboBox.Name = "targetComboBox";
            this.targetComboBox.Size = new System.Drawing.Size(110, 21);
            this.targetComboBox.TabIndex = 33;
            this.targetComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.targetComboBox_KeyPress);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(172, 147);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(29, 13);
            this.powerLabel.TabIndex = 32;
            this.powerLabel.Text = "Siła:";
            // 
            // armorLabel
            // 
            this.armorLabel.AutoSize = true;
            this.armorLabel.Location = new System.Drawing.Point(172, 277);
            this.armorLabel.Name = "armorLabel";
            this.armorLabel.Size = new System.Drawing.Size(49, 13);
            this.armorLabel.TabIndex = 31;
            this.armorLabel.Text = "Pancerz:";
            // 
            // characterBindingNavigator
            // 
            this.characterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.characterBindingNavigator.BindingSource = this.characterBindingSource;
            this.characterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.characterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.characterBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.characterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.characterBindingNavigatorSaveItem});
            this.characterBindingNavigator.Location = new System.Drawing.Point(132, 16);
            this.characterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.characterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.characterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.characterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.characterBindingNavigator.Name = "characterBindingNavigator";
            this.characterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.characterBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.characterBindingNavigator.TabIndex = 2;
            this.characterBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataMember = "Character";
            this.characterBindingSource.DataSource = this.gameDBDataSet;
            // 
            // gameDBDataSet
            // 
            this.gameDBDataSet.DataSetName = "GameDBDataSet";
            this.gameDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Usuń zapis";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Pierwszy";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Poprzedni";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Obecny zapis";
            this.bindingNavigatorPositionItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bindingNavigatorPositionItem_KeyPress);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Następny";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Ostatni";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // characterBindingNavigatorSaveItem
            // 
            this.characterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.characterBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("characterBindingNavigatorSaveItem.Image")));
            this.characterBindingNavigatorSaveItem.Name = "characterBindingNavigatorSaveItem";
            this.characterBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.characterBindingNavigatorSaveItem.Text = "Zapisz postęp";
            this.characterBindingNavigatorSaveItem.Click += new System.EventHandler(this.characterBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(294, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // classComboBox
            // 
            this.classComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Class", true));
            this.classComboBox.Enabled = false;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Wojownik",
            "Mag"});
            this.classComboBox.Location = new System.Drawing.Point(294, 95);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 21);
            this.classComboBox.TabIndex = 10;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            this.classComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.classComboBox_KeyPress);
            // 
            // lifeValueLabel
            // 
            this.lifeValueLabel.AutoSize = true;
            this.lifeValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Life", true));
            this.lifeValueLabel.Location = new System.Drawing.Point(294, 121);
            this.lifeValueLabel.Name = "lifeValueLabel";
            this.lifeValueLabel.Size = new System.Drawing.Size(13, 13);
            this.lifeValueLabel.TabIndex = 12;
            this.lifeValueLabel.Text = "0";
            // 
            // dmgValueLabel
            // 
            this.dmgValueLabel.AutoSize = true;
            this.dmgValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Damage", true));
            this.dmgValueLabel.Location = new System.Drawing.Point(294, 147);
            this.dmgValueLabel.Name = "dmgValueLabel";
            this.dmgValueLabel.Size = new System.Drawing.Size(13, 13);
            this.dmgValueLabel.TabIndex = 14;
            this.dmgValueLabel.Text = "0";
            // 
            // luckValueLabel
            // 
            this.luckValueLabel.AutoSize = true;
            this.luckValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Luck", true));
            this.luckValueLabel.Location = new System.Drawing.Point(294, 173);
            this.luckValueLabel.Name = "luckValueLabel";
            this.luckValueLabel.Size = new System.Drawing.Size(13, 13);
            this.luckValueLabel.TabIndex = 16;
            this.luckValueLabel.Text = "0";
            // 
            // expValueLabel
            // 
            this.expValueLabel.AutoSize = true;
            this.expValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Experience", true));
            this.expValueLabel.Location = new System.Drawing.Point(294, 199);
            this.expValueLabel.Name = "expValueLabel";
            this.expValueLabel.Size = new System.Drawing.Size(13, 13);
            this.expValueLabel.TabIndex = 18;
            this.expValueLabel.Text = "0";
            // 
            // lvlValueLabel
            // 
            this.lvlValueLabel.AutoSize = true;
            this.lvlValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Level", true));
            this.lvlValueLabel.Location = new System.Drawing.Point(294, 225);
            this.lvlValueLabel.Name = "lvlValueLabel";
            this.lvlValueLabel.Size = new System.Drawing.Size(13, 13);
            this.lvlValueLabel.TabIndex = 20;
            this.lvlValueLabel.Text = "0";
            // 
            // wDmgValueLabel
            // 
            this.wDmgValueLabel.AutoSize = true;
            this.wDmgValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "WeaponDamage", true));
            this.wDmgValueLabel.Location = new System.Drawing.Point(294, 251);
            this.wDmgValueLabel.Name = "wDmgValueLabel";
            this.wDmgValueLabel.Size = new System.Drawing.Size(13, 13);
            this.wDmgValueLabel.TabIndex = 22;
            this.wDmgValueLabel.Text = "0";
            // 
            // helmetValueLabel
            // 
            this.helmetValueLabel.AutoSize = true;
            this.helmetValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "HelmetArmor", true));
            this.helmetValueLabel.Location = new System.Drawing.Point(294, 303);
            this.helmetValueLabel.Name = "helmetValueLabel";
            this.helmetValueLabel.Size = new System.Drawing.Size(13, 13);
            this.helmetValueLabel.TabIndex = 24;
            this.helmetValueLabel.Text = "0";
            // 
            // breastplateValueLabel
            // 
            this.breastplateValueLabel.AutoSize = true;
            this.breastplateValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "BreastplateArmor", true));
            this.breastplateValueLabel.Location = new System.Drawing.Point(294, 329);
            this.breastplateValueLabel.Name = "breastplateValueLabel";
            this.breastplateValueLabel.Size = new System.Drawing.Size(13, 13);
            this.breastplateValueLabel.TabIndex = 26;
            this.breastplateValueLabel.Text = "0";
            // 
            // glovesValueLabel
            // 
            this.glovesValueLabel.AutoSize = true;
            this.glovesValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "GlovesArmor", true));
            this.glovesValueLabel.Location = new System.Drawing.Point(294, 355);
            this.glovesValueLabel.Name = "glovesValueLabel";
            this.glovesValueLabel.Size = new System.Drawing.Size(13, 13);
            this.glovesValueLabel.TabIndex = 28;
            this.glovesValueLabel.Text = "0";
            // 
            // bootsValueLabel
            // 
            this.bootsValueLabel.AutoSize = true;
            this.bootsValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "BootsArmor", true));
            this.bootsValueLabel.Location = new System.Drawing.Point(294, 381);
            this.bootsValueLabel.Name = "bootsValueLabel";
            this.bootsValueLabel.Size = new System.Drawing.Size(13, 13);
            this.bootsValueLabel.TabIndex = 30;
            this.bootsValueLabel.Text = "0";
            // 
            // tutorialButton
            // 
            this.tutorialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutorialButton.Location = new System.Drawing.Point(16, 352);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(110, 39);
            this.tutorialButton.TabIndex = 6;
            this.tutorialButton.Text = "Wskazówki";
            this.tutorialButton.UseVisualStyleBackColor = true;
            this.tutorialButton.Click += new System.EventHandler(this.tutorialButton_Click);
            // 
            // mapButton
            // 
            this.mapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mapButton.Enabled = false;
            this.mapButton.Location = new System.Drawing.Point(16, 262);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(110, 39);
            this.mapButton.TabIndex = 5;
            this.mapButton.Text = "Mapa";
            this.mapButton.UseVisualStyleBackColor = true;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // useButton
            // 
            this.useButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useButton.Enabled = false;
            this.useButton.Location = new System.Drawing.Point(16, 199);
            this.useButton.Name = "useButton";
            this.useButton.Size = new System.Drawing.Size(110, 39);
            this.useButton.TabIndex = 4;
            this.useButton.Text = "Użyj zdolności";
            this.useButton.UseVisualStyleBackColor = true;
            this.useButton.Click += new System.EventHandler(this.useButton_Click);
            // 
            // skillsComboBox
            // 
            this.skillsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skillsComboBox.FormattingEnabled = true;
            this.skillsComboBox.Location = new System.Drawing.Point(16, 122);
            this.skillsComboBox.Name = "skillsComboBox";
            this.skillsComboBox.Size = new System.Drawing.Size(110, 21);
            this.skillsComboBox.TabIndex = 3;
            this.skillsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skillsComboBox_KeyPress);
            // 
            // helpButton
            // 
            this.helpButton.Enabled = false;
            this.helpButton.Location = new System.Drawing.Point(132, 119);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(26, 26);
            this.helpButton.TabIndex = 2;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // abilityLabel
            // 
            this.abilityLabel.AutoSize = true;
            this.abilityLabel.Location = new System.Drawing.Point(16, 106);
            this.abilityLabel.Name = "abilityLabel";
            this.abilityLabel.Size = new System.Drawing.Size(68, 13);
            this.abilityLabel.TabIndex = 1;
            this.abilityLabel.Text = "Umiejętność:";
            // 
            // questButton
            // 
            this.questButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questButton.Location = new System.Drawing.Point(16, 54);
            this.questButton.Name = "questButton";
            this.questButton.Size = new System.Drawing.Size(110, 39);
            this.questButton.TabIndex = 0;
            this.questButton.Text = "Szukaj przygód!";
            this.questButton.UseVisualStyleBackColor = true;
            this.questButton.Click += new System.EventHandler(this.questButton_Click);
            // 
            // characterTableAdapter
            // 
            this.characterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharacterTableAdapter = this.characterTableAdapter;
            this.tableAdapterManager.UpdateOrder = Game.GameDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1124, 572);
            this.Controls.Add(this.characterGroupBox);
            this.Controls.Add(this.logGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gra";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.logGroupBox.ResumeLayout(false);
            this.logGroupBox.PerformLayout();
            this.characterGroupBox.ResumeLayout(false);
            this.characterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingNavigator)).EndInit();
            this.characterBindingNavigator.ResumeLayout(false);
            this.characterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.GroupBox characterGroupBox;
        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.Button useButton;
        private System.Windows.Forms.ComboBox skillsComboBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label abilityLabel;
        private GameDBDataSet gameDBDataSet;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private GameDBDataSetTableAdapters.CharacterTableAdapter characterTableAdapter;
        private GameDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator characterBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton characterBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label lifeValueLabel;
        private System.Windows.Forms.Label dmgValueLabel;
        private System.Windows.Forms.Label luckValueLabel;
        private System.Windows.Forms.Label expValueLabel;
        private System.Windows.Forms.Label lvlValueLabel;
        private System.Windows.Forms.Label wDmgValueLabel;
        private System.Windows.Forms.Label helmetValueLabel;
        private System.Windows.Forms.Label breastplateValueLabel;
        private System.Windows.Forms.Label glovesValueLabel;
        private System.Windows.Forms.Label bootsValueLabel;
        private System.Windows.Forms.Label armorLabel;
        private System.Windows.Forms.Label powerLabel;
        public System.Windows.Forms.Button questButton;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.ComboBox targetComboBox;
    }
}

