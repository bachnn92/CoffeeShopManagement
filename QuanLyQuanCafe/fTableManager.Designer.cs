
namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.mnDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscont = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlTable = new System.Windows.Forms.NumericUpDown();
            this.TbtnAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpTable);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 398);
            this.panel1.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(3, 3);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(397, 392);
            this.flpTable.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminmToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminmToolStripMenuItem
            // 
            this.adminmToolStripMenuItem.Name = "adminmToolStripMenuItem";
            this.adminmToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminmToolStripMenuItem.Text = "Admin";
            this.adminmToolStripMenuItem.Click += new System.EventHandler(this.adminmToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(421, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 266);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(342, 260);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.btnSwitch);
            this.panel3.Controls.Add(this.mnDiscount);
            this.panel3.Controls.Add(this.btnDiscont);
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Location = new System.Drawing.Point(421, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 55);
            this.panel3.TabIndex = 2;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(3, 30);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(72, 21);
            this.cbSwitchTable.TabIndex = 5;
            // 
            // btnSwitch
            // 
            this.btnSwitch.AutoEllipsis = true;
            this.btnSwitch.Location = new System.Drawing.Point(3, 3);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(72, 24);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "Chuyển bàn";
            this.btnSwitch.UseVisualStyleBackColor = true;
            // 
            // mnDiscount
            // 
            this.mnDiscount.Location = new System.Drawing.Point(195, 31);
            this.mnDiscount.Name = "mnDiscount";
            this.mnDiscount.Size = new System.Drawing.Size(72, 20);
            this.mnDiscount.TabIndex = 2;
            this.mnDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDiscont
            // 
            this.btnDiscont.Location = new System.Drawing.Point(195, 3);
            this.btnDiscont.Name = "btnDiscont";
            this.btnDiscont.Size = new System.Drawing.Size(72, 24);
            this.btnDiscont.TabIndex = 2;
            this.btnDiscont.Text = "Giảm giá";
            this.btnDiscont.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(273, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(72, 48);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Thanh Toán";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlTable);
            this.panel4.Controls.Add(this.TbtnAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(421, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 56);
            this.panel4.TabIndex = 3;
            // 
            // pnlTable
            // 
            this.pnlTable.Location = new System.Drawing.Point(296, 17);
            this.pnlTable.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(36, 20);
            this.pnlTable.TabIndex = 2;
            // 
            // TbtnAddFood
            // 
            this.TbtnAddFood.Location = new System.Drawing.Point(217, 3);
            this.TbtnAddFood.Name = "TbtnAddFood";
            this.TbtnAddFood.Size = new System.Drawing.Size(72, 48);
            this.TbtnAddFood.TabIndex = 1;
            this.TbtnAddFood.Text = "Thêm món";
            this.TbtnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 30);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(208, 21);
            this.cbFood.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(208, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Quán Cà Phê";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mnDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button TbtnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnDiscont;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.NumericUpDown pnlTable;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.NumericUpDown mnDiscount;
    }
}