namespace Guide
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView = new System.Windows.Forms.TreeView();
            this.listView = new System.Windows.Forms.ListView();
            this.cbDrives = new System.Windows.Forms.ComboBox();
            this.cbListViewStyle = new System.Windows.Forms.ComboBox();
            this.tbCurrentFullPath = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbSelectedDisk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(0, 35);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(255, 465);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeCollapse);
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView.Location = new System.Drawing.Point(0, 35);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(507, 465);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // cbDrives
            // 
            this.cbDrives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDrives.FormattingEnabled = true;
            this.cbDrives.Location = new System.Drawing.Point(129, 5);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(122, 21);
            this.cbDrives.TabIndex = 2;
            this.cbDrives.DropDown += new System.EventHandler(this.cbDrives_DropDown);
            this.cbDrives.SelectedIndexChanged += new System.EventHandler(this.cbDrives_SelectedIndexChanged);
            // 
            // cbListViewStyle
            // 
            this.cbListViewStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbListViewStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbListViewStyle.FormattingEnabled = true;
            this.cbListViewStyle.Location = new System.Drawing.Point(383, 5);
            this.cbListViewStyle.Name = "cbListViewStyle";
            this.cbListViewStyle.Size = new System.Drawing.Size(119, 21);
            this.cbListViewStyle.TabIndex = 3;
            this.cbListViewStyle.SelectedIndexChanged += new System.EventHandler(this.cbListViewStyle_SelectedIndexChanged);
            // 
            // tbCurrentFullPath
            // 
            this.tbCurrentFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentFullPath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentFullPath.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbCurrentFullPath.Location = new System.Drawing.Point(59, 5);
            this.tbCurrentFullPath.Name = "tbCurrentFullPath";
            this.tbCurrentFullPath.Size = new System.Drawing.Size(319, 21);
            this.tbCurrentFullPath.TabIndex = 4;
            this.tbCurrentFullPath.TextChanged += new System.EventHandler(this.tbFullPath_TextChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(9, 6);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tbSelectedDisk);
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            this.splitContainer.Panel1.Controls.Add(this.cbDrives);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnBack);
            this.splitContainer.Panel2.Controls.Add(this.listView);
            this.splitContainer.Panel2.Controls.Add(this.cbListViewStyle);
            this.splitContainer.Panel2.Controls.Add(this.tbCurrentFullPath);
            this.splitContainer.Size = new System.Drawing.Size(763, 505);
            this.splitContainer.SplitterDistance = 254;
            this.splitContainer.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 26);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbIcon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbIcon.Location = new System.Drawing.Point(9, 512);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(60, 48);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 6;
            this.pbIcon.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.ForeColor = System.Drawing.Color.Blue;
            this.lblType.Location = new System.Drawing.Point(75, 514);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(218, 48);
            this.lblType.TabIndex = 7;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSize.ForeColor = System.Drawing.Color.Blue;
            this.lblSize.Location = new System.Drawing.Point(534, 514);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(240, 46);
            this.lblSize.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.ForeColor = System.Drawing.Color.Blue;
            this.lblDate.Location = new System.Drawing.Point(299, 516);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(229, 46);
            this.lblDate.TabIndex = 9;
            // 
            // tbSelectedDisk
            // 
            this.tbSelectedDisk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbSelectedDisk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSelectedDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSelectedDisk.Location = new System.Drawing.Point(3, 8);
            this.tbSelectedDisk.Name = "tbSelectedDisk";
            this.tbSelectedDisk.Size = new System.Drawing.Size(123, 15);
            this.tbSelectedDisk.TabIndex = 3;
            this.tbSelectedDisk.Text = "Selected Drive";
            this.tbSelectedDisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "My Guide";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;
        /// <summary>
        /// Список логических дисков
        /// </summary>
        private System.Windows.Forms.ComboBox cbDrives;
        /// <summary>
        /// Список возможных отображений элементов
        /// </summary>
        private System.Windows.Forms.ComboBox cbListViewStyle;
        /// <summary>
        /// Строка полного текущего пути выбраного элемента
        /// </summary>
        private System.Windows.Forms.TextBox tbCurrentFullPath;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbSelectedDisk;
    }
}

