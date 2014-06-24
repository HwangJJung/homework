namespace TreeViewer
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
            this.same_error_label = new System.Windows.Forms.Label();
            this.no_exist_error_label = new System.Windows.Forms.Label();
            this.Long_Animate_Timer = new System.Windows.Forms.Timer(this.components);
            this.btn_add_clicked = new System.Windows.Forms.PictureBox();
            this.btn_add_hover = new System.Windows.Forms.PictureBox();
            this.btn_add_normal = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_del_normal = new System.Windows.Forms.PictureBox();
            this.btn_del_clicked = new System.Windows.Forms.PictureBox();
            this.btn_del_hover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_clicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_hover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_del_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_del_clicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_del_hover)).BeginInit();
            this.SuspendLayout();
            // 
            // same_error_label
            // 
            this.same_error_label.AutoSize = true;
            this.same_error_label.ForeColor = System.Drawing.Color.Red;
            this.same_error_label.Location = new System.Drawing.Point(17, 615);
            this.same_error_label.Name = "same_error_label";
            this.same_error_label.Size = new System.Drawing.Size(169, 12);
            this.same_error_label.TabIndex = 7;
            this.same_error_label.Text = "같은 값의 노드가 이미 있다냥.";
            this.same_error_label.Visible = false;
            this.same_error_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // no_exist_error_label
            // 
            this.no_exist_error_label.AutoSize = true;
            this.no_exist_error_label.ForeColor = System.Drawing.Color.Red;
            this.no_exist_error_label.Location = new System.Drawing.Point(17, 615);
            this.no_exist_error_label.Name = "no_exist_error_label";
            this.no_exist_error_label.Size = new System.Drawing.Size(141, 12);
            this.no_exist_error_label.TabIndex = 8;
            this.no_exist_error_label.Text = "그런 노드는 아직 없다냥.";
            this.no_exist_error_label.Visible = false;
            // 
            // Long_Animate_Timer
            // 
            this.Long_Animate_Timer.Enabled = true;
            this.Long_Animate_Timer.Tick += new System.EventHandler(this.Long_Animate_Timer_Tick);
            // 
            // btn_add_clicked
            // 
            this.btn_add_clicked.Enabled = false;
            this.btn_add_clicked.Image = global::TreeViewer.Properties.Resources.btn_add_clicked;
            this.btn_add_clicked.Location = new System.Drawing.Point(128, 626);
            this.btn_add_clicked.Name = "btn_add_clicked";
            this.btn_add_clicked.Size = new System.Drawing.Size(143, 59);
            this.btn_add_clicked.TabIndex = 2;
            this.btn_add_clicked.TabStop = false;
            this.btn_add_clicked.Visible = false;
            // 
            // btn_add_hover
            // 
            this.btn_add_hover.Enabled = false;
            this.btn_add_hover.Image = global::TreeViewer.Properties.Resources.btn_add_hover;
            this.btn_add_hover.Location = new System.Drawing.Point(133, 626);
            this.btn_add_hover.Name = "btn_add_hover";
            this.btn_add_hover.Size = new System.Drawing.Size(143, 59);
            this.btn_add_hover.TabIndex = 1;
            this.btn_add_hover.TabStop = false;
            this.btn_add_hover.Visible = false;
            // 
            // btn_add_normal
            // 
            this.btn_add_normal.Image = global::TreeViewer.Properties.Resources.btn_add_normal;
            this.btn_add_normal.Location = new System.Drawing.Point(133, 626);
            this.btn_add_normal.Name = "btn_add_normal";
            this.btn_add_normal.Size = new System.Drawing.Size(143, 59);
            this.btn_add_normal.TabIndex = 0;
            this.btn_add_normal.TabStop = false;
            this.btn_add_normal.Click += new System.EventHandler(this.btn_add_normal_Click);
            this.btn_add_normal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_add_normal_MouseDown);
            this.btn_add_normal.MouseEnter += new System.EventHandler(this.btn_add_normal_MouseEnter);
            this.btn_add_normal.MouseLeave += new System.EventHandler(this.btn_add_normal_MouseLeave);
            this.btn_add_normal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_add_normal_MouseUp);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown1.Location = new System.Drawing.Point(12, 638);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 38);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_add_normal_Click);
            // 
            // btn_del_normal
            // 
            this.btn_del_normal.Image = global::TreeViewer.Properties.Resources.btn_del_normal;
            this.btn_del_normal.Location = new System.Drawing.Point(281, 629);
            this.btn_del_normal.Name = "btn_del_normal";
            this.btn_del_normal.Size = new System.Drawing.Size(140, 61);
            this.btn_del_normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_del_normal.TabIndex = 11;
            this.btn_del_normal.TabStop = false;
            this.btn_del_normal.Click += new System.EventHandler(this.btn_del_normal_Click);
            this.btn_del_normal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_del_normal_MouseDown);
            this.btn_del_normal.MouseEnter += new System.EventHandler(this.btn_del_normal_MouseEnter);
            this.btn_del_normal.MouseLeave += new System.EventHandler(this.btn_del_normal_MouseLeave);
            this.btn_del_normal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_del_normal_MouseUp);
            // 
            // btn_del_clicked
            // 
            this.btn_del_clicked.Enabled = false;
            this.btn_del_clicked.Image = global::TreeViewer.Properties.Resources.btn_del_clicked;
            this.btn_del_clicked.Location = new System.Drawing.Point(275, 629);
            this.btn_del_clicked.Name = "btn_del_clicked";
            this.btn_del_clicked.Size = new System.Drawing.Size(146, 61);
            this.btn_del_clicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_del_clicked.TabIndex = 12;
            this.btn_del_clicked.TabStop = false;
            this.btn_del_clicked.Visible = false;
            // 
            // btn_del_hover
            // 
            this.btn_del_hover.Enabled = false;
            this.btn_del_hover.Image = global::TreeViewer.Properties.Resources.btn_del_hover;
            this.btn_del_hover.Location = new System.Drawing.Point(282, 629);
            this.btn_del_hover.Name = "btn_del_hover";
            this.btn_del_hover.Size = new System.Drawing.Size(138, 61);
            this.btn_del_hover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_del_hover.TabIndex = 13;
            this.btn_del_hover.TabStop = false;
            this.btn_del_hover.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 694);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.no_exist_error_label);
            this.Controls.Add(this.same_error_label);
            this.Controls.Add(this.btn_add_clicked);
            this.Controls.Add(this.btn_add_hover);
            this.Controls.Add(this.btn_add_normal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_del_clicked);
            this.Controls.Add(this.btn_del_hover);
            this.Controls.Add(this.btn_del_normal);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TreeViewer";
            this.Load += new System.EventHandler(this.TreeViewer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_clicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_hover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_del_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_del_clicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_del_hover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
        #endregion

        private System.Windows.Forms.PictureBox btn_add_normal;
        private System.Windows.Forms.PictureBox btn_add_hover;
        private System.Windows.Forms.PictureBox btn_add_clicked;
        private System.Windows.Forms.Label same_error_label;
        private System.Windows.Forms.Label no_exist_error_label;
        private System.Windows.Forms.Timer Long_Animate_Timer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btn_del_normal;
        private System.Windows.Forms.PictureBox btn_del_clicked;
        private System.Windows.Forms.PictureBox btn_del_hover;
    }
   
}

