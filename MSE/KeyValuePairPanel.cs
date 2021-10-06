using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MSE
{
    public partial class KeyValuePairPanel : UserControl
    {
        
        private String[] CompareSigns = { ">", ">=", "=", "<=", "<" };

        private DataBase.CompareTerm compareTerm = DataBase.CompareTerm.COPMARE_EQUAL;
        private bool m_changeTermAllowed = false;
        private bool m_readOnly;

        public bool changeTermAllowed
        {
            get
            {
                return m_changeTermAllowed;
            }
            set
            {
                m_changeTermAllowed = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                return m_readOnly;
            }
            set
            {
                m_readOnly = value;
                valueNum.ReadOnly = m_readOnly;
                checkBox1.Visible = !value;
            }
        }

        public bool AllowUserModify
        {
            set
            {
                deleteButton.Visible = value;
                keyTextBox.ReadOnly = !value;
            }
        }

        public bool Used
        {
            set
            {
                checkBox1.Checked = value;
            }
            get
            {
                return checkBox1.Checked;
            }
        }

        public String Key
        {
            get
            {
                return keyTextBox.Text;
            }
            set
            {
                keyTextBox.Text = value;
            }
        }

        public int Value
        {
            get
            {
                return (int)valueNum.Value;
            }
            set
            {
                valueNum.Value = value;
            }
        }

        public DataBase.CompareTerm Term
        {
            get
            {
                return compareTerm;
            }
            set
            {
                compareTerm = value;
                spacerLabel.Text = CompareSigns[(int)compareTerm];
            }
        }


        public KeyValuePairPanel()
        {
            InitializeComponent();
            keyTextBox.AutoCompleteCustomSource.Add(DataBase.PRICE_STRING_CONST);
        }

        public void setPositionLabel(int position)
        {
            positionLabel.Text = position.ToString();
        }

        public void setDeleteButtonHandler(EventHandler handler)
        {
            deleteButton.Click += handler;
        }

        public bool check()
        {
            return (keyTextBox.Text != "");
        }


        private void spacerLabel_Click(object sender, EventArgs e)
        {
            if (m_changeTermAllowed && !m_readOnly)
            {
                ++compareTerm;
                if (compareTerm == DataBase.CompareTerm.VALUES_COUNT)
                    compareTerm = 0;
                spacerLabel.Text = CompareSigns[(int)compareTerm];
            }
        }

        private void KeyValuePairPanel_Layout(object sender, LayoutEventArgs e)
        {
            keyTextBox.Width = Width / 4;
            valueNum.Width = Width / 4;
        }

        public void showDeleteButton(bool show)
        {
            deleteButton.Visible = show;
        }
    }
}
