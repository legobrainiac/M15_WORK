namespace trab_m15_psi_tomás_pinto_n24
{
    partial class player_gt_items
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
            this.txt_item = new System.Windows.Forms.TextBox();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_players = new System.Windows.Forms.ComboBox();
            this.txt_players = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(142, 74);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(121, 20);
            this.txt_item.TabIndex = 0;
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(15, 74);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(121, 21);
            this.cb_item.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // cb_players
            // 
            this.cb_players.FormattingEnabled = true;
            this.cb_players.Location = new System.Drawing.Point(15, 113);
            this.cb_players.Name = "cb_players";
            this.cb_players.Size = new System.Drawing.Size(121, 21);
            this.cb_players.TabIndex = 4;
            // 
            // txt_players
            // 
            this.txt_players.Location = new System.Drawing.Point(142, 113);
            this.txt_players.Name = "txt_players";
            this.txt_players.Size = new System.Drawing.Size(121, 20);
            this.txt_players.TabIndex = 3;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(15, 48);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(121, 20);
            this.txt_count.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Give:";
            // 
            // player_gt_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_players);
            this.Controls.Add(this.txt_players);
            this.Controls.Add(this.cb_item);
            this.Controls.Add(this.txt_item);
            this.Name = "player_gt_items";
            this.Text = "player_gt_items";
            this.Load += new System.EventHandler(this.player_gt_items_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_players;
        private System.Windows.Forms.TextBox txt_players;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label3;
    }
}