
namespace EagleEye
{
    partial class EagleEyeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modulesTabControl = new System.Windows.Forms.TabControl();
            this.dashboardPage = new System.Windows.Forms.TabPage();
            this.setUrlButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.spiderPage = new System.Windows.Forms.TabPage();
            this.spiderList = new System.Windows.Forms.ListBox();
            this.spiderButton = new System.Windows.Forms.Button();
            this.pathTraversalPage = new System.Windows.Forms.TabPage();
            this.modulesTabControl.SuspendLayout();
            this.dashboardPage.SuspendLayout();
            this.spiderPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // modulesTabControl
            // 
            this.modulesTabControl.Controls.Add(this.dashboardPage);
            this.modulesTabControl.Controls.Add(this.spiderPage);
            this.modulesTabControl.Controls.Add(this.pathTraversalPage);
            this.modulesTabControl.Location = new System.Drawing.Point(12, 12);
            this.modulesTabControl.Name = "modulesTabControl";
            this.modulesTabControl.SelectedIndex = 0;
            this.modulesTabControl.Size = new System.Drawing.Size(776, 426);
            this.modulesTabControl.TabIndex = 0;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Controls.Add(this.setUrlButton);
            this.dashboardPage.Controls.Add(this.urlTextBox);
            this.dashboardPage.Location = new System.Drawing.Point(4, 24);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(768, 398);
            this.dashboardPage.TabIndex = 2;
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.UseVisualStyleBackColor = true;
            // 
            // setUrlButton
            // 
            this.setUrlButton.Location = new System.Drawing.Point(132, 6);
            this.setUrlButton.Name = "setUrlButton";
            this.setUrlButton.Size = new System.Drawing.Size(75, 23);
            this.setUrlButton.TabIndex = 1;
            this.setUrlButton.Text = "Set URL";
            this.setUrlButton.UseVisualStyleBackColor = true;
            this.setUrlButton.Click += new System.EventHandler(this.setUrlButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(6, 6);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(120, 23);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // spiderPage
            // 
            this.spiderPage.Controls.Add(this.spiderList);
            this.spiderPage.Controls.Add(this.spiderButton);
            this.spiderPage.Location = new System.Drawing.Point(4, 24);
            this.spiderPage.Name = "spiderPage";
            this.spiderPage.Padding = new System.Windows.Forms.Padding(3);
            this.spiderPage.Size = new System.Drawing.Size(768, 398);
            this.spiderPage.TabIndex = 0;
            this.spiderPage.Text = "Spider";
            this.spiderPage.UseVisualStyleBackColor = true;
            // 
            // spiderList
            // 
            this.spiderList.FormattingEnabled = true;
            this.spiderList.ItemHeight = 15;
            this.spiderList.Location = new System.Drawing.Point(6, 31);
            this.spiderList.Name = "spiderList";
            this.spiderList.Size = new System.Drawing.Size(120, 364);
            this.spiderList.TabIndex = 3;
            this.spiderList.SelectedIndexChanged += new System.EventHandler(this.spiderList_SelectedIndexChanged);
            // 
            // spiderButton
            // 
            this.spiderButton.Location = new System.Drawing.Point(6, 6);
            this.spiderButton.Name = "spiderButton";
            this.spiderButton.Size = new System.Drawing.Size(120, 23);
            this.spiderButton.TabIndex = 2;
            this.spiderButton.Text = "Spider URL";
            this.spiderButton.UseVisualStyleBackColor = true;
            this.spiderButton.Click += new System.EventHandler(this.spiderButton_Click);
            // 
            // pathTraversalPage
            // 
            this.pathTraversalPage.Location = new System.Drawing.Point(4, 24);
            this.pathTraversalPage.Name = "pathTraversalPage";
            this.pathTraversalPage.Padding = new System.Windows.Forms.Padding(3);
            this.pathTraversalPage.Size = new System.Drawing.Size(768, 398);
            this.pathTraversalPage.TabIndex = 1;
            this.pathTraversalPage.Text = "Path Traversal";
            this.pathTraversalPage.UseVisualStyleBackColor = true;
            // 
            // EagleEyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modulesTabControl);
            this.Name = "EagleEyeForm";
            this.Text = "EagleEye";
            this.Load += new System.EventHandler(this.EagleEyeForm_Load);
            this.modulesTabControl.ResumeLayout(false);
            this.dashboardPage.ResumeLayout(false);
            this.dashboardPage.PerformLayout();
            this.spiderPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl modulesTabControl;
        private System.Windows.Forms.TabPage spiderPage;
        private System.Windows.Forms.TabPage pathTraversalPage;
        private System.Windows.Forms.TabPage dashboardPage;
        private System.Windows.Forms.Button spiderButton;
        private System.Windows.Forms.Button setUrlButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.ListBox spiderList;
    }
}

