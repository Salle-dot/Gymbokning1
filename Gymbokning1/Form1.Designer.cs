namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnBoka = new System.Windows.Forms.Button();
            this.btnAvboka = new System.Windows.Forms.Button();
            this.listViewPass = new System.Windows.Forms.ListView();
            this.kategoriColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tidColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.antalPlatserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBoka
            // 
            this.btnBoka.Location = new System.Drawing.Point(40, 181);
            this.btnBoka.Name = "btnBoka";
            this.btnBoka.Size = new System.Drawing.Size(123, 44);
            this.btnBoka.TabIndex = 0;
            this.btnBoka.Text = "Boka";
            this.btnBoka.UseVisualStyleBackColor = true;
            this.btnBoka.Click += new System.EventHandler(this.btnBoka_Click);
            // 
            // btnAvboka
            // 
            this.btnAvboka.Location = new System.Drawing.Point(40, 247);
            this.btnAvboka.Name = "btnAvboka";
            this.btnAvboka.Size = new System.Drawing.Size(123, 46);
            this.btnAvboka.TabIndex = 1;
            this.btnAvboka.Text = "Avboka";
            this.btnAvboka.UseVisualStyleBackColor = true;
            // 
            // listViewPass
            // 
            this.listViewPass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kategoriColumn,
            this.tidColumn,
            this.antalPlatserColumn});
            this.listViewPass.HideSelection = false;
            this.listViewPass.Location = new System.Drawing.Point(40, 12);
            this.listViewPass.Name = "listViewPass";
            this.listViewPass.Size = new System.Drawing.Size(423, 145);
            this.listViewPass.TabIndex = 2;
            this.listViewPass.UseCompatibleStateImageBehavior = false;
            this.listViewPass.View = System.Windows.Forms.View.Details;
            // 
            // kategoriColumn
            // 
            this.kategoriColumn.Text = "Kategori";
            this.kategoriColumn.Width = 100;
            // 
            // tidColumn
            // 
            this.tidColumn.Text = "Tid";
            this.tidColumn.Width = 100;
            // 
            // antalPlatserColumn
            // 
            this.antalPlatserColumn.Text = "Antal Platser";
            this.antalPlatserColumn.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewPass);
            this.Controls.Add(this.btnAvboka);
            this.Controls.Add(this.btnBoka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoka;
        private System.Windows.Forms.Button btnAvboka;
        private System.Windows.Forms.ListView listViewPass;
        private System.Windows.Forms.ColumnHeader kategoriColumn;
        private System.Windows.Forms.ColumnHeader tidColumn;
        private System.Windows.Forms.ColumnHeader antalPlatserColumn;
    }
}

