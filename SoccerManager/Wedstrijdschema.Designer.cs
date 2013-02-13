namespace SoccerManager
{
    partial class Wedstrijdschema
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_tespelen = new System.Windows.Forms.CheckBox();
            this.cb_gespeeld = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "Wedstrijdschema";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 10F);
            this.button3.Location = new System.Drawing.Point(354, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = "Bekijk finale wedstrijden";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cb_tespelen
            // 
            this.cb_tespelen.AutoSize = true;
            this.cb_tespelen.Checked = true;
            this.cb_tespelen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_tespelen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tespelen.Location = new System.Drawing.Point(423, 71);
            this.cb_tespelen.Name = "cb_tespelen";
            this.cb_tespelen.Size = new System.Drawing.Size(151, 17);
            this.cb_tespelen.TabIndex = 14;
            this.cb_tespelen.Text = "Te spelen wedstrijden";
            this.cb_tespelen.UseVisualStyleBackColor = true;
            // 
            // cb_gespeeld
            // 
            this.cb_gespeeld.AutoSize = true;
            this.cb_gespeeld.Checked = true;
            this.cb_gespeeld.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gespeeld.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gespeeld.Location = new System.Drawing.Point(201, 71);
            this.cb_gespeeld.Name = "cb_gespeeld";
            this.cb_gespeeld.Size = new System.Drawing.Size(156, 17);
            this.cb_gespeeld.TabIndex = 13;
            this.cb_gespeeld.Text = "Gespeelde wedstrijden";
            this.cb_gespeeld.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Toon: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10F);
            this.button1.Location = new System.Drawing.Point(85, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Nieuwe wedstrijd toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 411);
            this.dataGridView1.TabIndex = 10;
            // 
            // Wedstrijdschema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_tespelen);
            this.Controls.Add(this.cb_gespeeld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Wedstrijdschema";
            this.Text = "Wedstrijdschema";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cb_tespelen;
        private System.Windows.Forms.CheckBox cb_gespeeld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}