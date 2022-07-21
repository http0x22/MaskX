using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Roblox_Executor_Template_by_leltard
{
    public partial class MaskXMain : Form
    {
        WeAreDevs_API.ExploitAPI api = new WeAreDevs_API.ExploitAPI();
        Point mousePos;

        public MaskXMain()
        {
            InitializeComponent();
        }
        private void MaskXMain_Load(object sender, EventArgs e)
        {
            ScriptList.Items.Clear();
            Functions.PopulateListBox(ScriptList, "./scripts", "*.lua");
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = new Point(-e.X, -e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mousePos.X, mousePos.Y);
                Location = mousePosition;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximazeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                MaximazeButton.Text = "M";
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                MaximazeButton.Text = "R";
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            api.SendScript(ScriptEditor.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ScriptEditor.Text = "";
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Lua scripts (*.lua)|*.lua";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Title = "Open Script File";
                ScriptEditor.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Lua scripts (*.lua)|*.lua";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sfd.Title = "Save Script File";

                using (Stream s = File.Open(sfd.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(ScriptEditor.Text);
                }
            }
            
        }

        private void InjectButton_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ScriptList.Items.Clear();
            Functions.PopulateListBox(ScriptList, "./scripts", "*.lua");
        }

        private void ScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptEditor.Text = File.ReadAllText($"./scripts/{ScriptList.SelectedItem}");
        }
    }
}
