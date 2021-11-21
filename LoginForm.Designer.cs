
namespace SyncfusionWinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBoxLoginAuth = new System.Windows.Forms.TextBox();
            this.sfButtonSignIn = new Syncfusion.WinForms.Controls.SfButton();
            this.LineGray = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.LineBlue = new System.Windows.Forms.Label();
            this.textBoxPassAuth = new System.Windows.Forms.TextBox();
            this.sfButtonChangePass = new Syncfusion.WinForms.Controls.SfButton();
            this.LineBlueAuth1 = new System.Windows.Forms.Label();
            this.LineBlueAuth2 = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.LineBlueChange2 = new System.Windows.Forms.Label();
            this.LineBlueChange1 = new System.Windows.Forms.Label();
            this.textBoxPassChange = new System.Windows.Forms.TextBox();
            this.textBoxLoginChange = new System.Windows.Forms.TextBox();
            this.LineBlueChange4 = new System.Windows.Forms.Label();
            this.LineBlueChange3 = new System.Windows.Forms.Label();
            this.textBoxConfPassChange = new System.Windows.Forms.TextBox();
            this.textBoxNewPassChange = new System.Windows.Forms.TextBox();
            this.pictureBoxConfPassChange = new System.Windows.Forms.PictureBox();
            this.pictureBoxNewPassChange = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassChange = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoginChange = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassAuth = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoginAuth = new System.Windows.Forms.PictureBox();
            this.sfButtonSaveChanges = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButtonCancel = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfPassChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPassChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassAuth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginAuth)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLoginAuth
            // 
            this.textBoxLoginAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginAuth.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoginAuth.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxLoginAuth.Location = new System.Drawing.Point(90, 127);
            this.textBoxLoginAuth.Name = "textBoxLoginAuth";
            this.textBoxLoginAuth.Size = new System.Drawing.Size(150, 24);
            this.textBoxLoginAuth.TabIndex = 1;
            this.textBoxLoginAuth.Text = "Логин";
            this.textBoxLoginAuth.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLoginAuth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            this.textBoxLoginAuth.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // sfButtonSignIn
            // 
            this.sfButtonSignIn.AccessibleName = "Button";
            this.sfButtonSignIn.BackColor = System.Drawing.Color.DodgerBlue;
            this.sfButtonSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sfButtonSignIn.FocusRectangleVisible = true;
            this.sfButtonSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.sfButtonSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sfButtonSignIn.ImageSize = new System.Drawing.Size(25, 25);
            this.sfButtonSignIn.Location = new System.Drawing.Point(62, 250);
            this.sfButtonSignIn.Name = "sfButtonSignIn";
            this.sfButtonSignIn.Size = new System.Drawing.Size(178, 36);
            this.sfButtonSignIn.Style.BackColor = System.Drawing.Color.DodgerBlue;
            this.sfButtonSignIn.Style.ForeColor = System.Drawing.Color.White;
            this.sfButtonSignIn.TabIndex = 3;
            this.sfButtonSignIn.Text = "Войти";
            this.sfButtonSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sfButtonSignIn.UseVisualStyleBackColor = false;
            this.sfButtonSignIn.Click += new System.EventHandler(this.sfButtonSignIn_Click);
            // 
            // LineGray
            // 
            this.LineGray.BackColor = System.Drawing.Color.Silver;
            this.LineGray.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineGray.Location = new System.Drawing.Point(-22, 72);
            this.LineGray.Name = "LineGray";
            this.LineGray.Size = new System.Drawing.Size(681, 2);
            this.LineGray.TabIndex = 5;
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAuth.Location = new System.Drawing.Point(62, 19);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(273, 47);
            this.labelAuth.TabIndex = 4;
            this.labelAuth.Text = "АВТОРИЗАЦИЯ";
            this.labelAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LineBlue
            // 
            this.LineBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.LineBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineBlue.Location = new System.Drawing.Point(-105, 74);
            this.LineBlue.Name = "LineBlue";
            this.LineBlue.Size = new System.Drawing.Size(681, 2);
            this.LineBlue.TabIndex = 0;
            // 
            // textBoxPassAuth
            // 
            this.textBoxPassAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassAuth.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassAuth.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassAuth.Location = new System.Drawing.Point(90, 189);
            this.textBoxPassAuth.Name = "textBoxPassAuth";
            this.textBoxPassAuth.Size = new System.Drawing.Size(150, 24);
            this.textBoxPassAuth.TabIndex = 2;
            this.textBoxPassAuth.Text = "Пароль";
            this.textBoxPassAuth.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPassAuth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            this.textBoxPassAuth.Leave += new System.EventHandler(this.textBoxPass_Leave);
            // 
            // sfButtonChangePass
            // 
            this.sfButtonChangePass.AccessibleName = "Button";
            this.sfButtonChangePass.BackColor = System.Drawing.Color.White;
            this.sfButtonChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sfButtonChangePass.FocusRectangleVisible = true;
            this.sfButtonChangePass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.sfButtonChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sfButtonChangePass.ImageSize = new System.Drawing.Size(25, 25);
            this.sfButtonChangePass.Location = new System.Drawing.Point(62, 296);
            this.sfButtonChangePass.Name = "sfButtonChangePass";
            this.sfButtonChangePass.Size = new System.Drawing.Size(178, 36);
            this.sfButtonChangePass.Style.BackColor = System.Drawing.Color.White;
            this.sfButtonChangePass.Style.ForeColor = System.Drawing.Color.Gray;
            this.sfButtonChangePass.TabIndex = 4;
            this.sfButtonChangePass.Text = "Сменить пароль";
            this.sfButtonChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sfButtonChangePass.UseVisualStyleBackColor = false;
            this.sfButtonChangePass.Click += new System.EventHandler(this.sfButtonChangePass_Click);
            // 
            // LineBlueAuth1
            // 
            this.LineBlueAuth1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.LineBlueAuth1.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineBlueAuth1.Location = new System.Drawing.Point(62, 152);
            this.LineBlueAuth1.Name = "LineBlueAuth1";
            this.LineBlueAuth1.Size = new System.Drawing.Size(178, 2);
            this.LineBlueAuth1.TabIndex = 13;
            // 
            // LineBlueAuth2
            // 
            this.LineBlueAuth2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.LineBlueAuth2.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineBlueAuth2.Location = new System.Drawing.Point(62, 213);
            this.LineBlueAuth2.Name = "LineBlueAuth2";
            this.LineBlueAuth2.Size = new System.Drawing.Size(178, 2);
            this.LineBlueAuth2.TabIndex = 14;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelChange.Location = new System.Drawing.Point(55, 19);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(293, 47);
            this.labelChange.TabIndex = 15;
            this.labelChange.Text = "СМЕНА ПАРОЛЯ";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChange.Visible = false;
            // 
            // LineBlueChange2
            // 
            this.LineBlueChange2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.LineBlueChange2.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineBlueChange2.Location = new System.Drawing.Point(62, 160);
            this.LineBlueChange2.Name = "LineBlueChange2";
            this.LineBlueChange2.Size = new System.Drawing.Size(178, 2);
            this.LineBlueChange2.TabIndex = 21;
            this.LineBlueChange2.Visible = false;
            // 
            // LineBlueChange1
            // 
            this.LineBlueChange1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.LineBlueChange1.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineBlueChange1.Location = new System.Drawing.Point(62, 115);
            this.LineBlueChange1.Name = "LineBlueChange1";
            this.LineBlueChange1.Size = new System.Drawing.Size(178, 2);
            this.LineBlueChange1.TabIndex = 20;
            this.LineBlueChange1.Visible = false;
            // 
            // textBoxPassChange
            // 
            this.textBoxPassChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassChange.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassChange.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassChange.Location = new System.Drawing.Point(90, 136);
            this.textBoxPassChange.Name = "textBoxPassChange";
            this.textBoxPassChange.Size = new System.Drawing.Size(150, 24);
            this.textBoxPassChange.TabIndex = 17;
            this.textBoxPassChange.Text = "Текущий пароль";
            this.textBoxPassChange.Visible = false;
            this.textBoxPassChange.Enter += new System.EventHandler(this.textBoxPassChange_Enter);
            this.textBoxPassChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassChange_KeyPress);
            this.textBoxPassChange.Leave += new System.EventHandler(this.textBoxPassChange_Leave);
            // 
            // textBoxLoginChange
            // 
            this.textBoxLoginChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginChange.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoginChange.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxLoginChange.Location = new System.Drawing.Point(90, 90);
            this.textBoxLoginChange.Name = "textBoxLoginChange";
            this.textBoxLoginChange.Size = new System.Drawing.Size(150, 24);
            this.textBoxLoginChange.TabIndex = 16;
            this.textBoxLoginChange.Text = "Логин";
            this.textBoxLoginChange.Visible = false;
            this.textBoxLoginChange.Enter += new System.EventHandler(this.textBoxLoginChange_Enter);
            this.textBoxLoginChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoginChange_KeyPress);
            this.textBoxLoginChange.Leave += new System.EventHandler(this.textBoxLoginChange_Leave);
            // 
            // LineBlueChange4
            // 
            this.LineBlueChange4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.LineBlueChange4.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineBlueChange4.Location = new System.Drawing.Point(62, 254);
            this.LineBlueChange4.Name = "LineBlueChange4";
            this.LineBlueChange4.Size = new System.Drawing.Size(178, 2);
            this.LineBlueChange4.TabIndex = 27;
            this.LineBlueChange4.Visible = false;
            // 
            // LineBlueChange3
            // 
            this.LineBlueChange3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.LineBlueChange3.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineBlueChange3.Location = new System.Drawing.Point(62, 209);
            this.LineBlueChange3.Name = "LineBlueChange3";
            this.LineBlueChange3.Size = new System.Drawing.Size(178, 2);
            this.LineBlueChange3.TabIndex = 26;
            this.LineBlueChange3.Visible = false;
            // 
            // textBoxConfPassChange
            // 
            this.textBoxConfPassChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfPassChange.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConfPassChange.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConfPassChange.Location = new System.Drawing.Point(90, 230);
            this.textBoxConfPassChange.Name = "textBoxConfPassChange";
            this.textBoxConfPassChange.Size = new System.Drawing.Size(150, 24);
            this.textBoxConfPassChange.TabIndex = 23;
            this.textBoxConfPassChange.Text = "Подтвердить пароль";
            this.textBoxConfPassChange.Visible = false;
            this.textBoxConfPassChange.Enter += new System.EventHandler(this.textBoxConfPassChange_Enter);
            this.textBoxConfPassChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfPassChange_KeyPress);
            this.textBoxConfPassChange.Leave += new System.EventHandler(this.textBoxConfPassChange_Leave);
            // 
            // textBoxNewPassChange
            // 
            this.textBoxNewPassChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPassChange.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPassChange.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNewPassChange.Location = new System.Drawing.Point(90, 184);
            this.textBoxNewPassChange.Name = "textBoxNewPassChange";
            this.textBoxNewPassChange.Size = new System.Drawing.Size(150, 24);
            this.textBoxNewPassChange.TabIndex = 22;
            this.textBoxNewPassChange.Text = "Новый пароль";
            this.textBoxNewPassChange.Visible = false;
            this.textBoxNewPassChange.Enter += new System.EventHandler(this.textBoxNewPassChange_Enter);
            this.textBoxNewPassChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewPassChange_KeyPress);
            this.textBoxNewPassChange.Leave += new System.EventHandler(this.textBoxNewPassChange_Leave);
            // 
            // pictureBoxConfPassChange
            // 
            this.pictureBoxConfPassChange.Image = global::SyncfusionWinFormsApp1.Properties.Resources.PasswordChange;
            this.pictureBoxConfPassChange.Location = new System.Drawing.Point(62, 230);
            this.pictureBoxConfPassChange.Name = "pictureBoxConfPassChange";
            this.pictureBoxConfPassChange.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxConfPassChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConfPassChange.TabIndex = 25;
            this.pictureBoxConfPassChange.TabStop = false;
            this.pictureBoxConfPassChange.Visible = false;
            // 
            // pictureBoxNewPassChange
            // 
            this.pictureBoxNewPassChange.Image = global::SyncfusionWinFormsApp1.Properties.Resources.PasswordChange;
            this.pictureBoxNewPassChange.Location = new System.Drawing.Point(62, 184);
            this.pictureBoxNewPassChange.Name = "pictureBoxNewPassChange";
            this.pictureBoxNewPassChange.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxNewPassChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNewPassChange.TabIndex = 24;
            this.pictureBoxNewPassChange.TabStop = false;
            this.pictureBoxNewPassChange.Visible = false;
            // 
            // pictureBoxPassChange
            // 
            this.pictureBoxPassChange.Image = global::SyncfusionWinFormsApp1.Properties.Resources.Password2;
            this.pictureBoxPassChange.Location = new System.Drawing.Point(62, 136);
            this.pictureBoxPassChange.Name = "pictureBoxPassChange";
            this.pictureBoxPassChange.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxPassChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPassChange.TabIndex = 19;
            this.pictureBoxPassChange.TabStop = false;
            this.pictureBoxPassChange.Visible = false;
            // 
            // pictureBoxLoginChange
            // 
            this.pictureBoxLoginChange.Image = global::SyncfusionWinFormsApp1.Properties.Resources.Login;
            this.pictureBoxLoginChange.Location = new System.Drawing.Point(62, 90);
            this.pictureBoxLoginChange.Name = "pictureBoxLoginChange";
            this.pictureBoxLoginChange.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxLoginChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoginChange.TabIndex = 18;
            this.pictureBoxLoginChange.TabStop = false;
            this.pictureBoxLoginChange.Visible = false;
            // 
            // pictureBoxPassAuth
            // 
            this.pictureBoxPassAuth.Image = global::SyncfusionWinFormsApp1.Properties.Resources.Password2;
            this.pictureBoxPassAuth.Location = new System.Drawing.Point(62, 189);
            this.pictureBoxPassAuth.Name = "pictureBoxPassAuth";
            this.pictureBoxPassAuth.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxPassAuth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPassAuth.TabIndex = 12;
            this.pictureBoxPassAuth.TabStop = false;
            // 
            // pictureBoxLoginAuth
            // 
            this.pictureBoxLoginAuth.Image = global::SyncfusionWinFormsApp1.Properties.Resources.Login;
            this.pictureBoxLoginAuth.Location = new System.Drawing.Point(62, 127);
            this.pictureBoxLoginAuth.Name = "pictureBoxLoginAuth";
            this.pictureBoxLoginAuth.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxLoginAuth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoginAuth.TabIndex = 11;
            this.pictureBoxLoginAuth.TabStop = false;
            // 
            // sfButtonSaveChanges
            // 
            this.sfButtonSaveChanges.AccessibleName = "Button";
            this.sfButtonSaveChanges.BackColor = System.Drawing.Color.DodgerBlue;
            this.sfButtonSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sfButtonSaveChanges.FocusRectangleVisible = true;
            this.sfButtonSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.sfButtonSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sfButtonSaveChanges.ImageSize = new System.Drawing.Size(25, 25);
            this.sfButtonSaveChanges.Location = new System.Drawing.Point(62, 277);
            this.sfButtonSaveChanges.Name = "sfButtonSaveChanges";
            this.sfButtonSaveChanges.Size = new System.Drawing.Size(178, 36);
            this.sfButtonSaveChanges.Style.BackColor = System.Drawing.Color.DodgerBlue;
            this.sfButtonSaveChanges.Style.ForeColor = System.Drawing.Color.White;
            this.sfButtonSaveChanges.TabIndex = 28;
            this.sfButtonSaveChanges.Text = "Сохранить изменения";
            this.sfButtonSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sfButtonSaveChanges.UseVisualStyleBackColor = false;
            this.sfButtonSaveChanges.Visible = false;
            this.sfButtonSaveChanges.Click += new System.EventHandler(this.sfButtonSaveChanges_Click);
            // 
            // sfButtonCancel
            // 
            this.sfButtonCancel.AccessibleName = "Button";
            this.sfButtonCancel.BackColor = System.Drawing.Color.White;
            this.sfButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sfButtonCancel.FocusRectangleVisible = true;
            this.sfButtonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.sfButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sfButtonCancel.ImageSize = new System.Drawing.Size(25, 25);
            this.sfButtonCancel.Location = new System.Drawing.Point(62, 324);
            this.sfButtonCancel.Name = "sfButtonCancel";
            this.sfButtonCancel.Size = new System.Drawing.Size(178, 36);
            this.sfButtonCancel.Style.BackColor = System.Drawing.Color.White;
            this.sfButtonCancel.Style.ForeColor = System.Drawing.Color.Gray;
            this.sfButtonCancel.TabIndex = 29;
            this.sfButtonCancel.Text = "Отмена";
            this.sfButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sfButtonCancel.UseVisualStyleBackColor = false;
            this.sfButtonCancel.Visible = false;
            this.sfButtonCancel.Click += new System.EventHandler(this.sfButtonCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 384);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.LineGray);
            this.Controls.Add(this.LineBlue);
            this.Controls.Add(this.pictureBoxLoginAuth);
            this.Controls.Add(this.textBoxLoginAuth);
            this.Controls.Add(this.LineBlueAuth1);
            this.Controls.Add(this.pictureBoxPassAuth);
            this.Controls.Add(this.textBoxPassAuth);
            this.Controls.Add(this.LineBlueAuth2);
            this.Controls.Add(this.sfButtonSignIn);
            this.Controls.Add(this.sfButtonChangePass);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.pictureBoxLoginChange);
            this.Controls.Add(this.textBoxLoginChange);
            this.Controls.Add(this.LineBlueChange1);
            this.Controls.Add(this.pictureBoxPassChange);
            this.Controls.Add(this.textBoxPassChange);
            this.Controls.Add(this.LineBlueChange2);
            this.Controls.Add(this.pictureBoxNewPassChange);
            this.Controls.Add(this.textBoxNewPassChange);
            this.Controls.Add(this.LineBlueChange3);
            this.Controls.Add(this.pictureBoxConfPassChange);
            this.Controls.Add(this.textBoxConfPassChange);
            this.Controls.Add(this.LineBlueChange4);
            this.Controls.Add(this.sfButtonSaveChanges);
            this.Controls.Add(this.sfButtonCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Style.ShadowOpacity = ((byte)(100));
            this.Text = "Бухгалтерия";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfPassChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPassChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassAuth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginAuth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLoginAuth;
        private Syncfusion.WinForms.Controls.SfButton sfButtonSignIn;
        private System.Windows.Forms.Label LineGray;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label LineBlue;
        private System.Windows.Forms.TextBox textBoxPassAuth;
        private Syncfusion.WinForms.Controls.SfButton sfButtonChangePass;
        private System.Windows.Forms.PictureBox pictureBoxLoginAuth;
        private System.Windows.Forms.PictureBox pictureBoxPassAuth;
        private System.Windows.Forms.Label LineBlueAuth1;
        private System.Windows.Forms.Label LineBlueAuth2;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label LineBlueChange2;
        private System.Windows.Forms.Label LineBlueChange1;
        private System.Windows.Forms.PictureBox pictureBoxPassChange;
        private System.Windows.Forms.PictureBox pictureBoxLoginChange;
        private System.Windows.Forms.TextBox textBoxPassChange;
        private System.Windows.Forms.TextBox textBoxLoginChange;
        private System.Windows.Forms.Label LineBlueChange4;
        private System.Windows.Forms.Label LineBlueChange3;
        private System.Windows.Forms.PictureBox pictureBoxConfPassChange;
        private System.Windows.Forms.PictureBox pictureBoxNewPassChange;
        private System.Windows.Forms.TextBox textBoxConfPassChange;
        private System.Windows.Forms.TextBox textBoxNewPassChange;
        private Syncfusion.WinForms.Controls.SfButton sfButtonSaveChanges;
        private Syncfusion.WinForms.Controls.SfButton sfButtonCancel;
    }
}