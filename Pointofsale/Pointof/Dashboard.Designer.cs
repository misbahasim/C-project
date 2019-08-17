namespace Pointof
{
    partial class Dashboard
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
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.btnProductForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStockForm = new System.Windows.Forms.Button();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.pnlShowForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCategoryForm.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnCategoryForm.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCategoryForm.Location = new System.Drawing.Point(-1, 122);
            this.btnCategoryForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(177, 43);
            this.btnCategoryForm.TabIndex = 0;
            this.btnCategoryForm.Text = "Category";
            this.btnCategoryForm.UseVisualStyleBackColor = false;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // btnProductForm
            // 
            this.btnProductForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductForm.FlatAppearance.BorderSize = 0;
            this.btnProductForm.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductForm.Location = new System.Drawing.Point(-1, 201);
            this.btnProductForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnProductForm.Name = "btnProductForm";
            this.btnProductForm.Size = new System.Drawing.Size(177, 43);
            this.btnProductForm.TabIndex = 1;
            this.btnProductForm.Text = "Product";
            this.btnProductForm.UseVisualStyleBackColor = false;
            this.btnProductForm.Click += new System.EventHandler(this.btnProductForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnStockForm);
            this.panel1.Controls.Add(this.btnUserForm);
            this.panel1.Controls.Add(this.btnProductForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 561);
            this.panel1.TabIndex = 2;
            // 
            // btnStockForm
            // 
            this.btnStockForm.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockForm.Location = new System.Drawing.Point(-1, 371);
            this.btnStockForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStockForm.Name = "btnStockForm";
            this.btnStockForm.Size = new System.Drawing.Size(177, 43);
            this.btnStockForm.TabIndex = 3;
            this.btnStockForm.Text = "Stock in";
            this.btnStockForm.UseVisualStyleBackColor = true;
            this.btnStockForm.Click += new System.EventHandler(this.btnStockForm_Click);
            // 
            // btnUserForm
            // 
            this.btnUserForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUserForm.FlatAppearance.BorderSize = 0;
            this.btnUserForm.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserForm.Location = new System.Drawing.Point(-1, 285);
            this.btnUserForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(177, 43);
            this.btnUserForm.TabIndex = 2;
            this.btnUserForm.Text = "Users";
            this.btnUserForm.UseVisualStyleBackColor = false;
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // pnlShowForm
            // 
            this.pnlShowForm.Location = new System.Drawing.Point(180, 0);
            this.pnlShowForm.Name = "pnlShowForm";
            this.pnlShowForm.Size = new System.Drawing.Size(830, 561);
            this.pnlShowForm.TabIndex = 3;
            this.pnlShowForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShowForm_Paint);
            // 
            // MainOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 561);
            this.Controls.Add(this.pnlShowForm);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainOutputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.Load += new System.EventHandler(this.MainOutputForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Button btnProductForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUserForm;
        private System.Windows.Forms.Button btnStockForm;
        private System.Windows.Forms.Panel pnlShowForm;

    }
}

