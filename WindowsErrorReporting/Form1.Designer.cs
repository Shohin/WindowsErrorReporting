namespace WindowsErrorReporting
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.appsListView = new System.Windows.Forms.ListView();
            this.displayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.installedOn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeSoft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionSoft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationSoft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.getListButton = new System.Windows.Forms.Button();
            this.countSoftLabel = new System.Windows.Forms.Label();
            this.fullPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.fullPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appsListView
            // 
            this.appsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.displayName,
            this.publisherName,
            this.installedOn,
            this.sizeSoft,
            this.versionSoft,
            this.locationSoft});
            this.appsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appsListView.GridLines = true;
            this.appsListView.Location = new System.Drawing.Point(0, 0);
            this.appsListView.Name = "appsListView";
            this.appsListView.Size = new System.Drawing.Size(892, 414);
            this.appsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.appsListView.TabIndex = 0;
            this.appsListView.UseCompatibleStateImageBehavior = false;
            this.appsListView.View = System.Windows.Forms.View.Details;
            this.appsListView.DoubleClick += new System.EventHandler(this.appsListView_DoubleClick);
            // 
            // displayName
            // 
            this.displayName.Text = "Dastur nomi";
            this.displayName.Width = 300;
            // 
            // publisherName
            // 
            this.publisherName.Text = "Ishlab chiqaruvchi";
            this.publisherName.Width = 150;
            // 
            // installedOn
            // 
            this.installedOn.Text = "O`rnatilgan sanasi";
            this.installedOn.Width = 100;
            // 
            // sizeSoft
            // 
            this.sizeSoft.Text = "Dastur o`lchami";
            this.sizeSoft.Width = 100;
            // 
            // versionSoft
            // 
            this.versionSoft.Text = "Versiyasi";
            this.versionSoft.Width = 150;
            // 
            // locationSoft
            // 
            this.locationSoft.Text = "Dastur jildi";
            this.locationSoft.Width = 150;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.button2);
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Controls.Add(this.getListButton);
            this.topPanel.Controls.Add(this.countSoftLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(892, 59);
            this.topPanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(590, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dasturga o`tish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(724, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chiqish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // getListButton
            // 
            this.getListButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getListButton.ForeColor = System.Drawing.Color.Blue;
            this.getListButton.Location = new System.Drawing.Point(435, 8);
            this.getListButton.Name = "getListButton";
            this.getListButton.Size = new System.Drawing.Size(149, 41);
            this.getListButton.TabIndex = 1;
            this.getListButton.Text = "Ro`yxatni olish";
            this.getListButton.UseVisualStyleBackColor = true;
            this.getListButton.Click += new System.EventHandler(this.getListButton_Click);
            // 
            // countSoftLabel
            // 
            this.countSoftLabel.AutoSize = true;
            this.countSoftLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countSoftLabel.Location = new System.Drawing.Point(12, 20);
            this.countSoftLabel.Name = "countSoftLabel";
            this.countSoftLabel.Size = new System.Drawing.Size(189, 22);
            this.countSoftLabel.TabIndex = 0;
            this.countSoftLabel.Text = "O`rnatilgan Dasturlar";
            // 
            // fullPanel
            // 
            this.fullPanel.Controls.Add(this.appsListView);
            this.fullPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullPanel.Location = new System.Drawing.Point(0, 59);
            this.fullPanel.Name = "fullPanel";
            this.fullPanel.Size = new System.Drawing.Size(892, 414);
            this.fullPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 473);
            this.Controls.Add(this.fullPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.Text = "O`rnatilgan Dasturlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.fullPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView appsListView;
        private System.Windows.Forms.ColumnHeader displayName;
        private System.Windows.Forms.ColumnHeader publisherName;
        private System.Windows.Forms.ColumnHeader installedOn;
        private System.Windows.Forms.ColumnHeader sizeSoft;
        private System.Windows.Forms.ColumnHeader versionSoft;
        private System.Windows.Forms.ColumnHeader locationSoft;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel fullPanel;
        private System.Windows.Forms.Label countSoftLabel;
        private System.Windows.Forms.Button getListButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

