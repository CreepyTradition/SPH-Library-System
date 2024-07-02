namespace LibrarySystem
{
    partial class LibrarySystem
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
            this.borrowButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borrowButton
            // 
            this.borrowButton.AutoSize = true;
            this.borrowButton.Location = new System.Drawing.Point(96, 194);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(239, 76);
            this.borrowButton.TabIndex = 0;
            this.borrowButton.Text = "Borrow Book";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.AutoSize = true;
            this.manageButton.Location = new System.Drawing.Point(484, 194);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(239, 76);
            this.manageButton.TabIndex = 1;
            this.manageButton.Text = "Manage Books";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // LibrarySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.grand_library_with_endless_shelves_panoramic_background_generative_ai_918839_3742;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.borrowButton);
            this.Name = "LibrarySystem";
            this.Text = "SPH Pedia Department Library System";
            this.Load += new System.EventHandler(this.LibrarySystem_Load);
            this.Resize += new System.EventHandler(this.LibrarySystem_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button manageButton;
    }
}

