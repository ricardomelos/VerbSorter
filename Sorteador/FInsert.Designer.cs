namespace Sorteador
{
    partial class FInsert
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
            this.txNewVerb = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txNewVerb
            // 
            this.txNewVerb.Location = new System.Drawing.Point(60, 79);
            this.txNewVerb.Name = "txNewVerb";
            this.txNewVerb.Size = new System.Drawing.Size(122, 20);
            this.txNewVerb.TabIndex = 0;
            this.txNewVerb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNewVerb_KeyPress);
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(188, 77);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 1;
            this.btInsert.Text = "Inserir";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // FInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 201);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txNewVerb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FInsert";
            this.Text = "Sorteador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNewVerb;
        private System.Windows.Forms.Button btInsert;
    }
}