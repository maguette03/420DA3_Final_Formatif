namespace _420DA3_Final_Formatif.Presentation
{
    partial class MainMenu
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
            topBarPanel = new Panel();
            buttomBarPanel = new Panel();
            printDialog1 = new PrintDialog();
            centerTabelLayot = new TableLayoutPanel();
            centerPanel = new Panel();
            btnCreateCountry = new Button();
            btnView = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            SearchTextBox = new TextBox();
            searchResults = new ListBox();
            BtnQuitter = new Button();
            buttomBarPanel.SuspendLayout();
            centerTabelLayot.SuspendLayout();
            centerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topBarPanel
            // 
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(0, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(378, 39);
            topBarPanel.TabIndex = 0;
            // 
            // buttomBarPanel
            // 
            buttomBarPanel.Controls.Add(BtnQuitter);
            buttomBarPanel.Dock = DockStyle.Bottom;
            buttomBarPanel.Location = new Point(0, 305);
            buttomBarPanel.Name = "buttomBarPanel";
            buttomBarPanel.Size = new Size(378, 39);
            buttomBarPanel.TabIndex = 1;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // centerTabelLayot
            // 
            centerTabelLayot.ColumnCount = 3;
            centerTabelLayot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            centerTabelLayot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            centerTabelLayot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            centerTabelLayot.Controls.Add(centerPanel, 1, 0);
            centerTabelLayot.Dock = DockStyle.Fill;
            centerTabelLayot.Location = new Point(0, 39);
            centerTabelLayot.Name = "centerTabelLayot";
            centerTabelLayot.RowCount = 1;
            centerTabelLayot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            centerTabelLayot.Size = new Size(378, 266);
            centerTabelLayot.TabIndex = 2;
            // 
            // centerPanel
            // 
            centerPanel.Controls.Add(searchResults);
            centerPanel.Controls.Add(SearchTextBox);
            centerPanel.Controls.Add(btnDelete);
            centerPanel.Controls.Add(btnEdit);
            centerPanel.Controls.Add(btnView);
            centerPanel.Controls.Add(btnCreateCountry);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(67, 3);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(244, 260);
            centerPanel.TabIndex = 0;
            // 
            // btnCreateCountry
            // 
            btnCreateCountry.Location = new Point(3, 3);
            btnCreateCountry.Name = "btnCreateCountry";
            btnCreateCountry.Size = new Size(238, 33);
            btnCreateCountry.TabIndex = 0;
            btnCreateCountry.Text = "Create New Country";
            btnCreateCountry.UseVisualStyleBackColor = true;
            btnCreateCountry.Click += btnCreateCountry_Click;
            // 
            // btnView
            // 
            btnView.Enabled = false;
            btnView.Location = new Point(3, 224);
            btnView.Name = "btnView";
            btnView.Size = new Size(68, 33);
            btnView.TabIndex = 1;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(77, 224);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(72, 33);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(169, 224);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 33);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(0, 64);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Shearch Countries";
            SearchTextBox.Size = new Size(241, 31);
            SearchTextBox.TabIndex = 4;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // searchResults
            // 
            searchResults.FormattingEnabled = true;
            searchResults.ItemHeight = 25;
            searchResults.Location = new Point(3, 96);
            searchResults.Name = "searchResults";
            searchResults.Size = new Size(235, 104);
            searchResults.TabIndex = 5;
            searchResults.SelectedIndexChanged += searchResults_SelectedIndexChanged;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Location = new Point(266, 3);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(109, 33);
            BtnQuitter.TabIndex = 4;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 344);
            Controls.Add(centerTabelLayot);
            Controls.Add(buttomBarPanel);
            Controls.Add(topBarPanel);
            Name = "MainMenu";
            Text = "MainMenu";
            buttomBarPanel.ResumeLayout(false);
            centerTabelLayot.ResumeLayout(false);
            centerPanel.ResumeLayout(false);
            centerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topBarPanel;
        private Panel buttomBarPanel;
        private PrintDialog printDialog1;
        private TableLayoutPanel centerTabelLayot;
        private Panel centerPanel;
        private Button btnView;
        private Button btnCreateCountry;
        private ListBox searchResults;
        private TextBox SearchTextBox;
        private Button btnDelete;
        private Button btnEdit;
        private Button BtnQuitter;
    }
}