namespace SortAlgorithms
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
            this.button_Add = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.button_Sort = new System.Windows.Forms.Button();
            this.label_Out = new System.Windows.Forms.Label();
            this.label_Sort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(181, 97);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(96, 33);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 102);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(126, 22);
            this.textBoxResult.TabIndex = 1;
            // 
            // button_Sort
            // 
            this.button_Sort.Location = new System.Drawing.Point(12, 190);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(265, 33);
            this.button_Sort.TabIndex = 2;
            this.button_Sort.Text = "Сортировка";
            this.button_Sort.UseVisualStyleBackColor = true;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // label_Out
            // 
            this.label_Out.AutoSize = true;
            this.label_Out.Location = new System.Drawing.Point(13, 148);
            this.label_Out.Name = "label_Out";
            this.label_Out.Size = new System.Drawing.Size(0, 17);
            this.label_Out.TabIndex = 3;
            // 
            // label_Sort
            // 
            this.label_Sort.AutoSize = true;
            this.label_Sort.Location = new System.Drawing.Point(12, 251);
            this.label_Sort.Name = "label_Sort";
            this.label_Sort.Size = new System.Drawing.Size(0, 17);
            this.label_Sort.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Sort);
            this.Controls.Add(this.label_Out);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Label label_Out;
        private System.Windows.Forms.Label label_Sort;
    }
}

