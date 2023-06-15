namespace Practic_1_3
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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Filename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.bt_addSong = new System.Windows.Forms.Button();
            this.tb_Author = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_GoToStart = new System.Windows.Forms.Button();
            this.bt_ClearPlaylist = new System.Windows.Forms.Button();
            this.bt_removeSong = new System.Windows.Forms.Button();
            this.tb_index = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_GoToIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Путь до файла";
            // 
            // tb_Filename
            // 
            this.tb_Filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Filename.Location = new System.Drawing.Point(22, 174);
            this.tb_Filename.Name = "tb_Filename";
            this.tb_Filename.Size = new System.Drawing.Size(189, 29);
            this.tb_Filename.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Автор";
            // 
            // tb_Title
            // 
            this.tb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Title.Location = new System.Drawing.Point(21, 118);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(189, 29);
            this.tb_Title.TabIndex = 17;
            // 
            // bt_addSong
            // 
            this.bt_addSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_addSong.Location = new System.Drawing.Point(22, 209);
            this.bt_addSong.Name = "bt_addSong";
            this.bt_addSong.Size = new System.Drawing.Size(189, 41);
            this.bt_addSong.TabIndex = 16;
            this.bt_addSong.Text = "Добавить";
            this.bt_addSong.UseVisualStyleBackColor = true;
            this.bt_addSong.Click += new System.EventHandler(this.bt_addSong_Click);
            // 
            // tb_Author
            // 
            this.tb_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Author.Location = new System.Drawing.Point(22, 57);
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.Size = new System.Drawing.Size(188, 29);
            this.tb_Author.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(251, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Текущая песня:";
            this.label9.UseWaitCursor = true;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenameLabel.Location = new System.Drawing.Point(258, 126);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(0, 20);
            this.filenameLabel.TabIndex = 31;
            this.filenameLabel.UseWaitCursor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(258, 92);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 20);
            this.titleLabel.TabIndex = 30;
            this.titleLabel.UseWaitCursor = true;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(258, 57);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(0, 20);
            this.authorLabel.TabIndex = 29;
            this.authorLabel.UseWaitCursor = true;
            // 
            // bt_next
            // 
            this.bt_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_next.Location = new System.Drawing.Point(338, 163);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(102, 29);
            this.bt_next.TabIndex = 33;
            this.bt_next.Text = "Далее";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.UseWaitCursor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click_1);
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_back.Location = new System.Drawing.Point(249, 163);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(83, 29);
            this.bt_back.TabIndex = 34;
            this.bt_back.Text = "Назад";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.UseWaitCursor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_GoToStart
            // 
            this.bt_GoToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_GoToStart.Location = new System.Drawing.Point(22, 256);
            this.bt_GoToStart.Name = "bt_GoToStart";
            this.bt_GoToStart.Size = new System.Drawing.Size(189, 41);
            this.bt_GoToStart.TabIndex = 35;
            this.bt_GoToStart.Text = "Перейти к началу";
            this.bt_GoToStart.UseVisualStyleBackColor = true;
            this.bt_GoToStart.Click += new System.EventHandler(this.bt_GoToStart_Click);
            // 
            // bt_ClearPlaylist
            // 
            this.bt_ClearPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_ClearPlaylist.Location = new System.Drawing.Point(22, 303);
            this.bt_ClearPlaylist.Name = "bt_ClearPlaylist";
            this.bt_ClearPlaylist.Size = new System.Drawing.Size(189, 58);
            this.bt_ClearPlaylist.TabIndex = 36;
            this.bt_ClearPlaylist.Text = "Очистить плейлист";
            this.bt_ClearPlaylist.UseVisualStyleBackColor = true;
            this.bt_ClearPlaylist.Click += new System.EventHandler(this.bt_ClearPlaylist_Click);
            // 
            // bt_removeSong
            // 
            this.bt_removeSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_removeSong.Location = new System.Drawing.Point(251, 257);
            this.bt_removeSong.Name = "bt_removeSong";
            this.bt_removeSong.Size = new System.Drawing.Size(189, 40);
            this.bt_removeSong.TabIndex = 40;
            this.bt_removeSong.Text = "Удалить песню";
            this.bt_removeSong.UseVisualStyleBackColor = true;
            this.bt_removeSong.UseWaitCursor = true;
            this.bt_removeSong.Click += new System.EventHandler(this.bt_removeSong_Click);
            // 
            // tb_index
            // 
            this.tb_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_index.Location = new System.Drawing.Point(326, 315);
            this.tb_index.Name = "tb_index";
            this.tb_index.Size = new System.Drawing.Size(114, 29);
            this.tb_index.TabIndex = 39;
            this.tb_index.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(251, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Индекс:";
            this.label8.UseWaitCursor = true;
            // 
            // bt_GoToIndex
            // 
            this.bt_GoToIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_GoToIndex.Location = new System.Drawing.Point(251, 210);
            this.bt_GoToIndex.Name = "bt_GoToIndex";
            this.bt_GoToIndex.Size = new System.Drawing.Size(189, 41);
            this.bt_GoToIndex.TabIndex = 37;
            this.bt_GoToIndex.Text = "Перейти по индексу";
            this.bt_GoToIndex.UseVisualStyleBackColor = true;
            this.bt_GoToIndex.UseWaitCursor = true;
            this.bt_GoToIndex.Click += new System.EventHandler(this.bt_GoToIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 426);
            this.Controls.Add(this.bt_removeSong);
            this.Controls.Add(this.tb_index);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_GoToIndex);
            this.Controls.Add(this.bt_ClearPlaylist);
            this.Controls.Add(this.bt_GoToStart);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Filename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.bt_addSong);
            this.Controls.Add(this.tb_Author);
            this.Name = "Form1";
            this.Text = "Музыка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bt_removeSong;
        private System.Windows.Forms.TextBox tb_index;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_GoToIndex;

        private System.Windows.Forms.Button bt_ClearPlaylist;

        private System.Windows.Forms.Button bt_GoToStart;

        private System.Windows.Forms.Button bt_back;

        private System.Windows.Forms.Button bt_next;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Filename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Button bt_addSong;
        private System.Windows.Forms.TextBox tb_Author;

        #endregion
    }
}