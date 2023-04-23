
namespace corona
{
    partial class Form5
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
            this.datahistorique = new System.Windows.Forms.DataGridView();
            this.fermerform5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datahistorique)).BeginInit();
            this.SuspendLayout();
            // 
            // datahistorique
            // 
            this.datahistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datahistorique.Location = new System.Drawing.Point(12, 12);
            this.datahistorique.Name = "datahistorique";
            this.datahistorique.RowHeadersWidth = 51;
            this.datahistorique.RowTemplate.Height = 24;
            this.datahistorique.Size = new System.Drawing.Size(569, 530);
            this.datahistorique.TabIndex = 0;
            // 
            // fermerform5
            // 
            this.fermerform5.Location = new System.Drawing.Point(506, 555);
            this.fermerform5.Name = "fermerform5";
            this.fermerform5.Size = new System.Drawing.Size(75, 23);
            this.fermerform5.TabIndex = 1;
            this.fermerform5.Text = "Fermer";
            this.fermerform5.UseVisualStyleBackColor = true;
            this.fermerform5.Click += new System.EventHandler(this.fermerform5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 590);
            this.Controls.Add(this.fermerform5);
            this.Controls.Add(this.datahistorique);
            this.Name = "Form5";
            this.Text = "Historique";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.datahistorique)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datahistorique;
        private System.Windows.Forms.Button fermerform5;
    }
}