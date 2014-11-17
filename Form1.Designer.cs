namespace XMLCreator
{
    partial class XMLCreator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_path = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_files = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.lbl_files = new System.Windows.Forms.Label();
            this.lbl_url = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_args = new System.Windows.Forms.Label();
            this.txt_args = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(234, 25);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(37, 23);
            this.btn_path.TabIndex = 0;
            this.btn_path.Text = "...";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(12, 27);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(216, 20);
            this.txt_path.TabIndex = 1;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(94, 390);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 42);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Create Update.xml";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_files
            // 
            this.txt_files.Location = new System.Drawing.Point(11, 83);
            this.txt_files.Multiline = true;
            this.txt_files.Name = "txt_files";
            this.txt_files.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_files.Size = new System.Drawing.Size(259, 119);
            this.txt_files.TabIndex = 3;
            this.txt_files.WordWrap = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(234, 54);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(36, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Multiselect = true;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(12, 229);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(259, 20);
            this.txt_url.TabIndex = 5;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(12, 275);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(258, 66);
            this.txt_description.TabIndex = 6;
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(12, 9);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(29, 13);
            this.lbl_path.TabIndex = 7;
            this.lbl_path.Text = "Pfad";
            // 
            // lbl_files
            // 
            this.lbl_files.AutoSize = true;
            this.lbl_files.Location = new System.Drawing.Point(12, 64);
            this.lbl_files.Name = "lbl_files";
            this.lbl_files.Size = new System.Drawing.Size(84, 13);
            this.lbl_files.TabIndex = 8;
            this.lbl_files.Text = "Weitere Dateien";
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(12, 213);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(66, 13);
            this.lbl_url.TabIndex = 9;
            this.lbl_url.Text = "Upload URL";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(12, 259);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(110, 13);
            this.lbl_description.TabIndex = 10;
            this.lbl_description.Text = "Update Beschreibung";
            // 
            // lbl_args
            // 
            this.lbl_args.AutoSize = true;
            this.lbl_args.Location = new System.Drawing.Point(11, 348);
            this.lbl_args.Name = "lbl_args";
            this.lbl_args.Size = new System.Drawing.Size(76, 13);
            this.lbl_args.TabIndex = 11;
            this.lbl_args.Text = "Startparameter";
            // 
            // txt_args
            // 
            this.txt_args.Location = new System.Drawing.Point(12, 364);
            this.txt_args.Name = "txt_args";
            this.txt_args.Size = new System.Drawing.Size(258, 20);
            this.txt_args.TabIndex = 12;
            // 
            // XMLCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 440);
            this.Controls.Add(this.txt_args);
            this.Controls.Add(this.lbl_args);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.lbl_files);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_files);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_path);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XMLCreator";
            this.Text = "XMLCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_files;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Label lbl_files;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_args;
        private System.Windows.Forms.TextBox txt_args;
    }
}

