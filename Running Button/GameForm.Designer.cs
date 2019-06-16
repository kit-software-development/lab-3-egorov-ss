namespace RunningButton
{
    partial class GameForm
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
            this.btn = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.AllowDrop = true;
            this.btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn.Location = new System.Drawing.Point(12, 421);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "Push Me !";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btn);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(677, 465);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.pnlContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseOnForm);
            // 
            // GameForm
            // 
            this.ClientSize = new System.Drawing.Size(677, 465);
            this.Controls.Add(this.pnlContent);
            this.MinimumSize = new System.Drawing.Size(316, 339);
            this.Name = "GameForm";
            this.Text = "Running Button";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Resize += new System.EventHandler(this.OnFormResize);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel pnlContent;
    }
}

