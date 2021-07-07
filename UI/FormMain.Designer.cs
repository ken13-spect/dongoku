
namespace AppUCA.UI
{
    partial class FormMain
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCourseDelete = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvCourseShow = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.txtCourseDurationAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCourseScheduleAdd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCourseAuthorAdd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCourseTopicAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCourseModuleAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourseTitleAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvInscriptionShow = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInscriptionAdd = new System.Windows.Forms.Button();
            this.txtInscriptionPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInscriptionMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInscriptionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvCourseShow)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvInscriptionShow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(657, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Libros";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(385, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCourseDelete);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.dgvCourseShow);
            this.groupBox6.Location = new System.Drawing.Point(3, 191);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(648, 152);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gestion";
            // 
            // btnCourseDelete
            // 
            this.btnCourseDelete.Location = new System.Drawing.Point(516, 120);
            this.btnCourseDelete.Name = "btnCourseDelete";
            this.btnCourseDelete.Size = new System.Drawing.Size(127, 26);
            this.btnCourseDelete.TabIndex = 27;
            this.btnCourseDelete.Text = "Eliminar";
            this.btnCourseDelete.UseVisualStyleBackColor = true;
            this.btnCourseDelete.Click += new System.EventHandler(this.btnCourseDelete_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(516, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Selecciona un curso";
            // 
            // dgvCourseShow
            // 
            this.dgvCourseShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseShow.Location = new System.Drawing.Point(5, 22);
            this.dgvCourseShow.Name = "dgvCourseShow";
            this.dgvCourseShow.RowTemplate.Height = 25;
            this.dgvCourseShow.Size = new System.Drawing.Size(506, 125);
            this.dgvCourseShow.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBookAdd);
            this.groupBox4.Controls.Add(this.txtCourseDurationAdd);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtCourseScheduleAdd);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtCourseAuthorAdd);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtCourseTopicAdd);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtCourseModuleAdd);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtCourseTitleAdd);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 183);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cursos";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(60, 152);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(231, 26);
            this.btnBookAdd.TabIndex = 30;
            this.btnBookAdd.Text = "Agregar curso";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // txtCourseDurationAdd
            // 
            this.txtCourseDurationAdd.Location = new System.Drawing.Point(140, 70);
            this.txtCourseDurationAdd.Name = "txtCourseDurationAdd";
            this.txtCourseDurationAdd.Size = new System.Drawing.Size(96, 20);
            this.txtCourseDurationAdd.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Duracion";
            // 
            // txtCourseScheduleAdd
            // 
            this.txtCourseScheduleAdd.Location = new System.Drawing.Point(240, 70);
            this.txtCourseScheduleAdd.Name = "txtCourseScheduleAdd";
            this.txtCourseScheduleAdd.Size = new System.Drawing.Size(120, 20);
            this.txtCourseScheduleAdd.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Edicion";
            // 
            // txtCourseAuthorAdd
            // 
            this.txtCourseAuthorAdd.Location = new System.Drawing.Point(5, 70);
            this.txtCourseAuthorAdd.Name = "txtCourseAuthorAdd";
            this.txtCourseAuthorAdd.Size = new System.Drawing.Size(130, 20);
            this.txtCourseAuthorAdd.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Autor";
            // 
            // txtCourseTopicAdd
            // 
            this.txtCourseTopicAdd.Location = new System.Drawing.Point(207, 32);
            this.txtCourseTopicAdd.Name = "txtCourseTopicAdd";
            this.txtCourseTopicAdd.Size = new System.Drawing.Size(152, 20);
            this.txtCourseTopicAdd.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tema";
            // 
            // txtCourseModuleAdd
            // 
            this.txtCourseModuleAdd.Location = new System.Drawing.Point(143, 32);
            this.txtCourseModuleAdd.Name = "txtCourseModuleAdd";
            this.txtCourseModuleAdd.Size = new System.Drawing.Size(60, 20);
            this.txtCourseModuleAdd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Modulos";
            // 
            // txtCourseTitleAdd
            // 
            this.txtCourseTitleAdd.Location = new System.Drawing.Point(5, 32);
            this.txtCourseTitleAdd.Name = "txtCourseTitleAdd";
            this.txtCourseTitleAdd.Size = new System.Drawing.Size(130, 20);
            this.txtCourseTitleAdd.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Titulo";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Administracion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvInscriptionShow);
            this.groupBox3.Location = new System.Drawing.Point(5, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 143);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inscripciones";
            // 
            // dgvInscriptionShow
            // 
            this.dgvInscriptionShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInscriptionShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscriptionShow.Location = new System.Drawing.Point(5, 19);
            this.dgvInscriptionShow.Name = "dgvInscriptionShow";
            this.dgvInscriptionShow.RowTemplate.Height = 25;
            this.dgvInscriptionShow.Size = new System.Drawing.Size(637, 119);
            this.dgvInscriptionShow.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInscriptionAdd);
            this.groupBox2.Controls.Add(this.txtInscriptionPhone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtInscriptionMail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtInscriptionName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(276, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 186);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inscripciones";
            // 
            // btnInscriptionAdd
            // 
            this.btnInscriptionAdd.Location = new System.Drawing.Point(5, 152);
            this.btnInscriptionAdd.Name = "btnInscriptionAdd";
            this.btnInscriptionAdd.Size = new System.Drawing.Size(366, 29);
            this.btnInscriptionAdd.TabIndex = 6;
            this.btnInscriptionAdd.Text = "Realizar Inscripcion";
            this.btnInscriptionAdd.UseVisualStyleBackColor = true;
            this.btnInscriptionAdd.Click += new System.EventHandler(this.btnInscriptionAdd_Click);
            // 
            // txtInscriptionPhone
            // 
            this.txtInscriptionPhone.Location = new System.Drawing.Point(5, 72);
            this.txtInscriptionPhone.Name = "txtInscriptionPhone";
            this.txtInscriptionPhone.Size = new System.Drawing.Size(160, 20);
            this.txtInscriptionPhone.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero telefono";
            // 
            // txtInscriptionMail
            // 
            this.txtInscriptionMail.Location = new System.Drawing.Point(212, 32);
            this.txtInscriptionMail.Name = "txtInscriptionMail";
            this.txtInscriptionMail.Size = new System.Drawing.Size(160, 20);
            this.txtInscriptionMail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo electronico";
            // 
            // txtInscriptionName
            // 
            this.txtInscriptionName.Location = new System.Drawing.Point(5, 32);
            this.txtInscriptionName.Name = "txtInscriptionName";
            this.txtInscriptionName.Size = new System.Drawing.Size(202, 20);
            this.txtInscriptionName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre completo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(702, 429);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvCourseShow)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvInscriptionShow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtBookPagesAdd;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox ourse;
        private System.Windows.Forms.TextBox txtCourseAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCourseDelete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvCourseShow;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.TextBox txtCourseDurationAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCourseScheduleAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCourseAuthorAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCourseTopicAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCourseModuleAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCourseTitleAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvInscriptionShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInscriptionMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInscriptionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnInscriptionAdd;
        private System.Windows.Forms.TextBox txtInscriptionPhone;
        private System.Windows.Forms.Label label2;
    }
}