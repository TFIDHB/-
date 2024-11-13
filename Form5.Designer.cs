namespace Модель_леса
{
    partial class Form5
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
            this.Type = new System.Windows.Forms.ComboBox();
            this.AnimalClass = new System.Windows.Forms.Label();
            this.AnimalSpec = new System.Windows.Forms.Label();
            this.Spec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.OK = new System.Windows.Forms.Button();
            this.objBehavior = new System.Windows.Forms.ComboBox();
            this.Behav = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Хищник",
            "Травоядное",
            "Растение",
            "Насекомое"});
            this.Type.Location = new System.Drawing.Point(106, 160);
            this.Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(655, 45);
            this.Type.TabIndex = 0;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // AnimalClass
            // 
            this.AnimalClass.AutoSize = true;
            this.AnimalClass.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalClass.Location = new System.Drawing.Point(96, 69);
            this.AnimalClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnimalClass.Name = "AnimalClass";
            this.AnimalClass.Size = new System.Drawing.Size(146, 63);
            this.AnimalClass.TabIndex = 1;
            this.AnimalClass.Text = "Класс";
            // 
            // AnimalSpec
            // 
            this.AnimalSpec.AutoSize = true;
            this.AnimalSpec.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalSpec.Location = new System.Drawing.Point(96, 258);
            this.AnimalSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnimalSpec.Name = "AnimalSpec";
            this.AnimalSpec.Size = new System.Drawing.Size(110, 63);
            this.AnimalSpec.TabIndex = 2;
            this.AnimalSpec.Text = "Вид";
            // 
            // Spec
            // 
            this.Spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spec.FormattingEnabled = true;
            this.Spec.Items.AddRange(new object[] {
            "Хищник",
            "Травоядное",
            "Растение",
            "Насекомое"});
            this.Spec.Location = new System.Drawing.Point(106, 344);
            this.Spec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(655, 45);
            this.Spec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(95, 599);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(107, 690);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(657, 43);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(262, 806);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(309, 112);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // objBehavior
            // 
            this.objBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objBehavior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objBehavior.FormattingEnabled = true;
            this.objBehavior.Items.AddRange(new object[] {
            "Бездействует(относительно других объектов)",
            "Охотится",
            "Питается"});
            this.objBehavior.Location = new System.Drawing.Point(106, 518);
            this.objBehavior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objBehavior.Name = "objBehavior";
            this.objBehavior.Size = new System.Drawing.Size(655, 45);
            this.objBehavior.TabIndex = 7;
            this.objBehavior.SelectedIndexChanged += new System.EventHandler(this.objBehavior_SelectedIndexChanged);
            // 
            // Behav
            // 
            this.Behav.AutoSize = true;
            this.Behav.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Behav.Location = new System.Drawing.Point(95, 421);
            this.Behav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Behav.Name = "Behav";
            this.Behav.Size = new System.Drawing.Size(258, 63);
            this.Behav.TabIndex = 8;
            this.Behav.Text = "Поведение";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 1017);
            this.Controls.Add(this.Behav);
            this.Controls.Add(this.objBehavior);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Spec);
            this.Controls.Add(this.AnimalSpec);
            this.Controls.Add(this.AnimalClass);
            this.Controls.Add(this.Type);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label AnimalClass;
        private System.Windows.Forms.Label AnimalSpec;
        private System.Windows.Forms.ComboBox Spec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox objBehavior;
        private System.Windows.Forms.Label Behav;
    }
}