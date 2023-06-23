namespace Sincronico2
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
            btn_iniciar.Location = new Point(225, 181);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(114, 23);
            btn_iniciar.TabIndex = 0;
            btn_iniciar.Text = "Iniciar Proceso";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(432, 181);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // loadingGIF
            // 
            loadingGIF.Image = (Image)resources.GetObject("loadingGIF.Image");
            loadingGIF.Location = new Point(225, 225);
            loadingGIF.Name = "loadingGIF";
            loadingGIF.Size = new Size(282, 156);
            loadingGIF.SizeMode = PictureBoxSizeMode.StretchImage;
            loadingGIF.TabIndex = 2;
            loadingGIF.TabStop = false;
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