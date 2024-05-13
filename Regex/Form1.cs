using AppRegex.Utils;

namespace AppRegex;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonValidate_Click(object sender, EventArgs e)
    {
        MessageBox.Show(RegexUtils.ValidateEmail(textBoxEmail.Text) ? "Yes" : "No");
    }
}
