namespace Temperature_converter
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
            txtTempInput = new TextBox();
            cmbInputUnit = new ComboBox();
            label1 = new Label();
            cmbOutputUnit = new ComboBox();
            btnConvert = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtTempInput
            // 
            txtTempInput.BackColor = SystemColors.ButtonHighlight;
            txtTempInput.Location = new Point(76, 114);
            txtTempInput.Name = "txtTempInput";
            txtTempInput.Size = new Size(134, 27);
            txtTempInput.TabIndex = 0;
            txtTempInput.Text = "\n";
            // 
            // cmbInputUnit
            // 
            cmbInputUnit.BackColor = SystemColors.ButtonHighlight;
            cmbInputUnit.FormattingEnabled = true;
            cmbInputUnit.Location = new Point(263, 113);
            cmbInputUnit.Name = "cmbInputUnit";
            cmbInputUnit.Size = new Size(54, 28);
            cmbInputUnit.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 121);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 2;
            label1.Text = "To";
            // 
            // cmbOutputUnit
            // 
            cmbOutputUnit.BackColor = SystemColors.ButtonHighlight;
            cmbOutputUnit.FormattingEnabled = true;
            cmbOutputUnit.Location = new Point(471, 113);
            cmbOutputUnit.Name = "cmbOutputUnit";
            cmbOutputUnit.Size = new Size(58, 28);
            cmbOutputUnit.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(601, 114);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 34F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.ForeColor = SystemColors.ActiveCaptionText;
            lblResult.Location = new Point(128, 264);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 76);
            lblResult.TabIndex = 5;
            lblResult.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 492);
            Controls.Add(lblResult);
            Controls.Add(btnConvert);
            Controls.Add(cmbOutputUnit);
            Controls.Add(label1);
            Controls.Add(cmbInputUnit);
            Controls.Add(txtTempInput);
            Name = "Form1";
            Text = "Temperature Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTempInput;
        private ComboBox cmbInputUnit;
        private Label label1;
        private ComboBox cmbOutputUnit;
        private Button btnConvert;
        private Label lblResult;
    }
}