namespace Calculator
{
    partial class CalculatorForm
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
            System.Windows.Forms.Button btn7;
            System.Windows.Forms.Button btn9;
            System.Windows.Forms.Button btn8;
            System.Windows.Forms.Button btn4;
            System.Windows.Forms.Button btn5;
            System.Windows.Forms.Button btn6;
            System.Windows.Forms.Button btn2;
            System.Windows.Forms.Button btn3;
            System.Windows.Forms.Button btn0;
            System.Windows.Forms.Button btnCE;
            System.Windows.Forms.Button btnDot;
            System.Windows.Forms.Button btnAdd;
            System.Windows.Forms.Button btnSub;
            System.Windows.Forms.Button btnMul;
            System.Windows.Forms.Button btnDiv;
            System.Windows.Forms.Panel pnlDisplay;
            System.Windows.Forms.Button btn1;
            this.btnEquals = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.tablayoutButtons = new System.Windows.Forms.TableLayoutPanel();
            btn7 = new System.Windows.Forms.Button();
            btn9 = new System.Windows.Forms.Button();
            btn8 = new System.Windows.Forms.Button();
            btn4 = new System.Windows.Forms.Button();
            btn5 = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            btn3 = new System.Windows.Forms.Button();
            btn0 = new System.Windows.Forms.Button();
            btnCE = new System.Windows.Forms.Button();
            btnDot = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnSub = new System.Windows.Forms.Button();
            btnMul = new System.Windows.Forms.Button();
            btnDiv = new System.Windows.Forms.Button();
            pnlDisplay = new System.Windows.Forms.Panel();
            btn1 = new System.Windows.Forms.Button();
            pnlDisplay.SuspendLayout();
            this.tablayoutButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn7
            // 
            btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn7.Location = new System.Drawing.Point(5, 5);
            btn7.Margin = new System.Windows.Forms.Padding(5);
            btn7.Name = "btn7";
            btn7.Size = new System.Drawing.Size(69, 41);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // btn9
            // 
            btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn9.Location = new System.Drawing.Point(163, 5);
            btn9.Margin = new System.Windows.Forms.Padding(5);
            btn9.Name = "btn9";
            btn9.Size = new System.Drawing.Size(69, 41);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // btn8
            // 
            btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn8.Location = new System.Drawing.Point(84, 5);
            btn8.Margin = new System.Windows.Forms.Padding(5);
            btn8.Name = "btn8";
            btn8.Size = new System.Drawing.Size(69, 41);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // btn4
            // 
            btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn4.Location = new System.Drawing.Point(5, 56);
            btn4.Margin = new System.Windows.Forms.Padding(5);
            btn4.Name = "btn4";
            btn4.Size = new System.Drawing.Size(69, 41);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // btn5
            // 
            btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn5.Location = new System.Drawing.Point(84, 56);
            btn5.Margin = new System.Windows.Forms.Padding(5);
            btn5.Name = "btn5";
            btn5.Size = new System.Drawing.Size(69, 41);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // btn6
            // 
            btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn6.Location = new System.Drawing.Point(163, 56);
            btn6.Margin = new System.Windows.Forms.Padding(5);
            btn6.Name = "btn6";
            btn6.Size = new System.Drawing.Size(69, 41);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // btn2
            // 
            btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn2.Location = new System.Drawing.Point(84, 107);
            btn2.Margin = new System.Windows.Forms.Padding(5);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(69, 41);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // btn3
            // 
            btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn3.Location = new System.Drawing.Point(163, 107);
            btn3.Margin = new System.Windows.Forms.Padding(5);
            btn3.Name = "btn3";
            btn3.Size = new System.Drawing.Size(69, 41);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // btn0
            // 
            btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn0.Location = new System.Drawing.Point(84, 158);
            btn0.Margin = new System.Windows.Forms.Padding(5);
            btn0.Name = "btn0";
            btn0.Size = new System.Drawing.Size(69, 41);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // btnCE
            // 
            btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            btnCE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnCE.Location = new System.Drawing.Point(5, 158);
            btnCE.Margin = new System.Windows.Forms.Padding(5);
            btnCE.Name = "btnCE";
            btnCE.Size = new System.Drawing.Size(69, 41);
            btnCE.TabIndex = 11;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += new System.EventHandler(this.OnClearClick);
            // 
            // btnDot
            // 
            btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            btnDot.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnDot.Location = new System.Drawing.Point(163, 158);
            btnDot.Margin = new System.Windows.Forms.Padding(5);
            btnDot.Name = "btnDot";
            btnDot.Size = new System.Drawing.Size(69, 41);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += new System.EventHandler(this.OnDotClick);
            // 
            // btnAdd
            // 
            btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnAdd.Location = new System.Drawing.Point(242, 5);
            btnAdd.Margin = new System.Windows.Forms.Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(71, 41);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // btnSub
            // 
            btnSub.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSub.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnSub.Location = new System.Drawing.Point(242, 56);
            btnSub.Margin = new System.Windows.Forms.Padding(5);
            btnSub.Name = "btnSub";
            btnSub.Size = new System.Drawing.Size(71, 41);
            btnSub.TabIndex = 14;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // btnMul
            // 
            btnMul.Dock = System.Windows.Forms.DockStyle.Fill;
            btnMul.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnMul.Location = new System.Drawing.Point(242, 107);
            btnMul.Margin = new System.Windows.Forms.Padding(5);
            btnMul.Name = "btnMul";
            btnMul.Size = new System.Drawing.Size(71, 41);
            btnMul.TabIndex = 15;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // btnDiv
            // 
            btnDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            btnDiv.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnDiv.Location = new System.Drawing.Point(242, 158);
            btnDiv.Margin = new System.Windows.Forms.Padding(5);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new System.Drawing.Size(71, 41);
            btnDiv.TabIndex = 16;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += new System.EventHandler(this.OnOperationClick);
            // 
            // btnEquals
            // 
            this.tablayoutButtons.SetColumnSpan(this.btnEquals, 4);
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEquals.Location = new System.Drawing.Point(5, 209);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(5);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(308, 45);
            this.btnEquals.TabIndex = 0;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.OnCalculationClick);
            // 
            // pnlDisplay
            // 
            pnlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pnlDisplay.Controls.Add(this.lblDisplay);
            pnlDisplay.Location = new System.Drawing.Point(2, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new System.Drawing.Size(327, 54);
            pnlDisplay.TabIndex = 19;
            // 
            // lblDisplay
            // 
            this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplay.Location = new System.Drawing.Point(0, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(327, 54);
            this.lblDisplay.TabIndex = 18;
            this.lblDisplay.Text = "ERR";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn1
            // 
            btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn1.Location = new System.Drawing.Point(5, 107);
            btn1.Margin = new System.Windows.Forms.Padding(5);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(69, 41);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += new System.EventHandler(this.OnDigitClick);
            // 
            // tablayoutButtons
            // 
            this.tablayoutButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablayoutButtons.ColumnCount = 4;
            this.tablayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablayoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablayoutButtons.Controls.Add(btn7, 0, 0);
            this.tablayoutButtons.Controls.Add(this.btnEquals, 0, 4);
            this.tablayoutButtons.Controls.Add(btn8, 1, 0);
            this.tablayoutButtons.Controls.Add(btnDiv, 3, 3);
            this.tablayoutButtons.Controls.Add(btn9, 2, 0);
            this.tablayoutButtons.Controls.Add(btnDot, 2, 3);
            this.tablayoutButtons.Controls.Add(btnMul, 3, 2);
            this.tablayoutButtons.Controls.Add(btn0, 1, 3);
            this.tablayoutButtons.Controls.Add(btnCE, 0, 3);
            this.tablayoutButtons.Controls.Add(btnAdd, 3, 0);
            this.tablayoutButtons.Controls.Add(btnSub, 3, 1);
            this.tablayoutButtons.Controls.Add(btn4, 0, 1);
            this.tablayoutButtons.Controls.Add(btn5, 1, 1);
            this.tablayoutButtons.Controls.Add(btn3, 2, 2);
            this.tablayoutButtons.Controls.Add(btn6, 2, 1);
            this.tablayoutButtons.Controls.Add(btn2, 1, 2);
            this.tablayoutButtons.Controls.Add(btn1, 0, 2);
            this.tablayoutButtons.Location = new System.Drawing.Point(2, 57);
            this.tablayoutButtons.Name = "tablayoutButtons";
            this.tablayoutButtons.RowCount = 5;
            this.tablayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablayoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablayoutButtons.Size = new System.Drawing.Size(318, 259);
            this.tablayoutButtons.TabIndex = 20;
            // 
            // CalculatorForm
            // 
            this.AcceptButton = this.btnEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 317);
            this.Controls.Add(this.tablayoutButtons);
            this.Controls.Add(pnlDisplay);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(575, 500);
            this.MinimumSize = new System.Drawing.Size(250, 356);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyboardPress);
            pnlDisplay.ResumeLayout(false);
            this.tablayoutButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TableLayoutPanel tablayoutButtons;
        private System.Windows.Forms.Button btnEquals;
    }
}

