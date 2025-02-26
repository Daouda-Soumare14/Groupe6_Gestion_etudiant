namespace Projet_Exament_Gestion_Etudiant.views
{
    partial class FormEtudiant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_etudiant = new System.Windows.Forms.DataGridView();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.btn_edit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_etudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_etudiant
            // 
            this.dataGridView_etudiant.AllowUserToAddRows = false;
            this.dataGridView_etudiant.AllowUserToDeleteRows = false;
            this.dataGridView_etudiant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_etudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_etudiant.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_etudiant.GridColor = System.Drawing.Color.White;
            this.dataGridView_etudiant.Location = new System.Drawing.Point(-4, 320);
            this.dataGridView_etudiant.Name = "dataGridView_etudiant";
            this.dataGridView_etudiant.ReadOnly = true;
            this.dataGridView_etudiant.RowHeadersWidth = 82;
            this.dataGridView_etudiant.RowTemplate.Height = 33;
            this.dataGridView_etudiant.Size = new System.Drawing.Size(1978, 1107);
            this.dataGridView_etudiant.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btn_add.IconColor = System.Drawing.Color.Navy;
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.IconSize = 70;
            this.btn_add.Location = new System.Drawing.Point(1613, 169);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 75);
            this.btn_add.TabIndex = 1;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btn_edit.IconColor = System.Drawing.Color.Navy;
            this.btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_edit.IconSize = 70;
            this.btn_edit.Location = new System.Drawing.Point(1728, 169);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 75);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1429);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView_etudiant);
            this.Name = "FormEtudiant";
            this.Text = "FormEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_etudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_etudiant;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_edit;
    }
}