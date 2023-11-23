using CSharpExercices;
using System.Linq;

namespace CSharpExersices
{
    public partial class Form1 : Form
    {
        private readonly ShowPicture showPictureWindow;
        private Dictionary<String, Action> executionDictionary = new Dictionary<String, Action>();


        public Form1()
        {
            InitializeComponent();
            this.showPictureWindow = new ShowPicture();

            this.executionDictionary.Add("+", () =>
            {
                this.label2.Text = "" + (int.Parse(this.textBox1.Text) + int.Parse(this.textBox2.Text));
            });
            this.executionDictionary.Add("-", () =>
            {
                this.label2.Text = "" + (int.Parse(this.textBox1.Text) - int.Parse(this.textBox2.Text));
            });
            this.executionDictionary.Add("*", () =>
            {
                this.label2.Text = "" + (int.Parse(this.textBox1.Text) * int.Parse(this.textBox2.Text));
            });
            this.executionDictionary.Add("/", () =>
            {
                this.label2.Text = "" + (int.Parse(this.textBox1.Text) / int.Parse(this.textBox2.Text));
            });
            this.label1.Text = getSelectedOperationAsString();

            Controls.OfType<RadioButton>().ToList().ForEach(r => r.Click += new EventHandler(this.onSelectorClick));
        }

        private void onSelectorClick(object? sender, EventArgs e)
        {
            this.label1.Text = getSelectedOperationAsString();
        }


        private string getSelectedOperationAsString()
        {
            return Controls.
                OfType<RadioButton>().
                ToList().
                Find(r => r.Checked)?.
                Text;
        }

        private void ModalSelectorCheckedChanged(object sender, EventArgs e)
        {
            this.modalSelector.ForeColor = this.modalSelector.Checked ? Color.Red : Color.Black;
        }

        private void OnNewImageClick(object sender, MouseEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png;|Todos los archivos (*.*)|*.*";
            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                showPictureWindow.Image = openFileDialog.FileName;
                if (this.modalSelector.Checked)
                    showPictureWindow.ShowDialog();
                else
                    this.showPictureWindow.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.executionDictionary[getSelectedOperationAsString()]();
        }
    }
}
