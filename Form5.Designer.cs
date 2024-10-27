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
            this.Type.Location = new System.Drawing.Point(71, 104);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(438, 33);
            this.Type.TabIndex = 0;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // AnimalClass
            // 
            this.AnimalClass.AutoSize = true;
            this.AnimalClass.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalClass.Location = new System.Drawing.Point(64, 45);
            this.AnimalClass.Name = "AnimalClass";
            this.AnimalClass.Size = new System.Drawing.Size(96, 42);
            this.AnimalClass.TabIndex = 1;
            this.AnimalClass.Text = "Класс";
            // 
            // AnimalSpec
            // 
            this.AnimalSpec.AutoSize = true;
            this.AnimalSpec.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalSpec.Location = new System.Drawing.Point(64, 168);
            this.AnimalSpec.Name = "AnimalSpec";
            this.AnimalSpec.Size = new System.Drawing.Size(73, 42);
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
            this.Spec.Location = new System.Drawing.Point(71, 232);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(438, 33);
            this.Spec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(71, 369);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(438, 31);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(175, 524);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(206, 73);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Spec);
            this.Controls.Add(this.AnimalSpec);
            this.Controls.Add(this.AnimalClass);
            this.Controls.Add(this.Type);
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
    }
}