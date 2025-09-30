namespace RandomQuotesGenerator
{
    partial class Main
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
            Label lbl1;
            Label lbl2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lblTitle = new Label();
            btnGenerate = new Button();
            github = new PictureBox();
            picLoading = new PictureBox();
            lbl1 = new Label();
            lbl2 = new Label();
            ((System.ComponentModel.ISupportInitialize)github).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(14, 123);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(361, 33);
            lbl1.TabIndex = 1;
            lbl1.Text = "Looking for inspiration?\n";
            lbl1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(14, 176);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(361, 33);
            lbl2.TabIndex = 2;
            lbl2.Text = "Generate a quote now!";
            lbl2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(-5, -2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 86);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Motivation Quote Generator";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Green;
            btnGenerate.BackgroundImageLayout = ImageLayout.None;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(133, 249);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(118, 44);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // github
            // 
            github.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            github.BackgroundImageLayout = ImageLayout.None;
            github.Cursor = Cursors.Hand;
            github.ErrorImage = (Image)resources.GetObject("github.ErrorImage");
            github.Image = (Image)resources.GetObject("github.Image");
            github.InitialImage = (Image)resources.GetObject("github.InitialImage");
            github.Location = new Point(352, 347);
            github.Name = "github";
            github.Size = new Size(31, 33);
            github.TabIndex = 4;
            github.TabStop = false;
            github.Click += github_Click;
            // 
            // picLoading
            // 
            picLoading.BackgroundImageLayout = ImageLayout.None;
            picLoading.ErrorImage = (Image)resources.GetObject("picLoading.ErrorImage");
            picLoading.Image = (Image)resources.GetObject("picLoading.Image");
            picLoading.InitialImage = (Image)resources.GetObject("picLoading.InitialImage");
            picLoading.Location = new Point(141, 123);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(101, 102);
            picLoading.TabIndex = 5;
            picLoading.TabStop = false;
            picLoading.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(387, 383);
            Controls.Add(picLoading);
            Controls.Add(github);
            Controls.Add(btnGenerate);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblTitle);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Motivation Quote Genrator";
            ((System.ComponentModel.ISupportInitialize)github).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnGenerate;
        private PictureBox github;
        private PictureBox picLoading;
    }
}
