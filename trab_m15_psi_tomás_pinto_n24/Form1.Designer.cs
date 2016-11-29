namespace trab_m15_psi_tomás_pinto_n24
{
    partial class frm_main
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
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRecipePerItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeForItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveTakeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listInventoryPerPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.itemRecipesToolStripMenuItem,
            this.playersToolStripMenuItem,
            this.inventoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listItemsToolStripMenuItem,
            this.addNewItemsToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // listItemsToolStripMenuItem
            // 
            this.listItemsToolStripMenuItem.Name = "listItemsToolStripMenuItem";
            this.listItemsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listItemsToolStripMenuItem.Text = "List Items";
            this.listItemsToolStripMenuItem.Click += new System.EventHandler(this.listItemsToolStripMenuItem_Click);
            // 
            // addNewItemsToolStripMenuItem
            // 
            this.addNewItemsToolStripMenuItem.Name = "addNewItemsToolStripMenuItem";
            this.addNewItemsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addNewItemsToolStripMenuItem.Text = "Add / Remove Items";
            this.addNewItemsToolStripMenuItem.Click += new System.EventHandler(this.addNewItemsToolStripMenuItem_Click);
            // 
            // itemRecipesToolStripMenuItem
            // 
            this.itemRecipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listRecipePerItemToolStripMenuItem,
            this.addRecipeForItemToolStripMenuItem});
            this.itemRecipesToolStripMenuItem.Name = "itemRecipesToolStripMenuItem";
            this.itemRecipesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.itemRecipesToolStripMenuItem.Text = "Item Recipes";
            // 
            // listRecipePerItemToolStripMenuItem
            // 
            this.listRecipePerItemToolStripMenuItem.Name = "listRecipePerItemToolStripMenuItem";
            this.listRecipePerItemToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.listRecipePerItemToolStripMenuItem.Text = "List Recipe per Item";
            this.listRecipePerItemToolStripMenuItem.Click += new System.EventHandler(this.listRecipePerItemToolStripMenuItem_Click);
            // 
            // addRecipeForItemToolStripMenuItem
            // 
            this.addRecipeForItemToolStripMenuItem.Name = "addRecipeForItemToolStripMenuItem";
            this.addRecipeForItemToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addRecipeForItemToolStripMenuItem.Text = "Add / Remove Recipe for Item";
            this.addRecipeForItemToolStripMenuItem.Click += new System.EventHandler(this.addRecipeForItemToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listPlayersToolStripMenuItem,
            this.removePlayersToolStripMenuItem,
            this.giveTakeItemsToolStripMenuItem});
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // listPlayersToolStripMenuItem
            // 
            this.listPlayersToolStripMenuItem.Name = "listPlayersToolStripMenuItem";
            this.listPlayersToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listPlayersToolStripMenuItem.Text = "List Players";
            this.listPlayersToolStripMenuItem.Click += new System.EventHandler(this.listPlayersToolStripMenuItem_Click);
            // 
            // removePlayersToolStripMenuItem
            // 
            this.removePlayersToolStripMenuItem.Name = "removePlayersToolStripMenuItem";
            this.removePlayersToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.removePlayersToolStripMenuItem.Text = "Add / Remove players";
            this.removePlayersToolStripMenuItem.Click += new System.EventHandler(this.removePlayersToolStripMenuItem_Click);
            // 
            // giveTakeItemsToolStripMenuItem
            // 
            this.giveTakeItemsToolStripMenuItem.Name = "giveTakeItemsToolStripMenuItem";
            this.giveTakeItemsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.giveTakeItemsToolStripMenuItem.Text = "Give / Take Items";
            this.giveTakeItemsToolStripMenuItem.Click += new System.EventHandler(this.giveTakeItemsToolStripMenuItem_Click);
            // 
            // inventoriesToolStripMenuItem
            // 
            this.inventoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listInventoryPerPlayersToolStripMenuItem});
            this.inventoriesToolStripMenuItem.Name = "inventoriesToolStripMenuItem";
            this.inventoriesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.inventoriesToolStripMenuItem.Text = "Inventories";
            // 
            // listInventoryPerPlayersToolStripMenuItem
            // 
            this.listInventoryPerPlayersToolStripMenuItem.Name = "listInventoryPerPlayersToolStripMenuItem";
            this.listInventoryPerPlayersToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.listInventoryPerPlayersToolStripMenuItem.Text = "List inventory per Players";
            this.listInventoryPerPlayersToolStripMenuItem.Click += new System.EventHandler(this.listInventoryPerPlayersToolStripMenuItem_Click);
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AllowUserToOrderColumns = true;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(13, 28);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.Size = new System.Drawing.Size(599, 281);
            this.dgv_main.TabIndex = 1;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "Main Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRecipePerItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecipeForItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listInventoryPerPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveTakeItemsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_main;
    }
}

