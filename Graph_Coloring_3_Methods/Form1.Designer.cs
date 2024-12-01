namespace Graph_Coloring_3_Methods
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addVertexButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.deleteVertexButon = new System.Windows.Forms.Button();
            this.deleteEdgeButton = new System.Windows.Forms.Button();
            this.MoveVertexButton = new System.Windows.Forms.Button();
            this.colorGraphButton = new System.Windows.Forms.Button();
            this.ifSlowModeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(169, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 401);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // addVertexButton
            // 
            this.addVertexButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addVertexButton.BackgroundImage")));
            this.addVertexButton.Location = new System.Drawing.Point(27, 62);
            this.addVertexButton.Name = "addVertexButton";
            this.addVertexButton.Size = new System.Drawing.Size(64, 64);
            this.addVertexButton.TabIndex = 1;
            this.addVertexButton.UseVisualStyleBackColor = true;
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEdgeButton.BackgroundImage")));
            this.addEdgeButton.Location = new System.Drawing.Point(27, 148);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(64, 68);
            this.addEdgeButton.TabIndex = 2;
            this.addEdgeButton.UseVisualStyleBackColor = true;
            // 
            // deleteVertexButon
            // 
            this.deleteVertexButon.Location = new System.Drawing.Point(15, 332);
            this.deleteVertexButon.Name = "deleteVertexButon";
            this.deleteVertexButon.Size = new System.Drawing.Size(75, 23);
            this.deleteVertexButon.TabIndex = 3;
            this.deleteVertexButon.Text = "button1";
            this.deleteVertexButon.UseVisualStyleBackColor = true;
            // 
            // deleteEdgeButton
            // 
            this.deleteEdgeButton.Location = new System.Drawing.Point(15, 438);
            this.deleteEdgeButton.Name = "deleteEdgeButton";
            this.deleteEdgeButton.Size = new System.Drawing.Size(101, 36);
            this.deleteEdgeButton.TabIndex = 4;
            this.deleteEdgeButton.Text = "button1";
            this.deleteEdgeButton.UseVisualStyleBackColor = true;
            // 
            // MoveVertexButton
            // 
            this.MoveVertexButton.Location = new System.Drawing.Point(883, 187);
            this.MoveVertexButton.Name = "MoveVertexButton";
            this.MoveVertexButton.Size = new System.Drawing.Size(75, 23);
            this.MoveVertexButton.TabIndex = 5;
            this.MoveVertexButton.Text = "button1";
            this.MoveVertexButton.UseVisualStyleBackColor = true;
            // 
            // colorGraphButton
            // 
            this.colorGraphButton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorGraphButton.Location = new System.Drawing.Point(807, 419);
            this.colorGraphButton.Name = "colorGraphButton";
            this.colorGraphButton.Size = new System.Drawing.Size(270, 90);
            this.colorGraphButton.TabIndex = 6;
            this.colorGraphButton.Text = "РАСКРАСЕЕЕТЬ";
            this.colorGraphButton.UseVisualStyleBackColor = true;
            this.colorGraphButton.Leave += new System.EventHandler(this.colorGraphButton_Leave);
            this.colorGraphButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorGraphButton_MouseClick);
            // 
            // ifSlowModeCheckBox
            // 
            this.ifSlowModeCheckBox.AutoSize = true;
            this.ifSlowModeCheckBox.Location = new System.Drawing.Point(851, 348);
            this.ifSlowModeCheckBox.Name = "ifSlowModeCheckBox";
            this.ifSlowModeCheckBox.Size = new System.Drawing.Size(75, 17);
            this.ifSlowModeCheckBox.TabIndex = 7;
            this.ifSlowModeCheckBox.Text = "Поэтапно";
            this.ifSlowModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 597);
            this.Controls.Add(this.ifSlowModeCheckBox);
            this.Controls.Add(this.colorGraphButton);
            this.Controls.Add(this.MoveVertexButton);
            this.Controls.Add(this.deleteEdgeButton);
            this.Controls.Add(this.deleteVertexButon);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.addVertexButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addVertexButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button deleteVertexButon;
        private System.Windows.Forms.Button deleteEdgeButton;
        private System.Windows.Forms.Button MoveVertexButton;
        private System.Windows.Forms.Button colorGraphButton;
        private System.Windows.Forms.CheckBox ifSlowModeCheckBox;
    }
}

