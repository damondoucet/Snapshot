namespace Snapshot
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._noPicturesLabel = new System.Windows.Forms.Label();
            this._previous = new System.Windows.Forms.Button();
            this._next = new System.Windows.Forms.Button();
            this._save = new System.Windows.Forms.Button();
            this._delete = new System.Windows.Forms.Button();
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _pictureBox
            // 
            this._pictureBox.Location = new System.Drawing.Point(12, 12);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(342, 245);
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            this._pictureBox.DoubleClick += new System.EventHandler(this.OnPictureBoxDoubleClick);
            // 
            // _noPicturesLabel
            // 
            this._noPicturesLabel.AutoSize = true;
            this._noPicturesLabel.Location = new System.Drawing.Point(152, 118);
            this._noPicturesLabel.Name = "_noPicturesLabel";
            this._noPicturesLabel.Size = new System.Drawing.Size(62, 13);
            this._noPicturesLabel.TabIndex = 1;
            this._noPicturesLabel.Text = "No Pictures";
            // 
            // _previous
            // 
            this._previous.Location = new System.Drawing.Point(12, 263);
            this._previous.Name = "_previous";
            this._previous.Size = new System.Drawing.Size(22, 23);
            this._previous.TabIndex = 2;
            this._previous.Text = "<";
            this._previous.UseVisualStyleBackColor = true;
            this._previous.Click += new System.EventHandler(this.OnPreviousClick);
            // 
            // _next
            // 
            this._next.Location = new System.Drawing.Point(332, 263);
            this._next.Name = "_next";
            this._next.Size = new System.Drawing.Size(22, 23);
            this._next.TabIndex = 3;
            this._next.Text = ">";
            this._next.UseVisualStyleBackColor = true;
            this._next.Click += new System.EventHandler(this.OnNextClick);
            // 
            // _save
            // 
            this._save.Location = new System.Drawing.Point(117, 263);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(56, 23);
            this._save.TabIndex = 4;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = true;
            this._save.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // _delete
            // 
            this._delete.Location = new System.Drawing.Point(193, 263);
            this._delete.Name = "_delete";
            this._delete.Size = new System.Drawing.Size(56, 23);
            this._delete.TabIndex = 5;
            this._delete.Text = "Delete";
            this._delete.UseVisualStyleBackColor = true;
            this._delete.Click += new System.EventHandler(this.OnDeleteClick);
            // 
            // _notifyIcon
            // 
            this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
            this._notifyIcon.Text = "Snapshot";
            this._notifyIcon.Visible = true;
            this._notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnNotifyIconDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 296);
            this.Controls.Add(this._delete);
            this.Controls.Add(this._save);
            this.Controls.Add(this._next);
            this.Controls.Add(this._previous);
            this.Controls.Add(this._noPicturesLabel);
            this.Controls.Add(this._pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Snapshot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Resize += new System.EventHandler(this.OnResize);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Label _noPicturesLabel;
        private System.Windows.Forms.Button _previous;
        private System.Windows.Forms.Button _next;
        private System.Windows.Forms.Button _save;
        private System.Windows.Forms.Button _delete;
        private System.Windows.Forms.NotifyIcon _notifyIcon;
    }
}

