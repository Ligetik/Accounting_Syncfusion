
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.sfButtonSignIn = new Syncfusion.WinForms.Controls.SfButton();
            this.Line = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.sfButtonChangePass = new Syncfusion.WinForms.Controls.SfButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxLogin.Location = new System.Drawing.Point(90, 127);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(150, 24);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "Логин";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
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
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.Silver;
            this.Line.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line.Location = new System.Drawing.Point(-22, 72);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(681, 2);
            this.Line.TabIndex = 5;
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAuth.Location = new System.Drawing.Point(62, 15);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(273, 47);
            this.labelAuth.TabIndex = 4;
            this.labelAuth.Text = "АВТОРИЗАЦИЯ";
            this.labelAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-105, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 2);
            this.label1.TabIndex = 0;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPass.Location = new System.Drawing.Point(90, 189);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(150, 24);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.Text = "Пароль";
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            this.textBoxPass.Leave += new System.EventHandler(this.textBoxPass_Leave);
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
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 2);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 2);
            this.label3.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SyncfusionWinFormsApp1.Properties.Resources.Password2;
            this.pictureBox2.Location = new System.Drawing.Point(62, 189);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SyncfusionWinFormsApp1.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(62, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sfButtonChangePass);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.sfButtonSignIn);
            this.Controls.Add(this.textBoxLogin);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private Syncfusion.WinForms.Controls.SfButton sfButtonSignIn;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPass;
        private Syncfusion.WinForms.Controls.SfButton sfButtonChangePass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}