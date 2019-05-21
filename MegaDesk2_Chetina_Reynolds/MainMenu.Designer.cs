namespace MegaDesk_Chetina
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonViewQuotes = new System.Windows.Forms.Button();
            this.buttonSearchQuotes = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(58, 43);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(197, 54);
            this.buttonAddNew.TabIndex = 0;
            this.buttonAddNew.Text = "Add New Quote";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonViewQuotes
            // 
            this.buttonViewQuotes.Location = new System.Drawing.Point(58, 122);
            this.buttonViewQuotes.Name = "buttonViewQuotes";
            this.buttonViewQuotes.Size = new System.Drawing.Size(197, 61);
            this.buttonViewQuotes.TabIndex = 1;
            this.buttonViewQuotes.Text = "View Quotes";
            this.buttonViewQuotes.UseVisualStyleBackColor = true;
            this.buttonViewQuotes.Click += new System.EventHandler(this.ButtonViewQuotes_Click);
            // 
            // buttonSearchQuotes
            // 
            this.buttonSearchQuotes.Location = new System.Drawing.Point(58, 214);
            this.buttonSearchQuotes.Name = "buttonSearchQuotes";
            this.buttonSearchQuotes.Size = new System.Drawing.Size(197, 59);
            this.buttonSearchQuotes.TabIndex = 2;
            this.buttonSearchQuotes.Text = "Search Quotes";
            this.buttonSearchQuotes.UseVisualStyleBackColor = true;
            this.buttonSearchQuotes.Click += new System.EventHandler(this.ButtonSearchQuotes_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(58, 298);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(197, 59);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearchQuotes);
            this.Controls.Add(this.buttonViewQuotes);
            this.Controls.Add(this.buttonAddNew);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonViewQuotes;
        private System.Windows.Forms.Button buttonSearchQuotes;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

