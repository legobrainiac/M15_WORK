namespace trab_m15_psi_tomás_pinto_n24
{
    partial class recipe_tree_view
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
            this.tree_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tree_view
            // 
            this.tree_view.Location = new System.Drawing.Point(12, 12);
            this.tree_view.Name = "tree_view";
            this.tree_view.Size = new System.Drawing.Size(260, 237);
            this.tree_view.TabIndex = 0;
            // 
            // recipe_tree_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tree_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "recipe_tree_view";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.recipe_tree_view_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree_view;
    }
}