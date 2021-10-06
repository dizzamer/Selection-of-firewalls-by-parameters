using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MSE
{
    public partial class Form1 : Form
    {

        private DataBase db;

        public Form1()
        {
            InitializeComponent();
            CheckConfig();
        }

        private void CheckConfig()
        {
            // Загрузка параметров
            // В данный момент параметры определенны в программе
            // запрет изменения списка параметров
            addItemParamContainer.AllowUserModifyList = false;
            searchParametersList.AllowUserModifyList = false;
            editItemParamsContainer.AllowUserModifyList = false;
            // заполнение списков параметров для поиска, добавления, редактирования
            List<String> parametersNames = new List<String>
            {
                "Стоимость",
                "Пропускная способность(Мбит/с)",
                "Число зон безопасности",
                "Кол-во портов 10МБит/с",
                "Кол-во портов 100МБит/с",
                "Кол-во портов 1ГБит/с",
                "Наличие сетевого интерфейса",
                "Кол-во пользователей",
                "Кол-во одновременных сессий",
                "Кол-во правил фильтрации",
                "Кол-во виртуальных маршрутизаторов",
                "Кол-во поддерживаемых туннелей VPN"
            };
            foreach (var item in parametersNames)
            {
                addItemParamContainer.addItem(item, 0);
                searchParametersList.addItem(item, 0);
                editItemParamsContainer.addItem(item, 0);
            }
        }

        //***************************************** Меню ******************************

        private void addClick(object sender, EventArgs e)
        {
            addItemContainer.Visible = true;
            addItemContainer.BringToFront();
            mainMenu.Visible = false;
            mainMenu.Dock = DockStyle.None;
            addItemContainer.Dock = DockStyle.Fill;
        }

        private void editClick(object sender, EventArgs e)
        {
            editItemContainer.Visible = true;
            editItemContainer.BringToFront();
            mainMenu.Visible = false;
            mainMenu.Dock = DockStyle.None;
            editItemContainer.Dock = DockStyle.Fill;
        }

        private void AboutClick(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("about.txt")) // загрузка текста окна О программе
            {                
                aboutText.Text = System.IO.File.ReadAllText("about.txt", Encoding.GetEncoding(1251));
            }
            aboutContainer.Visible = true;
            aboutContainer.BringToFront();
            mainMenu.Visible = false;
            mainMenu.Dock = DockStyle.None;
            aboutContainer.Dock = DockStyle.Fill;
        }       

        private void SearchClick(object sender, EventArgs e)
        {            
            searchContainer.Visible = true;
            searchContainer.BringToFront();
            mainMenu.Visible = false;
            mainMenu.Dock = DockStyle.None;
            searchContainer.Dock = DockStyle.Fill;
        }

        private void GoBackToMenuClick(object sender, EventArgs e)
        {
            mainMenu.Visible = true;
            mainMenu.BringToFront();
            searchContainer.Visible = aboutContainer.Visible = addItemContainer.Visible = editItemContainer.Visible = false;
            searchContainer.Dock = aboutContainer.Dock = addItemContainer.Dock = editItemContainer.Dock = DockStyle.None;
            mainMenu.Dock = DockStyle.Fill;
        }

        //***************************************** Меню ******************************
        
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DataBase();
            db.LoadFromFile();
            editItemsList.DataSource = db.items;
            mainMenu.BringToFront();
            mainMenu.Dock = DockStyle.Fill;
        }

        private void AddItemButton_Click(object sender, EventArgs e) // добавление нового МСЭ
        {
            DataBase.DataBaseItem item  = new DataBase.DataBaseItem();
            item.name = addItemName.Text;
            item.parameters = new Dictionary<String, int>();
            foreach (KeyValuePairPanel pan in addItemParamContainer.items)
            {
                item.parameters.Add(pan.Key, pan.Value);
            }
            db.AddItem(item);
            MessageBox.Show(this, "МСЭ добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoBackToMenuClick(null, null);
            addItemParamContainer.ClearValues();
        }

        private void editItemDeleteButton_Click(object sender, EventArgs e) // удаление МСЭ из списка
        {
            if (editItemsList.SelectedItem != null)
                db.DeleteItem(editItemsList.SelectedItem as DataBase.DataBaseItem);
        }

        private void exitMenuItem_Click(object sender, EventArgs e) // выход
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // сохранение перед выходом
        {
            db.saveToFile();
        }

        private void searchButton_Click(object sender, EventArgs e) // поиск
        {
            priceResultParameters.Clear();
            parameResultParameters.Clear();
            List<DataBase.SearchParameter> par = new List<DataBase.SearchParameter>();
            foreach (var term in searchParametersList.items) // заполнение списка параметров поиска
            {
                if (!term.Used)
                    continue;
                DataBase.SearchParameter p = new DataBase.SearchParameter
                {
                    key = term.Key,
                    value = term.Value,
                    term = term.Term
                };
                par.Add(p);
            }

            if (par.Count > 0) // если список не пустой
            {                
                var res = db.search(par); // поиск
                if (res[0] != null) // если найден элемент по цене
                {
                    priceResultName.Text = res[0].name;
                    foreach(var param in res[0].parameters)
                    {
                        priceResultParameters.addItem(param.Key, param.Value);
                    }
                    searchTabs.SelectedIndex = 1;
                }
                if (res[1] != null) // если найден элемент по параметрам
                {
                    paramsResultName.Text = res[1].name;
                    foreach (var param in res[1].parameters)
                    {
                        parameResultParameters.addItem(param.Key, param.Value);
                    }
                }
            }
        }

        private void mainMenu_Layout(object sender, LayoutEventArgs e) // автоподстройка ширины
        {
            mainMenuButtonContainer.Location = new Point(mainMenu.Width / 2 - mainMenuButtonContainer.Width / 2, mainMenu.Height / 2 - mainMenuButtonContainer.Height / 2);
        }

        private void editItemsList_SelectedIndexChanged(object sender, EventArgs e) // отображение параметров выбранного МСЭ в окне редактирования
        {
            editItemParamsContainer.Clear();
            editItemsEditButton.Text = "ИЗМЕНИТЬ";
            editItemParamsContainer.ReadOnly = true;
            foreach(var p in ((DataBase.DataBaseItem)editItemsList.SelectedItem).parameters)
            {
                editItemParamsContainer.addItem(p.Key, p.Value);
            }
        }

        private void editItemsEditButton_Click(object sender, EventArgs e) // изменение - созранение МСЭ в окне редактирования
        {
            if (editItemsEditButton.Text == "ИЗМЕНИТЬ")
            {
                editItemParamsContainer.ReadOnly = false;
                editItemsEditButton.Text = "СОХРАНИТЬ";
            } else
            {
                editItemParamsContainer.ReadOnly = true;
                DataBase.DataBaseItem item = (DataBase.DataBaseItem)editItemsList.SelectedItem;
                foreach (var p in editItemParamsContainer.items)
                {
                    if (item.parameters.ContainsKey(p.Key))
                        item.parameters[p.Key] = p.Value;
                }
                editItemsEditButton.Text = "ИЗМЕНИТЬ";
            }
        }

    }
}
