using SetupParameterLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetupParameterManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IList<SetupGroup> GetGroups()
        {
            return SetupParameterHandler.GetGroups();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cboGroups.DisplayMember = "Name";
                cboSubGroups.DisplayMember = "Name";
                cboParameters.DisplayMember = "Name";
                cboGroups.DataSource = GetGroups();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void cboGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null == cboGroups.SelectedItem) return;

            var dataitem = (SetupGroup)cboGroups.SelectedItem;
            cboSubGroups.DataSource = null;
            cboParameters.DataSource = null;
            cboSubGroups.DisplayMember = "Name";
            cboSubGroups.DataSource = dataitem.SetupSubGroups;
        }

        private void cboSubGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null == cboSubGroups.SelectedItem) return;

            var dataitem = (SetupSubGroup)cboSubGroups.SelectedItem;
            cboParameters.DataSource = null;
            cboParameters.DisplayMember = "Name";
            cboParameters.DataSource = dataitem.SetupParameters;
        }

        private void cboParameters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var g = new SetupGroup();
                g.Name = txtName.Text;
                g.Key = txtKey.Text;
                g.DisplayIndex = 0;
                SetupParameterHandler.SaveGroup(g);
                cboGroups.DataSource = GetGroups();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
