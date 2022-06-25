namespace FishData
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
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblMinTime = new System.Windows.Forms.Label();
            this.lblMinT = new System.Windows.Forms.Label();
            this.lblMaxTime = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblMaxT = new System.Windows.Forms.Label();
            this.lblFish = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtMinT = new System.Windows.Forms.TextBox();
            this.txtMinTime = new System.Windows.Forms.TextBox();
            this.txtMaxTime = new System.Windows.Forms.TextBox();
            this.txtMaxT = new System.Windows.Forms.TextBox();
            this.txtFish = new System.Windows.Forms.TextBox();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.menuFile.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFile
            // 
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(1099, 24);
            this.menuFile.TabIndex = 0;
            this.menuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlInput.Controls.Add(this.txtData);
            this.pnlInput.Controls.Add(this.btnClear);
            this.pnlInput.Controls.Add(this.lblTemp);
            this.pnlInput.Controls.Add(this.lblData);
            this.pnlInput.Controls.Add(this.lblMinTime);
            this.pnlInput.Controls.Add(this.lblMinT);
            this.pnlInput.Controls.Add(this.lblMaxTime);
            this.pnlInput.Controls.Add(this.btnCheck);
            this.pnlInput.Controls.Add(this.lblMaxT);
            this.pnlInput.Controls.Add(this.lblFish);
            this.pnlInput.Controls.Add(this.txtTemp);
            this.pnlInput.Controls.Add(this.txtMinT);
            this.pnlInput.Controls.Add(this.txtMinTime);
            this.pnlInput.Controls.Add(this.txtMaxTime);
            this.pnlInput.Controls.Add(this.txtMaxT);
            this.pnlInput.Controls.Add(this.txtFish);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInput.Location = new System.Drawing.Point(0, 24);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(518, 544);
            this.pnlInput.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(26, 165);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(134, 20);
            this.txtData.TabIndex = 16;
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(415, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(26, 188);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(74, 13);
            this.lblTemp.TabIndex = 14;
            this.lblTemp.Text = "Температура";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(23, 145);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 13;
            this.lblData.Text = "Дата";
            // 
            // lblMinTime
            // 
            this.lblMinTime.AutoSize = true;
            this.lblMinTime.Location = new System.Drawing.Point(195, 94);
            this.lblMinTime.Name = "lblMinTime";
            this.lblMinTime.Size = new System.Drawing.Size(113, 13);
            this.lblMinTime.TabIndex = 12;
            this.lblMinTime.Text = "Минимальное время";
            // 
            // lblMinT
            // 
            this.lblMinT.AutoSize = true;
            this.lblMinT.Location = new System.Drawing.Point(26, 95);
            this.lblMinT.Name = "lblMinT";
            this.lblMinT.Size = new System.Drawing.Size(142, 13);
            this.lblMinT.TabIndex = 11;
            this.lblMinT.Text = "Min температура хранения";
            // 
            // lblMaxTime
            // 
            this.lblMaxTime.AutoSize = true;
            this.lblMaxTime.Location = new System.Drawing.Point(192, 51);
            this.lblMaxTime.Name = "lblMaxTime";
            this.lblMaxTime.Size = new System.Drawing.Size(119, 13);
            this.lblMaxTime.TabIndex = 10;
            this.lblMaxTime.Text = "Максимальное время";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(415, 161);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Проверить ";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblMaxT
            // 
            this.lblMaxT.AutoSize = true;
            this.lblMaxT.Location = new System.Drawing.Point(23, 52);
            this.lblMaxT.Name = "lblMaxT";
            this.lblMaxT.Size = new System.Drawing.Size(145, 13);
            this.lblMaxT.TabIndex = 8;
            this.lblMaxT.Text = "Max температура хранения";
            // 
            // lblFish
            // 
            this.lblFish.AutoSize = true;
            this.lblFish.Location = new System.Drawing.Point(23, 4);
            this.lblFish.Name = "lblFish";
            this.lblFish.Size = new System.Drawing.Size(57, 13);
            this.lblFish.TabIndex = 7;
            this.lblFish.Text = "Вид рыбы";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(23, 205);
            this.txtTemp.Multiline = true;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(386, 192);
            this.txtTemp.TabIndex = 6;
            this.txtTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp_KeyPress);
            // 
            // txtMinT
            // 
            this.txtMinT.Location = new System.Drawing.Point(23, 112);
            this.txtMinT.Name = "txtMinT";
            this.txtMinT.Size = new System.Drawing.Size(137, 20);
            this.txtMinT.TabIndex = 4;
            this.txtMinT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinT_KeyPress);
            // 
            // txtMinTime
            // 
            this.txtMinTime.Location = new System.Drawing.Point(192, 112);
            this.txtMinTime.Name = "txtMinTime";
            this.txtMinTime.Size = new System.Drawing.Size(130, 20);
            this.txtMinTime.TabIndex = 3;
            this.txtMinTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinTime_KeyPress);
            // 
            // txtMaxTime
            // 
            this.txtMaxTime.Location = new System.Drawing.Point(192, 68);
            this.txtMaxTime.Name = "txtMaxTime";
            this.txtMaxTime.Size = new System.Drawing.Size(130, 20);
            this.txtMaxTime.TabIndex = 2;
            this.txtMaxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTime_KeyPress);
            // 
            // txtMaxT
            // 
            this.txtMaxT.Location = new System.Drawing.Point(23, 68);
            this.txtMaxT.Name = "txtMaxT";
            this.txtMaxT.Size = new System.Drawing.Size(137, 20);
            this.txtMaxT.TabIndex = 1;
            this.txtMaxT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxT_KeyPress);
            // 
            // txtFish
            // 
            this.txtFish.Location = new System.Drawing.Point(23, 23);
            this.txtFish.Name = "txtFish";
            this.txtFish.Size = new System.Drawing.Size(137, 20);
            this.txtFish.TabIndex = 0;
            this.txtFish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFish_KeyPress);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Controls.Add(this.txtResult);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResult.Location = new System.Drawing.Point(518, 24);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(581, 544);
            this.pnlResult.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(91, 190);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(220, 35);
            this.txtResult.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(91, 161);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(36, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Отчёт";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 568);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.menuFile);
            this.MainMenuStrip = this.menuFile;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblMaxT;
        private System.Windows.Forms.Label lblFish;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtMinT;
        private System.Windows.Forms.TextBox txtMinTime;
        private System.Windows.Forms.TextBox txtMaxTime;
        private System.Windows.Forms.TextBox txtMaxT;
        private System.Windows.Forms.TextBox txtFish;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblMinTime;
        private System.Windows.Forms.Label lblMinT;
        private System.Windows.Forms.Label lblMaxTime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
    }
}

