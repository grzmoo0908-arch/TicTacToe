using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Requirement_tic_tac_toe_Game
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Form1_Print(object sender, PaintEventArgs e)
		{
			Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 500, 100, 500, 400);
            e.Graphics.DrawLine(Pen, 600, 100, 600, 400);
            e.Graphics.DrawLine(Pen, 400, 300, 700, 300);
            e.Graphics.DrawLine(Pen, 400, 200, 700, 200);    
		}
		
		void  WhoIsWinner()
		{
			if (button1.Tag.ToString() == "x" && button4.Tag.ToString() == "x" && button7.Tag.ToString() == "x"
			  ||button1.Tag.ToString() == "x" && button2.Tag.ToString() == "x" && button3.Tag.ToString() == "x"
			  ||button1.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button9.Tag.ToString() == "x"
			  ||button2.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button8.Tag.ToString() == "x"
			  ||button3.Tag.ToString() == "x" && button6.Tag.ToString() == "x" && button9.Tag.ToString() == "x"
			  ||button3.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button7.Tag.ToString() == "x"
			  ||button4.Tag.ToString() == "x" && button5.Tag.ToString() == "x" && button6.Tag.ToString() == "x"
			  ||button7.Tag.ToString() == "x" && button8.Tag.ToString() == "x" && button9.Tag.ToString() == "x")
			{
				lblWinner.Text = "Player1";
				lblTurn.Text = "Game Over Player2";
				
				button1.Enabled = false;
				button4.Enabled = false;
				button7.Enabled = false;
				button2.Enabled = false;
				button5.Enabled = false;
				button8.Enabled = false;
				button3.Enabled = false;
				button6.Enabled = false;
				button9.Enabled = false;
				
			}
			
	  else if  (button1.Tag.ToString() == "o" && button4.Tag.ToString() == "o" && button7.Tag.ToString() == "o"
			  ||button1.Tag.ToString() == "o" && button2.Tag.ToString() == "o" && button3.Tag.ToString() == "o"
			  ||button1.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button9.Tag.ToString() == "o"
			  ||button2.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button8.Tag.ToString() == "o"
			  ||button3.Tag.ToString() == "o" && button6.Tag.ToString() == "o" && button9.Tag.ToString() == "o"
			  ||button3.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button7.Tag.ToString() == "o"
			  ||button4.Tag.ToString() == "o" && button5.Tag.ToString() == "o" && button6.Tag.ToString() == "o"
			  ||button7.Tag.ToString() == "o" && button8.Tag.ToString() == "o" && button9.Tag.ToString() == "o")
			{
				lblWinner.Text = "Player2";
				lblTurn.Text = "Game Over Player1";
				
				button1.Enabled = false;
				button4.Enabled = false;
				button7.Enabled = false;
				button2.Enabled = false;
				button5.Enabled = false;
				button8.Enabled = false;
				button3.Enabled = false;
				button6.Enabled = false;
				button9.Enabled = false;
				
			}
			else if (button1.Tag.ToString() != "?" && button4.Tag.ToString() != "?" && button7.Tag.ToString() != "?"
			       &&button2.Tag.ToString() != "?" && button5.Tag.ToString() != "?" && button8.Tag.ToString() != "?"
			       &&button3.Tag.ToString() != "?" && button6.Tag.ToString() != "?" && button9.Tag.ToString() != "?")
			{
				
				lblWinner.Text = "Draw";
				lblTurn.Text = "Game Over";
				
				button1.Enabled = false;
				button4.Enabled = false;
				button7.Enabled = false;
				button2.Enabled = false;
				button5.Enabled = false;
				button8.Enabled = false;
				button3.Enabled = false;
				button6.Enabled = false;
				button9.Enabled = false;
				
			}
		}

		void Pb1Click(object sender, EventArgs e)
		{
			
			if(button1.Tag.ToString() == "x" || button1.Tag.ToString() == "o" )
			{ 
			    MessageBox.Show("Already Played Here");
			    return ;
			}
			
			if (lblTurn.Text == "Player1")
			{
				 button1.Tag = "x";
	    	     button1.Image = Resource.X;
	    	     lblTurn.Text = "Player2";
			}
			else if (lblTurn.Text == "Player2")
			{
				button1.Tag = "o";
				button1.Image = Resource.O;
				lblTurn.Text = "Player1";
			}
			WhoIsWinner();
		}
		
		void Pb2Click(object sender, EventArgs e)
		{		
			
			if(button4.Tag.ToString() == "x" || button4.Tag.ToString() == "o")
			{
			    MessageBox.Show("Already Played Here");
			    return;
			}	
			if (lblTurn.Text == "Player1")
			{
				 button4.Tag = "x";
	    	     button4.Image = Resource.X;
	    	     lblTurn.Text = "Player2";
			}
			else if (lblTurn.Text == "Player2")
			{
				button4.Tag = "o";
				button4.Image = Resource.O;
				lblTurn.Text = "Player1";
			}
			
			WhoIsWinner();
	
		}
		void Pb3Click(object sender, EventArgs e)
		{
			
			if(button7.Tag.ToString() == "x" || button7.Tag.ToString() == "o")
			{
			    MessageBox.Show("Already Played Here");
			    return ;
			}
				
			if (lblTurn.Text == "Player1")
			{
				button7.Tag = "x";
	    	     button7.Image = Resource.X;
	    	     lblTurn.Text = "Player2";
			}
			else if (lblTurn.Text == "Player2")
			{
				button7.Tag = "o";
				button7.Image = Resource.O;
				lblTurn.Text = "Player1";
			}
			
	            WhoIsWinner();
		}
		void Pb4Click(object sender, EventArgs e)
		{
			
			if(button2.Tag.ToString() == "x" || button2.Tag.ToString() == "o" )
			{
			    MessageBox.Show("Already Played Here");
			    return ;
			}

			if (lblTurn.Text == "Player1")
			{
				button2.Tag = "x";
	    	     button2.Image = Resource.X;
	    	     lblTurn.Text = "Player2";
			}
			else if (lblTurn.Text == "Player2")
			{
				button2.Tag = "o";
				button2.Image = Resource.O;
				lblTurn.Text = "Player1";
			}
			
			WhoIsWinner();
	
		}
		void Pb5Click(object sender, EventArgs e)
		{
			
			if(button5.Tag.ToString() == "x" || button5.Tag.ToString() == "o")
			{
			    MessageBox.Show("Already Played Here");
			    return;
			} 
			
			if (lblTurn.Text == "Player1")
			{
				button5.Tag = "x";
	    	     button5.Image = Resource.X;
	    	     lblTurn.Text = "Player2";
			}
			else if (lblTurn.Text == "Player2")
			{
				button5.Tag = "o";
				button5.Image = Resource.O;
				lblTurn.Text = "Player1";
			}
			
	           
			WhoIsWinner();
		}
		
		void Pb6Click(object sender, EventArgs e)
		{
			
			if(button8.Tag.ToString() == "x" || button8.Tag.ToString() == "o")
			{
				
			    MessageBox.Show("Already Played Here");
			    return ;
			}
			
			if (lblTurn.Text == "Player1")
			{
				button8.Tag = "x";
	    	     button8.Image = Resource.X;
	    	     lblTurn.Text = "Player2";
			}
			else if (lblTurn.Text == "Player2")
			{
				button8.Tag = "o";
				button8.Image = Resource.O;
				lblTurn.Text = "Player1";
			}
			
	            WhoIsWinner();
		}
		
		void Pb7Click(object sender, EventArgs e)
		{
			
			if(button3.Tag.ToString() == "x" || button3.Tag.ToString() == "o")
			{
			    MessageBox.Show("Already Played Here");
			    return ;
			}
			
			if (lblTurn.Text == "Player1")
			{
				button3.Tag = "x";
	    	     button3.Image = Resource.X;
	    	     lblTurn.Text = "Player2";
			}
			else if (lblTurn.Text == "Player2")
			{
				button3.Tag = "o";
				button3.Image = Resource.O;
				lblTurn.Text = "Player1";
			}
			
			WhoIsWinner();
	
		}
		
		void Pb8Click(object sender, EventArgs e)
		{
			
			if(button6.Tag.ToString() == "x" || button6.Tag.ToString() == "o" )
			{
			    MessageBox.Show("Already Played Here");
			    return ;
			}
			
			if (lblTurn.Text == "Player1")
			{
			
				button6.Tag = "x";
	    	     button6.Image = Resource.X;
	    	     lblTurn.Text = "Player2";
			}
			else if (lblTurn.Text == "Player2")
			{
				button6.Tag = "o";
				button6.Image = Resource.O;
				lblTurn.Text = "Player1";
			}
			
			WhoIsWinner();
	
		}
		
		void Pb9Click(object sender, EventArgs e)
		{
			
			if(button9.Tag.ToString() == "x" || button9.Tag.ToString() == "o" )
			{
				MessageBox.Show("Already Played Here");
				return ;
			}	
	
			if (lblTurn.Text == "Player1")
			{
				button9.Tag = "x";
	    	     button9.Image = Resource.X;
	    	     lblTurn.Text = "Player2";
			}
			else if (lblTurn.Text == "Player2")
			{
				button9.Tag = "o";
				button9.Image = Resource.O;
				lblTurn.Text = "Player1";
			}
			
			WhoIsWinner();
	
		}

		void Button1Click(object sender, EventArgs e)
		{
			    button1.Enabled = true;
				button4.Enabled = true;
				button7.Enabled = true;
				button2.Enabled = true;
				button5.Enabled = true;
				button8.Enabled = true;
				button3.Enabled = true;
				button6.Enabled = true;
				button9.Enabled = true;
				
				button1.Image = Resource.Question;
			    button4.Image = Resource.Question;
			    button7.Image = Resource.Question;
			    button2.Image = Resource.Question;
			    button5.Image = Resource.Question;
			    button8.Image = Resource.Question;
			    button3.Image = Resource.Question;
			    button6.Image = Resource.Question;
			    button9.Image = Resource.Question;
			    
			    
			    button1.Tag = "?";
			    button4.Tag = "?";
			    button7.Tag = "?";
			    button2.Tag = "?";
			    button5.Tag = "?";
			    button8.Tag = "?";
			    button3.Tag = "?";
			    button6.Tag = "?";
			    button9.Tag = "?";
			    
			    lblWinner.Text = "In Progress";
			    
			    if(lblTurn.Text ==  "Game Over Player1")
			    {
			    	lblTurn.Text = "Player1";
			    	
			    }else if (lblTurn.Text == "Game Over Player2")
			    {
			    	lblTurn.Text = "Player2";
			    }
			    else if (lblTurn.Text == "Game Over")
			    	lblTurn.Text = "Player1";
	
		}

		
		
		//Solution Doctor
		
		/*
		
        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

       



      
        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
           

            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }
            
            GameStatus.GameOver = false;
            return false;


        }

        void EndGame()
        {

            lblTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                 
                case enWinner.Player1:
                   
                       lblWinner.Text = "Player1";
                        break;
                   
                case enWinner.Player2:
                   
                        lblWinner.Text = "Player2";
                        break;

                default:

                        lblWinner.Text = "Draw";
                        break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void  CheckWinner()
        {

      
            //checked rows
            //check Row1
            if (CheckValues(button1, button2, button3))
             return;

            //check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //check Row3
            if (CheckValues(button7, button8, button9))
                return;

            //checked cols
            //check col1
            if (CheckValues(button1, button4, button7))
                return;

            //check col2
            if (CheckValues(button2, button5, button8))
                return;

            //check col3
            if (CheckValues(button3, button6, button9))
                return;

            //check Diagonal

            //check Diagonal1
            if (CheckValues(button1, button5, button9))
                return;

            //check Diagonal2
            if (CheckValues(button3, button5, button7))
                return;


        }


        public void ChangeImage(Button btn)
        {

            if (btn.Tag.ToString()=="?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn= enPlayer.Player2;
                        lblTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            
            else

            {
                MessageBox.Show("Wrong Choice","Worng",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            if(GameStatus.PlayCount ==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
           
          
        }

       
        
        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RestButton(Button btn)
        {
            btn.Image = Resource.Question;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
            
        }
        private void RestartGame()
        {

            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);

            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = "Player 1";
            GameStatus.PlayCount =0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lblWinner.Text = "In Progress";



        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();

        }

       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color white = Color.FromArgb(255, 255, 255,255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            
            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            //draw Vertical lines
            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);

            

        }
        */
    }
}