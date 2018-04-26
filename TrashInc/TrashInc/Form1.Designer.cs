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
            this.AdmiTabPage = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.driver1TabPage = new System.Windows.Forms.TabPage();
            this.drv1BeginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drv1NotifBox = new System.Windows.Forms.RichTextBox();
            this.drv1EndBtn = new System.Windows.Forms.Button();
            this.driver2TabPage = new System.Windows.Forms.TabPage();
            this.drv2BeginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.drv2NotifBox = new System.Windows.Forms.RichTextBox();
            this.drv2EndBtn = new System.Windows.Forms.Button();
            this.driver3TabPage = new System.Windows.Forms.TabPage();
            this.drv3BeginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.drv3NotifBox = new System.Windows.Forms.RichTextBox();
            this.drv3EndBtn = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.AdmiTabPage.SuspendLayout();
            this.driver1TabPage.SuspendLayout();
            this.driver2TabPage.SuspendLayout();
            this.driver3TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AdmiTabPage);
            this.TabControl.Controls.Add(this.driver1TabPage);
            this.TabControl.Controls.Add(this.driver2TabPage);
            this.TabControl.Controls.Add(this.driver3TabPage);
            this.TabControl.Location = new System.Drawing.Point(1, 1);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1163, 602);
            this.TabControl.TabIndex = 0;
            // 
            // AdmiTabPage
            // 
            this.AdmiTabPage.Controls.Add(this.webBrowser1);
            this.AdmiTabPage.Location = new System.Drawing.Point(4, 25);
            this.AdmiTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmiTabPage.Name = "AdmiTabPage";
            this.AdmiTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmiTabPage.Size = new System.Drawing.Size(1155, 573);
            this.AdmiTabPage.TabIndex = 0;
            this.AdmiTabPage.Text = "Administrateur";
            this.AdmiTabPage.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 2);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1149, 569);
            this.webBrowser1.TabIndex = 0;
            // 
            // driver1TabPage
            // 
            this.driver1TabPage.Controls.Add(this.drv1BeginBtn);
            this.driver1TabPage.Controls.Add(this.label1);
            this.driver1TabPage.Controls.Add(this.drv1NotifBox);
            this.driver1TabPage.Controls.Add(this.drv1EndBtn);
            this.driver1TabPage.Location = new System.Drawing.Point(4, 25);
            this.driver1TabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.driver1TabPage.Name = "driver1TabPage";
            this.driver1TabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.driver1TabPage.Size = new System.Drawing.Size(1155, 573);
            this.driver1TabPage.TabIndex = 1;
            this.driver1TabPage.Text = "Travailleur 1";
            this.driver1TabPage.UseVisualStyleBackColor = true;
            // 
            // drv1BeginBtn
            // 
            this.drv1BeginBtn.Location = new System.Drawing.Point(6, 16);
            this.drv1BeginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drv1BeginBtn.Name = "drv1BeginBtn";
            this.drv1BeginBtn.Size = new System.Drawing.Size(100, 46);
            this.drv1BeginBtn.TabIndex = 3;
            this.drv1BeginBtn.Text = "Début du trajet";
            this.drv1BeginBtn.UseVisualStyleBackColor = true;
            this.drv1BeginBtn.Click += new System.EventHandler(this.drv1BeginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notifications";
            // 
            // drv1NotifBox
            // 
            this.drv1NotifBox.Location = new System.Drawing.Point(9, 135);
            this.drv1NotifBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drv1NotifBox.Name = "drv1NotifBox";
            this.drv1NotifBox.Size = new System.Drawing.Size(295, 267);
            this.drv1NotifBox.TabIndex = 1;
            this.drv1NotifBox.Text = "";
            // 
            // drv1EndBtn
            // 
            this.drv1EndBtn.Location = new System.Drawing.Point(7, 66);
            this.drv1EndBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drv1EndBtn.Name = "drv1EndBtn";
            this.drv1EndBtn.Size = new System.Drawing.Size(100, 46);
            this.drv1EndBtn.TabIndex = 0;
            this.drv1EndBtn.Text = "Fin de trajet";
            this.drv1EndBtn.UseVisualStyleBackColor = true;
            this.drv1EndBtn.Click += new System.EventHandler(this.drv1EndBtn_Click);
            // 
            // driver2TabPage
            // 
            this.driver2TabPage.Controls.Add(this.drv2BeginBtn);
            this.driver2TabPage.Controls.Add(this.label2);
            this.driver2TabPage.Controls.Add(this.drv2NotifBox);
            this.driver2TabPage.Controls.Add(this.drv2EndBtn);
            this.driver2TabPage.Location = new System.Drawing.Point(4, 25);
            this.driver2TabPage.Name = "driver2TabPage";
            this.driver2TabPage.Size = new System.Drawing.Size(1155, 573);
            this.driver2TabPage.TabIndex = 2;
            this.driver2TabPage.Text = "Travailleur 2";
            this.driver2TabPage.UseVisualStyleBackColor = true;
            // 
            // drv2BeginBtn
            // 
            this.drv2BeginBtn.Location = new System.Drawing.Point(7, 24);
            this.drv2BeginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drv2BeginBtn.Name = "drv2BeginBtn";
            this.drv2BeginBtn.Size = new System.Drawing.Size(100, 46);
            this.drv2BeginBtn.TabIndex = 7;
            this.drv2BeginBtn.Text = "Début du trajet";
            this.drv2BeginBtn.UseVisualStyleBackColor = true;
            this.drv2BeginBtn.Click += new System.EventHandler(this.drv2BeginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Notifications";
            // 
            // drv2NotifBox
            // 
            this.drv2NotifBox.Location = new System.Drawing.Point(10, 143);
            this.drv2NotifBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drv2NotifBox.Name = "drv2NotifBox";
            this.drv2NotifBox.Size = new System.Drawing.Size(295, 267);
            this.drv2NotifBox.TabIndex = 5;
            this.drv2NotifBox.Text = "";
            // 
            // drv2EndBtn
            // 
            this.drv2EndBtn.Location = new System.Drawing.Point(8, 74);
            this.drv2EndBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drv2EndBtn.Name = "drv2EndBtn";
            this.drv2EndBtn.Size = new System.Drawing.Size(100, 46);
            this.drv2EndBtn.TabIndex = 4;
            this.drv2EndBtn.Text = "Fin de trajet";
            this.drv2EndBtn.UseVisualStyleBackColor = true;
            this.drv2EndBtn.Click += new System.EventHandler(this.drv2EndBtn_Click);
            // 
            // driver3TabPage
            // 
            this.driver3TabPage.Controls.Add(this.drv3BeginBtn);
            this.driver3TabPage.Controls.Add(this.label3);
            this.driver3TabPage.Controls.Add(this.drv3NotifBox);
            this.driver3TabPage.Controls.Add(this.drv3EndBtn);
            this.driver3TabPage.Location = new System.Drawing.Point(4, 25);
            this.driver3TabPage.Name = "driver3TabPage";
            this.driver3TabPage.Size = new System.Drawing.Size(1155, 573);
            this.driver3TabPage.TabIndex = 3;
            this.driver3TabPage.Text = "Travailleur 3";
            this.driver3TabPage.UseVisualStyleBackColor = true;
            // 
            // drv3BeginBtn
            // 
            this.drv3BeginBtn.Location = new System.Drawing.Point(3, 38);
            this.drv3BeginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drv3BeginBtn.Name = "drv3BeginBtn";
            this.drv3BeginBtn.Size = new System.Drawing.Size(100, 46);
            this.drv3BeginBtn.TabIndex = 7;
            this.drv3BeginBtn.Text = "Début du trajet";
            this.drv3BeginBtn.UseVisualStyleBackColor = true;
            this.drv3BeginBtn.Click += new System.EventHandler(this.drv3BeginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notifications";
            // 
            // drv3NotifBox
            // 
            this.drv3NotifBox.Location = new System.Drawing.Point(6, 157);
            this.drv3NotifBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drv3NotifBox.Name = "drv3NotifBox";
            this.drv3NotifBox.Size = new System.Drawing.Size(295, 267);
            this.drv3NotifBox.TabIndex = 5;
            this.drv3NotifBox.Text = "";
            // 
            // drv3EndBtn
            // 
            this.drv3EndBtn.Location = new System.Drawing.Point(4, 88);
            this.drv3EndBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drv3EndBtn.Name = "drv3EndBtn";
            this.drv3EndBtn.Size = new System.Drawing.Size(100, 46);
            this.drv3EndBtn.TabIndex = 4;
            this.drv3EndBtn.Text = "Fin de trajet";
            this.drv3EndBtn.UseVisualStyleBackColor = true;
            this.drv3EndBtn.Click += new System.EventHandler(this.drv3EndBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 606);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.AdmiTabPage.ResumeLayout(false);
            this.driver1TabPage.ResumeLayout(false);
            this.driver1TabPage.PerformLayout();
            this.driver2TabPage.ResumeLayout(false);
            this.driver2TabPage.PerformLayout();
            this.driver3TabPage.ResumeLayout(false);
            this.driver3TabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage AdmiTabPage;
        private System.Windows.Forms.TabPage driver1TabPage;
        private System.Windows.Forms.Button drv1EndBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox drv1NotifBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button drv1BeginBtn;
        private System.Windows.Forms.TabPage driver2TabPage;
        private System.Windows.Forms.TabPage driver3TabPage;
        private System.Windows.Forms.Button drv2BeginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox drv2NotifBox;
        private System.Windows.Forms.Button drv2EndBtn;
        private System.Windows.Forms.Button drv3BeginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox drv3NotifBox;
        private System.Windows.Forms.Button drv3EndBtn;
    }
}

