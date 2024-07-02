using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class LibrarySystem : Form
    {
        private Rectangle buttonOriginalRectangle;
        private Rectangle originalFormSize;
        private Rectangle buttonManageRectangle;

        public LibrarySystem()
        {
            InitializeComponent();
        }

        private void LibrarySystem_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle = new Rectangle(borrowButton.Location.X, borrowButton.Location.Y, borrowButton.Width, borrowButton.Height);
            buttonManageRectangle = new Rectangle(manageButton.Location.X, manageButton.Location.Y, manageButton.Width, manageButton.Height);
        }

        private void resizeControl(Rectangle rect, Control cont)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(rect.X * xRatio);
            int newY = (int)(rect.Y * yRatio);

            int newWidth = (int)(rect.Width * xRatio);
            int newHeight = (int)(rect.Height * yRatio);

            cont.Location = new Point(newX, newY);
            cont.Size = new Size(newWidth, newHeight);
        }

        private void LibrarySystem_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonOriginalRectangle, borrowButton);
            resizeControl(buttonManageRectangle, manageButton);
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            borrowBooks f2 = new borrowBooks();
            f2.Show();
            Visible = false;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            manageBooks f2 = new manageBooks();
            f2.Show();
            Visible = false;
        }
    }
}
