namespace Projet_Exament_Gestion_Etudiant.views
{
    partial class FormMatiere
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
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.dataGridView_matiere = new System.Windows.Forms.DataGridView();
            this.btn_edit = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matiere)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btn_add.IconColor = System.Drawing.Color.Navy;
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.IconSize = 70;
            this.btn_add.Location = new System.Drawing.Point(706, 35);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 60);
            this.btn_add.TabIndex = 4;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView_matiere
            // 
            this.dataGridView_matiere.AllowUserToAddRows = false;
            this.dataGridView_matiere.AllowUserToDeleteRows = false;
            this.dataGridView_matiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_matiere.Location = new System.Drawing.Point(158, 128);
            this.dataGridView_matiere.Name = "dataGridView_matiere";
            this.dataGridView_matiere.ReadOnly = true;
            this.dataGridView_matiere.RowHeadersWidth = 62;
            this.dataGridView_matiere.RowTemplate.Height = 28;
            this.dataGridView_matiere.Size = new System.Drawing.Size(703, 417);
            this.dataGridView_matiere.TabIndex = 5;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btn_edit.IconColor = System.Drawing.Color.Navy;
            this.btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_edit.IconSize = 70;
            this.btn_edit.Location = new System.Drawing.Point(805, 35);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(56, 60);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.iconButton1.IconColor = System.Drawing.Color.Navy;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 70;
            this.iconButton1.Location = new System.Drawing.Point(706, 35);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(56, 60);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.iconButton2.IconColor = System.Drawing.Color.Navy;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 70;
            this.iconButton2.Location = new System.Drawing.Point(805, 35);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(56, 60);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // FormMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 590);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridView_matiere);
            this.Controls.Add(this.btn_add);
            this.Name = "FormMatiere";
            this.Text = "FormMatiere";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matiere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_add;
        private System.Windows.Forms.DataGridView dataGridView_matiere;
        private FontAwesome.Sharp.IconButton btn_edit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}