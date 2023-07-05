namespace Translator
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxBefore = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxAfter = new System.Windows.Forms.TextBox();
            this.textBoxPathNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPath.Location = new System.Drawing.Point(204, 12);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(818, 29);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(13, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(185, 29);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Открыть файл";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBoxBefore
            // 
            this.textBoxBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBefore.Location = new System.Drawing.Point(13, 110);
            this.textBoxBefore.MaxLength = 0;
            this.textBoxBefore.Multiline = true;
            this.textBoxBefore.Name = "textBoxBefore";
            this.textBoxBefore.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxBefore.Size = new System.Drawing.Size(500, 404);
            this.textBoxBefore.TabIndex = 2;
            this.textBoxBefore.WordWrap = false;
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(523, 519);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(185, 29);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Преобразовать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML|*.xml";
            // 
            // textBoxAfter
            // 
            this.textBoxAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAfter.Location = new System.Drawing.Point(523, 110);
            this.textBoxAfter.MaxLength = 0;
            this.textBoxAfter.Multiline = true;
            this.textBoxAfter.Name = "textBoxAfter";
            this.textBoxAfter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxAfter.Size = new System.Drawing.Size(500, 404);
            this.textBoxAfter.TabIndex = 5;
            this.textBoxAfter.WordWrap = false;
            this.textBoxAfter.TextChanged += new System.EventHandler(this.textBoxAfter_TextChanged);
            this.textBoxAfter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAfter_KeyDown);
            // 
            // textBoxPathNew
            // 
            this.textBoxPathNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPathNew.Location = new System.Drawing.Point(204, 47);
            this.textBoxPathNew.Name = "textBoxPathNew";
            this.textBoxPathNew.ReadOnly = true;
            this.textBoxPathNew.Size = new System.Drawing.Size(818, 29);
            this.textBoxPathNew.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Строки до перевода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(519, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Строки после перевода";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPathNew);
            this.Controls.Add(this.textBoxAfter);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxBefore);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Переводчик для XML файлов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxBefore;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxAfter;
        private System.Windows.Forms.TextBox textBoxPathNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

