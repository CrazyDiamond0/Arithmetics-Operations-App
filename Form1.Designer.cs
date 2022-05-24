namespace AlgorithmOperations
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureOriginal = new System.Windows.Forms.PictureBox();
            this.LabelOriginal = new System.Windows.Forms.Label();
            this.labelBS = new System.Windows.Forms.Label();
            this.labelMediere = new System.Windows.Forms.Label();
            this.labelMediana = new System.Windows.Forms.Label();
            this.pictureBGSub = new System.Windows.Forms.PictureBox();
            this.imageMediere = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.alphalable = new System.Windows.Forms.Label();
            this.Gifspeedlable = new System.Windows.Forms.Label();
            this.alphatext = new System.Windows.Forms.NumericUpDown();
            this.Gifspeedtext = new System.Windows.Forms.NumericUpDown();
            this.thresholdtext = new System.Windows.Forms.NumericUpDown();
            this.Thresholdlable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBGSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMediere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphatext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gifspeedtext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdtext)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureOriginal
            // 
            this.pictureOriginal.BackColor = System.Drawing.Color.White;
            this.pictureOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOriginal.Location = new System.Drawing.Point(682, 73);
            this.pictureOriginal.Name = "pictureOriginal";
            this.pictureOriginal.Size = new System.Drawing.Size(254, 215);
            this.pictureOriginal.TabIndex = 4;
            this.pictureOriginal.TabStop = false;
            // 
            // LabelOriginal
            // 
            this.LabelOriginal.AutoSize = true;
            this.LabelOriginal.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOriginal.Location = new System.Drawing.Point(765, 46);
            this.LabelOriginal.Name = "LabelOriginal";
            this.LabelOriginal.Size = new System.Drawing.Size(96, 24);
            this.LabelOriginal.TabIndex = 5;
            this.LabelOriginal.Text = "Original";
            this.LabelOriginal.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBS
            // 
            this.labelBS.AutoSize = true;
            this.labelBS.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBS.Location = new System.Drawing.Point(42, 16);
            this.labelBS.Name = "labelBS";
            this.labelBS.Size = new System.Drawing.Size(274, 24);
            this.labelBS.TabIndex = 6;
            this.labelBS.Text = "Background Substaction";
            this.labelBS.Click += new System.EventHandler(this.labelBS_Click);
            // 
            // labelMediere
            // 
            this.labelMediere.AutoSize = true;
            this.labelMediere.BackColor = System.Drawing.Color.Transparent;
            this.labelMediere.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediere.Location = new System.Drawing.Point(459, 13);
            this.labelMediere.Name = "labelMediere";
            this.labelMediere.Size = new System.Drawing.Size(94, 24);
            this.labelMediere.TabIndex = 7;
            this.labelMediere.Text = "Mediere";
            // 
            // labelMediana
            // 
            this.labelMediana.AutoSize = true;
            this.labelMediana.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediana.Location = new System.Drawing.Point(760, 13);
            this.labelMediana.Name = "labelMediana";
            this.labelMediana.Size = new System.Drawing.Size(99, 24);
            this.labelMediana.TabIndex = 8;
            this.labelMediana.Text = "Mediana";
            // 
            // pictureBGSub
            // 
            this.pictureBGSub.BackColor = System.Drawing.Color.White;
            this.pictureBGSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBGSub.Location = new System.Drawing.Point(62, 40);
            this.pictureBGSub.Name = "pictureBGSub";
            this.pictureBGSub.Size = new System.Drawing.Size(254, 215);
            this.pictureBGSub.TabIndex = 9;
            this.pictureBGSub.TabStop = false;
            // 
            // imageMediere
            // 
            this.imageMediere.BackColor = System.Drawing.Color.White;
            this.imageMediere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageMediere.Location = new System.Drawing.Point(381, 40);
            this.imageMediere.Name = "imageMediere";
            this.imageMediere.Size = new System.Drawing.Size(254, 215);
            this.imageMediere.TabIndex = 2;
            this.imageMediere.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.Color.White;
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(678, 40);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(254, 215);
            this.imageBox2.TabIndex = 10;
            this.imageBox2.TabStop = false;
            // 
            // alphalable
            // 
            this.alphalable.AutoSize = true;
            this.alphalable.Location = new System.Drawing.Point(452, 103);
            this.alphalable.Name = "alphalable";
            this.alphalable.Size = new System.Drawing.Size(37, 13);
            this.alphalable.TabIndex = 14;
            this.alphalable.Text = "Alpha:";
            // 
            // Gifspeedlable
            // 
            this.Gifspeedlable.AutoSize = true;
            this.Gifspeedlable.Location = new System.Drawing.Point(442, 135);
            this.Gifspeedlable.Name = "Gifspeedlable";
            this.Gifspeedlable.Size = new System.Drawing.Size(55, 13);
            this.Gifspeedlable.TabIndex = 15;
            this.Gifspeedlable.Text = "Gif speed:";
            // 
            // alphatext
            // 
            this.alphatext.DecimalPlaces = 2;
            this.alphatext.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.alphatext.Location = new System.Drawing.Point(503, 101);
            this.alphatext.Name = "alphatext";
            this.alphatext.Size = new System.Drawing.Size(120, 20);
            this.alphatext.TabIndex = 16;
            this.alphatext.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.alphatext.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Gifspeedtext
            // 
            this.Gifspeedtext.Location = new System.Drawing.Point(503, 133);
            this.Gifspeedtext.Name = "Gifspeedtext";
            this.Gifspeedtext.Size = new System.Drawing.Size(120, 20);
            this.Gifspeedtext.TabIndex = 17;
            this.Gifspeedtext.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // thresholdtext
            // 
            this.thresholdtext.Location = new System.Drawing.Point(503, 167);
            this.thresholdtext.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdtext.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thresholdtext.Name = "thresholdtext";
            this.thresholdtext.Size = new System.Drawing.Size(120, 20);
            this.thresholdtext.TabIndex = 19;
            this.thresholdtext.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // Thresholdlable
            // 
            this.Thresholdlable.AutoSize = true;
            this.Thresholdlable.Location = new System.Drawing.Point(412, 169);
            this.Thresholdlable.Name = "Thresholdlable";
            this.Thresholdlable.Size = new System.Drawing.Size(85, 13);
            this.Thresholdlable.TabIndex = 18;
            this.Thresholdlable.Text = "Image threshold:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelMediere);
            this.groupBox1.Controls.Add(this.labelMediana);
            this.groupBox1.Controls.Add(this.pictureBGSub);
            this.groupBox1.Controls.Add(this.imageMediere);
            this.groupBox1.Controls.Add(this.imageBox2);
            this.groupBox1.Controls.Add(this.labelBS);
            this.groupBox1.Location = new System.Drawing.Point(4, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 264);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(385, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 144);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Values";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.thresholdtext);
            this.Controls.Add(this.Thresholdlable);
            this.Controls.Add(this.Gifspeedtext);
            this.Controls.Add(this.alphatext);
            this.Controls.Add(this.Gifspeedlable);
            this.Controls.Add(this.alphalable);
            this.Controls.Add(this.LabelOriginal);
            this.Controls.Add(this.pictureOriginal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arithmetics Operation Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBGSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMediere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphatext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gifspeedtext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdtext)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureOriginal;
        private System.Windows.Forms.Label LabelOriginal;
        private System.Windows.Forms.Label labelBS;
        private System.Windows.Forms.Label labelMediere;
        private System.Windows.Forms.Label labelMediana;
        private System.Windows.Forms.PictureBox pictureBGSub;
        private Emgu.CV.UI.ImageBox imageMediere;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label alphalable;
        private System.Windows.Forms.Label Gifspeedlable;
        private System.Windows.Forms.NumericUpDown alphatext;
        private System.Windows.Forms.NumericUpDown Gifspeedtext;
        private System.Windows.Forms.NumericUpDown thresholdtext;
        private System.Windows.Forms.Label Thresholdlable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

