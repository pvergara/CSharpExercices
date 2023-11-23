namespace CSharpExercices
{
    public partial class ShowPicture : Form
    {
        private string _image;

        public ShowPicture()
        {
            InitializeComponent();
        }

        public string Image {
            get
            {
                return _image;
            }
            set
            {
                this._image = value;
                this.pictureBox1.Image = new Bitmap(Image);
            }
        }
    }
}
