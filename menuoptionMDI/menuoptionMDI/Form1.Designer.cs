namespace menuoptionMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.last15daysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highOrderValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productOrder2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderEntryToolStripMenuItem,
            this.modifyOrderToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // orderEntryToolStripMenuItem
            // 
            this.orderEntryToolStripMenuItem.Name = "orderEntryToolStripMenuItem";
            this.orderEntryToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.orderEntryToolStripMenuItem.Text = "order entry";
            this.orderEntryToolStripMenuItem.Click += new System.EventHandler(this.orderEntryToolStripMenuItem_Click);
            // 
            // modifyOrderToolStripMenuItem
            // 
            this.modifyOrderToolStripMenuItem.Name = "modifyOrderToolStripMenuItem";
            this.modifyOrderToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.modifyOrderToolStripMenuItem.Text = "modify order";
            this.modifyOrderToolStripMenuItem.Click += new System.EventHandler(this.modifyOrderToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.last15daysToolStripMenuItem,
            this.highOrderValueToolStripMenuItem,
            this.productOrder2ToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ordersToolStripMenuItem.Text = "orders";
            // 
            // last15daysToolStripMenuItem
            // 
            this.last15daysToolStripMenuItem.Name = "last15daysToolStripMenuItem";
            this.last15daysToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.last15daysToolStripMenuItem.Text = "last 15days";
            this.last15daysToolStripMenuItem.Click += new System.EventHandler(this.last15daysToolStripMenuItem_Click);
            // 
            // highOrderValueToolStripMenuItem
            // 
            this.highOrderValueToolStripMenuItem.Name = "highOrderValueToolStripMenuItem";
            this.highOrderValueToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.highOrderValueToolStripMenuItem.Text = "high order value";
            this.highOrderValueToolStripMenuItem.Click += new System.EventHandler(this.highOrderValueToolStripMenuItem_Click);
            // 
            // productOrder2ToolStripMenuItem
            // 
            this.productOrder2ToolStripMenuItem.Name = "productOrder2ToolStripMenuItem";
            this.productOrder2ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.productOrder2ToolStripMenuItem.Text = "product order >= 2";
            this.productOrder2ToolStripMenuItem.Click += new System.EventHandler(this.productOrder2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 627);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem last15daysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highOrderValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productOrder2ToolStripMenuItem;
    }
}

