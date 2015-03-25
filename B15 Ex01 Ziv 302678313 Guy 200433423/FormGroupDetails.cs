using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace B15_Ex01_Ziv_302678313_Guy_200433423
{
    public partial class FormGroupDetails : Form
    {
        Group m_Group;

        public FormGroupDetails(Group i_Group)
        {
            InitializeComponent();
            m_Group = i_Group;
            fetchGroupDetails();
        }

        private void fetchGroupDetails()
        {
            pictureBox.LoadAsync(m_Group.IconUrl);
            labelGroupName.Text = m_Group.Name;
            if (!string.IsNullOrEmpty(m_Group.Description))
            {
                labelGroupDescription.Text = m_Group.Description;
            }
            else
            {
                labelGroupDescription.Text = "No Description.";
            }

            foreach (User member in m_Group.Members)
            {
                listBoxGroupMembers.Items.Add(member.Name);
            }	
        }
    }
}
