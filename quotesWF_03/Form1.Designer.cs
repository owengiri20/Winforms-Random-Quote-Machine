namespace quotesWF_03
{
    partial class Form1
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
            this.quoteContentTxt = new System.Windows.Forms.TextBox();
            this.genarateButton = new System.Windows.Forms.Button();
            this.quoteAuthorTxt = new System.Windows.Forms.TextBox();
            this.pageTitle = new System.Windows.Forms.Label();
            this.quoteToAddTxt = new System.Windows.Forms.TextBox();
            this.addNewQuoteButton = new System.Windows.Forms.Button();
            this.quoteAuthorToAddTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNewQuotePageButton = new System.Windows.Forms.Button();
            this.backToQuotesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quoteContentTxt
            // 
            this.quoteContentTxt.BackColor = System.Drawing.Color.White;
            this.quoteContentTxt.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteContentTxt.Location = new System.Drawing.Point(92, 104);
            this.quoteContentTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quoteContentTxt.Multiline = true;
            this.quoteContentTxt.Name = "quoteContentTxt";
            this.quoteContentTxt.Size = new System.Drawing.Size(384, 124);
            this.quoteContentTxt.TabIndex = 0;
            // 
            // genarateButton
            // 
            this.genarateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.genarateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genarateButton.ForeColor = System.Drawing.Color.White;
            this.genarateButton.Location = new System.Drawing.Point(92, 289);
            this.genarateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genarateButton.Name = "genarateButton";
            this.genarateButton.Size = new System.Drawing.Size(384, 28);
            this.genarateButton.TabIndex = 1;
            this.genarateButton.Text = "genarateButton";
            this.genarateButton.UseVisualStyleBackColor = false;
            this.genarateButton.Click += new System.EventHandler(this.genarateButton_Click);
            // 
            // quoteAuthorTxt
            // 
            this.quoteAuthorTxt.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteAuthorTxt.Location = new System.Drawing.Point(92, 236);
            this.quoteAuthorTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quoteAuthorTxt.Multiline = true;
            this.quoteAuthorTxt.Name = "quoteAuthorTxt";
            this.quoteAuthorTxt.Size = new System.Drawing.Size(384, 45);
            this.quoteAuthorTxt.TabIndex = 2;
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.Color.White;
            this.pageTitle.Location = new System.Drawing.Point(39, 21);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(295, 38);
            this.pageTitle.TabIndex = 3;
            this.pageTitle.Text = "PROTOTYPE Quote Gen";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quoteToAddTxt
            // 
            this.quoteToAddTxt.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteToAddTxt.Location = new System.Drawing.Point(92, 104);
            this.quoteToAddTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quoteToAddTxt.Multiline = true;
            this.quoteToAddTxt.Name = "quoteToAddTxt";
            this.quoteToAddTxt.Size = new System.Drawing.Size(384, 124);
            this.quoteToAddTxt.TabIndex = 4;
            this.quoteToAddTxt.Text = "add new quote here...";
            // 
            // addNewQuoteButton
            // 
            this.addNewQuoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.addNewQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewQuoteButton.ForeColor = System.Drawing.Color.White;
            this.addNewQuoteButton.Location = new System.Drawing.Point(92, 289);
            this.addNewQuoteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNewQuoteButton.Name = "addNewQuoteButton";
            this.addNewQuoteButton.Size = new System.Drawing.Size(384, 28);
            this.addNewQuoteButton.TabIndex = 5;
            this.addNewQuoteButton.Text = "addNewQuoteButton";
            this.addNewQuoteButton.UseVisualStyleBackColor = false;
            this.addNewQuoteButton.Click += new System.EventHandler(this.addNewQuoteButton_Click);
            // 
            // quoteAuthorToAddTxt
            // 
            this.quoteAuthorToAddTxt.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteAuthorToAddTxt.Location = new System.Drawing.Point(92, 236);
            this.quoteAuthorToAddTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quoteAuthorToAddTxt.Multiline = true;
            this.quoteAuthorToAddTxt.Name = "quoteAuthorToAddTxt";
            this.quoteAuthorToAddTxt.Size = new System.Drawing.Size(384, 45);
            this.quoteAuthorToAddTxt.TabIndex = 6;
            this.quoteAuthorToAddTxt.Text = "add author name here...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.pageTitle);
            this.panel1.Location = new System.Drawing.Point(92, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 82);
            this.panel1.TabIndex = 7;
            // 
            // addNewQuotePageButton
            // 
            this.addNewQuotePageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.addNewQuotePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewQuotePageButton.ForeColor = System.Drawing.Color.White;
            this.addNewQuotePageButton.Location = new System.Drawing.Point(92, 325);
            this.addNewQuotePageButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewQuotePageButton.Name = "addNewQuotePageButton";
            this.addNewQuotePageButton.Size = new System.Drawing.Size(384, 28);
            this.addNewQuotePageButton.TabIndex = 8;
            this.addNewQuotePageButton.Text = "add new quote";
            this.addNewQuotePageButton.UseVisualStyleBackColor = false;
            this.addNewQuotePageButton.Click += new System.EventHandler(this.addNewQuotePageButton_Click);
            // 
            // backToQuotesButton
            // 
            this.backToQuotesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.backToQuotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToQuotesButton.ForeColor = System.Drawing.Color.White;
            this.backToQuotesButton.Location = new System.Drawing.Point(92, 325);
            this.backToQuotesButton.Margin = new System.Windows.Forms.Padding(4);
            this.backToQuotesButton.Name = "backToQuotesButton";
            this.backToQuotesButton.Size = new System.Drawing.Size(384, 28);
            this.backToQuotesButton.TabIndex = 9;
            this.backToQuotesButton.Text = "back To Quotes";
            this.backToQuotesButton.UseVisualStyleBackColor = false;
            this.backToQuotesButton.Click += new System.EventHandler(this.backToQuotesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 568);
            this.Controls.Add(this.backToQuotesButton);
            this.Controls.Add(this.addNewQuotePageButton);
            this.Controls.Add(this.quoteAuthorToAddTxt);
            this.Controls.Add(this.addNewQuoteButton);
            this.Controls.Add(this.quoteToAddTxt);
            this.Controls.Add(this.quoteAuthorTxt);
            this.Controls.Add(this.genarateButton);
            this.Controls.Add(this.quoteContentTxt);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Random Quote Machine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quoteContentTxt;
        private System.Windows.Forms.Button genarateButton;
        private System.Windows.Forms.TextBox quoteAuthorTxt;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.TextBox quoteToAddTxt;
        private System.Windows.Forms.Button addNewQuoteButton;
        private System.Windows.Forms.TextBox quoteAuthorToAddTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addNewQuotePageButton;
        private System.Windows.Forms.Button backToQuotesButton;
    }
}

