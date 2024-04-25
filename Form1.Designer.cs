namespace DecimalConverter
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
            lblDec = new Label();
            txtDec = new TextBox();
            lblHex = new Label();
            lblBin = new Label();
            txtBin = new TextBox();
            txtHex = new TextBox();
            btnClear = new Button();
            lblTitle = new Label();
            btnConv = new Button();
            SuspendLayout();
            // 
            // lblDec
            // 
            lblDec.AutoSize = true;
            lblDec.Location = new Point(228, 143);
            lblDec.Name = "lblDec";
            lblDec.Size = new Size(71, 20);
            lblDec.TabIndex = 0;
            lblDec.Text = "Decimal :";
            lblDec.UseWaitCursor = true;
            // 
            // txtDec
            // 
            txtDec.Location = new Point(305, 136);
            txtDec.Name = "txtDec";
            txtDec.Size = new Size(306, 27);
            txtDec.TabIndex = 1;
            txtDec.UseWaitCursor = true;
            // 
            // lblHex
            // 
            lblHex.AutoSize = true;
            lblHex.Location = new Point(192, 274);
            lblHex.Name = "lblHex";
            lblHex.Size = new Size(107, 20);
            lblHex.TabIndex = 2;
            lblHex.Text = "Hexadecimal : ";
            lblHex.UseWaitCursor = true;
            // 
            // lblBin
            // 
            lblBin.AutoSize = true;
            lblBin.Location = new Point(242, 213);
            lblBin.Name = "lblBin";
            lblBin.Size = new Size(57, 20);
            lblBin.TabIndex = 3;
            lblBin.Text = "Binary :";
            lblBin.UseWaitCursor = true;
            // 
            // txtBin
            // 
            txtBin.Location = new Point(305, 210);
            txtBin.Name = "txtBin";
            txtBin.Size = new Size(306, 27);
            txtBin.TabIndex = 4;
            txtBin.UseWaitCursor = true;
            // 
            // txtHex
            // 
            txtHex.Location = new Point(305, 274);
            txtHex.Name = "txtHex";
            txtHex.Size = new Size(306, 27);
            txtHex.TabIndex = 5;
            txtHex.UseWaitCursor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(415, 347);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(154, 54);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.UseWaitCursor = true;
            btnClear.Click += button1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(166, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(522, 46);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Decimal to Binary to Hexadecimal";
            lblTitle.UseWaitCursor = true;
            // 
            // btnConv
            // 
            btnConv.Location = new Point(242, 347);
            btnConv.Name = "btnConv";
            btnConv.Size = new Size(154, 54);
            btnConv.TabIndex = 8;
            btnConv.Text = "Convert";
            btnConv.UseVisualStyleBackColor = true;
            btnConv.UseWaitCursor = true;
            btnConv.Click += btnConv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConv);
            Controls.Add(lblTitle);
            Controls.Add(btnClear);
            Controls.Add(txtHex);
            Controls.Add(txtBin);
            Controls.Add(lblBin);
            Controls.Add(lblHex);
            Controls.Add(txtDec);
            Controls.Add(lblDec);
            KeyPreview = true;
            Name = "Form1";
            Text = "Number Converter";
            UseWaitCursor = true;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDec;
        private TextBox txtDec;
        private Label lblHex;
        private Label lblBin;
        private TextBox txtBin;
        private TextBox txtHex;
        private Button btnClear;
        private Label lblTitle;
        private Button btnConv;
    }
}
