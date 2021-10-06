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
    public partial class ControlListContainer : UserControl
    {
        public ControlListContainer()
        {
            InitializeComponent();
            items = new List<KeyValuePairPanel>();
        }

        public bool AllowUserModifyList
        {
            get
            {
                return m_allowUserModifyList;
            }
            set
            {
                m_allowUserModifyList = value;
                itemAddButtonContainer.Visible = m_allowUserModifyList;
                foreach (var pan in items)
                {
                    //pan.showDeleteButton(m_llowUserModifyList);
                    pan.AllowUserModify = m_allowUserModifyList;
                }
            }
        }

        public bool AllowChangeTerm
        {
            get
            {
                return m_allowChangeTerm;
            }
            set
            {
                m_allowChangeTerm = value;
                foreach(var pan in items)
                {
                    pan.changeTermAllowed = m_allowChangeTerm;
                }
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
                foreach (var pan in items)
                {
                    pan.ReadOnly = m_readOnly;
                }
            }
        }

        private bool m_readOnly = false;
        private bool m_allowChangeTerm = false;
        private bool m_allowUserModifyList = true;

        public List<KeyValuePairPanel> items;

        public void addItem(String key, int value, DataBase.CompareTerm term = DataBase.CompareTerm.COPMARE_EQUAL)
        {
            KeyValuePairPanel pan = new KeyValuePairPanel();
            pan.Parent = this;
            pan.Dock = DockStyle.Top;
            pan.setDeleteButtonHandler(new EventHandler(this.deleteParamButtonClick));
            pan.setPositionLabel(this.Controls.Count - 1);
            pan.changeTermAllowed = m_allowChangeTerm;
            pan.ReadOnly = m_readOnly;
            pan.AllowUserModify = m_allowUserModifyList;
            pan.Key = key;
            pan.Value = value;
            pan.Term = term;

            this.Controls.Add(pan);
            pan.BringToFront();
            itemAddButtonContainer.BringToFront();
            items.Add(pan);
        }

        public void Clear()
        {
            foreach(var item in items)
            {
                this.Controls.Remove(item);
            }
            items.Clear();
        }

        public void ClearValues()
        {
            foreach (var item in items)
            {
                item.Value = 0;
            }
        }

        private void addItemAddParamButton_Click(object sender, EventArgs e)
        {

            KeyValuePairPanel pan = new KeyValuePairPanel();
            pan.Parent = this;
            pan.Dock = DockStyle.Top;
            pan.setDeleteButtonHandler(new EventHandler(this.deleteParamButtonClick));
            pan.setPositionLabel(this.Controls.Count - 1);
            pan.changeTermAllowed = m_allowChangeTerm;

            this.Controls.Add(pan);
            pan.BringToFront();
            itemAddButtonContainer.BringToFront();
            items.Add(pan);
        }

        private void deleteParamButtonClick(object sender, EventArgs e)
        {
            if (!(sender is Control))
                return;
            this.Controls.Remove(((Control)sender).Parent);
            items.Remove((KeyValuePairPanel)((Control)sender).Parent);
            for (int i = 1; i < this.Controls.Count; ++i)
            {
                ((KeyValuePairPanel)(this.Controls[i])).setPositionLabel(this.Controls.Count - i);
            }
        }
    }
}
