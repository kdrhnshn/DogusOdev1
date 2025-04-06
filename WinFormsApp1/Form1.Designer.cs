namespace WinFormsPayment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogTipi = new Label();
            cmbPaymentType = new ComboBox();
            txtAmount = new TextBox();
            lblMesaj = new Label();
            btnKaydet = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblLogTipi
            // 
            lblLogTipi.AutoSize = true;
            lblLogTipi.Location = new Point(303, 57);
            lblLogTipi.Name = "lblLogTipi";
            lblLogTipi.Size = new Size(77, 15);
            lblLogTipi.TabIndex = 0;
            lblLogTipi.Text = "Ödeme Tipi : ";
            lblLogTipi.Click += lblPaymentType_Click;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Seçiniz", "CashPayment", "BankTransfer", "CardPayment" });
            cmbPaymentType.Location = new Point(448, 58);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(255, 23);
            cmbPaymentType.TabIndex = 1;
            cmbPaymentType.SelectedIndexChanged += cmbPaymentType_SelectedIndexChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(450, 120);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(253, 23);
            txtAmount.TabIndex = 2;
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(307, 123);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(44, 15);
            lblMesaj.TabIndex = 3;
            lblMesaj.Text = "Miktar:";
            lblMesaj.Click += lblAmount_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(595, 202);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(108, 66);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Ödeme yap";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnPay_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(300, 378);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "Sonuç : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 465);
            Controls.Add(lblResult);
            Controls.Add(btnKaydet);
            Controls.Add(lblMesaj);
            Controls.Add(txtAmount);
            Controls.Add(cmbPaymentType);
            Controls.Add(lblLogTipi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogTipi;
        private ComboBox cmbPaymentType;
        private TextBox txtAmount;
        private Label lblMesaj;
        private Button btnKaydet;
        private Label lblResult;
    }
}
