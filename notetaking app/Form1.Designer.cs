namespace NoteTaking_App
{
    partial class NoteTaker
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
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.Notebox = new System.Windows.Forms.TextBox();
            this.title_ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PreviousNotes = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(714, 56);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(569, 31);
            this.TitleBox.TabIndex = 0;
            // 
            // Notebox
            // 
            this.Notebox.Location = new System.Drawing.Point(714, 126);
            this.Notebox.Multiline = true;
            this.Notebox.Name = "Notebox";
            this.Notebox.Size = new System.Drawing.Size(569, 559);
            this.Notebox.TabIndex = 1;
            // 
            // title_
            // 
            this.title_.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title_.Location = new System.Drawing.Point(714, 15);
            this.title_.Name = "title_";
            this.title_.Size = new System.Drawing.Size(569, 38);
            this.title_.TabIndex = 2;
            this.title_.Text = "Title:";
            this.title_.Click += new System.EventHandler(this.title__Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(714, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note:";
            // 
            // PreviousNotes
            // 
            this.PreviousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreviousNotes.Location = new System.Drawing.Point(0, 0);
            this.PreviousNotes.Name = "PreviousNotes";
            this.PreviousNotes.RowHeadersWidth = 62;
            this.PreviousNotes.RowTemplate.Height = 33;
            this.PreviousNotes.Size = new System.Drawing.Size(708, 494);
            this.PreviousNotes.TabIndex = 4;
            this.PreviousNotes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PreviousNotes_MouseDoubleClick);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.White;
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadButton.Location = new System.Drawing.Point(0, 500);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(341, 53);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(347, 500);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(361, 53);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.BackColor = System.Drawing.Color.White;
            this.NewNoteButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewNoteButton.Location = new System.Drawing.Point(0, 570);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(341, 50);
            this.NewNoteButton.TabIndex = 7;
            this.NewNoteButton.Text = "NewNote";
            this.NewNoteButton.UseVisualStyleBackColor = false;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(347, 570);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(361, 53);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1283, 697);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewNoteButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.PreviousNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_);
            this.Controls.Add(this.Notebox);
            this.Controls.Add(this.TitleBox);
            this.Name = "NoteTaker";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TitleBox;
        private TextBox Notebox;
        private Label title_;
        private Label label1;
        private DataGridView PreviousNotes;
        private Button LoadButton;
        private Button DeleteButton;
        private Button NewNoteButton;
        private Button SaveButton;
    }
}