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
            this.drv1EndBtn = new System.Windows.Forms.Button();
            this.drv1NotifBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.driver1TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AdmiPage);
            this.TabControl.Controls.Add(this.driver1TabPage);
            this.TabControl.Location = new System.Drawing.Point(1, 1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1163, 602);
            this.TabControl.TabIndex = 0;
            // 
            // AdmiPage
            // 
            this.AdmiPage.Location = new System.Drawing.Point(4, 25);
            this.AdmiPage.Name = "AdmiPage";
            this.AdmiPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdmiPage.Size = new System.Drawing.Size(1155, 573);
            this.AdmiPage.TabIndex = 0;
            this.AdmiPage.Text = "Administrateur";
            this.AdmiPage.UseVisualStyleBackColor = true;
            // 
            // driver1TabPage
            // 
            this.driver1TabPage.Controls.Add(this.label1);
            this.driver1TabPage.Controls.Add(this.drv1NotifBox);
            this.driver1TabPage.Controls.Add(this.drv1EndBtn);
            this.driver1TabPage.Location = new System.Drawing.Point(4, 25);
            this.driver1TabPage.Name = "driver1TabPage";
            this.driver1TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.driver1TabPage.Size = new System.Drawing.Size(1155, 573);
            this.driver1TabPage.TabIndex = 1;
            this.driver1TabPage.Text = "driver1";
            this.driver1TabPage.UseVisualStyleBackColor = true;
            // 
            // drv1EndBtn
            // 
            this.drv1EndBtn.Location = new System.Drawing.Point(9, 9);
            this.drv1EndBtn.Name = "drv1EndBtn";
            this.drv1EndBtn.Size = new System.Drawing.Size(100, 45);
            this.drv1EndBtn.TabIndex = 0;
            this.drv1EndBtn.Text = "Fin de trajet";
            this.drv1EndBtn.UseVisualStyleBackColor = true;
            // 
            // drv1NotifBox
            // 
            this.drv1NotifBox.Location = new System.Drawing.Point(9, 135);
            this.drv1NotifBox.Name = "drv1NotifBox";
            this.drv1NotifBox.Size = new System.Drawing.Size(295, 268);
            this.drv1NotifBox.TabIndex = 1;
            this.drv1NotifBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notifications";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 605);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
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
    }
}

