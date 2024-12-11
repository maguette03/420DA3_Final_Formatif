namespace _420DA3_Final_Formatif.Presentation
{
    partial class CountryView
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
            TopBarpanel = new Panel();
            ButtomBarpanel = new Panel();
            btnAction = new Button();
            BtnAnnuler = new Button();
            centerTableLayoutPanel = new TableLayoutPanel();
            panel1 = new Panel();
            SpokenLanguageLabel = new Label();
            SpokenLanguageValue = new ListBox();
            FullNameValue = new TextBox();
            ShortNameValue = new TextBox();
            IdValue = new NumericUpDown();
            FullNameLabel = new Label();
            ShortNameLable = new Label();
            IdLabel = new Label();
            ButtomBarpanel.SuspendLayout();
            centerTableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IdValue).BeginInit();
            SuspendLayout();
            // 
            // TopBarpanel
            // 
            TopBarpanel.Dock = DockStyle.Top;
            TopBarpanel.Location = new Point(0, 0);
            TopBarpanel.Name = "TopBarpanel";
            TopBarpanel.Size = new Size(578, 76);
            TopBarpanel.TabIndex = 0;
            // 
            // ButtomBarpanel
            // 
            ButtomBarpanel.Controls.Add(btnAction);
            ButtomBarpanel.Controls.Add(BtnAnnuler);
            ButtomBarpanel.Dock = DockStyle.Bottom;
            ButtomBarpanel.Location = new Point(0, 468);
            ButtomBarpanel.Name = "ButtomBarpanel";
            ButtomBarpanel.Size = new Size(578, 76);
            ButtomBarpanel.TabIndex = 1;
            // 
            // btnAction
            // 
            btnAction.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAction.Location = new Point(252, 15);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(145, 39);
            btnAction.TabIndex = 1;
            btnAction.Text = "PLACEHOLDER";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAnnuler.Location = new Point(421, 15);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(145, 39);
            BtnAnnuler.TabIndex = 0;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            BtnAnnuler.Click += BtnAnnuler_Click;
            // 
            // centerTableLayoutPanel
            // 
            centerTableLayoutPanel.ColumnCount = 3;
            centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            centerTableLayoutPanel.Controls.Add(panel1, 1, 0);
            centerTableLayoutPanel.Dock = DockStyle.Fill;
            centerTableLayoutPanel.Location = new Point(0, 76);
            centerTableLayoutPanel.Name = "centerTableLayoutPanel";
            centerTableLayoutPanel.RowCount = 1;
            centerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            centerTableLayoutPanel.Size = new Size(578, 392);
            centerTableLayoutPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(SpokenLanguageLabel);
            panel1.Controls.Add(SpokenLanguageValue);
            panel1.Controls.Add(FullNameValue);
            panel1.Controls.Add(ShortNameValue);
            panel1.Controls.Add(IdValue);
            panel1.Controls.Add(FullNameLabel);
            panel1.Controls.Add(ShortNameLable);
            panel1.Controls.Add(IdLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(42, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 386);
            panel1.TabIndex = 0;
            // 
            // SpokenLanguageLabel
            // 
            SpokenLanguageLabel.Location = new Point(3, 141);
            SpokenLanguageLabel.Margin = new Padding(3);
            SpokenLanguageLabel.Name = "SpokenLanguageLabel";
            SpokenLanguageLabel.Size = new Size(491, 28);
            SpokenLanguageLabel.TabIndex = 7;
            SpokenLanguageLabel.Text = "Spoken Language:";
            SpokenLanguageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SpokenLanguageValue
            // 
            SpokenLanguageValue.FormattingEnabled = true;
            SpokenLanguageValue.ItemHeight = 25;
            SpokenLanguageValue.Location = new Point(3, 185);
            SpokenLanguageValue.Name = "SpokenLanguageValue";
            SpokenLanguageValue.SelectionMode = SelectionMode.MultiSimple;
            SpokenLanguageValue.Size = new Size(488, 179);
            SpokenLanguageValue.TabIndex = 6;
            // 
            // FullNameValue
            // 
            FullNameValue.Location = new Point(196, 97);
            FullNameValue.Name = "FullNameValue";
            FullNameValue.PlaceholderText = "FullName";
            FullNameValue.Size = new Size(281, 31);
            FullNameValue.TabIndex = 5;
            // 
            // ShortNameValue
            // 
            ShortNameValue.Location = new Point(196, 54);
            ShortNameValue.Name = "ShortNameValue";
            ShortNameValue.PlaceholderText = "ShortName";
            ShortNameValue.Size = new Size(281, 31);
            ShortNameValue.TabIndex = 4;
            // 
            // IdValue
            // 
            IdValue.Enabled = false;
            IdValue.Location = new Point(196, 11);
            IdValue.Maximum = new decimal(new int[] { -402653184, -1613725636, 54210108, 0 });
            IdValue.Name = "IdValue";
            IdValue.Size = new Size(281, 31);
            IdValue.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            FullNameLabel.Location = new Point(3, 100);
            FullNameLabel.Margin = new Padding(3);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(180, 23);
            FullNameLabel.TabIndex = 2;
            FullNameLabel.Text = "FullName:";
            FullNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // ShortNameLable
            // 
            ShortNameLable.Location = new Point(3, 57);
            ShortNameLable.Margin = new Padding(3);
            ShortNameLable.Name = "ShortNameLable";
            ShortNameLable.Size = new Size(180, 23);
            ShortNameLable.TabIndex = 1;
            ShortNameLable.Text = "ShortName:";
            ShortNameLable.TextAlign = ContentAlignment.TopRight;
            // 
            // IdLabel
            // 
            IdLabel.Location = new Point(10, 13);
            IdLabel.Margin = new Padding(3);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(180, 23);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "Id:";
            IdLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CountryView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 544);
            Controls.Add(centerTableLayoutPanel);
            Controls.Add(ButtomBarpanel);
            Controls.Add(TopBarpanel);
            MinimumSize = new Size(600, 600);
            Name = "CountryView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des Pays";
            ButtomBarpanel.ResumeLayout(false);
            centerTableLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IdValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopBarpanel;
        private Panel ButtomBarpanel;
        private TableLayoutPanel centerTableLayoutPanel;
        private Panel panel1;
        private Label IdLabel;
        private Label ShortNameLable;
        private NumericUpDown IdValue;
        private Label FullNameLabel;
        private TextBox FullNameValue;
        private TextBox ShortNameValue;
        private Label SpokenLanguageLabel;
        private ListBox SpokenLanguageValue;
        private Button btnAction;
        private Button BtnAnnuler;
    }
}