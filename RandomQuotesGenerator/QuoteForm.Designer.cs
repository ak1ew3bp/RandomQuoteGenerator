namespace RandomQuotesGenerator
{
    partial class QuoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuoteForm));
            lblTitle = new Label();
            lblQuote = new Label();
            btnOK = new Button();
            label1 = new Label();
            picShareFB = new PictureBox();
            picShareInsta = new PictureBox();
            picShareX = new PictureBox();
            picCopy = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picShareFB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShareInsta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShareX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCopy).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(-1, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(613, 64);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Motivation Quote Generator";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuote
            // 
            lblQuote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblQuote.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuote.ForeColor = Color.White;
            lblQuote.Location = new Point(12, 82);
            lblQuote.Name = "lblQuote";
            lblQuote.Size = new Size(587, 99);
            lblQuote.TabIndex = 2;
            lblQuote.Text = "Quotes goes here";
            lblQuote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOK.BackColor = Color.Green;
            btnOK.BackgroundImageLayout = ImageLayout.None;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(12, 201);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(587, 33);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(242, 247);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 4;
            label1.Text = "Share with Friends:";
            // 
            // picShareFB
            // 
            picShareFB.Cursor = Cursors.Hand;
            picShareFB.Image = (Image)resources.GetObject("picShareFB.Image");
            picShareFB.Location = new Point(234, 270);
            picShareFB.Name = "picShareFB";
            picShareFB.Size = new Size(28, 28);
            picShareFB.TabIndex = 5;
            picShareFB.TabStop = false;
            // 
            // picShareInsta
            // 
            picShareInsta.Cursor = Cursors.Hand;
            picShareInsta.Image = (Image)resources.GetObject("picShareInsta.Image");
            picShareInsta.Location = new Point(268, 270);
            picShareInsta.Name = "picShareInsta";
            picShareInsta.Size = new Size(28, 28);
            picShareInsta.TabIndex = 6;
            picShareInsta.TabStop = false;
            // 
            // picShareX
            // 
            picShareX.Cursor = Cursors.Hand;
            picShareX.Image = (Image)resources.GetObject("picShareX.Image");
            picShareX.Location = new Point(302, 270);
            picShareX.Name = "picShareX";
            picShareX.Size = new Size(28, 28);
            picShareX.TabIndex = 7;
            picShareX.TabStop = false;
            // 
            // picCopy
            // 
            picCopy.Cursor = Cursors.Hand;
            picCopy.Image = (Image)resources.GetObject("picCopy.Image");
            picCopy.Location = new Point(336, 270);
            picCopy.Name = "picCopy";
            picCopy.Size = new Size(28, 28);
            picCopy.TabIndex = 8;
            picCopy.TabStop = false;
            picCopy.Click += picCopy_Click;
            // 
            // QuoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(611, 310);
            ControlBox = false;
            Controls.Add(picCopy);
            Controls.Add(picShareX);
            Controls.Add(picShareInsta);
            Controls.Add(picShareFB);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Controls.Add(lblQuote);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuoteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Random Quote Generator";
            ((System.ComponentModel.ISupportInitialize)picShareFB).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShareInsta).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShareX).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCopy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQuote;
        private Button btnOK;
        private Label label1;
        private PictureBox picShareFB;
        private PictureBox picShareInsta;
        private PictureBox picShareX;
        private PictureBox picCopy;
    }
}