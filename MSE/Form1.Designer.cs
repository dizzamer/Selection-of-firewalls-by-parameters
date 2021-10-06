namespace MSE
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.Panel();
            this.mainMenuButtonContainer = new System.Windows.Forms.Panel();
            this.exitMenuItem = new System.Windows.Forms.Button();
            this.aboutMenuItem = new System.Windows.Forms.Button();
            this.editMenuItem = new System.Windows.Forms.Button();
            this.addMenuItem = new System.Windows.Forms.Button();
            this.searchMenuItem = new System.Windows.Forms.Button();
            this.addItemContainer = new System.Windows.Forms.Panel();
            this.addItemParamContainer = new MSE.ControlListContainer();
            this.addItemTopMenuContainer = new System.Windows.Forms.Panel();
            this.addItemName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addItemMenuContainer = new System.Windows.Forms.Panel();
            this.addItemButton = new System.Windows.Forms.Button();
            this.addItemGoBackButton = new System.Windows.Forms.Button();
            this.editItemContainer = new System.Windows.Forms.Panel();
            this.editItemButtonsContainer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editItemParamsContainer = new MSE.ControlListContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editItemGoBackButton = new System.Windows.Forms.Button();
            this.editItemsEditButton = new System.Windows.Forms.Button();
            this.editItemDeleteButton = new System.Windows.Forms.Button();
            this.editItemsList = new System.Windows.Forms.ListBox();
            this.aboutContainer = new System.Windows.Forms.Panel();
            this.aboutText = new System.Windows.Forms.Label();
            this.aboutMenuContainer = new System.Windows.Forms.Panel();
            this.aboutGoBackButton = new System.Windows.Forms.Button();
            this.searchContainer = new System.Windows.Forms.Panel();
            this.searchButtonContainer = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchGoBackButton = new System.Windows.Forms.Button();
            this.searchTabs = new System.Windows.Forms.TabControl();
            this.searchTermsTab = new System.Windows.Forms.TabPage();
            this.searchParametersList = new MSE.ControlListContainer();
            this.priceResultTab = new System.Windows.Forms.TabPage();
            this.priceResultParameters = new MSE.ControlListContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priceResultName = new System.Windows.Forms.TextBox();
            this.parametersResultTab = new System.Windows.Forms.TabPage();
            this.parameResultParameters = new MSE.ControlListContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paramsResultName = new System.Windows.Forms.TextBox();
            this.mainMenu.SuspendLayout();
            this.mainMenuButtonContainer.SuspendLayout();
            this.addItemContainer.SuspendLayout();
            this.addItemTopMenuContainer.SuspendLayout();
            this.addItemMenuContainer.SuspendLayout();
            this.editItemContainer.SuspendLayout();
            this.editItemButtonsContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.aboutContainer.SuspendLayout();
            this.aboutMenuContainer.SuspendLayout();
            this.searchContainer.SuspendLayout();
            this.searchButtonContainer.SuspendLayout();
            this.searchTabs.SuspendLayout();
            this.searchTermsTab.SuspendLayout();
            this.priceResultTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.parametersResultTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.mainMenuButtonContainer);
            this.mainMenu.Location = new System.Drawing.Point(107, 106);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(680, 423);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Layout += new System.Windows.Forms.LayoutEventHandler(this.mainMenu_Layout);
            // 
            // mainMenuButtonContainer
            // 
            this.mainMenuButtonContainer.Controls.Add(this.exitMenuItem);
            this.mainMenuButtonContainer.Controls.Add(this.aboutMenuItem);
            this.mainMenuButtonContainer.Controls.Add(this.editMenuItem);
            this.mainMenuButtonContainer.Controls.Add(this.addMenuItem);
            this.mainMenuButtonContainer.Controls.Add(this.searchMenuItem);
            this.mainMenuButtonContainer.Location = new System.Drawing.Point(225, 127);
            this.mainMenuButtonContainer.Name = "mainMenuButtonContainer";
            this.mainMenuButtonContainer.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.mainMenuButtonContainer.Size = new System.Drawing.Size(215, 169);
            this.mainMenuButtonContainer.TabIndex = 7;
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitMenuItem.Location = new System.Drawing.Point(5, 130);
            this.exitMenuItem.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(205, 30);
            this.exitMenuItem.TabIndex = 10;
            this.exitMenuItem.Text = "ВЫХОД";
            this.exitMenuItem.UseVisualStyleBackColor = true;
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutMenuItem.Location = new System.Drawing.Point(5, 100);
            this.aboutMenuItem.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(205, 30);
            this.aboutMenuItem.TabIndex = 9;
            this.aboutMenuItem.Text = "О ПРОГРАММЕ";
            this.aboutMenuItem.UseVisualStyleBackColor = true;
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutClick);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.editMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editMenuItem.Location = new System.Drawing.Point(5, 70);
            this.editMenuItem.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(205, 30);
            this.editMenuItem.TabIndex = 8;
            this.editMenuItem.Text = "УДАЛИТЬ МСЭ";
            this.editMenuItem.UseVisualStyleBackColor = true;
            this.editMenuItem.Click += new System.EventHandler(this.editClick);
            // 
            // addMenuItem
            // 
            this.addMenuItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.addMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMenuItem.Location = new System.Drawing.Point(5, 40);
            this.addMenuItem.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(205, 30);
            this.addMenuItem.TabIndex = 7;
            this.addMenuItem.Text = "ДОБАВИТЬ";
            this.addMenuItem.UseVisualStyleBackColor = true;
            this.addMenuItem.Click += new System.EventHandler(this.addClick);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchMenuItem.Location = new System.Drawing.Point(5, 10);
            this.searchMenuItem.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(205, 30);
            this.searchMenuItem.TabIndex = 6;
            this.searchMenuItem.Text = "ВЫБОР МСЭ";
            this.searchMenuItem.UseVisualStyleBackColor = true;
            this.searchMenuItem.Click += new System.EventHandler(this.SearchClick);
            // 
            // addItemContainer
            // 
            this.addItemContainer.Controls.Add(this.addItemParamContainer);
            this.addItemContainer.Controls.Add(this.addItemTopMenuContainer);
            this.addItemContainer.Controls.Add(this.addItemMenuContainer);
            this.addItemContainer.Location = new System.Drawing.Point(107, 106);
            this.addItemContainer.Name = "addItemContainer";
            this.addItemContainer.Size = new System.Drawing.Size(680, 423);
            this.addItemContainer.TabIndex = 1;
            this.addItemContainer.Visible = false;
            // 
            // addItemParamContainer
            // 
            this.addItemParamContainer.AllowChangeTerm = false;
            this.addItemParamContainer.AllowUserModifyList = true;
            this.addItemParamContainer.AutoScroll = true;
            this.addItemParamContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addItemParamContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addItemParamContainer.Location = new System.Drawing.Point(0, 28);
            this.addItemParamContainer.Name = "addItemParamContainer";
            this.addItemParamContainer.ReadOnly = false;
            this.addItemParamContainer.Size = new System.Drawing.Size(680, 360);
            this.addItemParamContainer.TabIndex = 4;
            // 
            // addItemTopMenuContainer
            // 
            this.addItemTopMenuContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addItemTopMenuContainer.Controls.Add(this.addItemName);
            this.addItemTopMenuContainer.Controls.Add(this.label7);
            this.addItemTopMenuContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.addItemTopMenuContainer.Location = new System.Drawing.Point(0, 0);
            this.addItemTopMenuContainer.Name = "addItemTopMenuContainer";
            this.addItemTopMenuContainer.Padding = new System.Windows.Forms.Padding(3);
            this.addItemTopMenuContainer.Size = new System.Drawing.Size(680, 28);
            this.addItemTopMenuContainer.TabIndex = 3;
            // 
            // addItemName
            // 
            this.addItemName.Dock = System.Windows.Forms.DockStyle.Left;
            this.addItemName.Location = new System.Drawing.Point(96, 3);
            this.addItemName.Name = "addItemName";
            this.addItemName.Size = new System.Drawing.Size(213, 20);
            this.addItemName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "ДОБАВИТЬ МСЭ";
            // 
            // addItemMenuContainer
            // 
            this.addItemMenuContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addItemMenuContainer.Controls.Add(this.addItemButton);
            this.addItemMenuContainer.Controls.Add(this.addItemGoBackButton);
            this.addItemMenuContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addItemMenuContainer.Location = new System.Drawing.Point(0, 388);
            this.addItemMenuContainer.Name = "addItemMenuContainer";
            this.addItemMenuContainer.Size = new System.Drawing.Size(680, 35);
            this.addItemMenuContainer.TabIndex = 2;
            // 
            // addItemButton
            // 
            this.addItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addItemButton.Location = new System.Drawing.Point(530, 0);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 35);
            this.addItemButton.TabIndex = 3;
            this.addItemButton.Text = "ДОБАВИТЬ";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // addItemGoBackButton
            // 
            this.addItemGoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addItemGoBackButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addItemGoBackButton.Location = new System.Drawing.Point(605, 0);
            this.addItemGoBackButton.Name = "addItemGoBackButton";
            this.addItemGoBackButton.Size = new System.Drawing.Size(75, 35);
            this.addItemGoBackButton.TabIndex = 2;
            this.addItemGoBackButton.Text = "В МЕНЮ";
            this.addItemGoBackButton.UseVisualStyleBackColor = true;
            this.addItemGoBackButton.Click += new System.EventHandler(this.GoBackToMenuClick);
            // 
            // editItemContainer
            // 
            this.editItemContainer.Controls.Add(this.editItemButtonsContainer);
            this.editItemContainer.Controls.Add(this.editItemsList);
            this.editItemContainer.Location = new System.Drawing.Point(887, 13);
            this.editItemContainer.Name = "editItemContainer";
            this.editItemContainer.Padding = new System.Windows.Forms.Padding(3);
            this.editItemContainer.Size = new System.Drawing.Size(632, 388);
            this.editItemContainer.TabIndex = 2;
            this.editItemContainer.Visible = false;
            // 
            // editItemButtonsContainer
            // 
            this.editItemButtonsContainer.Controls.Add(this.panel4);
            this.editItemButtonsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editItemButtonsContainer.Location = new System.Drawing.Point(220, 3);
            this.editItemButtonsContainer.Name = "editItemButtonsContainer";
            this.editItemButtonsContainer.Size = new System.Drawing.Size(409, 382);
            this.editItemButtonsContainer.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.editItemParamsContainer);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 382);
            this.panel4.TabIndex = 4;
            // 
            // editItemParamsContainer
            // 
            this.editItemParamsContainer.AllowChangeTerm = false;
            this.editItemParamsContainer.AllowUserModifyList = false;
            this.editItemParamsContainer.AutoScroll = true;
            this.editItemParamsContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.editItemParamsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editItemParamsContainer.Location = new System.Drawing.Point(0, 0);
            this.editItemParamsContainer.Name = "editItemParamsContainer";
            this.editItemParamsContainer.ReadOnly = true;
            this.editItemParamsContainer.Size = new System.Drawing.Size(409, 190);
            this.editItemParamsContainer.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.editItemGoBackButton);
            this.panel3.Controls.Add(this.editItemsEditButton);
            this.panel3.Controls.Add(this.editItemDeleteButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 192);
            this.panel3.TabIndex = 3;
            // 
            // editItemGoBackButton
            // 
            this.editItemGoBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editItemGoBackButton.Location = new System.Drawing.Point(150, 94);
            this.editItemGoBackButton.Name = "editItemGoBackButton";
            this.editItemGoBackButton.Size = new System.Drawing.Size(107, 26);
            this.editItemGoBackButton.TabIndex = 2;
            this.editItemGoBackButton.Text = "В МЕНЮ";
            this.editItemGoBackButton.UseVisualStyleBackColor = true;
            this.editItemGoBackButton.Click += new System.EventHandler(this.GoBackToMenuClick);
            // 
            // editItemsEditButton
            // 
            this.editItemsEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editItemsEditButton.Location = new System.Drawing.Point(150, 62);
            this.editItemsEditButton.Name = "editItemsEditButton";
            this.editItemsEditButton.Size = new System.Drawing.Size(107, 26);
            this.editItemsEditButton.TabIndex = 1;
            this.editItemsEditButton.Text = "ИЗМЕНИТЬ";
            this.editItemsEditButton.UseVisualStyleBackColor = true;
            this.editItemsEditButton.Click += new System.EventHandler(this.editItemsEditButton_Click);
            // 
            // editItemDeleteButton
            // 
            this.editItemDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editItemDeleteButton.Location = new System.Drawing.Point(149, 30);
            this.editItemDeleteButton.Name = "editItemDeleteButton";
            this.editItemDeleteButton.Size = new System.Drawing.Size(108, 26);
            this.editItemDeleteButton.TabIndex = 0;
            this.editItemDeleteButton.Text = "УДАЛИТЬ";
            this.editItemDeleteButton.UseVisualStyleBackColor = true;
            this.editItemDeleteButton.Click += new System.EventHandler(this.editItemDeleteButton_Click);
            // 
            // editItemsList
            // 
            this.editItemsList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.editItemsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.editItemsList.FormattingEnabled = true;
            this.editItemsList.Location = new System.Drawing.Point(3, 3);
            this.editItemsList.Name = "editItemsList";
            this.editItemsList.Size = new System.Drawing.Size(217, 382);
            this.editItemsList.TabIndex = 0;
            this.editItemsList.SelectedIndexChanged += new System.EventHandler(this.editItemsList_SelectedIndexChanged);
            // 
            // aboutContainer
            // 
            this.aboutContainer.Controls.Add(this.aboutText);
            this.aboutContainer.Controls.Add(this.aboutMenuContainer);
            this.aboutContainer.Location = new System.Drawing.Point(107, 106);
            this.aboutContainer.Name = "aboutContainer";
            this.aboutContainer.Size = new System.Drawing.Size(680, 423);
            this.aboutContainer.TabIndex = 3;
            this.aboutContainer.Visible = false;
            // 
            // aboutText
            // 
            this.aboutText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutText.Location = new System.Drawing.Point(0, 0);
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(680, 393);
            this.aboutText.TabIndex = 4;
            this.aboutText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutMenuContainer
            // 
            this.aboutMenuContainer.Controls.Add(this.aboutGoBackButton);
            this.aboutMenuContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutMenuContainer.Location = new System.Drawing.Point(0, 393);
            this.aboutMenuContainer.Name = "aboutMenuContainer";
            this.aboutMenuContainer.Size = new System.Drawing.Size(680, 30);
            this.aboutMenuContainer.TabIndex = 3;
            // 
            // aboutGoBackButton
            // 
            this.aboutGoBackButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.aboutGoBackButton.Location = new System.Drawing.Point(605, 0);
            this.aboutGoBackButton.Name = "aboutGoBackButton";
            this.aboutGoBackButton.Size = new System.Drawing.Size(75, 30);
            this.aboutGoBackButton.TabIndex = 3;
            this.aboutGoBackButton.Text = "В МЕНЮ";
            this.aboutGoBackButton.UseVisualStyleBackColor = true;
            this.aboutGoBackButton.Click += new System.EventHandler(this.GoBackToMenuClick);
            // 
            // searchContainer
            // 
            this.searchContainer.Controls.Add(this.searchButtonContainer);
            this.searchContainer.Controls.Add(this.searchTabs);
            this.searchContainer.Location = new System.Drawing.Point(107, 106);
            this.searchContainer.Name = "searchContainer";
            this.searchContainer.Size = new System.Drawing.Size(680, 423);
            this.searchContainer.TabIndex = 2;
            this.searchContainer.Visible = false;
            // 
            // searchButtonContainer
            // 
            this.searchButtonContainer.Controls.Add(this.searchButton);
            this.searchButtonContainer.Controls.Add(this.searchGoBackButton);
            this.searchButtonContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchButtonContainer.Location = new System.Drawing.Point(0, 393);
            this.searchButtonContainer.Name = "searchButtonContainer";
            this.searchButtonContainer.Size = new System.Drawing.Size(680, 30);
            this.searchButtonContainer.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButton.Location = new System.Drawing.Point(530, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 30);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "ПОИСК";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchGoBackButton
            // 
            this.searchGoBackButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchGoBackButton.Location = new System.Drawing.Point(605, 0);
            this.searchGoBackButton.Name = "searchGoBackButton";
            this.searchGoBackButton.Size = new System.Drawing.Size(75, 30);
            this.searchGoBackButton.TabIndex = 2;
            this.searchGoBackButton.Text = "В МЕНЮ";
            this.searchGoBackButton.UseVisualStyleBackColor = true;
            this.searchGoBackButton.Click += new System.EventHandler(this.GoBackToMenuClick);
            // 
            // searchTabs
            // 
            this.searchTabs.Controls.Add(this.searchTermsTab);
            this.searchTabs.Controls.Add(this.priceResultTab);
            this.searchTabs.Controls.Add(this.parametersResultTab);
            this.searchTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTabs.Location = new System.Drawing.Point(0, 0);
            this.searchTabs.Name = "searchTabs";
            this.searchTabs.SelectedIndex = 0;
            this.searchTabs.Size = new System.Drawing.Size(680, 423);
            this.searchTabs.TabIndex = 0;
            // 
            // searchTermsTab
            // 
            this.searchTermsTab.BackColor = System.Drawing.SystemColors.Control;
            this.searchTermsTab.Controls.Add(this.searchParametersList);
            this.searchTermsTab.Location = new System.Drawing.Point(4, 22);
            this.searchTermsTab.Name = "searchTermsTab";
            this.searchTermsTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTermsTab.Size = new System.Drawing.Size(672, 397);
            this.searchTermsTab.TabIndex = 0;
            this.searchTermsTab.Text = "Условия поиска";
            // 
            // searchParametersList
            // 
            this.searchParametersList.AllowChangeTerm = true;
            this.searchParametersList.AllowUserModifyList = false;
            this.searchParametersList.AutoScroll = true;
            this.searchParametersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchParametersList.Location = new System.Drawing.Point(3, 3);
            this.searchParametersList.Name = "searchParametersList";
            this.searchParametersList.ReadOnly = false;
            this.searchParametersList.Size = new System.Drawing.Size(666, 391);
            this.searchParametersList.TabIndex = 0;
            // 
            // priceResultTab
            // 
            this.priceResultTab.BackColor = System.Drawing.SystemColors.Control;
            this.priceResultTab.Controls.Add(this.priceResultParameters);
            this.priceResultTab.Controls.Add(this.panel1);
            this.priceResultTab.Location = new System.Drawing.Point(4, 22);
            this.priceResultTab.Name = "priceResultTab";
            this.priceResultTab.Padding = new System.Windows.Forms.Padding(3);
            this.priceResultTab.Size = new System.Drawing.Size(672, 397);
            this.priceResultTab.TabIndex = 1;
            this.priceResultTab.Text = "Результат(цена)";
            // 
            // priceResultParameters
            // 
            this.priceResultParameters.AllowChangeTerm = false;
            this.priceResultParameters.AllowUserModifyList = false;
            this.priceResultParameters.AutoScroll = true;
            this.priceResultParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceResultParameters.Location = new System.Drawing.Point(3, 31);
            this.priceResultParameters.Name = "priceResultParameters";
            this.priceResultParameters.ReadOnly = true;
            this.priceResultParameters.Size = new System.Drawing.Size(666, 363);
            this.priceResultParameters.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.priceResultName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(666, 28);
            this.panel1.TabIndex = 0;
            // 
            // priceResultName
            // 
            this.priceResultName.BackColor = System.Drawing.SystemColors.Window;
            this.priceResultName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceResultName.Location = new System.Drawing.Point(3, 3);
            this.priceResultName.Name = "priceResultName";
            this.priceResultName.ReadOnly = true;
            this.priceResultName.Size = new System.Drawing.Size(660, 20);
            this.priceResultName.TabIndex = 0;
            // 
            // parametersResultTab
            // 
            this.parametersResultTab.BackColor = System.Drawing.SystemColors.Control;
            this.parametersResultTab.Controls.Add(this.parameResultParameters);
            this.parametersResultTab.Controls.Add(this.panel2);
            this.parametersResultTab.Location = new System.Drawing.Point(4, 22);
            this.parametersResultTab.Name = "parametersResultTab";
            this.parametersResultTab.Padding = new System.Windows.Forms.Padding(3);
            this.parametersResultTab.Size = new System.Drawing.Size(672, 397);
            this.parametersResultTab.TabIndex = 2;
            this.parametersResultTab.Text = "Результат(параметры)";
            // 
            // parameResultParameters
            // 
            this.parameResultParameters.AllowChangeTerm = false;
            this.parameResultParameters.AllowUserModifyList = false;
            this.parameResultParameters.AutoScroll = true;
            this.parameResultParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameResultParameters.Location = new System.Drawing.Point(3, 31);
            this.parameResultParameters.Name = "parameResultParameters";
            this.parameResultParameters.ReadOnly = true;
            this.parameResultParameters.Size = new System.Drawing.Size(666, 363);
            this.parameResultParameters.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paramsResultName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(666, 28);
            this.panel2.TabIndex = 2;
            // 
            // paramsResultName
            // 
            this.paramsResultName.BackColor = System.Drawing.SystemColors.Window;
            this.paramsResultName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramsResultName.Location = new System.Drawing.Point(3, 3);
            this.paramsResultName.Name = "paramsResultName";
            this.paramsResultName.ReadOnly = true;
            this.paramsResultName.Size = new System.Drawing.Size(660, 20);
            this.paramsResultName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1520, 633);
            this.Controls.Add(this.editItemContainer);
            this.Controls.Add(this.addItemContainer);
            this.Controls.Add(this.searchContainer);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.aboutContainer);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(416, 249);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Программа написана студентом гр. ИСТ-742 Палладий Н.А.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenuButtonContainer.ResumeLayout(false);
            this.addItemContainer.ResumeLayout(false);
            this.addItemTopMenuContainer.ResumeLayout(false);
            this.addItemTopMenuContainer.PerformLayout();
            this.addItemMenuContainer.ResumeLayout(false);
            this.editItemContainer.ResumeLayout(false);
            this.editItemButtonsContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.aboutContainer.ResumeLayout(false);
            this.aboutMenuContainer.ResumeLayout(false);
            this.searchContainer.ResumeLayout(false);
            this.searchButtonContainer.ResumeLayout(false);
            this.searchTabs.ResumeLayout(false);
            this.searchTermsTab.ResumeLayout(false);
            this.priceResultTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.parametersResultTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.Panel addItemContainer;
        private System.Windows.Forms.Panel editItemContainer;
        private System.Windows.Forms.Panel aboutContainer;
        private System.Windows.Forms.Panel searchContainer;
        private System.Windows.Forms.Panel addItemMenuContainer;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button addItemGoBackButton;
        private System.Windows.Forms.TextBox addItemName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel addItemTopMenuContainer;
        private System.Windows.Forms.Panel aboutMenuContainer;
        private System.Windows.Forms.Button aboutGoBackButton;
        private System.Windows.Forms.Panel editItemButtonsContainer;
        private System.Windows.Forms.Button editItemsEditButton;
        private System.Windows.Forms.Button editItemDeleteButton;
        private System.Windows.Forms.ListBox editItemsList;
        private System.Windows.Forms.Button editItemGoBackButton;
        private ControlListContainer addItemParamContainer;
        private System.Windows.Forms.TabControl searchTabs;
        private System.Windows.Forms.TabPage searchTermsTab;
        private System.Windows.Forms.TabPage priceResultTab;
        private System.Windows.Forms.TabPage parametersResultTab;
        private ControlListContainer searchParametersList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox priceResultName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox paramsResultName;
        private System.Windows.Forms.Panel searchButtonContainer;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button searchGoBackButton;
        private ControlListContainer priceResultParameters;
        private ControlListContainer parameResultParameters;
        private System.Windows.Forms.Label aboutText;
        private System.Windows.Forms.Panel mainMenuButtonContainer;
        private System.Windows.Forms.Button exitMenuItem;
        private System.Windows.Forms.Button aboutMenuItem;
        private System.Windows.Forms.Button editMenuItem;
        private System.Windows.Forms.Button addMenuItem;
        private System.Windows.Forms.Button searchMenuItem;
        private System.Windows.Forms.Panel panel4;
        private ControlListContainer editItemParamsContainer;
        private System.Windows.Forms.Panel panel3;
    }
}

