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
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_players = new System.Windows.Forms.ComboBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_give = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(15, 51);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(121, 21);
            this.cb_item.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To / From:";
            // 
            // cb_players
            // 
            this.cb_players.FormattingEnabled = true;
            this.cb_players.Location = new System.Drawing.Point(15, 91);
            this.cb_players.Name = "cb_players";
            this.cb_players.Size = new System.Drawing.Size(121, 21);
            this.cb_players.TabIndex = 4;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(15, 25);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(121, 20);
            this.txt_count.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Give / Take:";
            // 
            // btn_give
            // 
            this.btn_give.Location = new System.Drawing.Point(15, 118);
            this.btn_give.Name = "btn_give";
            this.btn_give.Size = new System.Drawing.Size(121, 23);
            this.btn_give.TabIndex = 8;
            this.btn_give.Text = "Give / Take";
            this.btn_give.UseVisualStyleBackColor = true;
            this.btn_give.Click += new System.EventHandler(this.btn_give_Click);
            // 
            // player_gt_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 149);
            this.Controls.Add(this.btn_give);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_players);
            this.Controls.Add(this.cb_item);
            this.Name = "player_gt_items";
            this.Text = "player_gt_items";
            this.Load += new System.EventHandler(this.player_gt_items_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_players;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_give;
    }
}