
namespace Rendeles
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
            this.label1 = new System.Windows.Forms.Label();
            this.productCbx = new System.Windows.Forms.ComboBox();
            this.toCartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SizingCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cartLbx = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék";
            // 
            // productCbx
            // 
            this.productCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCbx.FormattingEnabled = true;
            this.productCbx.Location = new System.Drawing.Point(12, 70);
            this.productCbx.Name = "productCbx";
            this.productCbx.Size = new System.Drawing.Size(121, 21);
            this.productCbx.TabIndex = 1;
            this.productCbx.SelectedIndexChanged += new System.EventHandler(this.productCbx_SelectedIndexChanged);
            // 
            // toCartBtn
            // 
            this.toCartBtn.Location = new System.Drawing.Point(439, 69);
            this.toCartBtn.Name = "toCartBtn";
            this.toCartBtn.Size = new System.Drawing.Size(75, 23);
            this.toCartBtn.TabIndex = 2;
            this.toCartBtn.Text = "Kosárba";
            this.toCartBtn.UseVisualStyleBackColor = true;
            this.toCartBtn.Click += new System.EventHandler(this.toCartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kiszerelés";
            // 
            // SizingCbx
            // 
            this.SizingCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizingCbx.FormattingEnabled = true;
            this.SizingCbx.Location = new System.Drawing.Point(158, 70);
            this.SizingCbx.Name = "SizingCbx";
            this.SizingCbx.Size = new System.Drawing.Size(121, 21);
            this.SizingCbx.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Literár";
            // 
            // priceTbx
            // 
            this.priceTbx.Enabled = false;
            this.priceTbx.Location = new System.Drawing.Point(302, 71);
            this.priceTbx.Name = "priceTbx";
            this.priceTbx.Size = new System.Drawing.Size(100, 20);
            this.priceTbx.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kosár tartalma";
            // 
            // cartLbx
            // 
            this.cartLbx.FormattingEnabled = true;
            this.cartLbx.Location = new System.Drawing.Point(16, 184);
            this.cartLbx.Name = "cartLbx";
            this.cartLbx.Size = new System.Drawing.Size(772, 251);
            this.cartLbx.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Végösszeg: 0 Ft";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cartLbx);
            this.Controls.Add(this.priceTbx);
            this.Controls.Add(this.toCartBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SizingCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productCbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rendelések";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productCbx;
        private System.Windows.Forms.Button toCartBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SizingCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox cartLbx;
        private System.Windows.Forms.Label label5;
    }
}

