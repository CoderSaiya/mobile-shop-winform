namespace MobileShop.UI.Forms.Views;

public partial class MainForm : Form
{
    private CompanyControl companyControl;
    private ModelControl modelControl;
    private MobileControl mobileControl;
    private ByDateControl byDateControl;
    private ByDateToDateControl byDateToDateControl;
    private UsersControl usersControl;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        ShowCompany();
    }

    private void ClearContent()
    {
        contentPanel.Controls.Clear();
    }

    private void ShowCompany()
    {
        ClearContent();
        if (companyControl == null)
            companyControl = new CompanyControl();
        companyControl.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(companyControl);
    }

    private void ShowModel()
    {
        ClearContent();
        if (modelControl == null)
            modelControl = new ModelControl();
        modelControl.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(modelControl);
    }

    private void ShowMobile()
    {
        ClearContent();
        if (mobileControl == null)
            mobileControl = new MobileControl();
        mobileControl.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(mobileControl);
    }

    private void ShowByDateReport()
    {
        ClearContent();
        if (byDateControl == null)
            byDateControl = new ByDateControl();
        byDateControl.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(byDateControl);
    }

    private void ShowByDateToDate()
    {
        ClearContent();
        if (byDateToDateControl == null)
            byDateToDateControl = new ByDateToDateControl();
        byDateToDateControl.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(byDateToDateControl);
    }

    private void ShowUsers()
    {
        ClearContent();
        if (usersControl == null)
            usersControl = new UsersControl();
        usersControl.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(usersControl);
    }

    private void companyTab_Click(object sender, EventArgs e) => ShowCompany();
    private void modelTab_Click(object sender, EventArgs e) => ShowModel();
    private void mobileTab_Click(object sender, EventArgs e) => ShowMobile();
    private void byDateSubTab_Click(object sender, EventArgs e) => ShowByDateReport();
    private void byDateToDateSubTab_Click(object sender, EventArgs e) => ShowByDateToDate();
    private void UsersTab_Click(object sender, EventArgs e) => ShowUsers();

    private void logoutTab_Click(object sender, EventArgs e)
    {
        this.Hide();
        new LoginForm().Show();
    }

    bool menuExpand = false;
    private void menuTransition_Tick(object sender, EventArgs e)
    {
        if (menuExpand == false)
        {
            menuContainer.Height += 10;
            if (menuContainer.Height >= 217)
            {
                menuTransition.Stop();
                menuExpand = true;

            }
        }
        else
        {
            menuContainer.Height -= 10;
            if (menuContainer.Height <= 75)
            {
                menuTransition.Stop();
                menuExpand = false;
            }
        }
    }

    private void salesTab_Click(object sender, EventArgs e)
    {
        menuTransition.Start();
    }

    private void exitBox_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }

    private void contentPanel_Paint(object sender, PaintEventArgs e)
    {

    }
}