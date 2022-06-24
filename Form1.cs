namespace _04052
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nameBox.Validating += nameBox_Validating;
            ageBox.Validating += ageBox_Validating;
        }

        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nameBox.Text))
            {
                errorProvider1.SetError(nameBox, "Не указано имя!");
            }
            else if (nameBox.Text.Length < 4)
            {
                errorProvider1.SetError(nameBox, "Слишком короткое имя!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void ageBox_Validating(object sender, CancelEventArgs e)
        {
            int age = 0;
            if (String.IsNullOrEmpty(ageBox.Text))
            {
                errorProvider1.SetError(ageBox, "Не указан возраст!");
            }
            else if (!Int32.TryParse(ageBox.Text, out age))
            {
                errorProvider1.SetError(ageBox, "Некорретный возраст!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}