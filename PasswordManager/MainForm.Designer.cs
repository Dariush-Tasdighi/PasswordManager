namespace PasswordManager
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			myMenuStrip = new Dtat.Windows.Forms.MenuStrip();
			fileToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			newToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			openToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem1 = new Dtat.Windows.Forms.ToolStripSeparator();
			aboutToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			exitToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			toolsToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			insertToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			duplicateToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			updateToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			deleteToolStripMenuItem = new Dtat.Windows.Forms.ToolStripMenuItem();
			myStatusStrip = new Dtat.Windows.Forms.StatusStrip();
			menuPanel = new Dtat.Windows.Forms.Panel();
			menuSplitter = new Dtat.Windows.Forms.Splitter();
			mainPanel = new Dtat.Windows.Forms.Panel();
			myDataGridView = new Dtat.Windows.Forms.DataGridView();
			searchPanel = new Dtat.Windows.Forms.Panel();
			label1 = new Dtat.Windows.Forms.Label();
			searchTextBox = new Dtat.Windows.Forms.TextBox();
			fileTextBox = new Dtat.Windows.Forms.TextBox();
			pathNameLabel = new Dtat.Windows.Forms.Label();
			myMenuStrip.SuspendLayout();
			mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)myDataGridView).BeginInit();
			searchPanel.SuspendLayout();
			SuspendLayout();
			// 
			// myMenuStrip
			// 
			myMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
			myMenuStrip.Location = new System.Drawing.Point(0, 0);
			myMenuStrip.Name = "myMenuStrip";
			myMenuStrip.Size = new System.Drawing.Size(753, 28);
			myMenuStrip.TabIndex = 0;
			myMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripMenuItem1, aboutToolStripMenuItem, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			newToolStripMenuItem.Text = "&New";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			openToolStripMenuItem.Text = "&Open";
			openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			aboutToolStripMenuItem.Text = "&About";
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			exitToolStripMenuItem.Text = "E&xit";
			// 
			// toolsToolStripMenuItem
			// 
			toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { insertToolStripMenuItem, duplicateToolStripMenuItem, updateToolStripMenuItem, deleteToolStripMenuItem });
			toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			toolsToolStripMenuItem.Text = "&Tools";
			// 
			// insertToolStripMenuItem
			// 
			insertToolStripMenuItem.Name = "insertToolStripMenuItem";
			insertToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
			insertToolStripMenuItem.Text = "&Insert";
			// 
			// duplicateToolStripMenuItem
			// 
			duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
			duplicateToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
			duplicateToolStripMenuItem.Text = "Du&plicate";
			// 
			// updateToolStripMenuItem
			// 
			updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			updateToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
			updateToolStripMenuItem.Text = "&Update";
			// 
			// deleteToolStripMenuItem
			// 
			deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			deleteToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
			deleteToolStripMenuItem.Text = "&Delete";
			// 
			// myStatusStrip
			// 
			myStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			myStatusStrip.Location = new System.Drawing.Point(0, 467);
			myStatusStrip.Name = "myStatusStrip";
			myStatusStrip.Size = new System.Drawing.Size(753, 22);
			myStatusStrip.TabIndex = 1;
			myStatusStrip.Text = "statusStrip1";
			// 
			// menuPanel
			// 
			menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			menuPanel.Location = new System.Drawing.Point(0, 28);
			menuPanel.Name = "menuPanel";
			menuPanel.Size = new System.Drawing.Size(250, 439);
			menuPanel.TabIndex = 2;
			// 
			// menuSplitter
			// 
			menuSplitter.Location = new System.Drawing.Point(250, 28);
			menuSplitter.Name = "menuSplitter";
			menuSplitter.Size = new System.Drawing.Size(4, 439);
			menuSplitter.TabIndex = 3;
			menuSplitter.TabStop = false;
			// 
			// mainPanel
			// 
			mainPanel.Controls.Add(myDataGridView);
			mainPanel.Controls.Add(searchPanel);
			mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			mainPanel.Location = new System.Drawing.Point(254, 28);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new System.Drawing.Size(499, 439);
			mainPanel.TabIndex = 4;
			// 
			// myDataGridView
			// 
			myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			myDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			myDataGridView.Location = new System.Drawing.Point(0, 68);
			myDataGridView.Name = "myDataGridView";
			myDataGridView.RowHeadersWidth = 51;
			myDataGridView.Size = new System.Drawing.Size(499, 371);
			myDataGridView.TabIndex = 1;
			// 
			// searchPanel
			// 
			searchPanel.Controls.Add(label1);
			searchPanel.Controls.Add(searchTextBox);
			searchPanel.Controls.Add(fileTextBox);
			searchPanel.Controls.Add(pathNameLabel);
			searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
			searchPanel.Location = new System.Drawing.Point(0, 0);
			searchPanel.Name = "searchPanel";
			searchPanel.Size = new System.Drawing.Size(499, 68);
			searchPanel.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(6, 39);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(69, 20);
			label1.TabIndex = 3;
			label1.Text = "&Search";
			// 
			// searchTextBox
			// 
			searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			searchTextBox.Location = new System.Drawing.Point(81, 36);
			searchTextBox.Name = "searchTextBox";
			searchTextBox.Size = new System.Drawing.Size(415, 27);
			searchTextBox.TabIndex = 2;
			searchTextBox.TextChanged += SearchTextBox_TextChanged;
			// 
			// fileTextBox
			// 
			fileTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			fileTextBox.Location = new System.Drawing.Point(81, 3);
			fileTextBox.Name = "fileTextBox";
			fileTextBox.ReadOnly = true;
			fileTextBox.Size = new System.Drawing.Size(415, 27);
			fileTextBox.TabIndex = 1;
			// 
			// pathNameLabel
			// 
			pathNameLabel.AutoSize = true;
			pathNameLabel.Location = new System.Drawing.Point(6, 6);
			pathNameLabel.Name = "pathNameLabel";
			pathNameLabel.Size = new System.Drawing.Size(49, 20);
			pathNameLabel.TabIndex = 0;
			pathNameLabel.Text = "&File";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(753, 489);
			Controls.Add(mainPanel);
			Controls.Add(menuSplitter);
			Controls.Add(menuPanel);
			Controls.Add(myStatusStrip);
			Controls.Add(myMenuStrip);
			MainMenuStrip = myMenuStrip;
			Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			Name = "MainForm";
			Text = "Password Manager";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			Load += MainForm_Load;
			myMenuStrip.ResumeLayout(false);
			myMenuStrip.PerformLayout();
			mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)myDataGridView).EndInit();
			searchPanel.ResumeLayout(false);
			searchPanel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Dtat.Windows.Forms.MenuStrip myMenuStrip;
		private Dtat.Windows.Forms.StatusStrip myStatusStrip;
		private Dtat.Windows.Forms.Panel menuPanel;
		private Dtat.Windows.Forms.Splitter menuSplitter;
		private Dtat.Windows.Forms.Panel mainPanel;
		private Dtat.Windows.Forms.DataGridView myDataGridView;
		private Dtat.Windows.Forms.Panel searchPanel;
		private Dtat.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private Dtat.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private Dtat.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private Dtat.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private Dtat.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private Dtat.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private Dtat.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private Dtat.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
		private Dtat.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
		private Dtat.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private Dtat.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private Dtat.Windows.Forms.Label label1;
		private Dtat.Windows.Forms.TextBox searchTextBox;
		private Dtat.Windows.Forms.TextBox fileTextBox;
		private Dtat.Windows.Forms.Label pathNameLabel;
	}
}
