
namespace SyncfusionWinFormsApp1
{
    partial class ChangePassForm
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
            this.sfButtonSignIn = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
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
            this.sfButtonSignIn.Location = new System.Drawing.Point(311, 210);
            this.sfButtonSignIn.Name = "sfButtonSignIn";
            this.sfButtonSignIn.Size = new System.Drawing.Size(178, 36);
            this.sfButtonSignIn.Style.BackColor = System.Drawing.Color.DodgerBlue;
            this.sfButtonSignIn.Style.ForeColor = System.Drawing.Color.White;
            this.sfButtonSignIn.TabIndex = 4;
            this.sfButtonSignIn.Text = "Войти";
            this.sfButtonSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sfButtonSignIn.UseVisualStyleBackColor = false;
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.sfButtonSignIn);
            this.Name = "ChangePassForm";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "ChangePassForm";
            this.Load += new System.EventHandler(this.ChangePassForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton sfButtonSignIn;
    }
}