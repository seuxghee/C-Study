namespace DogCare
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.prsBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrLife = new System.Windows.Forms.Timer(this.components);
            this.tboxName = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(77, 41);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(190, 69);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "놀아주기";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(77, 116);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(190, 69);
            this.btnFeed.TabIndex = 0;
            this.btnFeed.Text = "먹이주기";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // prsBar
            // 
            this.prsBar.Location = new System.Drawing.Point(341, 53);
            this.prsBar.Name = "prsBar";
            this.prsBar.Size = new System.Drawing.Size(478, 20);
            this.prsBar.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("굴림", 11F);
            this.lblStatus.Location = new System.Drawing.Point(338, 102);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "상태메세지";
            // 
            // tmrLife
            // 
            this.tmrLife.Tick += new System.EventHandler(this.tmrLife_Tick);
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(341, 15);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(100, 21);
            this.tboxName.TabIndex = 3;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(474, 13);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(104, 23);
            this.btnstart.TabIndex = 4;
            this.btnstart.Text = "게임시작";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 668);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.prsBar);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.ProgressBar prsBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrLife;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Button btnstart;
    }
}

