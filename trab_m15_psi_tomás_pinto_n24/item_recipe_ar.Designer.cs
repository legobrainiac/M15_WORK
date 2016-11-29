namespace trab_m15_psi_tomás_pinto_n24
{
    partial class item_recipe_ar
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
            this.btn_add = new System.Windows.Forms.Button();
            this.clb_recipe_items = new System.Windows.Forms.CheckedListBox();
            this.lb_items = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(492, 295);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // clb_recipe_items
            // 
            this.clb_recipe_items.FormattingEnabled = true;
            this.clb_recipe_items.Location = new System.Drawing.Point(138, 25);
            this.clb_recipe_items.Name = "clb_recipe_items";
            this.clb_recipe_items.Size = new System.Drawing.Size(120, 289);
            this.clb_recipe_items.TabIndex = 4;
            // 
            // lb_items
            // 
            this.lb_items.FormattingEnabled = true;
            this.lb_items.Location = new System.Drawing.Point(12, 25);
            this.lb_items.Name = "lb_items";
            this.lb_items.Size = new System.Drawing.Size(120, 290);
            this.lb_items.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Recipe";
            // 
            // item_recipe_ar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_items);
            this.Controls.Add(this.clb_recipe_items);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "item_recipe_ar";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.item_recipe_ar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.CheckedListBox clb_recipe_items;
        private System.Windows.Forms.ListBox lb_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}