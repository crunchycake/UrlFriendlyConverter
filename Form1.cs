using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;

namespace UrlFriendlyConverter
{
    public partial class UrlFriendlyConverter : Form
    {
        public UrlFriendlyConverter()
        {
            InitializeComponent();
            this.Text = "UrlFriendlyConverter";
            btnConvert.Click += btnConvert_Click;
            btnCopy.Click += btnCopy_Click;
            chkAutoConvert.CheckedChanged += chkAutoConvert_CheckedChanged;
            btnClear.Click += btnClear_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtOutput.Text = ConvertToUrlFriendly(txtInput.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                Clipboard.SetText(txtOutput.Text);
                MessageBox.Show("Tekst skopiowany do schowka!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtInput.Focus();
        }


        private void chkAutoConvert_CheckedChanged(object sender, EventArgs e)
        {
            btnConvert.Enabled = !chkAutoConvert.Checked;
            if (chkAutoConvert.Checked)
                txtInput.TextChanged += TxtInput_TextChanged;
            else
                txtInput.TextChanged -= TxtInput_TextChanged;
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            txtOutput.Text = ConvertToUrlFriendly(txtInput.Text);
        }

        private string ConvertToUrlFriendly(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            // UsuniÍcie znakÛw diakrytycznych
            text = RemoveDiacritics(text);

            // Zamiana na ma≥e litery
            text = text.ToLowerInvariant();

            // Zastπpienie spacji myúlnikami
            text = text.Replace(" ", "-");

            // UsuniÍcie niedozwolonych znakÛw
            text = Regex.Replace(text, @"[^a-z0-9\-]", "");

            // UsuniÍcie wielu myúlnikÛw z rzÍdu
            text = Regex.Replace(text, @"-{2,}", "-");

            // UsuniÍcie myúlnikÛw z poczπtku i koÒca
            text = text.Trim('-');

            return text;
        }

        //private string RemoveDiacritics(string text)
        //{
        //    var normalizedString = text.Normalize(NormalizationForm.FormD);
        //    var stringBuilder = new StringBuilder();

        //    foreach (var c in normalizedString)
        //    {
        //        var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
        //        if (unicodeCategory != UnicodeCategory.NonSpacingMark)
        //        {
        //            stringBuilder.Append(c);
        //        }
        //    }

        //    return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        //}

        private string RemoveDiacritics(string text)
        {
            // Mapowanie polskich znakÛw
            var polishChars = new Dictionary<char, char>()
    {
        {'π', 'a'}, {'•', 'A'},
        {'Ê', 'c'}, {'∆', 'C'},
        {'Í', 'e'}, {' ', 'E'},
        {'≥', 'l'}, {'£', 'L'},
        {'Ò', 'n'}, {'—', 'N'},
        {'Û', 'o'}, {'”', 'O'},
        {'ú', 's'}, {'å', 'S'},
        {'ü', 'z'}, {'è', 'Z'},
        {'ø', 'z'}, {'Ø', 'Z'}
    };

            foreach (var pair in polishChars)
            {
                text = text.Replace(pair.Key, pair.Value);
            }

            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
