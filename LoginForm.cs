using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SyncfusionWinFormsApp1
{
    public partial class LoginForm : SfForm
    {
        public LoginForm()
        {
            InitializeComponent();

            this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212);
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;
            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LineBlue;
        }

        private void sfButtonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string loginUser = textBoxLoginAuth.Text;
                string passUser = textBoxPassAuth.Text;

                DB db = new DB();

                string query = "SELECT * FROM users WHERE login = '" + loginUser.Trim() + "' AND pass = '" + passUser.Trim() + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetSqlConnection());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    MetroForm1 mainForm = new MetroForm1();
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBoxAdv.Show("Неверный логин и пароль");
                    textBoxLoginAuth.Clear();
                    textBoxPassAuth.Clear();
                    textBoxLoginAuth.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBoxAdv.Show(error.Message);
            }
            
        }

        #region TextBoxes Events

        #region Auth
        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBoxPassAuth.Focus();
            }
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                sfButtonSignIn.Focus();
            }
        }
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLoginAuth.Text == "Логин")
            {
                textBoxLoginAuth.Text = "";
                textBoxLoginAuth.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLoginAuth.Text == "")
            {
                textBoxLoginAuth.Text = "Логин";
                textBoxLoginAuth.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPassAuth.Text == "Пароль")
            {
                textBoxPassAuth.Text = "";
                textBoxPassAuth.ForeColor = Color.Black;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPassAuth.Text == "")
            {
                textBoxPassAuth.Text = "Пароль";
                textBoxPassAuth.ForeColor = Color.DimGray;
            }
        }
        #endregion

        #region Change
        private void textBoxLoginChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBoxPassChange.Focus();
            }
        }

        private void textBoxPassChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBoxNewPassChange.Focus();
            }
        }
        private void textBoxNewPassChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                textBoxConfPassChange.Focus();
            }
        }
        private void textBoxConfPassChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                sfButtonSaveChanges.Focus();
            }
        }
        private void textBoxLoginChange_Enter(object sender, EventArgs e)
        {
            if (textBoxLoginChange.Text == "Логин")
            {
                textBoxLoginChange.Text = "";
                textBoxLoginChange.ForeColor = Color.Black;
            }
        }

        private void textBoxPassChange_Enter(object sender, EventArgs e)
        {
            if (textBoxPassChange.Text == "Текущий пароль")
            {
                textBoxPassChange.Text = "";
                textBoxPassChange.ForeColor = Color.Black;
            }
        }

        private void textBoxNewPassChange_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPassChange.Text == "Новый пароль")
            {
                textBoxNewPassChange.Text = "";
                textBoxNewPassChange.ForeColor = Color.Black;
            }
        }

        private void textBoxConfPassChange_Enter(object sender, EventArgs e)
        {
            if (textBoxConfPassChange.Text == "Подтвердить пароль")
            {
                textBoxConfPassChange.Text = "";
                textBoxConfPassChange.ForeColor = Color.Black;
            }
        }
        private void textBoxLoginChange_Leave(object sender, EventArgs e)
        {
            if (textBoxLoginChange.Text == "")
            {
                textBoxLoginChange.Text = "Логин";
                textBoxLoginChange.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPassChange_Leave(object sender, EventArgs e)
        {
            if (textBoxPassChange.Text == "")
            {
                textBoxPassChange.Text = "Текущий пароль";
                textBoxPassChange.ForeColor = Color.DimGray;
            }
        }
        private void textBoxNewPassChange_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPassChange.Text == "")
            {
                textBoxNewPassChange.Text = "Новый пароль";
                textBoxNewPassChange.ForeColor = Color.DimGray;
            }
        }

        private void textBoxConfPassChange_Leave(object sender, EventArgs e)
        {
            if (textBoxConfPassChange.Text == "")
            {
                textBoxConfPassChange.Text = "Подтвердить пароль";
                textBoxConfPassChange.ForeColor = Color.DimGray;
            }
        }

        #endregion

        #endregion

        private void sfButtonChangePass_Click(object sender, EventArgs e)
        {
            //auth
            labelAuth.Visible = false;           

            pictureBoxLoginAuth.Visible = false;
            textBoxLoginAuth.Visible = false;
            LineBlueAuth1.Visible = false;

            pictureBoxPassAuth.Visible = false;
            textBoxPassAuth.Visible = false;
            LineBlueAuth2.Visible = false;

            sfButtonSignIn.Visible = false;
            sfButtonChangePass.Visible = false;

            //change
            labelChange.Visible = true;

            pictureBoxLoginChange.Visible = true;
            textBoxLoginChange.Visible = true;
            LineBlueChange1.Visible = true;

            pictureBoxPassChange.Visible = true;
            textBoxPassChange.Visible = true;
            LineBlueChange2.Visible = true;

            pictureBoxNewPassChange.Visible = true;
            textBoxNewPassChange.Visible = true;
            LineBlueChange3.Visible = true;

            pictureBoxConfPassChange.Visible = true;
            textBoxConfPassChange.Visible = true;
            LineBlueChange4.Visible = true;

            sfButtonSaveChanges.Visible = true;
            sfButtonCancel.Visible = true;
        }

        private void sfButtonCancel_Click(object sender, EventArgs e)
        {
            //auth
            labelAuth.Visible = true;

            pictureBoxLoginAuth.Visible = true;
            textBoxLoginAuth.Visible = true;
            LineBlueAuth1.Visible = true;

            pictureBoxPassAuth.Visible = true;
            textBoxPassAuth.Visible = true;
            LineBlueAuth2.Visible = true;

            sfButtonSignIn.Visible = true;
            sfButtonChangePass.Visible = true;

            //change
            labelChange.Visible = false;

            pictureBoxLoginChange.Visible = false;
            textBoxLoginChange.Visible = false;
            LineBlueChange1.Visible = false;

            pictureBoxPassChange.Visible = false;
            textBoxPassChange.Visible = false;
            LineBlueChange2.Visible = false;

            pictureBoxNewPassChange.Visible = false;
            textBoxNewPassChange.Visible = false;
            LineBlueChange3.Visible = false;

            pictureBoxConfPassChange.Visible = false;
            textBoxConfPassChange.Visible = false;
            LineBlueChange4.Visible = false;

            sfButtonSaveChanges.Visible = false;
            sfButtonCancel.Visible = false;


            textBoxLoginChange.Clear();
            textBoxPassChange.Clear();
            textBoxNewPassChange.Clear();
            textBoxConfPassChange.Clear();
            textBoxLoginChange.Text = "Логин";
            textBoxPassChange.Text = "Текущий пароль";
            textBoxNewPassChange.Text = "Новый пароль";
            textBoxConfPassChange.Text = "Подтвердить пароль";
            textBoxLoginAuth.Focus();
        }

        private void sfButtonSaveChanges_Click(object sender, EventArgs e)
        {
            DB dB = new DB();

            string newPassUser = textBoxNewPassChange.Text;
            string confirmPassUser = textBoxConfPassChange.Text;
            string loginUser = textBoxLoginChange.Text;
            string passUser = textBoxPassChange.Text;

            try
            {
                if (newPassUser == confirmPassUser)
                {
                    string sqlExpression = "UPDATE users SET pass = '" + confirmPassUser.Trim() + "'WHERE login = '" + loginUser.Trim()
                        + "' AND pass = '" + passUser.Trim() + "'";

                    string connectionString = @"Data Source=DESKTOP-7VG9T54;Initial Catalog=sql;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);

                        int number = command.ExecuteNonQuery();

                        if (number > 0)
                        {
                            MessageBoxAdv.Show("Ваш пароль изменён");
                        }

                        else
                        {
                            MessageBoxAdv.Show("Неверный логин и пароль, попробуйте ещё раз");
                        }
                    }
                }
                else
                {
                    MessageBoxAdv.Show("Ваш пароль новый пароль не совпадает, попробуйте ещё раз");
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
