
namespace DataGridViewEntitiyFramework
{
    partial class Form2
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
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblKitapYılı = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapYili = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.Location = new System.Drawing.Point(65, 90);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(76, 20);
            this.lblKitapAdi.TabIndex = 0;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // lblKitapYılı
            // 
            this.lblKitapYılı.AutoSize = true;
            this.lblKitapYılı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapYılı.Location = new System.Drawing.Point(65, 134);
            this.lblKitapYılı.Name = "lblKitapYılı";
            this.lblKitapYılı.Size = new System.Drawing.Size(74, 20);
            this.lblKitapYılı.TabIndex = 1;
            this.lblKitapYılı.Text = "Kitap Yılı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(177, 90);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(230, 22);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // txtKitapYili
            // 
            this.txtKitapYili.Location = new System.Drawing.Point(175, 135);
            this.txtKitapYili.Name = "txtKitapYili";
            this.txtKitapYili.Size = new System.Drawing.Size(232, 22);
            this.txtKitapYili.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(268, 186);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 55);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKitapYili);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.lblKitapYılı);
            this.Controls.Add(this.lblKitapAdi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblKitapYılı;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapYili;
        private System.Windows.Forms.Button btnKaydet;
    }
}