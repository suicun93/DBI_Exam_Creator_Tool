using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using DBI_Exam_Creator_Tool.Utils;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class PicturePreview : Form
    {
        public List<string> Images { get; set; }

        public PicturePreview(List<string> images)
        {
            InitializeComponent();
            this.Images = images;

            renderImages();
        }

        private void renderImages()
        {
            tabControl.TabPages.Clear();
            for (var i = 0; i < Images.Count; i++)
            {
                var imgData = Images[i];
                Image image = ImageUtils.Base64StringToImage(imgData);

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = image;

                TabPage tab = new TabPage("Image " + (i + 1));
                tab.AutoScroll = true;
                tab.Controls.Add(pb);

                tabControl.TabPages.Add(tab);
            }
        }

        private void renderTab(int i)
        {
            var imgData = Images[i];
            Image image = ImageUtils.Base64StringToImage(imgData);

            PictureBox pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.Image = image;

            TabPage tab = new TabPage("Image " + (i + 1));
            tab.AutoScroll = true;
            tab.Controls.Add(pb);

            tabControl.TabPages[i] = tab;
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            var selectedIndex = tabControl.SelectedIndex;
            if (selectedIndex != 0)
            {
                var temp = Images[selectedIndex - 1];
                Images[selectedIndex - 1] = Images[selectedIndex];
                Images[selectedIndex] = temp;

                //renderTab(selectedIndex - 1);
                //renderTab(selectedIndex);
                renderImages();
                tabControl.SelectedIndex = selectedIndex - 1;
            }
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            var selectedIndex = tabControl.SelectedIndex;
            if (selectedIndex != tabControl.TabPages.Count - 1)
            {
                var temp = Images[selectedIndex + 1];
                Images[selectedIndex + 1] = Images[selectedIndex];
                Images[selectedIndex] = temp;

                //renderTab(selectedIndex + 1);
                //renderTab(selectedIndex);
                renderImages();
                tabControl.SelectedIndex = selectedIndex + 1;
            }
        }
    }
}
