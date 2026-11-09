namespace DateHandling;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculateDays_Click(object sender, EventArgs e)
    {
        // TODO: Add code to calculate the days until due date
        DateTime currentDate = DateTime.Today;
        DateTime futureDate = Convert.ToDateTime(txtFutureDate.Text);

        TimeSpan timeTillDue = futureDate - currentDate;
        int daysTillDue = timeTillDue.Days;

        MessageBox.Show("Days Till Due: " + Convert.ToString(daysTillDue) + " \n" + "Current Date: " + Convert.ToString(currentDate.ToShortDateString()) + " \n" + "Future Date: " + Convert.ToString(futureDate.ToShortDateString()));

        

    }

    private void btnCalculateAge_Click(object sender, EventArgs e)
    {
        // TODO: Add code to calculate the age
        DateTime currentDate = DateTime.Today;
        DateTime birthDate = Convert.ToDateTime(txtBirthDate.Text);


        int year = currentDate.Year - birthDate.Year;

        if(birthDate.DayOfYear >= currentDate.DayOfYear)
        {
            year += 1;
        }

        TimeSpan age = currentDate - birthDate;
        //int daysTillDue = age;

        MessageBox.Show("Age: " + Convert.ToString(year) + " \n" + "Birth Date: " + Convert.ToString(birthDate.ToShortDateString()) + " \n" + "Today's Date: " + Convert.ToString(currentDate.ToShortDateString()));
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
