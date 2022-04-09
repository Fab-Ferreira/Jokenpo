/*
 * Created by SharpDevelop.
 * User: rm20212930048
 * Date: 08/04/2022
 * Time: 08:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace jokenpo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox papel;
		private System.Windows.Forms.PictureBox pedra;
		private System.Windows.Forms.PictureBox tesoura;
		private System.Windows.Forms.Button restart;
		private System.Windows.Forms.Label pontPlayer;
		private System.Windows.Forms.Label pontBot;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label ties;
		private System.Windows.Forms.Label opcao1;
		private System.Windows.Forms.Label opcao2;
		private System.Windows.Forms.Label opcao3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.papel = new System.Windows.Forms.PictureBox();
			this.pedra = new System.Windows.Forms.PictureBox();
			this.tesoura = new System.Windows.Forms.PictureBox();
			this.restart = new System.Windows.Forms.Button();
			this.pontPlayer = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pontBot = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ties = new System.Windows.Forms.Label();
			this.opcao1 = new System.Windows.Forms.Label();
			this.opcao2 = new System.Windows.Forms.Label();
			this.opcao3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.papel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pedra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tesoura)).BeginInit();
			this.SuspendLayout();
			// 
			// papel
			// 
			this.papel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.papel.Image = ((System.Drawing.Image)(resources.GetObject("papel.Image")));
			this.papel.Location = new System.Drawing.Point(287, 94);
			this.papel.Name = "papel";
			this.papel.Size = new System.Drawing.Size(260, 200);
			this.papel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.papel.TabIndex = 0;
			this.papel.TabStop = false;
			this.papel.Click += new System.EventHandler(this.ImageClick);
			// 
			// pedra
			// 
			this.pedra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pedra.Image = ((System.Drawing.Image)(resources.GetObject("pedra.Image")));
			this.pedra.Location = new System.Drawing.Point(12, 94);
			this.pedra.Name = "pedra";
			this.pedra.Size = new System.Drawing.Size(260, 200);
			this.pedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pedra.TabIndex = 1;
			this.pedra.TabStop = false;
			this.pedra.Click += new System.EventHandler(this.ImageClick);
			// 
			// tesoura
			// 
			this.tesoura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tesoura.Cursor = System.Windows.Forms.Cursors.Default;
			this.tesoura.Image = ((System.Drawing.Image)(resources.GetObject("tesoura.Image")));
			this.tesoura.Location = new System.Drawing.Point(565, 94);
			this.tesoura.Name = "tesoura";
			this.tesoura.Size = new System.Drawing.Size(260, 200);
			this.tesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tesoura.TabIndex = 2;
			this.tesoura.TabStop = false;
			this.tesoura.Click += new System.EventHandler(this.ImageClick);
			// 
			// restart
			// 
			this.restart.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restart.Location = new System.Drawing.Point(635, 348);
			this.restart.Name = "restart";
			this.restart.Size = new System.Drawing.Size(115, 37);
			this.restart.TabIndex = 3;
			this.restart.Text = "Reiniciar";
			this.restart.UseVisualStyleBackColor = true;
			this.restart.Visible = false;
			this.restart.Click += new System.EventHandler(this.RestartClick);
			// 
			// pontPlayer
			// 
			this.pontPlayer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pontPlayer.Location = new System.Drawing.Point(228, 348);
			this.pontPlayer.Name = "pontPlayer";
			this.pontPlayer.Size = new System.Drawing.Size(94, 23);
			this.pontPlayer.TabIndex = 4;
			this.pontPlayer.Text = "0";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 348);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Pontuação do jogador:";
			// 
			// pontBot
			// 
			this.pontBot.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pontBot.Location = new System.Drawing.Point(260, 382);
			this.pontBot.Name = "pontBot";
			this.pontBot.Size = new System.Drawing.Size(104, 23);
			this.pontBot.TabIndex = 5;
			this.pontBot.Text = "0";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 382);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(242, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Pontuação do computador:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(303, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(210, 34);
			this.label3.TabIndex = 8;
			this.label3.Text = "JOKENPÔ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(260, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(297, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Clique em uma imagem aleatória";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 418);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Empates:";
			// 
			// ties
			// 
			this.ties.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ties.Location = new System.Drawing.Point(115, 418);
			this.ties.Name = "ties";
			this.ties.Size = new System.Drawing.Size(107, 23);
			this.ties.TabIndex = 10;
			this.ties.Text = "0";
			// 
			// opcao1
			// 
			this.opcao1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.opcao1.ForeColor = System.Drawing.Color.LimeGreen;
			this.opcao1.Location = new System.Drawing.Point(33, 307);
			this.opcao1.Name = "opcao1";
			this.opcao1.Size = new System.Drawing.Size(210, 23);
			this.opcao1.TabIndex = 12;
			this.opcao1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// opcao2
			// 
			this.opcao2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.opcao2.ForeColor = System.Drawing.Color.LimeGreen;
			this.opcao2.Location = new System.Drawing.Point(314, 307);
			this.opcao2.Name = "opcao2";
			this.opcao2.Size = new System.Drawing.Size(210, 23);
			this.opcao2.TabIndex = 13;
			this.opcao2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// opcao3
			// 
			this.opcao3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.opcao3.ForeColor = System.Drawing.Color.LimeGreen;
			this.opcao3.Location = new System.Drawing.Point(590, 307);
			this.opcao3.Name = "opcao3";
			this.opcao3.Size = new System.Drawing.Size(210, 23);
			this.opcao3.TabIndex = 14;
			this.opcao3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 454);
			this.Controls.Add(this.opcao3);
			this.Controls.Add(this.opcao2);
			this.Controls.Add(this.opcao1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ties);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pontBot);
			this.Controls.Add(this.pontPlayer);
			this.Controls.Add(this.restart);
			this.Controls.Add(this.tesoura);
			this.Controls.Add(this.pedra);
			this.Controls.Add(this.papel);
			this.Name = "MainForm";
			this.Text = "jokenpo";
			((System.ComponentModel.ISupportInitialize)(this.papel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pedra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tesoura)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
