using AppReport.Model;
using Dapper;
using Microsoft.Data.SqlClient;
using Stimulsoft.Report;
using System.Reflection;

namespace AppReport;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void buttonReport_Click(object sender, EventArgs e)
    {
        var connStr = "data source=.;initial catalog=cs140211-codefirst2;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=AppDBFirst";
        using var conn = new SqlConnection(connStr);
        var data = await conn.QueryAsync<Product>("select * from forosh.Mahsol ");
        dataGridView1.DataSource = data;

        var reportFileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AppReport.Reports.ProductReport.mrt");

        var report = new StiReport();
        report.RegBusinessObject("ProductBO", data);
        //report.Load("ProductReport.mrt");
        report.Load(reportFileStream);
        report.Show();

    }
}
