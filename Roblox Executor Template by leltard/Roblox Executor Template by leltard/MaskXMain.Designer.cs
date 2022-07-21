namespace Roblox_Executor_Template_by_leltard
{
    partial class MaskXMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaskXMain));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ButtonsContainer = new System.Windows.Forms.Panel();
            this.ScriptList = new System.Windows.Forms.ListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MaximazeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ScriptEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ExecutorTitle = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.InjectButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.ButtonsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TopPanel.Controls.Add(this.ExecutorTitle);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.MaximazeButton);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 40);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // ButtonsContainer
            // 
            this.ButtonsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ButtonsContainer.Controls.Add(this.RefreshButton);
            this.ButtonsContainer.Controls.Add(this.OptionsButton);
            this.ButtonsContainer.Controls.Add(this.InjectButton);
            this.ButtonsContainer.Controls.Add(this.SaveFileButton);
            this.ButtonsContainer.Controls.Add(this.OpenFileButton);
            this.ButtonsContainer.Controls.Add(this.ClearButton);
            this.ButtonsContainer.Controls.Add(this.ExecuteButton);
            this.ButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsContainer.Location = new System.Drawing.Point(0, 260);
            this.ButtonsContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonsContainer.Name = "ButtonsContainer";
            this.ButtonsContainer.Size = new System.Drawing.Size(800, 40);
            this.ButtonsContainer.TabIndex = 1;
            // 
            // ScriptList
            // 
            this.ScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptList.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScriptList.ForeColor = System.Drawing.Color.White;
            this.ScriptList.FormattingEnabled = true;
            this.ScriptList.ItemHeight = 15;
            this.ScriptList.Location = new System.Drawing.Point(618, 40);
            this.ScriptList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(182, 220);
            this.ScriptList.TabIndex = 3;
            this.ScriptList.SelectedIndexChanged += new System.EventHandler(this.ScriptList_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(770, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "✕";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MaximazeButton
            // 
            this.MaximazeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximazeButton.FlatAppearance.BorderSize = 0;
            this.MaximazeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximazeButton.Location = new System.Drawing.Point(734, 0);
            this.MaximazeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximazeButton.Name = "MaximazeButton";
            this.MaximazeButton.Size = new System.Drawing.Size(30, 30);
            this.MaximazeButton.TabIndex = 1;
            this.MaximazeButton.Text = "M";
            this.MaximazeButton.UseVisualStyleBackColor = true;
            this.MaximazeButton.Click += new System.EventHandler(this.MaximazeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(698, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ScriptEditor
            // 
            this.ScriptEditor.AutoCompleteBrackets = true;
            this.ScriptEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ScriptEditor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.ScriptEditor.AutoScrollMinSize = new System.Drawing.Size(323, 15);
            this.ScriptEditor.BackBrush = null;
            this.ScriptEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ScriptEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ScriptEditor.CharHeight = 15;
            this.ScriptEditor.CharWidth = 8;
            this.ScriptEditor.CommentPrefix = "--";
            this.ScriptEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScriptEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptEditor.Font = new System.Drawing.Font("Courier New", 10F);
            this.ScriptEditor.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ScriptEditor.IsReplaceMode = false;
            this.ScriptEditor.Language = FastColoredTextBoxNS.Language.Lua;
            this.ScriptEditor.LeftBracket = '(';
            this.ScriptEditor.LeftBracket2 = '{';
            this.ScriptEditor.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.ScriptEditor.Location = new System.Drawing.Point(0, 40);
            this.ScriptEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ScriptEditor.Name = "ScriptEditor";
            this.ScriptEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptEditor.RightBracket = ')';
            this.ScriptEditor.RightBracket2 = '}';
            this.ScriptEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ScriptEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptEditor.ServiceColors")));
            this.ScriptEditor.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ScriptEditor.Size = new System.Drawing.Size(618, 220);
            this.ScriptEditor.TabIndex = 6;
            this.ScriptEditor.Text = "// This template was made by leltard!";
            this.ScriptEditor.Zoom = 100;
            // 
            // ExecutorTitle
            // 
            this.ExecutorTitle.AutoSize = true;
            this.ExecutorTitle.Location = new System.Drawing.Point(13, 13);
            this.ExecutorTitle.Name = "ExecutorTitle";
            this.ExecutorTitle.Size = new System.Drawing.Size(42, 15);
            this.ExecutorTitle.TabIndex = 3;
            this.ExecutorTitle.Text = "MaskX";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ExecuteButton.FlatAppearance.BorderSize = 0;
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteButton.Location = new System.Drawing.Point(4, 7);
            this.ExecuteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(100, 27);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(112, 7);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 27);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.OpenFileButton.FlatAppearance.BorderSize = 0;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Location = new System.Drawing.Point(220, 7);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(100, 27);
            this.OpenFileButton.TabIndex = 6;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SaveFileButton.FlatAppearance.BorderSize = 0;
            this.SaveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFileButton.Location = new System.Drawing.Point(328, 7);
            this.SaveFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(100, 27);
            this.SaveFileButton.TabIndex = 7;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = false;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // InjectButton
            // 
            this.InjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.InjectButton.FlatAppearance.BorderSize = 0;
            this.InjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectButton.Location = new System.Drawing.Point(436, 7);
            this.InjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InjectButton.Name = "InjectButton";
            this.InjectButton.Size = new System.Drawing.Size(100, 27);
            this.InjectButton.TabIndex = 8;
            this.InjectButton.Text = "Inject";
            this.InjectButton.UseVisualStyleBackColor = false;
            this.InjectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.OptionsButton.FlatAppearance.BorderSize = 0;
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.Location = new System.Drawing.Point(696, 7);
            this.OptionsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(100, 27);
            this.OptionsButton.TabIndex = 9;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Location = new System.Drawing.Point(588, 7);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(100, 27);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MaskXMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.ScriptEditor);
            this.Controls.Add(this.ScriptList);
            this.Controls.Add(this.ButtonsContainer);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MaskXMain";
            this.Text = "MaskX";
            this.Load += new System.EventHandler(this.MaskXMain_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ButtonsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ButtonsContainer;
        private System.Windows.Forms.ListBox ScriptList;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button MaximazeButton;
        private System.Windows.Forms.Label ExecutorTitle;
        private FastColoredTextBoxNS.FastColoredTextBox ScriptEditor;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button InjectButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}

