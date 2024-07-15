namespace imageLabellingTool
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            loadImageToolStripMenuItem = new ToolStripMenuItem();
            loadDirectoryToolStripMenuItem = new ToolStripMenuItem();
            clearImagesToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveLabeToolStripMenuItem = new ToolStripMenuItem();
            PanelForControl = new Panel();
            LabelSettingPanel = new Panel();
            SaveImageLabeledButton = new Button();
            ColorButton = new Button();
            comboBox1 = new ComboBox();
            positionlabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ImageListBox = new ListBox();
            ImagePanel = new Panel();
            PictureBoxSelectedImage = new PictureBox();
            menuStrip1.SuspendLayout();
            PanelForControl.SuspendLayout();
            LabelSettingPanel.SuspendLayout();
            ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxSelectedImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadImageToolStripMenuItem, loadDirectoryToolStripMenuItem, clearImagesToolStripMenuItem });
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(71, 24);
            loadToolStripMenuItem.Text = "Load...";
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new Size(200, 26);
            loadImageToolStripMenuItem.Text = "Load Image";
            loadImageToolStripMenuItem.Click += LoadImage_Click;
            // 
            // loadDirectoryToolStripMenuItem
            // 
            loadDirectoryToolStripMenuItem.Name = "loadDirectoryToolStripMenuItem";
            loadDirectoryToolStripMenuItem.Size = new Size(200, 26);
            loadDirectoryToolStripMenuItem.Text = "Load Directory";
            loadDirectoryToolStripMenuItem.Click += LoadDirectory_click;
            // 
            // clearImagesToolStripMenuItem
            // 
            clearImagesToolStripMenuItem.Name = "clearImagesToolStripMenuItem";
            clearImagesToolStripMenuItem.Size = new Size(200, 26);
            clearImagesToolStripMenuItem.Text = "Clear Images";
            clearImagesToolStripMenuItem.Click += ClearImages_click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveLabeToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(69, 24);
            saveToolStripMenuItem.Text = "Save...";
            // 
            // saveLabeToolStripMenuItem
            // 
            saveLabeToolStripMenuItem.Name = "saveLabeToolStripMenuItem";
            saveLabeToolStripMenuItem.Size = new Size(244, 26);
            saveLabeToolStripMenuItem.Text = "Save Labeled Images";
            saveLabeToolStripMenuItem.Click += SaveImages_click;
            // 
            // PanelForControl
            // 
            PanelForControl.Controls.Add(LabelSettingPanel);
            PanelForControl.Controls.Add(ImageListBox);
            PanelForControl.Dock = DockStyle.Left;
            PanelForControl.Location = new Point(0, 28);
            PanelForControl.Name = "PanelForControl";
            PanelForControl.Size = new Size(240, 525);
            PanelForControl.TabIndex = 1;
            // 
            // LabelSettingPanel
            // 
            LabelSettingPanel.Controls.Add(SaveImageLabeledButton);
            LabelSettingPanel.Controls.Add(ColorButton);
            LabelSettingPanel.Controls.Add(comboBox1);
            LabelSettingPanel.Controls.Add(positionlabel);
            LabelSettingPanel.Controls.Add(textBox1);
            LabelSettingPanel.Controls.Add(label1);
            LabelSettingPanel.Dock = DockStyle.Bottom;
            LabelSettingPanel.Location = new Point(0, 375);
            LabelSettingPanel.Name = "LabelSettingPanel";
            LabelSettingPanel.Size = new Size(240, 150);
            LabelSettingPanel.TabIndex = 2;
            // 
            // SaveImageLabeledButton
            // 
            SaveImageLabeledButton.Location = new Point(12, 105);
            SaveImageLabeledButton.Name = "SaveImageLabeledButton";
            SaveImageLabeledButton.Size = new Size(211, 29);
            SaveImageLabeledButton.TabIndex = 2;
            SaveImageLabeledButton.Text = "Save Labeled Images";
            SaveImageLabeledButton.UseVisualStyleBackColor = true;
            SaveImageLabeledButton.Click += SaveImages_click;
            // 
            // ColorButton
            // 
            ColorButton.BackColor = Color.Red;
            ColorButton.Location = new Point(192, 70);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(31, 29);
            ColorButton.TabIndex = 2;
            ColorButton.UseVisualStyleBackColor = false;
            ColorButton.Click += ColorButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Top Left", "Top Right", "Bottom Left", "Bottom Right" });
            comboBox1.Location = new Point(12, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 28);
            comboBox1.TabIndex = 2;
            // 
            // positionlabel
            // 
            positionlabel.AutoSize = true;
            positionlabel.Location = new Point(3, 48);
            positionlabel.Name = "positionlabel";
            positionlabel.Size = new Size(141, 20);
            positionlabel.TabIndex = 2;
            positionlabel.Text = "Position and color";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 2;
            label1.Text = "Text:";
            // 
            // ImageListBox
            // 
            ImageListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ImageListBox.FormattingEnabled = true;
            ImageListBox.ItemHeight = 20;
            ImageListBox.Location = new Point(0, 0);
            ImageListBox.Name = "ImageListBox";
            ImageListBox.Size = new Size(240, 304);
            ImageListBox.TabIndex = 2;
            ImageListBox.SelectedIndexChanged += ListBoxImages_SelectedIndexChanged;
            // 
            // ImagePanel
            // 
            ImagePanel.Controls.Add(PictureBoxSelectedImage);
            ImagePanel.Dock = DockStyle.Fill;
            ImagePanel.Location = new Point(240, 28);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(542, 525);
            ImagePanel.TabIndex = 2;
            // 
            // PictureBoxSelectedImage
            // 
            PictureBoxSelectedImage.BackgroundImageLayout = ImageLayout.Center;
            PictureBoxSelectedImage.Dock = DockStyle.Fill;
            PictureBoxSelectedImage.Location = new Point(0, 0);
            PictureBoxSelectedImage.Name = "PictureBoxSelectedImage";
            PictureBoxSelectedImage.Size = new Size(542, 525);
            PictureBoxSelectedImage.TabIndex = 0;
            PictureBoxSelectedImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(ImagePanel);
            Controls.Add(PanelForControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            PanelForControl.ResumeLayout(false);
            LabelSettingPanel.ResumeLayout(false);
            LabelSettingPanel.PerformLayout();
            ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxSelectedImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private ToolStripMenuItem loadDirectoryToolStripMenuItem;
        private ToolStripMenuItem clearImagesToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveLabeToolStripMenuItem;
        private Panel PanelForControl;
        private ListBox ImageListBox;
        private Panel LabelSettingPanel;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label positionlabel;
        private Button ColorButton;
        private Button SaveImageLabeledButton;
        private Panel ImagePanel;
        private PictureBox PictureBoxSelectedImage;
    }
}
