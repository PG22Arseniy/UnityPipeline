namespace PipelineForUnity
{
    partial class Form2
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
            this.ToCreateButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ShowInExplorerButton = new System.Windows.Forms.Button();
            this.ProjectNamesBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToCreateButton
            // 
            this.ToCreateButton.Location = new System.Drawing.Point(620, 35);
            this.ToCreateButton.Name = "ToCreateButton";
            this.ToCreateButton.Size = new System.Drawing.Size(121, 36);
            this.ToCreateButton.TabIndex = 9;
            this.ToCreateButton.Text = "To Create";
            this.ToCreateButton.UseVisualStyleBackColor = true;
            this.ToCreateButton.Click += new System.EventHandler(this.ToCreateButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(78, 253);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(626, 168);
            this.OutputTextBox.TabIndex = 8;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Your Project Name";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(396, 79);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(112, 41);
            this.OpenButton.TabIndex = 5;
            this.OpenButton.Text = "Open Project";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(396, 136);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 41);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete Project";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ShowInExplorerButton
            // 
            this.ShowInExplorerButton.Location = new System.Drawing.Point(396, 188);
            this.ShowInExplorerButton.Name = "ShowInExplorerButton";
            this.ShowInExplorerButton.Size = new System.Drawing.Size(112, 41);
            this.ShowInExplorerButton.TabIndex = 11;
            this.ShowInExplorerButton.Text = "Show in Explorer";
            this.ShowInExplorerButton.UseVisualStyleBackColor = true;
            this.ShowInExplorerButton.Click += new System.EventHandler(this.ShowInExplorerButton_Click);
            // 
            // ProjectNamesBox
            // 
            this.ProjectNamesBox.FormattingEnabled = true;
            this.ProjectNamesBox.Location = new System.Drawing.Point(168, 154);
            this.ProjectNamesBox.Name = "ProjectNamesBox";
            this.ProjectNamesBox.Size = new System.Drawing.Size(166, 23);
            this.ProjectNamesBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 14);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(69, 153);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 14;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProjectNamesBox);
            this.Controls.Add(this.ShowInExplorerButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ToCreateButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ToCreateButton;
        private TextBox OutputTextBox;
        private Label label1;
        private Button OpenButton;
        private Button DeleteButton;
        private Button ShowInExplorerButton;
        private ComboBox ProjectNamesBox;
        private Button button1;
        private Button RefreshButton;
    }
}