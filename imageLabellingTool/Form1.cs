using System.Windows.Forms;

namespace imageLabellingTool
{
    public partial class Form1 : Form
    {
        public Color labelColor = Color.Red;
        public string[] imageFiles;
        public Form1()
        {
            InitializeComponent();
            initialize();
        }
        public void initialize()
        {
            comboBox1.SelectedIndex = 0;
            ColorButton.BackColor = labelColor;
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.png;*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageListBox.Items.Add(openFileDialog.FileName);
                }
            }

        }

        private void LoadDirectory_click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    imageFiles = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.*")
                                          .Where(file => file.EndsWith(".bmp") || file.EndsWith(".png") || file.EndsWith(".jpg"))
                                          .ToArray();
                    ImageListBox.Items.AddRange(imageFiles);
                }
            }

        }

        private void ClearImages_click(object sender, EventArgs e)
        {
            ImageListBox.Items.Clear();
            PictureBoxSelectedImage.Image = null;
        }

        private void SaveImages_click(object sender, EventArgs e)
        {
            foreach (string filePath in ImageListBox.Items)
            {
                using (var savefiledialog = new SaveFileDialog())
                {
                    savefiledialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    savefiledialog.FileName = "labeled_" + Path.GetFileName(filePath);
                    if(savefiledialog.ShowDialog() == DialogResult.OK)
                    {
                        saveLabelImage(filePath, savefiledialog.FileName);
                    }
                }
               
                
            }

            MessageBox.Show("Labeled images have been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void saveLabelImage(string filepath,string savepath)
        {
            Image image = Image.FromFile(filepath);
            using (Graphics g = Graphics.FromImage(image))
            {
                string labelText = string.Format(label1.Text, ImageListBox.SelectedIndex);
                DrawLabel(g, image, labelText);
            }
            image.Save(savepath);
            
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    labelColor = colorDialog.Color;
                    ColorButton.BackColor = labelColor;
                }
            }
        }
        private void DrawLabel(Graphics g, Image image, string labelText)
        {
            using (Font font = new Font("Arial", image.Width / 20))
            using (Brush brush = new SolidBrush(labelColor))
            {
                SizeF textSize = g.MeasureString(labelText, font);
                PointF position = GetLabelPosition(image, textSize);
                g.DrawString(labelText, font, brush, position);
            }
        }
        private PointF GetLabelPosition(Image image, SizeF textSize)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Top Left":
                    return new PointF(10, 10);
                case "Top Right":
                    return new PointF(image.Width - textSize.Width - 10, 10);
                case "Bottom Left":
                    return new PointF(10, image.Height - textSize.Height - 10);
                case "Bottom Right":
                    return new PointF(image.Width - textSize.Width - 10, image.Height - textSize.Height - 10);
                default:
                    return new PointF(10, 10);
            }
        }
        private void DisplayImage(string filePath)
        {
            Image image = Image.FromFile(filePath);
            Bitmap bitmap = new Bitmap(image);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                string labelText = string.Format(textBox1.Text, ImageListBox.SelectedIndex);
                DrawLabel(g, image, labelText);
            }
            PictureBoxSelectedImage.Image = bitmap;
        }

        private void ListBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImageListBox.SelectedItem != null)
            {
                string filePath = ImageListBox.SelectedItem.ToString();
                DisplayImage(filePath);
            }
        }
    }
}
