namespace DecimalConverter
{
    public partial class Form1 : Form
    {
        public bool TxtBoxDecChanged = false;
        public bool TxtBoxBinChanged = false;
        public bool TxtBoxHexChanged = false;
        public Form1()
        {
            InitializeComponent();
            txtBin.TextChanged += new EventHandler(txtBin_TextChanged);
            txtDec.TextChanged += new EventHandler(txtDec_TextChanged);
            txtHex.TextChanged += new EventHandler(txtHex_TextChanged);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDec.Text = "";
            txtBin.Text = "";
            txtHex.Text = "";
        }

        protected void txtBin_TextChanged(object sender, EventArgs e)
        {
            TxtBoxBinChanged = true;
            TxtBoxDecChanged = false;
            TxtBoxHexChanged = false;
        }
        protected void txtDec_TextChanged(object sender, EventArgs e)
        {
            TxtBoxDecChanged = true;
            TxtBoxBinChanged = false;
            TxtBoxHexChanged = false;
        }
        protected void txtHex_TextChanged(object sender, EventArgs e)
        {
            TxtBoxHexChanged = true;
            TxtBoxDecChanged = false;
            TxtBoxBinChanged = false;
        }
        private void btnConv_Click(object sender, EventArgs e)
        {
            if (TxtBoxDecChanged && txtDec.Text != "")
            {
                // Convert decimal to binary and hexadecimal
                if (int.TryParse(txtDec.Text, out int numConverter))
                {
                    txtBin.Text = Convert.ToString(numConverter, 2);
                    txtHex.Text = Convert.ToString(numConverter, 16).ToUpper();
                }
                else
                {
                    MessageBox.Show("Invalid decimal input. Please enter a valid integer.");
                }
            }
            else if (TxtBoxBinChanged && txtBin.Text != "")
            {
                // Convert binary to decimal
                if (IsValidBinary(txtBin.Text))
                {
                    int decimalResult = Convert.ToInt32(txtBin.Text, 2);
                    txtDec.Text = decimalResult.ToString();
                    txtHex.Text = decimalResult.ToString("X");
                }
                else
                {
                    MessageBox.Show("Invalid binary input. Please enter a valid binary number (0 or 1).");
                }
            }
            else if (TxtBoxHexChanged && txtHex.Text != "")
            {
                // Convert hexadecimal to decimal
                if (IsValidHexadecimal(txtHex.Text))
                {
                    int decimalResult = Convert.ToInt32(txtHex.Text, 16);
                    txtDec.Text = decimalResult.ToString();
                    txtBin.Text = Convert.ToString(decimalResult, 2);
                }
                else
                {
                    MessageBox.Show("Invalid hexadecimal input. Please enter a valid hexadecimal number (0-9, A-F).");
                }
            }
        }

        private bool IsValidBinary(string binaryString)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(binaryString, "^[01]+$");
        }

        private bool IsValidHexadecimal(string hexadecimalString)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(hexadecimalString, "^[0-9A-Fa-f]+$");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConv.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
