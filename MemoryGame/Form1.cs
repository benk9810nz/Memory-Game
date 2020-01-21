using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayingCards;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        /*
         * Intalises the Const for the cards
         * */
        const int NUM_CARDS = 32;
        const int NUM_COLS = 8;
        const int CARD_WIDTH = 75;
        const int CARD_HEIGHT = 107;
        const char CHEAT_KEY = 'c';
        const char SHOW_KEY = 's';
        int score;
        Deck deck;
        PictureBox[] myCards;
        int state;
        CardRank rank1;
        PictureBox pb1;
        PictureBox pb2;
        PlayingCard card1;
        PlayingCard card2;
        int cardsRight;
        PictureBox[] pBoxes = new PictureBox[32];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            state = 0;
            score = 0;
            this.CenterToScreen();
            this.MaximizeBox = false;
            myCards = new PictureBox[32];
            getImages();
            createPBoxes();
        }

        public void createPBoxes()
        {
            for (int i = 0; i < NUM_CARDS; i++)
            {
                PlayingCard card = deck.DealTopCard();
                card.IsFaceUp = false;
                PictureBox box = new PictureBox();
                box.Size = new Size(CARD_WIDTH, CARD_HEIGHT);
                int row = i / NUM_COLS;
                int col = i % NUM_COLS;
                box.Image = card.GetImage();
                box.Location = new Point(10 + col * (CARD_WIDTH + 10), 10 + row * (CARD_HEIGHT + 10));
                box.Tag = card;
                box.Click += Box_Click;
                this.Controls.Add(box);
                pBoxes[i] = box;
            }
        }

        public void getImages()
        {
            deck = new Deck(CardRank.Ace, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven, CardRank.Eight);
            List<Image> images = new List<Image>();

            for (int i = 0; i < NUM_CARDS; i++)
            {
                images.Add(imageList.Images[i]);
            }
            deck.AssignImages(images, imageList.Images[36]);
            deck.Shuffle();
        }

        private void Box_Click(object sender, EventArgs e)
        {
            PAN_Mode.Visible = false;
            PictureBox pBox = sender as PictureBox;
            PlayingCard card = pBox.Tag as PlayingCard;
                card.flip();
                pBox.Image = card.GetImage();
            if (state == 0)
            {
                timer.Start();
                pBox.Enabled = false;
                rank1 = card.MyRank;
                state = 1;
                card1 = card;
                pb1 = pBox;
            }
            else
            {
                    card1.flip();
                    pb1.Image = card1.GetImage();
                pBox.Enabled = false;
                pb2 = pBox;
                card2 = card;
                if (card.MyRank == rank1)
                {
                    MessageBoxR mbr = new MessageBoxR();
                    mbr.ShowDialog();
                    score++;
                    cardsRight = cardsRight + 2;
                    pb1.Visible = false;
                    pb2.Visible = false;
                    if (cardsRight == NUM_CARDS)
                    {
                       using(EndOfGame end = new EndOfGame())
                        {
                            if (end.ShowDialog() == DialogResult.Retry)
                            {
                                GetNewGame();
                            }

                            else if (end.ShowDialog() == DialogResult.Abort) this.Close();
                        }
                    }
                }
                else
                {
                    if (RB_Easy.Checked == true)
                    {
                        MessageBoxW mb = new MessageBoxW();
                        mb.ShowDialog();
                    }
                    pb1.Enabled = true;
                    pb2.Enabled = true;
                    card1.flip();
                    pb1.Image = card1.GetImage();
                    card2.flip();
                    pb2.Image = card2.GetImage();
                    score--;
                }
                state = 0;
            }
            LB_Score.Text = String.Format("Score: {0}", score);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            card1.flip();
            pb1.Image = card1.GetImage();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) //SHOW MODE
        {
                if ((e.KeyChar == 's') || (e.KeyChar == char.ToUpper(SHOW_KEY)))
                {
                    foreach (PictureBox pbox in pBoxes)
                    {
                        PlayingCard CurrentCard = (PlayingCard)pbox.Tag;
                        if (CurrentCard.IsFaceUp)
                        {
                            CurrentCard.flip();
                            pbox.Image = CurrentCard.GetImage();
                            pbox.Enabled = true;
                        }
                        else
                        {
                            CurrentCard.flip();
                            pbox.Image = CurrentCard.GetImage();
                            pbox.Enabled = false;
                        }
                    }
                }
                if ((e.KeyChar == CHEAT_KEY) || (e.KeyChar == char.ToUpper(CHEAT_KEY))) //CHEATERS MODE
                {
                    foreach (PictureBox pbox in pBoxes)
                    {
                        if (pbox.Enabled)
                        {
                            pbox.Enabled = false;
                        }
                        else pbox.Enabled = true;
                    }
                }
        }

        private void bt_CheatHelp_Click(object sender, EventArgs e)
        {
            Form form = new CheatModeHelp();
            form.Show();
        }

        private void RB_Hard_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Hard.Checked == true)
            {
                timer.Interval = 1;
                this.KeyPreview = false;
            }
            else
            {
                timer.Interval = 1000;
            }
        }

        private void GetNewGame()
        {
            getImages();

            foreach (PictureBox pictureBox in pBoxes)
            {
                this.Controls.Remove(pictureBox);
            }
            state = 0;
            score = 0;
            createPBoxes();
        }
    }
}