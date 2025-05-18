namespace HelloWorld.WinForms
{
    partial class MainWindow
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
            Banner = new Label();
            SuspendLayout();
            // 
            // Banner
            // 
            Banner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Banner.AutoSize = true;
            Banner.Font = new Font("Segoe UI", 13F);
            Banner.Location = new Point(307, 190);
            Banner.Name = "Banner";
            Banner.Size = new Size(153, 30);
            Banner.TabIndex = 0;
            Banner.Text = "Message Here";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Banner);
            Name = "MainWindow";
            Text = "Hello, World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Banner;
    }
}
