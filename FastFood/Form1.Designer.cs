namespace FastFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelFood = new System.Windows.Forms.Panel();
            this.panelTitlerBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaxsize = new System.Windows.Forms.Button();
            this.btnMiniSize = new System.Windows.Forms.Button();
            this.btnClosePanelChild = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnNoti = new System.Windows.Forms.Button();
            this.btnReporing = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktop.SuspendLayout();
            this.panelTitlerBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelFood);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(165, 65);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(840, 457);
            this.panelDesktop.TabIndex = 5;
            // 
            // panelFood
            // 
            this.panelFood.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFood.Location = new System.Drawing.Point(0, 0);
            this.panelFood.Margin = new System.Windows.Forms.Padding(2);
            this.panelFood.Name = "panelFood";
            this.panelFood.Size = new System.Drawing.Size(840, 457);
            this.panelFood.TabIndex = 7;
            this.panelFood.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFood_Paint);
            // 
            // panelTitlerBar
            // 
            this.panelTitlerBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitlerBar.Controls.Add(this.btnClose);
            this.panelTitlerBar.Controls.Add(this.btnMaxsize);
            this.panelTitlerBar.Controls.Add(this.btnMiniSize);
            this.panelTitlerBar.Controls.Add(this.btnClosePanelChild);
            this.panelTitlerBar.Controls.Add(this.lbTitle);
            this.panelTitlerBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlerBar.Location = new System.Drawing.Point(165, 0);
            this.panelTitlerBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitlerBar.Name = "panelTitlerBar";
            this.panelTitlerBar.Size = new System.Drawing.Size(840, 65);
            this.panelTitlerBar.TabIndex = 4;
            this.panelTitlerBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlerBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(817, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaxsize
            // 
            this.btnMaxsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxsize.FlatAppearance.BorderSize = 0;
            this.btnMaxsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxsize.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxsize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMaxsize.Location = new System.Drawing.Point(794, 0);
            this.btnMaxsize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaxsize.Name = "btnMaxsize";
            this.btnMaxsize.Size = new System.Drawing.Size(22, 24);
            this.btnMaxsize.TabIndex = 4;
            this.btnMaxsize.Text = "O";
            this.btnMaxsize.UseVisualStyleBackColor = true;
            this.btnMaxsize.Click += new System.EventHandler(this.btnMaxsize_Click);
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniSize.FlatAppearance.BorderSize = 0;
            this.btnMiniSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniSize.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMiniSize.Location = new System.Drawing.Point(772, 0);
            this.btnMiniSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.Size = new System.Drawing.Size(22, 24);
            this.btnMiniSize.TabIndex = 3;
            this.btnMiniSize.Text = "O";
            this.btnMiniSize.UseVisualStyleBackColor = true;
            this.btnMiniSize.Click += new System.EventHandler(this.btnMiniSize_Click);
            // 
            // btnClosePanelChild
            // 
            this.btnClosePanelChild.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClosePanelChild.FlatAppearance.BorderSize = 0;
            this.btnClosePanelChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePanelChild.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePanelChild.Image")));
            this.btnClosePanelChild.Location = new System.Drawing.Point(0, 0);
            this.btnClosePanelChild.Margin = new System.Windows.Forms.Padding(2);
            this.btnClosePanelChild.Name = "btnClosePanelChild";
            this.btnClosePanelChild.Size = new System.Drawing.Size(56, 65);
            this.btnClosePanelChild.TabIndex = 0;
            this.btnClosePanelChild.UseVisualStyleBackColor = true;
            this.btnClosePanelChild.Click += new System.EventHandler(this.btnClosePanelChild_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbTitle.Location = new System.Drawing.Point(388, 22);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(75, 24);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "HOME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fast Food";
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 114);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(165, 49);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "   Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 65);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(165, 49);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "   Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(165, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "   Log out";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 310);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(165, 49);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "   Admin";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnNoti
            // 
            this.btnNoti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoti.FlatAppearance.BorderSize = 0;
            this.btnNoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNoti.Image = ((System.Drawing.Image)(resources.GetObject("btnNoti.Image")));
            this.btnNoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoti.Location = new System.Drawing.Point(0, 261);
            this.btnNoti.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoti.Name = "btnNoti";
            this.btnNoti.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNoti.Size = new System.Drawing.Size(165, 49);
            this.btnNoti.TabIndex = 4;
            this.btnNoti.Text = "   Notifications";
            this.btnNoti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNoti.UseVisualStyleBackColor = true;
            // 
            // btnReporing
            // 
            this.btnReporing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporing.FlatAppearance.BorderSize = 0;
            this.btnReporing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnReporing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReporing.Image = ((System.Drawing.Image)(resources.GetObject("btnReporing.Image")));
            this.btnReporing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporing.Location = new System.Drawing.Point(0, 212);
            this.btnReporing.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporing.Name = "btnReporing";
            this.btnReporing.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnReporing.Size = new System.Drawing.Size(165, 49);
            this.btnReporing.TabIndex = 3;
            this.btnReporing.Text = "   Reporting";
            this.btnReporing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporing.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 163);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(165, 49);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "   Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnNoti);
            this.panelMenu.Controls.Add(this.btnReporing);
            this.panelMenu.Controls.Add(this.btnCustomer);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 522);
            this.panelMenu.TabIndex = 3;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 522);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitlerBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelTitlerBar.ResumeLayout(false);
            this.panelTitlerBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelFood;
        private System.Windows.Forms.Panel panelTitlerBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaxsize;
        private System.Windows.Forms.Button btnMiniSize;
        private System.Windows.Forms.Button btnClosePanelChild;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnNoti;
        private System.Windows.Forms.Button btnReporing;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
    }
}

