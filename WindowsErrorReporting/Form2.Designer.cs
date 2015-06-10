namespace WindowsErrorReporting
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
            this.fullPanel = new System.Windows.Forms.Panel();
            this.appsLocationListView = new System.Windows.Forms.ListView();
            this.nameApp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationApp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fullPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullPanel
            // 
            this.fullPanel.Controls.Add(this.appsLocationListView);
            this.fullPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullPanel.Location = new System.Drawing.Point(0, 53);
            this.fullPanel.Name = "fullPanel";
            this.fullPanel.Size = new System.Drawing.Size(868, 425);
            this.fullPanel.TabIndex = 0;
            // 
            // appsLocationListView
            // 
            this.appsLocationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameApp,
            this.locationApp});
            this.appsLocationListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appsLocationListView.GridLines = true;
            this.appsLocationListView.Location = new System.Drawing.Point(0, 0);
            this.appsLocationListView.Name = "appsLocationListView";
            this.appsLocationListView.Size = new System.Drawing.Size(868, 425);
            this.appsLocationListView.TabIndex = 0;
            this.appsLocationListView.UseCompatibleStateImageBehavior = false;
            this.appsLocationListView.View = System.Windows.Forms.View.Details;
            this.appsLocationListView.DoubleClick += new System.EventHandler(this.appsLocationListView_DoubleClick);
            // 
            // nameApp
            // 
            this.nameApp.Text = "Dastur nomi";
            this.nameApp.Width = 400;
            // 
            // locationApp
            // 
            this.locationApp.Text = "Dastur jildi";
            this.locationApp.Width = 500;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 53);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(34, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tekshirish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(210, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Chiqish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 478);
            this.Controls.Add(this.fullPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Dasturlar jildi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.fullPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fullPanel;
        private System.Windows.Forms.ListView appsLocationListView;
        private System.Windows.Forms.ColumnHeader nameApp;
        private System.Windows.Forms.ColumnHeader locationApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}