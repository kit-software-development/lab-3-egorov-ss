namespace ColorPalette
{
    partial class PaletteForm
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
            System.Windows.Forms.Label lblRed;
            System.Windows.Forms.Label lblRed0;
            System.Windows.Forms.Label lblRed255;
            System.Windows.Forms.Label lblGreen;
            System.Windows.Forms.Label lblBlue;
            System.Windows.Forms.Label lblGreen0;
            System.Windows.Forms.Label lblGreen255;
            System.Windows.Forms.Label lblBlue0;
            System.Windows.Forms.Label lblBlue255;
            this.sliderRed = new System.Windows.Forms.TrackBar();
            this.pnlColorPreview = new System.Windows.Forms.Panel();
            this.tbloutColorSliders = new System.Windows.Forms.TableLayoutPanel();
            this.sliderGreen = new System.Windows.Forms.TrackBar();
            this.sliderBlue = new System.Windows.Forms.TrackBar();
            lblRed = new System.Windows.Forms.Label();
            lblRed0 = new System.Windows.Forms.Label();
            lblRed255 = new System.Windows.Forms.Label();
            lblGreen = new System.Windows.Forms.Label();
            lblBlue = new System.Windows.Forms.Label();
            lblGreen0 = new System.Windows.Forms.Label();
            lblGreen255 = new System.Windows.Forms.Label();
            lblBlue0 = new System.Windows.Forms.Label();
            lblBlue255 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).BeginInit();
            this.tbloutColorSliders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            lblRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            lblRed.AutoSize = true;
            lblRed.Location = new System.Drawing.Point(3, 11);
            lblRed.Name = "lblRed";
            lblRed.Size = new System.Drawing.Size(44, 13);
            lblRed.TabIndex = 2;
            lblRed.Text = "Red:";
            // 
            // lblRed0
            // 
            lblRed0.AutoSize = true;
            lblRed0.Dock = System.Windows.Forms.DockStyle.Left;
            lblRed0.Location = new System.Drawing.Point(53, 35);
            lblRed0.Name = "lblRed0";
            lblRed0.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            lblRed0.Size = new System.Drawing.Size(20, 20);
            lblRed0.TabIndex = 3;
            lblRed0.Text = "0";
            // 
            // lblRed255
            // 
            lblRed255.AutoSize = true;
            lblRed255.Dock = System.Windows.Forms.DockStyle.Right;
            lblRed255.Location = new System.Drawing.Point(518, 35);
            lblRed255.Name = "lblRed255";
            lblRed255.Size = new System.Drawing.Size(25, 20);
            lblRed255.TabIndex = 4;
            lblRed255.Text = "255";
            // 
            // lblGreen
            // 
            lblGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            lblGreen.AutoSize = true;
            lblGreen.Location = new System.Drawing.Point(3, 66);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new System.Drawing.Size(44, 13);
            lblGreen.TabIndex = 5;
            lblGreen.Text = "Green:";
            // 
            // lblBlue
            // 
            lblBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            lblBlue.AutoSize = true;
            lblBlue.Location = new System.Drawing.Point(3, 121);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new System.Drawing.Size(44, 13);
            lblBlue.TabIndex = 8;
            lblBlue.Text = "Blue:";
            // 
            // lblGreen0
            // 
            lblGreen0.AutoSize = true;
            lblGreen0.Location = new System.Drawing.Point(53, 90);
            lblGreen0.Name = "lblGreen0";
            lblGreen0.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            lblGreen0.Size = new System.Drawing.Size(20, 13);
            lblGreen0.TabIndex = 9;
            lblGreen0.Text = "0";
            // 
            // lblGreen255
            // 
            lblGreen255.AutoSize = true;
            lblGreen255.Dock = System.Windows.Forms.DockStyle.Right;
            lblGreen255.Location = new System.Drawing.Point(518, 90);
            lblGreen255.Name = "lblGreen255";
            lblGreen255.Size = new System.Drawing.Size(25, 20);
            lblGreen255.TabIndex = 10;
            lblGreen255.Text = "255";
            // 
            // lblBlue0
            // 
            lblBlue0.AutoSize = true;
            lblBlue0.Location = new System.Drawing.Point(53, 145);
            lblBlue0.Name = "lblBlue0";
            lblBlue0.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            lblBlue0.Size = new System.Drawing.Size(20, 13);
            lblBlue0.TabIndex = 11;
            lblBlue0.Text = "0";
            // 
            // lblBlue255
            // 
            lblBlue255.AutoSize = true;
            lblBlue255.Dock = System.Windows.Forms.DockStyle.Right;
            lblBlue255.Location = new System.Drawing.Point(518, 145);
            lblBlue255.Name = "lblBlue255";
            lblBlue255.Size = new System.Drawing.Size(25, 20);
            lblBlue255.TabIndex = 12;
            lblBlue255.Text = "255";
            // 
            // sliderRed
            // 
            this.sliderRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbloutColorSliders.SetColumnSpan(this.sliderRed, 2);
            this.sliderRed.Location = new System.Drawing.Point(53, 3);
            this.sliderRed.Maximum = 255;
            this.sliderRed.Name = "sliderRed";
            this.sliderRed.Size = new System.Drawing.Size(490, 29);
            this.sliderRed.TabIndex = 1;
            this.sliderRed.TickFrequency = 5;
            this.sliderRed.Value = 125;
            this.sliderRed.ValueChanged += new System.EventHandler(this.OnColorChanged);
            this.sliderRed.MouseCaptureChanged += new System.EventHandler(this.OnColorChangeOver);
            // 
            // pnlColorPreview
            // 
            this.pnlColorPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlColorPreview.Location = new System.Drawing.Point(12, 12);
            this.pnlColorPreview.Name = "pnlColorPreview";
            this.pnlColorPreview.Size = new System.Drawing.Size(150, 303);
            this.pnlColorPreview.TabIndex = 0;
            // 
            // tbloutColorSliders
            // 
            this.tbloutColorSliders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbloutColorSliders.ColumnCount = 3;
            this.tbloutColorSliders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbloutColorSliders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbloutColorSliders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbloutColorSliders.Controls.Add(this.sliderGreen, 1, 2);
            this.tbloutColorSliders.Controls.Add(lblRed255, 2, 1);
            this.tbloutColorSliders.Controls.Add(lblRed, 0, 0);
            this.tbloutColorSliders.Controls.Add(this.sliderRed, 1, 0);
            this.tbloutColorSliders.Controls.Add(lblRed0, 1, 1);
            this.tbloutColorSliders.Controls.Add(lblGreen, 0, 2);
            this.tbloutColorSliders.Controls.Add(this.sliderBlue, 1, 4);
            this.tbloutColorSliders.Controls.Add(lblBlue, 0, 4);
            this.tbloutColorSliders.Controls.Add(lblGreen0, 1, 3);
            this.tbloutColorSliders.Controls.Add(lblGreen255, 2, 3);
            this.tbloutColorSliders.Controls.Add(lblBlue0, 1, 5);
            this.tbloutColorSliders.Controls.Add(lblBlue255, 2, 5);
            this.tbloutColorSliders.Location = new System.Drawing.Point(162, 12);
            this.tbloutColorSliders.Name = "tbloutColorSliders";
            this.tbloutColorSliders.RowCount = 7;
            this.tbloutColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbloutColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbloutColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbloutColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbloutColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tbloutColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbloutColorSliders.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbloutColorSliders.Size = new System.Drawing.Size(546, 303);
            this.tbloutColorSliders.TabIndex = 1;
            // 
            // sliderGreen
            // 
            this.sliderGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbloutColorSliders.SetColumnSpan(this.sliderGreen, 2);
            this.sliderGreen.Location = new System.Drawing.Point(53, 58);
            this.sliderGreen.Maximum = 255;
            this.sliderGreen.Name = "sliderGreen";
            this.sliderGreen.Size = new System.Drawing.Size(490, 29);
            this.sliderGreen.TabIndex = 6;
            this.sliderGreen.TickFrequency = 5;
            this.sliderGreen.Value = 125;
            this.sliderGreen.ValueChanged += new System.EventHandler(this.OnColorChanged);
            this.sliderGreen.MouseCaptureChanged += new System.EventHandler(this.OnColorChangeOver);
            // 
            // sliderBlue
            // 
            this.sliderBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbloutColorSliders.SetColumnSpan(this.sliderBlue, 2);
            this.sliderBlue.Location = new System.Drawing.Point(53, 113);
            this.sliderBlue.Maximum = 255;
            this.sliderBlue.Name = "sliderBlue";
            this.sliderBlue.Size = new System.Drawing.Size(490, 29);
            this.sliderBlue.TabIndex = 7;
            this.sliderBlue.TickFrequency = 5;
            this.sliderBlue.Value = 125;
            this.sliderBlue.ValueChanged += new System.EventHandler(this.OnColorChanged);
            this.sliderBlue.MouseCaptureChanged += new System.EventHandler(this.OnColorChangeOver);
            // 
            // PaletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 327);
            this.Controls.Add(this.tbloutColorSliders);
            this.Controls.Add(this.pnlColorPreview);
            this.MinimumSize = new System.Drawing.Size(467, 227);
            this.Name = "PaletteForm";
            this.Text = "Color Palette";
            ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).EndInit();
            this.tbloutColorSliders.ResumeLayout(false);
            this.tbloutColorSliders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlColorPreview;
        private System.Windows.Forms.TableLayoutPanel tbloutColorSliders;
        private System.Windows.Forms.TrackBar sliderRed;
        private System.Windows.Forms.TrackBar sliderGreen;
        private System.Windows.Forms.TrackBar sliderBlue;
    }
}

