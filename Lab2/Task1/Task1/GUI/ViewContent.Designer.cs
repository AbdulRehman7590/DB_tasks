namespace Task1.GUI
{
    partial class ViewContent
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
            this.search_Panel = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_Txt = new System.Windows.Forms.TextBox();
            this.search_Label = new System.Windows.Forms.Label();
            this.show_Panel = new System.Windows.Forms.Panel();
            this.display_GV = new System.Windows.Forms.DataGridView();
            this.search_Panel.SuspendLayout();
            this.show_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // search_Panel
            // 
            this.search_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.search_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.search_Panel.Controls.Add(this.search_btn);
            this.search_Panel.Controls.Add(this.search_Txt);
            this.search_Panel.Controls.Add(this.search_Label);
            this.search_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_Panel.Location = new System.Drawing.Point(0, 0);
            this.search_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.search_Panel.Name = "search_Panel";
            this.search_Panel.Size = new System.Drawing.Size(800, 111);
            this.search_Panel.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.search_btn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_btn.Location = new System.Drawing.Point(616, 38);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(108, 43);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_Txt
            // 
            this.search_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_Txt.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Txt.Location = new System.Drawing.Point(261, 47);
            this.search_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.search_Txt.Name = "search_Txt";
            this.search_Txt.Size = new System.Drawing.Size(309, 32);
            this.search_Txt.TabIndex = 1;
            // 
            // search_Label
            // 
            this.search_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_Label.AutoSize = true;
            this.search_Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_Label.Location = new System.Drawing.Point(90, 47);
            this.search_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.search_Label.Name = "search_Label";
            this.search_Label.Padding = new System.Windows.Forms.Padding(5);
            this.search_Label.Size = new System.Drawing.Size(166, 33);
            this.search_Label.TabIndex = 0;
            this.search_Label.Text = "Enter the Name :";
            // 
            // show_Panel
            // 
            this.show_Panel.AutoScroll = true;
            this.show_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.show_Panel.Controls.Add(this.display_GV);
            this.show_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_Panel.Location = new System.Drawing.Point(0, 111);
            this.show_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.show_Panel.Name = "show_Panel";
            this.show_Panel.Size = new System.Drawing.Size(800, 339);
            this.show_Panel.TabIndex = 2;
            // 
            // display_GV
            // 
            this.display_GV.AllowUserToOrderColumns = true;
            this.display_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.display_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.display_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display_GV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display_GV.Location = new System.Drawing.Point(0, 0);
            this.display_GV.Margin = new System.Windows.Forms.Padding(4);
            this.display_GV.Name = "display_GV";
            this.display_GV.RowHeadersWidth = 51;
            this.display_GV.Size = new System.Drawing.Size(800, 339);
            this.display_GV.TabIndex = 0;
            // 
            // ViewContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_Panel);
            this.Controls.Add(this.search_Panel);
            this.Name = "ViewContent";
            this.Text = "View";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            this.search_Panel.ResumeLayout(false);
            this.search_Panel.PerformLayout();
            this.show_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.display_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel search_Panel;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_Txt;
        private System.Windows.Forms.Label search_Label;
        private System.Windows.Forms.Panel show_Panel;
        private System.Windows.Forms.DataGridView display_GV;
    }
}