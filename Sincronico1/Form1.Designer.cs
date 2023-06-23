namespace Sincronico1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_iniciar = new Button();
            btn_cancelar = new Button();
            loadingGIF = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loadingGIF).BeginInit();
            SuspendLayout();
            // 
            // btn_iniciar
            // 
            btn_iniciar.Location = new Point(182, 155);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(122, 23);
            btn_iniciar.TabIndex = 0;
            btn_iniciar.Text = "Iniciar proceso";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(428, 155);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // loadingGIF
            // 
            loadingGIF.Image = (Image)resources.GetObject("loadingGIF.Image");
            loadingGIF.Location = new Point(182, 184);
            loadingGIF.Name = "loadingGIF";
            loadingGIF.Size = new Size(321, 227);
            loadingGIF.SizeMode = PictureBoxSizeMode.StretchImage;
            loadingGIF.TabIndex = 2;
            loadingGIF.TabStop = false;
            loadingGIF.Click += loadingGIF_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadingGIF);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_iniciar);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)loadingGIF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_iniciar;
        private Button btn_cancelar;
        private PictureBox loadingGIF;
    }
}