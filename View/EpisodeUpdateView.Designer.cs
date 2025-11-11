namespace MVC_Update.View
{
    partial class EpisodeUpdateView
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
            label1 = new Label();
            label2 = new Label();
            tbTitle = new TextBox();
            label3 = new Label();
            tbAuthor = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            dtpDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 43);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 0;
            label1.Text = "Aflevering bijwerken";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(42, 124);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Titel";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(42, 147);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(357, 27);
            tbTitle.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(42, 201);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Datum";
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(42, 310);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(357, 27);
            tbAuthor.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(42, 287);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 5;
            label4.Text = "Auteur (ID)";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(42, 373);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(357, 47);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "BIJWERKEN";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(42, 233);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(357, 27);
            dtpDate.TabIndex = 2;
            // 
            // EpisodeUpdateView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(456, 450);
            Controls.Add(dtpDate);
            Controls.Add(btnUpdate);
            Controls.Add(tbAuthor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EpisodeUpdateView";
            Text = "EpisodeUpdateView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbTitle;
        private Label label3;
        private TextBox tbAuthor;
        private Label label4;
        private Button btnUpdate;
        private DateTimePicker dtpDate;
    }
}