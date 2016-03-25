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
    public partial class SetupGroupsEditor : Form
    {
        public enum EditMode
        {
            None,
            Add,
            Edit,
            Delete,
            Copy
        }
        private enum SetupSelectionType
        {
            None,
            Group,
            SubGroup,
            Parameter
        }

        private SetupSelectionType _selectionType = SetupSelectionType.None;
        private EditMode _editMode = EditMode.None;
        private IList<SetupGroup> _groups;

        public SetupGroupsEditor()
        {
            InitializeComponent();
        }

        private void SetupGroupsEditor_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            _groups = GetGroups();
            DisplayGroups(_groups);

        }
        private IList<SetupGroup> GetGroups()
        {
            return SetupParameterHandler.GetGroups();
        }
        private void DisplayGroups(IList<SetupGroup> groups)
        {
            try
            {
                var prevLevel = 0;
                var prevName = string.Empty;

                if (tvSetup.SelectedNode != null)
                {
                    prevLevel = tvSetup.SelectedNode.Level;
                    prevName = tvSetup.SelectedNode.Name;
                }
                tvSetup.SuspendLayout();

                tvSetup.Nodes.Clear();

                var rootNode = tvSetup.Nodes.Add("Setup Groups");
                rootNode.Name = "root";
                
                foreach (SetupGroup group in groups.OrderBy(n => n.DisplayIndex))
                {
                    var groupNode = new TreeNode(group.Name) { Tag = group };
                    groupNode.Name = group.Name;
                    foreach (SetupSubGroup subGroup in group.SetupSubGroups.OrderBy(n => n.DisplayIndex))
                    {
                        var subGroupNode = new TreeNode(subGroup.Name) { Tag = subGroup };
                        subGroupNode.Name = subGroup.Name;
                        groupNode.Nodes.Add(subGroupNode);
                        foreach (SetupParameter parameter in subGroup.SetupParameters.OrderBy(n => n.DisplayIndex))
                        {
                            var paramNode = new TreeNode(parameter.Name) { Tag = parameter };
                            paramNode.Name = parameter.Name;
                            subGroupNode.Nodes.Add(paramNode);
                        }
                    }
                    rootNode.Nodes.Add(groupNode);
                }

                rootNode.Expand();
                if (!String.IsNullOrEmpty(prevName))
                {
                    var nodes = tvSetup.Nodes.Find(prevName, true);
                    foreach (var node in nodes)
                    {
                        var foundNode = node;

                        foundNode.Expand();
                        while(foundNode.Parent != null)
                        {
                            foundNode = foundNode.Parent;
                            foundNode.Expand();
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                tvSetup.ResumeLayout();
            }
        }

        private void tvSetup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var node = e.Node;
                var tagObj = node.Tag;
                SetupSelectionType selection = SetupSelectionType.None;

                if (tagObj is SetupGroup)
                {
                    selection = SetupSelectionType.Group;
                }
                else if (tagObj is SetupSubGroup)
                {
                    selection = SetupSelectionType.SubGroup;
                }
                else if (tagObj is SetupParameter)
                {
                    selection = SetupSelectionType.Parameter;
                }

                UpdateUIState(selection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void UpdateUIState(SetupSelectionType selection)
        {
            switch (selection)
            {
                case SetupSelectionType.Group:
                    {
                        tvSetup.ContextMenuStrip = this.ctxGroup;
                        break;
                    }
                case SetupSelectionType.SubGroup:
                    {
                        tvSetup.ContextMenuStrip = this.ctxSubGroup;
                        break;
                    }
                case SetupSelectionType.Parameter:
                    {
                        tvSetup.ContextMenuStrip = this.ctxParameter;
                        break;
                    }
                case SetupSelectionType.None:
                    {
                        tvSetup.ContextMenuStrip = null;
                        break;
                    }
            }
            _selectionType = selection;
        }

        // param context menu //
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyObject();
        }
        private void deleteParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvSetup.SelectedNode == null) return;
            if (tvSetup.SelectedNode.Tag == null) return;
            var tagObj = tvSetup.SelectedNode.Tag;
            if (!(tagObj is SetupParameter)) return;

            var param = (SetupParameter)tagObj;

            EditParameter(param, EditMode.Delete);

        }
        private void editParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvSetup.SelectedNode == null) return;
            if (tvSetup.SelectedNode.Tag == null) return;
            var tagObj = tvSetup.SelectedNode.Tag;
            if (!(tagObj is SetupParameter)) return;

            var param = (SetupParameter)tagObj;

            EditParameter(param, EditMode.Edit);
        }
        // subgroup context menu //
        private void addParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvSetup.SelectedNode == null) return;
            if (tvSetup.SelectedNode.Tag == null) return;
            var tagObj = tvSetup.SelectedNode.Tag;
            if (!(tagObj is SetupSubGroup)) return;

            var subGroup = (SetupSubGroup)tagObj;

            var param = new SetupParameter() { SetupSubGroupId = subGroup.SetupSubGroupId, Name = "<New Parameter>", Key = "<NewParameter>", DisplayIndex = subGroup.SetupParameters.Count() };

            EditParameter(param, EditMode.Add);
        }
        private void deleteSubGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvSetup.SelectedNode == null) return;
            if (tvSetup.SelectedNode.Tag == null) return;
            var tagObj = tvSetup.SelectedNode.Tag;
            if (!(tagObj is SetupSubGroup)) return;

            var subGroup = (SetupSubGroup)tagObj;

            EditSubGroup(subGroup, EditMode.Delete);
        }
        private void editSubGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvSetup.SelectedNode == null) return;
            if (tvSetup.SelectedNode.Tag == null) return;
            var tagObj = tvSetup.SelectedNode.Tag;
            if (!(tagObj is SetupSubGroup)) return;

            var subGroup = (SetupSubGroup)tagObj;

            EditSubGroup(subGroup, EditMode.Edit);
        }
        // group context menu //
        private void addSubGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvSetup.SelectedNode == null) return;
            if (tvSetup.SelectedNode.Tag == null) return;
            var tagObj = tvSetup.SelectedNode.Tag;
            if (!(tagObj is SetupGroup)) return;

            var group = (SetupGroup)tagObj;

            var subGroup = new SetupSubGroup() { SetupGroupId = group.SetupGroupId, Name = "<New Group>", Key = "<NewGroup>", DisplayIndex = group.SetupSubGroups.Count() };

            EditSubGroup(subGroup, EditMode.Add);
        }
        private void tsmDeleteGroup_Click(object sender, EventArgs e)
        {
            if (tvSetup.SelectedNode == null) return;
            if (tvSetup.SelectedNode.Tag == null) return;
            var tagObj = tvSetup.SelectedNode.Tag;
            if (!(tagObj is SetupGroup)) return;

            var group = (SetupGroup)tagObj;

            EditGroup(group, EditMode.Delete);
        }
        private void tsmEditGroup_Click(object sender, EventArgs e)
        {
            if (tvSetup.SelectedNode == null) return;
            if (tvSetup.SelectedNode.Tag == null) return;
            var tagObj = tvSetup.SelectedNode.Tag;
            if (!(tagObj is SetupGroup)) return;

            var group = (SetupGroup)tagObj;

            EditGroup(group, EditMode.Edit);
        }

        private void SetEditMode(EditMode mode)
        {
            tvSetup.Enabled = (mode == EditMode.None);
            toolStrip1.Enabled = (mode == EditMode.None);
            _editMode = mode;
        }

        private void EditGroup(SetupGroup group, EditMode mode)
        {
            _selectionType = SetupSelectionType.Group;
            SetEditMode(mode);
            if (mode == EditMode.Delete)
            {
                if (ConfirmDelete(group.Name))
                {
                    SetupParameterHandler.DeleteGroup(group.SetupGroupId);
                }
                ClearEditArea();
                UpdateDisplay();
            }
            else
            {
                pnlEditButtons.Visible = true;
                pnlParam.Visible = false;
                pnlParam.Dock = DockStyle.None;
                pnlGroup.Visible = true;
                pnlGroup.Dock = DockStyle.Fill;
                txtName.Text = group.Name;
                txtKey.Text = group.Key;
                txtName.SelectAll();
                txtName.Focus();
            }
        }
        private void EditSubGroup(SetupSubGroup subGroup, EditMode mode)
        {
            _selectionType = SetupSelectionType.SubGroup;
            SetEditMode(mode);
            if (mode == EditMode.Delete)
            {
                if (ConfirmDelete(subGroup.Name))
                {
                    SetupParameterHandler.DeleteSubGroup(subGroup.SetupSubGroupId);
                }
                ClearEditArea();
                UpdateDisplay();
            }
            else
            {
                pnlEditButtons.Visible = true;
                pnlParam.Visible = false;
                pnlParam.Dock = DockStyle.None;
                pnlGroup.Visible = true;
                pnlGroup.Dock = DockStyle.Fill;
                txtName.Text = subGroup.Name;
                txtKey.Text = subGroup.Key;
                txtName.SelectAll();
                txtName.Focus();
            }
        }
        private void EditParameter(SetupParameter parameter, EditMode mode)
        {
            _selectionType = SetupSelectionType.Parameter;
            SetEditMode(mode);
            if (mode == EditMode.Delete)
            {
                if (ConfirmDelete(parameter.Name))
                {
                    SetupParameterHandler.DeleteParameter(parameter.SetupParameterId);
                }
                ClearEditArea();
                UpdateDisplay();
            }
            else
            {
                pnlEditButtons.Visible = true;
                pnlGroup.Visible = true;
                pnlGroup.Dock = DockStyle.Top;
                pnlParam.Visible = true;
                pnlParam.Dock = DockStyle.Fill;
                pnlParam.BringToFront();
                txtName.Text = parameter.Name;
                txtKey.Text = parameter.Key;
                txtOriginalSuffix.Text = parameter.OriginalSuffix;
                txtTranslatedSuffix.Text = parameter.TranslatedSuffix;
                chkTranslatable.Checked = parameter.IsTranslatable;
                txtName.SelectAll();
                txtName.Focus();
            }
        }
        private bool ConfirmDelete(string Name)
        {
            var result = MessageBox.Show(String.Format("Delete {0}?", Name), "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return (result == DialogResult.OK);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectionType == SetupSelectionType.Group)
                {
                    var group = (SetupGroup)tvSetup.SelectedNode.Tag;
                    group.Name = txtName.Text;
                    group.Key = txtKey.Text;
                    SetupParameterHandler.SaveGroup(group);
                }
                else if (_selectionType == SetupSelectionType.SubGroup)
                {
                    if (_editMode == EditMode.Add)
                    {
                        var group = (SetupGroup)tvSetup.SelectedNode.Tag;
                        var newSubGroup = new SetupSubGroup()
                        {
                            SetupGroupId = group.SetupGroupId,
                            Name = txtName.Text,
                            Key = txtKey.Text,
                            DisplayIndex = group.SetupSubGroups.Count()
                        };
                        group.SetupSubGroups.Add(newSubGroup);
                        SetupParameterHandler.SaveSubGroup(newSubGroup);
                    }
                    else if (_editMode == EditMode.Edit)
                    {
                        var subGroup = (SetupSubGroup)tvSetup.SelectedNode.Tag;
                        subGroup.Name = txtName.Text;
                        subGroup.Key = txtKey.Text;
                        SetupParameterHandler.SaveSubGroup(subGroup);
                    }
                }
                else if (_selectionType == SetupSelectionType.Parameter)
                {
                    if (_editMode == EditMode.Add)
                    {
                        var subGroup = (SetupSubGroup)tvSetup.SelectedNode.Tag;
                        var newParam = new SetupParameter()
                        {
                            SetupSubGroupId = subGroup.SetupSubGroupId,
                            Name = txtName.Text,
                            Key = txtKey.Text,
                            DisplayIndex = subGroup.SetupParameters.Count(),
                            OriginalSuffix = txtOriginalSuffix.Text,
                            TranslatedSuffix = txtTranslatedSuffix.Text,
                            IsTranslatable = chkTranslatable.Checked
                        };
                        subGroup.SetupParameters.Add(newParam);
                        SetupParameterHandler.SaveParameter(newParam);
                    }
                    else if (_editMode == EditMode.Edit)
                    {
                        var param = (SetupParameter)tvSetup.SelectedNode.Tag;
                        param.Name = txtName.Text;
                        param.Key = txtKey.Text;
                        SetupParameterHandler.SaveParameter(param);
                    }
                }

                ClearEditArea();

                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearEditArea();
        }

        private void ClearEditArea()
        {
            SetEditMode(EditMode.None);
            pnlEditButtons.Visible = false;
            pnlGroup.Visible = false;
            pnlGroup.Dock = DockStyle.None;
            pnlParam.Visible = false;
            pnlParam.Dock = DockStyle.None;
            txtName.Clear();
            txtKey.Clear();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtKey.Text.StartsWith("<"))
            {
                txtKey.Text = txtName.Text.Replace(" ", "");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private object _copyObj = null;
        private SetupSelectionType _copySelection = SetupSelectionType.None;
        private void tsbCopy_Click(object sender, EventArgs e)
        {
            CopyObject();
        }

        private void tsbPaste_Click(object sender, EventArgs e)
        {
            PasteObject();
        }

        private void CopyObject()
        {
            try
            {
                if (null == tvSetup.SelectedNode) return;

                var node = tvSetup.SelectedNode;
                _copyObj = node.Tag;
                _copySelection = SetupSelectionType.None;

                if (_copyObj is SetupGroup)
                {
                    _copySelection = SetupSelectionType.Group;
                }
                else if (_copyObj is SetupSubGroup)
                {
                    _copySelection = SetupSelectionType.SubGroup;
                }
                else if (_copyObj is SetupParameter)
                {
                    _copySelection = SetupSelectionType.Parameter;
                }
                EnablePaste();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void EnablePaste()
        {
            tsbPaste.Enabled = true;
            pasteToolStripMenuItem.Enabled = true;
            pasteToolStripMenuItem1.Enabled = true;
            pasteToolStripMenuItem2.Enabled = true;
        }
        private void DisablePaste()
        {
            tsbPaste.Enabled = false;
            pasteToolStripMenuItem.Enabled = false;
            pasteToolStripMenuItem1.Enabled = false;
            pasteToolStripMenuItem2.Enabled = false;
        }
        private void PasteObject()
        {
            try
            {
                if (null == tvSetup.SelectedNode) return;

                var node = tvSetup.SelectedNode;
                var pasteObj = node.Tag;
                if (pasteObj is SetupGroup)
                {
                    if (_copyObj is SetupSubGroup)
                    {
                        var target = (SetupGroup)pasteObj;
                        var source = (SetupSubGroup)_copyObj;
                        var newObj = source.Clone();
                        newObj.SetupGroupId = target.SetupGroupId;
                        SetupParameterHandler.SaveSubGroup(newObj);
                        _copyObj = null;
                        _copySelection = SetupSelectionType.None;
                    }
                }
                else if (pasteObj is SetupSubGroup)
                {
                    if (_copyObj is SetupParameter)
                    {
                        var target = (SetupSubGroup)pasteObj;
                        var source = (SetupParameter)_copyObj;
                        var newObj = source.Clone();
                        newObj.SetupSubGroupId = target.SetupSubGroupId;
                        SetupParameterHandler.SaveParameter(newObj);
                        _copyObj = null;
                        _copySelection = SetupSelectionType.None;
                    }
                }
                DisablePaste();
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CopyObject();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteObject();
        }
    }
}