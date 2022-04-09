using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jokenpo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		//Variáveis
		int contBot, contPlayer, empates, num;
		string bot = "COMPUTADOR", player = "JOGADOR";
		
		void ImageClick(object sender, EventArgs e)
		{
			Label[] L = {opcao1, opcao2, opcao3}; //Vetor com as Labels que aparecerá "Computador" ou "JOGADOR"
			
			Random random = new Random(); 
			int aleatorio = random.Next(0, 3); //Escolher aleatóriamente um número int de 0 à 2
			
			switch ((sender as PictureBox).Name)
			{
				case "pedra": //Caso o nome da PictureBox seja pedra
					num = 0;
					break;
				case "papel": //Caso o nome da PictureBox seja papel
					num = 1;
					break;
				case "tesoura": //Caso o nome da PictureBox seja tesoura
					num = 2;
					break;
			}
			
			if(aleatorio != num) //Se o valor randomizado for diferente de num
			{
				switch (aleatorio)
				{
					case 0: //Caso o valor escolhido tenha sido 0
						pedra.Visible = true;
						papel.Visible = false;
						tesoura.Visible = false;
						break;
					case 1: //Caso o valor escolhido tenha sido 1
						papel.Visible = true;
						pedra.Visible = false;
						tesoura.Visible = false;
						break;
					case 2: //Caso o valor escolhido tenha sido 2
						tesoura.Visible = true;
						papel.Visible = false;
						pedra.Visible = false;
						break;
				}
				
				(sender as PictureBox).Visible = true; //Deixar visivel a PictureBox selecionada
				
				L[num].Text = player; //A Label que se coincide com a PictureBox escolhida será definida por player
				L[num].ForeColor = Color.LimeGreen; //A cor da Label que se coincide com a PictureBox escolhida será LimeGreen
					
				L[aleatorio].Text = bot; //A Label que se coincide com a PictureBox randomizada será definida por bot
				L[aleatorio].ForeColor = Color.Red; //A cor da Label que se coincide com a PictureBox randomizada será Red
				
				//Se a PictureBox escolhida for o vitorioso
				if((aleatorio == 0 && papel.Visible == true) || (aleatorio == 1 && tesoura.Visible == true) || (aleatorio == 2 && pedra.Visible == true))
				{
					MessageBox.Show("Você ganhou!");
					contPlayer++;
				}
				else //Se a PictureBox escolhida for a perdedora
				{
					MessageBox.Show("Você perdeu!");
					contBot++;
				}
			}
			
			else //Se a PictureBox escolhida se coincidir com a do Computador
			{
				L[num].Text = "Ambos";
				L[num].ForeColor = Color.DarkCyan;
				
				switch (num)
				{
					case 0: //Se num valer 0
						papel.Visible = false;
						tesoura.Visible = false;
						break;
					case 1: //Se num valer 1
						pedra.Visible = false;
						tesoura.Visible = false;
						break;
					case 2: //Se num valer 2
						papel.Visible = false;
						pedra.Visible = false;
						break;
				}
				MessageBox.Show("Empate");
				empates++;
			}
			
			//Contadores, desativar PictureBoxes e Botão Restart
			pontPlayer.Text = contPlayer.ToString();
			pontBot.Text = contBot.ToString();
			ties.Text = empates.ToString();
			
			pedra.Enabled = false;
			papel.Enabled = false;
			tesoura.Enabled = false;
			
			restart.Visible = true;
		}
		
		//Ir novamente
		void RestartClick(object sender, EventArgs e)
		{
			pedra.Visible = true;
			papel.Visible = true;
			tesoura.Visible = true;
			
			pedra.Enabled = true;
			papel.Enabled = true;
			tesoura.Enabled = true;
			
			restart.Visible = false;
			
			opcao1.Text = "";
			opcao2.Text = "";
			opcao3.Text = "";
		}
	}
}