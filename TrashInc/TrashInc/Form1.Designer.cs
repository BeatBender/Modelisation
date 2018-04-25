namespace TrashInc
{
    partial class Form1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.AdmiPage = new System.Windows.Forms.TabPage();
            this.driver1TabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.drv1NotifBox = new System.Windows.Forms.RichTextBox();
            this.drv1EndBtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TabControl.SuspendLayout();
            this.AdmiPage.SuspendLayout();
            this.driver1TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AdmiPage);
            this.TabControl.Controls.Add(this.driver1TabPage);
            this.TabControl.Location = new System.Drawing.Point(1, 1);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(872, 489);
            this.TabControl.TabIndex = 0;
            // 
            // AdmiPage
            // 
            this.AdmiPage.Controls.Add(this.webBrowser1);
            this.AdmiPage.Location = new System.Drawing.Point(4, 22);
            this.AdmiPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdmiPage.Name = "AdmiPage";
            this.AdmiPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdmiPage.Size = new System.Drawing.Size(864, 463);
            this.AdmiPage.TabIndex = 0;
            this.AdmiPage.Text = "Administrateur";
            this.AdmiPage.UseVisualStyleBackColor = true;
            // 
            // driver1TabPage
            // 
            this.driver1TabPage.Controls.Add(this.label1);
            this.driver1TabPage.Controls.Add(this.drv1NotifBox);
            this.driver1TabPage.Controls.Add(this.drv1EndBtn);
            this.driver1TabPage.Location = new System.Drawing.Point(4, 22);
            this.driver1TabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.driver1TabPage.Name = "driver1TabPage";
            this.driver1TabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.driver1TabPage.Size = new System.Drawing.Size(864, 463);
            this.driver1TabPage.TabIndex = 1;
            this.driver1TabPage.Text = "driver1";
            this.driver1TabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notifications";
            // 
            // drv1NotifBox
            // 
            this.drv1NotifBox.Location = new System.Drawing.Point(7, 110);
            this.drv1NotifBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drv1NotifBox.Name = "drv1NotifBox";
            this.drv1NotifBox.Size = new System.Drawing.Size(222, 218);
            this.drv1NotifBox.TabIndex = 1;
            this.drv1NotifBox.Text = "";
            // 
            // drv1EndBtn
            // 
            this.drv1EndBtn.Location = new System.Drawing.Point(7, 7);
            this.drv1EndBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drv1EndBtn.Name = "drv1EndBtn";
            this.drv1EndBtn.Size = new System.Drawing.Size(75, 37);
            this.drv1EndBtn.TabIndex = 0;
            this.drv1EndBtn.Text = "Fin de trajet";
            this.drv1EndBtn.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(860, 459);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 492);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.AdmiPage.ResumeLayout(false);
            this.driver1TabPage.ResumeLayout(false);
            this.driver1TabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage AdmiPage;
        private System.Windows.Forms.TabPage driver1TabPage;
        private System.Windows.Forms.Button drv1EndBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox drv1NotifBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

