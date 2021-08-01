
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
            this.sfButtonPrinting1 = new Syncfusion.WinForms.Controls.SfButton();
            this.Line = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(52, 144);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(200, 31);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sfButtonPrinting1
            // 
            this.sfButtonPrinting1.AccessibleName = "Button";
            this.sfButtonPrinting1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sfButtonPrinting1.FocusRectangleVisible = true;
            this.sfButtonPrinting1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.sfButtonPrinting1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sfButtonPrinting1.ImageSize = new System.Drawing.Size(25, 25);
            this.sfButtonPrinting1.Location = new System.Drawing.Point(61, 335);
            this.sfButtonPrinting1.Name = "sfButtonPrinting1";
            this.sfButtonPrinting1.Size = new System.Drawing.Size(178, 36);
            this.sfButtonPrinting1.Style.Image = global::SyncfusionWinFormsApp1.Properties.Resources.print;
            this.sfButtonPrinting1.TabIndex = 3;
            this.sfButtonPrinting1.Text = "Печать";
            this.sfButtonPrinting1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
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
            this.labelAuth.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(75, 14);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(236, 47);
            this.labelAuth.TabIndex = 4;
            this.labelAuth.Text = "Авторизация";
            this.labelAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-105, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 2);
            this.label1.TabIndex = 6;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(52, 233);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(200, 31);
            this.textBoxPass.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 418);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.sfButtonPrinting1);
            this.Controls.Add(this.textBoxLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Бухгалтерия";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private Syncfusion.WinForms.Controls.SfButton sfButtonPrinting1;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}