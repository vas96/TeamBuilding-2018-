using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace TeamBuilding
{
    public partial class StartUp : Form
    {
        private const int MinimalLength = 6;
        private const int MaximalLength = 15;
        public static int SelectedUser;

        public StartUp()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (slideB.Left == 360)
                {
                    bunifuSeparator1.Left = bunifuThinButton22.Left;
                    bunifuSeparator1.Width = bunifuThinButton22.Width;

                    bunifuTransition1.HideSync(slideA);
                    slideA.Left = 360;

                    slideB.Visible = false;
                    slideB.Left = 10;

                    bunifuTransition1.ShowSync(slideB);
                    SignEmailField.Focus();
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (slideA.Left == 360)
                {
                    bunifuSeparator1.Left = bunifuThinButton21.Left;
                    bunifuSeparator1.Width = bunifuThinButton21.Width;

                    bunifuTransition1.HideSync(slideB);
                    slideB.Left = 360;

                    slideA.Visible = false;
                    slideA.Left = 10;

                    bunifuTransition1.ShowSync(slideA);
                    RegNameField.Focus();
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
                Environment.Exit(0);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            var teamBuildingEntities = Connection.Instance();
            var usersList = new ObservableCollection<Users>(teamBuildingEntities.Users);
            foreach (var user in usersList)
            {
                if (RegEmailField.Text == user.RegMail)
                {
                    MessageBox.Show("Такий користувач вже зареєстрований!");
                    return;
                }
            }
            try
            {
                if (!bunifuCustomLabel6.Visible && !bunifuCustomLabel9.Visible && !bunifuCustomLabel10.Visible
                    && RegNameField.Text != "" && RegEmailField.Text != "" && RegPasswordField.Text != "")
                {
                    Users user = new Users
                    {
                        UsrId = teamBuildingEntities.Users.Count() + 1,
                        Login = RegNameField.Text,
                        RegMail = RegEmailField.Text,
                        Password = RegPasswordField.Text,
                        PicturePath = "0.jpg",
                        Registered = DateTime.Now
                    };

                    teamBuildingEntities.Users.Add(user);
                    teamBuildingEntities.SaveChanges();
                    SelectedUser = user.UsrId;

                    MessageBox.Show("Sueccussfully registered");

                    Connection.Current = user;
                    var form2 = new MainForm(teamBuildingEntities.Users.Where(i=>i.UsrId==SelectedUser).First());
                    Hide();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Something is wrong");
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            var teamBuildingEntities =Connection.Instance();
            bool sueccessfullLogin = false;

            try
            {
                foreach (Users user in teamBuildingEntities.Users)
                {
                    if (SignEmailField.Text == user.RegMail && SignPasswordField.Text == user.Password)
                    {
                        SelectedUser = user.UsrId;
                        sueccessfullLogin = true;
                        Connection.Current = user;
                        var form2 = new MainForm(user);
                        Hide();
                        form2.Show();
                    }
                }

                if (!sueccessfullLogin)
                    MessageBox.Show("No such account found");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            var email = RegEmailField.Text;

            try
            {
                var address = new MailAddress(email);
                bunifuCustomLabel9.Visible = false;
            }

            catch (Exception)
            {
                bunifuCustomLabel9.Visible = true;
            }
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            var name = RegNameField.Text;
            bool meetsLengthRequirements = name.Length >= MinimalLength && name.Length <= MaximalLength;

            if (meetsLengthRequirements)
                bunifuCustomLabel6.Visible = false;

            else
                bunifuCustomLabel6.Visible = true;
        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            var password = RegPasswordField.Text;

            bool meetsLengthRequirements = password.Length >= MinimalLength && password.Length <= MaximalLength;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements && hasUpperCaseLetter && hasLowerCaseLetter && hasDecimalDigit;

            if (isValid)
                bunifuCustomLabel10.Visible = false;

            else
                bunifuCustomLabel10.Visible = true;
        }

        private void Sign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                bunifuThinButton26_Click(sender, e);
        }

        private void Reg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
                bunifuThinButton23_Click(sender, e);
        }
    }
}