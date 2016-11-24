namespace trab_m15_psi_tomás_pinto_n24
{
    partial class items_ar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(items_ar));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_photo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_autorestart = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(72, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(160, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(73, 42);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(160, 66);
            this.txt_desc.TabIndex = 1;
            this.txt_desc.Text = "";
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(12, 19);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(160, 90);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 2;
            this.pb_image.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 297);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_photo);
            this.groupBox2.Controls.Add(this.pb_image);
            this.groupBox2.Location = new System.Drawing.Point(61, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            // 
            // btn_photo
            // 
            this.btn_photo.Location = new System.Drawing.Point(12, 112);
            this.btn_photo.Name = "btn_photo";
            this.btn_photo.Size = new System.Drawing.Size(160, 23);
            this.btn_photo.TabIndex = 3;
            this.btn_photo.Text = "Get Photo";
            this.btn_photo.UseVisualStyleBackColor = true;
            this.btn_photo.Click += new System.EventHandler(this.btn_photo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(73, 263);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(160, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Add";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToAddRows = false;
            this.dgv_items.AllowUserToDeleteRows = false;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Location = new System.Drawing.Point(270, 28);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.ReadOnly = true;
            this.dgv_items.Size = new System.Drawing.Size(342, 296);
            this.dgv_items.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_autorestart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_autorestart
            // 
            this.tsb_autorestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_autorestart.Image = ((System.Drawing.Image)(resources.GetObject("tsb_autorestart.Image")));
            this.tsb_autorestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_autorestart.Name = "tsb_autorestart";
            this.tsb_autorestart.Size = new System.Drawing.Size(23, 22);
            this.tsb_autorestart.Text = "Toggler auto refresh";
            this.tsb_autorestart.Click += new System.EventHandler(this.tsb_autorestart_Click);
            // 
            // items_ar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 345);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_items);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "items_ar";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.items_ar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RichTextBox txt_desc;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_photo;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_autorestart;
    }
}