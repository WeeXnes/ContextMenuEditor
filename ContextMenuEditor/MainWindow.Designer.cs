using System.ComponentModel;

namespace ContextMenuEditor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_bgmenu = new System.Windows.Forms.RadioButton();
            this.rb_foldermenu = new System.Windows.Forms.RadioButton();
            this.rb_filemenu = new System.Windows.Forms.RadioButton();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.tb_filepath = new System.Windows.Forms.TextBox();
            this.tb_iconpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_bgmenu);
            this.groupBox1.Controls.Add(this.rb_foldermenu);
            this.groupBox1.Controls.Add(this.rb_filemenu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Type";
            // 
            // rb_bgmenu
            // 
            this.rb_bgmenu.Location = new System.Drawing.Point(6, 60);
            this.rb_bgmenu.Name = "rb_bgmenu";
            this.rb_bgmenu.Size = new System.Drawing.Size(165, 24);
            this.rb_bgmenu.TabIndex = 2;
            this.rb_bgmenu.TabStop = true;
            this.rb_bgmenu.Text = "Background Menu";
            this.rb_bgmenu.UseVisualStyleBackColor = true;
            // 
            // rb_foldermenu
            // 
            this.rb_foldermenu.Location = new System.Drawing.Point(6, 39);
            this.rb_foldermenu.Name = "rb_foldermenu";
            this.rb_foldermenu.Size = new System.Drawing.Size(104, 24);
            this.rb_foldermenu.TabIndex = 1;
            this.rb_foldermenu.TabStop = true;
            this.rb_foldermenu.Text = "Folder Menu";
            this.rb_foldermenu.UseVisualStyleBackColor = true;
            // 
            // rb_filemenu
            // 
            this.rb_filemenu.Location = new System.Drawing.Point(6, 19);
            this.rb_filemenu.Name = "rb_filemenu";
            this.rb_filemenu.Size = new System.Drawing.Size(104, 24);
            this.rb_filemenu.TabIndex = 0;
            this.rb_filemenu.TabStop = true;
            this.rb_filemenu.Text = "File Menu";
            this.rb_filemenu.UseVisualStyleBackColor = true;
            // 
            // tb_text
            // 
            this.tb_text.BackColor = System.Drawing.SystemColors.Window;
            this.tb_text.Location = new System.Drawing.Point(94, 109);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(242, 20);
            this.tb_text.TabIndex = 1;
            // 
            // tb_filepath
            // 
            this.tb_filepath.Location = new System.Drawing.Point(94, 135);
            this.tb_filepath.Name = "tb_filepath";
            this.tb_filepath.Size = new System.Drawing.Size(242, 20);
            this.tb_filepath.TabIndex = 2;
            // 
            // tb_iconpath
            // 
            this.tb_iconpath.Location = new System.Drawing.Point(94, 161);
            this.tb_iconpath.Name = "tb_iconpath";
            this.tb_iconpath.Size = new System.Drawing.Size(242, 20);
            this.tb_iconpath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = ".exe path:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "icon path:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 187);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(324, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(348, 223);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_iconpath);
            this.Controls.Add(this.tb_filepath);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Context Menu Editor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;

        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.TextBox tb_filepath;
        private System.Windows.Forms.TextBox tb_iconpath;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_filemenu;
        private System.Windows.Forms.RadioButton rb_foldermenu;
        private System.Windows.Forms.RadioButton rb_bgmenu;

        #endregion
    }
}