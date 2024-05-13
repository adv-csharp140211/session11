using BL;
using ViewModel;

namespace UI.Win;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonCreateProduct_Click(object sender, EventArgs e)
    {
        var productInput = new ProductInput { Name = "az UI", Price = 200, Description = "Az UI", Image = "az UI" };
        var productService = new ProductService();
        productService.Create(productInput);
    }
}
