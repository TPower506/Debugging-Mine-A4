using System.IO.Pipes;

namespace PowerLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Name: Tony Power
        Due Date: Nov. 17th/2022
        Description: Program displays flight information based off users booking prefrences.*/


        private void ResetTrip()
        {
            txtPeople.Clear();
            txtPeople.Focus();
            grpBoxTripInfo.Hide();
            radFlorida.Checked = false;
            radMexico.Checked = false;
            radCuba.Checked = true;
            radCash.Checked = false;
            radCreditCard.Checked = true;
            lblPrice.Text = ("");
            lblDisplayInfo.Hide();
        }

        private void SetFlight()
        {

            if (radFlorida.Checked == true)
            {
                chkBoxFlightInc.Checked = false;
            }
            if (radMexico.Checked == true)
                {
                chkBoxFlightInc.Checked = true;
                }
            if (radCuba.Checked == true) 
            { 
                chkBoxFlightInc.Checked = true;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ResetTrip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ResetTrip();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //declare variables
            string myName = ("Tony Power");
            const double MEXICO = 2300.79;
            const double CUBA = 2150.50;
            const double FLORDIA = 2150.50;
            const double DISCOUNT = 0.10;
            const int MINPEOPLE = 1;
            const int MAXPEOPLE = 10;
            const int BOGO1 = 1;
            const int BOGO2 = 3;

            //add tryparse instead of trycatch
            bool validPeople = int.TryParse(txtPeople.Text, out int CONFIRM);



            //double price = MEXICO, price2 = CUBA, price3 = FLORDIA;

            //if (radMexico.Checked)
            //    price *= CONFIRM;




            //if people entered is incorrectly
            if (validPeople == false) 
            
            {
                //display people must be whole #
                MessageBox.Show("People must be a whole number", "Input Error");
            }

            //if the number entered in people is NOT between 1 and 10
            if (CONFIRM < MINPEOPLE || CONFIRM > MAXPEOPLE)
            {
                //display to user people must be between 1 and 10
                MessageBox.Show("People must be between " + MINPEOPLE + "-" + MAXPEOPLE,  "Range Error - "+ myName +"");

                //reset forms
                ResetTrip();
            }
            //if user entered 1 display BOGO deal
            if (CONFIRM == BOGO1)
            {
                //bogo deal displayed
                MessageBox.Show("Special when booking single or triple. \nBOGO Special - Call 555-1212 to receive another person free!", "Limited Time Offer");
            }
            //if user entered 3 display bogo deal
            else if (CONFIRM == BOGO2) 
            {
                //bogo deal displayed
                MessageBox.Show("Special when booking single or triple. \nBOGO Special - Call 555-1212 to receive another person free!", "Limited Time Offer");
            }
               //if cuba is checked
            if (radCuba.Checked == true)
            {
                //display price of cuba into lable
                lblPrice.Text = CUBA.ToString("c2");
                //flight not included
                chkBoxFlightInc.Checked = false;
            }
               //if florida is checked
            else if (radFlorida.Checked == true)
            {
                //display price into lable
                lblPrice.Text = FLORDIA.ToString("c2");
                //check box for flight included is selected
                chkBoxFlightInc.Checked = true;

            }  //if mexico is checked
            else if (radMexico.Checked == true)
            {
                //display price in lable
                lblPrice.Text = MEXICO.ToString("c2");
                //flight not included
                chkBoxFlightInc.Checked = false;
            }
            
            grpBoxTripInfo.Visible= true;
            lblDisplayInfo.Visible= true;
            
            //display all information entered by user in display lable
            lblDisplayInfo.Text = "Booked by " + myName + "\n\nPeople: " + txtPeople.Text + "\nLocation:  \nPrice: " + lblPrice.Text + "";

            //grpBook.Enabled = false;

                 }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //display comfirmation message box verifying user has successfully completed the operation
            MessageBox.Show("Trip booked and Paid \nPrice: " + lblPrice.Text + "", "Email Confirmation Sent") ;
            
            //Application.Exit();
        }


    }  // end class
             }  // end namespace

