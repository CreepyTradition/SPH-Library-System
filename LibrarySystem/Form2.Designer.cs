namespace LibrarySystem
{
    partial class borrowBooks
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
            this.menuButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.borrowLabel = new System.Windows.Forms.Label();
            this.borrowBox = new System.Windows.Forms.TextBox();
            this.bookGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(634, 369);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(125, 44);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(44, 369);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(125, 44);
            this.borrowButton.TabIndex = 2;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(351, 369);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(125, 44);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(2, 329);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 18);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title:";
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(44, 329);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(206, 24);
            this.titleBox.TabIndex = 5;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(256, 329);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(55, 18);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Author:";
            // 
            // authorBox
            // 
            this.authorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorBox.Location = new System.Drawing.Point(317, 329);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(206, 24);
            this.authorBox.TabIndex = 7;
            // 
            // borrowLabel
            // 
            this.borrowLabel.AutoSize = true;
            this.borrowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowLabel.Location = new System.Drawing.Point(529, 329);
            this.borrowLabel.Name = "borrowLabel";
            this.borrowLabel.Size = new System.Drawing.Size(74, 18);
            this.borrowLabel.TabIndex = 8;
            this.borrowLabel.Text = "Borrower:";
            // 
            // borrowBox
            // 
            this.borrowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBox.Location = new System.Drawing.Point(609, 329);
            this.borrowBox.Name = "borrowBox";
            this.borrowBox.Size = new System.Drawing.Size(189, 24);
            this.borrowBox.TabIndex = 9;
            // 
            // bookGrid
            // 
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Location = new System.Drawing.Point(33, 13);
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.ReadOnly = true;
            this.bookGrid.Size = new System.Drawing.Size(742, 310);
            this.bookGrid.TabIndex = 10;
            this.bookGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookGrid_CellContentClick);
            // 
            // borrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.grand_library_with_endless_shelves_panoramic_background_generative_ai_918839_3742;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookGrid);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.borrowBox);
            this.Controls.Add(this.borrowLabel);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.borrowButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "borrowBooks";
            this.Text = "Borrow Books";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label borrowLabel;
        private System.Windows.Forms.TextBox borrowBox;
        private System.Windows.Forms.DataGridView bookGrid;
    }
}