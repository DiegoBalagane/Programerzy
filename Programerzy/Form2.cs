using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Programerzy
{
    public partial class Form2 : Form
    {
        private Form1 form1Form = null;
        private int questionNumber = 1;
        private Question currentQuestion = null;
        private QuestionContainer bases = new QuestionContainer();
        private bool finish = false;
        private bool using50 = false;
        private bool usingAudience = false;
        private bool usingSwap = false;
        private bool resignPosibility = false;
        private bool isUsing5050 = false;
        public Form2()
        {
            InitializeComponent();
        }
        public void setForm1Form(Form1 form)
        {
            this.form1Form = form;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void QuestionPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 179, 179, 179));

            pen.Width = 3;
            e.Graphics.DrawLine(pen, 0, 64, QuestionPanel.Width, 64);

            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 146, QuestionPanel.Width, 146);
            e.Graphics.DrawLine(pen, 0, 202, QuestionPanel.Width, 202);

            pen.Dispose();
        }

        private void PrizePanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);

            pen.Width = 2f;
            pen = new Pen(Color.White);

            Rectangle rect = PrizePanel.ClientRectangle;
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(pen, rect);

            pen.Dispose();
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            if (finish)
            {

                finito();
            }
            if(resignPosibility)
            {
                Helpdesk5050.Enabled = false;
                HelpdeskAudience.Enabled = false;
                HelpdeskSwap.Enabled = false;
                ButtonContinue.Text = "KONTYNUUJ";
                finish = true;
                if (currentQuestion.checkAnswer(AnswerA.Text))
                {
                    AnswerA.BackgroundImage = Properties.Resources.RightAnswerA;
                    AnswerA.ForeColor = Color.White;
                }
                else if (currentQuestion.checkAnswer(AnswerB.Text))
                {
                    AnswerB.BackgroundImage = Properties.Resources.RightAnswerB;
                    AnswerB.ForeColor = Color.White;
                }
                else if (currentQuestion.checkAnswer(AnswerC.Text))
                {
                    AnswerC.BackgroundImage = Properties.Resources.RightAnswerC;
                    AnswerC.ForeColor = Color.White;
                }
                else
                {
                    AnswerD.BackgroundImage = Properties.Resources.RightAnswerD;
                    AnswerD.ForeColor = Color.White;
                }
                switch (questionNumber)
                {
                    case 2:
                        Prize2.BackgroundImage = Properties.Resources.BasicButton;
                        Prize2.ForeColor = Color.White;
                        Prize1.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize1.ForeColor = Color.White;
                        break;
                    case 3:
                        Prize3.BackgroundImage = Properties.Resources.BasicButton;
                        Prize3.ForeColor = Color.White;
                        Prize2.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize2.ForeColor = Color.White;
                        break;
                    case 4:
                        Prize4.BackgroundImage = Properties.Resources.BasicButton;
                        Prize4.ForeColor = Color.White;
                        Prize3.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize3.ForeColor = Color.White;
                        break;
                    case 5:
                        Prize5.BackgroundImage = Properties.Resources.BasicButton;
                        Prize5.ForeColor = Color.White;
                        Prize4.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize4.ForeColor = Color.White;
                        break;
                    case 6:
                        Prize6.BackgroundImage = Properties.Resources.BasicButton;
                        Prize6.ForeColor = Color.White;
                        Prize5.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize5.ForeColor = Color.White;
                        break;
                    case 7:
                        Prize7.BackgroundImage = Properties.Resources.BasicButton;
                        Prize7.ForeColor = Color.White;
                        Prize6.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize6.ForeColor = Color.White;
                        break;
                    case 8:
                        Prize8.BackgroundImage = Properties.Resources.BasicButton;
                        Prize8.ForeColor = Color.White;
                        Prize7.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize7.ForeColor = Color.White;
                        break;
                    case 9:
                        Prize9.BackgroundImage = Properties.Resources.BasicButton;
                        Prize9.ForeColor = Color.White;
                        Prize8.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize8.ForeColor = Color.White;
                        break;
                    case 10:
                        Prize10.BackgroundImage = Properties.Resources.BasicButton;
                        Prize10.ForeColor = Color.White;
                        Prize9.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize9.ForeColor = Color.White;
                        break;
                    case 11:
                        Prize11.BackgroundImage = Properties.Resources.BasicButton;
                        Prize11.ForeColor = Color.White;
                        Prize10.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize10.ForeColor = Color.White;
                        break;
                    case 12:
                        Prize12.BackgroundImage = Properties.Resources.BasicButton;
                        Prize12.ForeColor = Color.White;
                        Prize11.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize11.ForeColor = Color.White;
                        break;
                }
            }
            else
            {
                resetingButtons();
                switch (questionNumber)
                {
                    case 1:
                        Prize1.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize1.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion1();
                        ButtonContinue.Visible = false;
                        break;
                    case 2:
                        Prize2.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize2.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion2();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 3:
                        Prize3.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize3.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion3();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 4:
                        Prize4.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize4.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion4();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 5:
                        Prize5.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize5.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion5();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 6:
                        Prize6.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize6.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion6();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 7:
                        Prize7.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize7.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion7();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 8:
                        Prize8.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize8.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion8();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 9:
                        Prize9.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize9.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion9();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 10:
                        Prize10.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize10.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion10();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 11:
                        Prize11.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize11.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion11();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                    case 12:
                        Prize12.BackgroundImage = Properties.Resources.CheckingButton;
                        Prize12.ForeColor = Color.Black;
                        currentQuestion = bases.getQuestion12();
                        ButtonContinue.Text = "REZYGNUJ";
                        resignPosibility = true;
                        break;
                }
                QuestionText.Text = currentQuestion.task;
                Random xd = new Random();
                int optionPlace = xd.Next(1, 5);
                if (optionPlace == 1)
                {
                    AnswerA.Text = currentQuestion.rightAnswer;
                    int randomix = xd.Next(1, 4);
                    switch (randomix)
                    {
                        case 1:
                            AnswerB.Text = currentQuestion.wrongAnswer1;
                            int randomixx = xd.Next(0, 2);
                            if (randomixx == 0)
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer2;
                                AnswerD.Text = currentQuestion.wrongAnswer3;
                            }
                            else
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer3;
                                AnswerD.Text = currentQuestion.wrongAnswer2;
                            }
                            break;
                        case 2:
                            AnswerB.Text = currentQuestion.wrongAnswer2;
                            int randomixxx = xd.Next(0, 2);
                            if (randomixxx == 0)
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer1;
                                AnswerD.Text = currentQuestion.wrongAnswer3;
                            }
                            else
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer3;
                                AnswerD.Text = currentQuestion.wrongAnswer1;
                            }
                            break;
                        case 3:
                            AnswerB.Text = currentQuestion.wrongAnswer3;
                            int randomixxxx = xd.Next(0, 2);
                            if (randomixxxx == 0)
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer1;
                                AnswerD.Text = currentQuestion.wrongAnswer2;
                            }
                            else
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer2;
                                AnswerD.Text = currentQuestion.wrongAnswer1;
                            }
                            break;
                    }
                }
                else if(optionPlace == 2)
                {
                    AnswerB.Text = currentQuestion.rightAnswer;
                    int randomix = xd.Next(1, 4);
                    switch (randomix)
                    {
                        case 1:
                            AnswerA.Text = currentQuestion.wrongAnswer1;
                            int randomixx = xd.Next(0, 2);
                            if (randomixx == 0)
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer2;
                                AnswerD.Text = currentQuestion.wrongAnswer3;
                            }
                            else
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer3;
                                AnswerD.Text = currentQuestion.wrongAnswer2;
                            }
                            break;
                        case 2:
                            AnswerA.Text = currentQuestion.wrongAnswer2;
                            int randomixxx = xd.Next(0, 2);
                            if (randomixxx == 0)
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer1;
                                AnswerD.Text = currentQuestion.wrongAnswer3;
                            }
                            else
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer3;
                                AnswerD.Text = currentQuestion.wrongAnswer1;
                            }
                            break;
                        case 3:
                            AnswerA.Text = currentQuestion.wrongAnswer3;
                            int randomixxxx = xd.Next(0, 2);
                            if (randomixxxx == 0)
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer1;
                                AnswerD.Text = currentQuestion.wrongAnswer2;
                            }
                            else
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer2;
                                AnswerD.Text = currentQuestion.wrongAnswer1;
                            }
                            break;
                    }
                }
                else if(optionPlace == 3)
                {
                    AnswerC.Text = currentQuestion.rightAnswer;
                    int randomix  = xd.Next(1, 4);
                    switch (randomix)
                    {
                        case 1:
                            AnswerA.Text = currentQuestion.wrongAnswer1;
                            int randomixx = xd.Next(0, 2);
                            if (randomixx == 0)
                            {
                                AnswerB.Text = currentQuestion.wrongAnswer2;
                                AnswerD.Text = currentQuestion.wrongAnswer3;
                            }
                            else
                            {
                                AnswerB.Text = currentQuestion.wrongAnswer3;
                                AnswerD.Text = currentQuestion.wrongAnswer2;
                            }
                            break;
                        case 2:
                            AnswerA.Text = currentQuestion.wrongAnswer2;
                            int randomixxx = xd.Next(0, 2);
                            if (randomixxx == 0)
                            {
                                AnswerB.Text = currentQuestion.wrongAnswer1;
                                AnswerD.Text = currentQuestion.wrongAnswer3;
                            }
                            else
                            {
                                AnswerB.Text = currentQuestion.wrongAnswer3;
                                AnswerD.Text = currentQuestion.wrongAnswer1;
                            }
                            break;
                        case 3:
                            AnswerA.Text = currentQuestion.wrongAnswer3;
                            int randomixxxx = xd.Next(0, 2);
                            if (randomixxxx == 0)
                            {
                                AnswerB.Text = currentQuestion.wrongAnswer1;
                                AnswerD.Text = currentQuestion.wrongAnswer2;
                            }
                            else
                            {
                                AnswerB.Text = currentQuestion.wrongAnswer2;
                                AnswerD.Text = currentQuestion.wrongAnswer1;
                            }
                            break;
                    }
                }
                else
                {
                    AnswerD.Text = currentQuestion.rightAnswer;
                    int randomix  = xd.Next(1, 4);
                    switch (randomix)
                    {
                        case 1:
                            AnswerA.Text = currentQuestion.wrongAnswer1;
                            int randomixx = xd.Next(0, 2);
                            if (randomixx == 0)
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer2;
                                AnswerB.Text = currentQuestion.wrongAnswer3;
                            }
                            else
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer3;
                                AnswerB.Text = currentQuestion.wrongAnswer2;
                            }
                            break;
                        case 2:
                            AnswerA.Text = currentQuestion.wrongAnswer2;
                            int randomixxx = xd.Next(0, 2);
                            if (randomixxx == 0)
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer1;
                                AnswerB.Text = currentQuestion.wrongAnswer3;
                            }
                            else
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer3;
                                AnswerB.Text = currentQuestion.wrongAnswer1;
                            }
                            break;
                        case 3:
                            AnswerA.Text = currentQuestion.wrongAnswer3;
                            int randomixxxx = xd.Next(0, 2);
                            if (randomixxxx == 0)
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer1;
                                AnswerB.Text = currentQuestion.wrongAnswer2;
                            }
                            else
                            {
                                AnswerC.Text = currentQuestion.wrongAnswer2;
                                AnswerB.Text = currentQuestion.wrongAnswer1;
                            }
                            break;
                    }
                
                        
                      
                }
            }
        }

        private void resetingButtons()
        {
            if(!using50)
            {
                Helpdesk5050.Enabled = true;
            }
            else
            {
                Helpdesk5050.Enabled = false;
            }
            if (!usingAudience)
            {
                HelpdeskAudience.Enabled = true;
            }
            else
            {
                HelpdeskAudience.Enabled = false;
            }
            if (!usingSwap)
            {
                HelpdeskSwap.Enabled = true;
            }
            else
            {
                HelpdeskSwap.Enabled = false;
            }
            LetterA.Visible = false;
            LetterB.Visible = false;
            LetterC.Visible = false;
            LetterD.Visible = false;
            AudienceResults.Visible = false;
            isUsing5050 = false;
            AnswerA.Enabled = true;
            AnswerB.Enabled = true;
            AnswerC.Enabled = true;
            AnswerD.Enabled = true;
            PanelPoll.Visible = false;
            AnswerA.BackgroundImage = Properties.Resources.BasicButtonA2;
            AnswerA.ForeColor = Color.White;
            AnswerB.BackgroundImage = Properties.Resources.BasicButtonB;
            AnswerB.ForeColor = Color.White;
            AnswerC.BackgroundImage = Properties.Resources.BasicButtonC;
            AnswerC.ForeColor = Color.White;
            AnswerD.BackgroundImage = Properties.Resources.BasicButtonD;
            AnswerD.ForeColor = Color.White;
            Prize1.BackgroundImage = Properties.Resources.BasicButton;
            Prize1.ForeColor = Color.White;
            Prize2.BackgroundImage = Properties.Resources.GuarantedButton;
            Prize2.ForeColor = Color.Black;
            Prize3.BackgroundImage = Properties.Resources.BasicButton;
            Prize3.ForeColor = Color.White;
            Prize4.BackgroundImage = Properties.Resources.BasicButton;
            Prize4.ForeColor = Color.White;
            Prize5.BackgroundImage = Properties.Resources.BasicButton;
            Prize5.ForeColor = Color.White;
            Prize6.BackgroundImage = Properties.Resources.BasicButton;
            Prize6.ForeColor = Color.White;
            Prize7.BackgroundImage = Properties.Resources.GuarantedButton;
            Prize7.ForeColor = Color.Black;
            Prize8.BackgroundImage = Properties.Resources.BasicButton;
            Prize8.ForeColor = Color.White;
            Prize9.BackgroundImage = Properties.Resources.BasicButton;
            Prize9.ForeColor = Color.White;
            Prize10.BackgroundImage = Properties.Resources.BasicButton;
            Prize10.ForeColor = Color.White;
            Prize11.BackgroundImage = Properties.Resources.BasicButton;
            Prize11.ForeColor = Color.White;
            Prize12.BackgroundImage = Properties.Resources.GuarantedButton;
            Prize12.ForeColor = Color.Black;
        }

        private void AnswerA_Click(object sender, EventArgs e)
        {
            AnswerA.BackgroundImage = Properties.Resources.CheckingButtonA;
            answerCheck(AnswerA);
            Thread.Sleep(2000);
        }

        private void AnswerB_Click(object sender, EventArgs e)
        {
            AnswerB.BackgroundImage = Properties.Resources.CheckingButtonB;
            answerCheck(AnswerB);
            Thread.Sleep(2000);
        }

        private void AnswerC_Click(object sender, EventArgs e)
        {
            AnswerC.BackgroundImage = Properties.Resources.CheckingButtonC;
            answerCheck(AnswerC);
            Thread.Sleep(2000);
        }

        private void AnswerD_Click(object sender, EventArgs e)
        {
            AnswerD.BackgroundImage = Properties.Resources.CheckingButtonD;
            answerCheck(AnswerD);
            Thread.Sleep(2000);
        }
        private void answerCheck(Button selectedOption)
        {
            resignPosibility = false;
            Helpdesk5050.Enabled = false;
            HelpdeskAudience.Enabled = false;
            HelpdeskSwap.Enabled = false;
            AnswerA.Enabled = false;
            AnswerB.Enabled = false;
            AnswerC.Enabled = false;
            AnswerD.Enabled = false;
            if (currentQuestion.checkAnswer(selectedOption.Text))
            {
                selectedOption.ForeColor = Color.White;
                if (selectedOption == AnswerA)
                {
                    selectedOption.BackgroundImage = Properties.Resources.RightAnswerA;
                }
                else if (selectedOption == AnswerB)
                {
                    selectedOption.BackgroundImage = Properties.Resources.RightAnswerB;
                }
                else if (selectedOption == AnswerC)
                {
                    selectedOption.BackgroundImage = Properties.Resources.RightAnswerC;
                }
                else
                {
                    selectedOption.BackgroundImage = Properties.Resources.RightAnswerD;
                }
                ButtonContinue.Visible = true;
                switch (questionNumber)
                {
                    case 1:
                        Prize1.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize1.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 2:
                        Prize2.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize2.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 3:
                        Prize3.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize3.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 4:
                        Prize4.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize4.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 5:
                        Prize5.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize5.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 6:
                        Prize6.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize6.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 7:
                        Prize7.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize7.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 8:
                        Prize8.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize8.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 9:
                        Prize9.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize9.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 10:
                        Prize10.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize10.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 11:
                        Prize11.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize11.ForeColor = Color.White;
                        ButtonContinue.Text = "NASTĘPNE PYTANIE";
                        break;
                    case 12:
                        Prize12.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize12.ForeColor = Color.White;
                        finish = true;
                        ButtonContinue.Text = "KONTYNUUJ";
                        break;
                }
                questionNumber++;
            }
            else
            {
                finish = true;
                selectedOption.ForeColor = Color.White;
                if (selectedOption == AnswerA)
                {
                    selectedOption.BackgroundImage = Properties.Resources.WrongAnswerA;
                }
                else if (selectedOption == AnswerB)
                {
                    selectedOption.BackgroundImage = Properties.Resources.WrongAnswerB;
                }
                else if (selectedOption == AnswerC)
                {
                    selectedOption.BackgroundImage = Properties.Resources.WrongAnswerC;
                }
                else
                {
                    selectedOption.BackgroundImage = Properties.Resources.WrongAnswerD;
                }
                ButtonContinue.Visible = true;
                ButtonContinue.Text = "KONTYNUUJ";
                if(currentQuestion.checkAnswer(AnswerA.Text))
                {
                    AnswerA.BackgroundImage = Properties.Resources.RightAnswerA;
                    AnswerA.ForeColor = Color.White;
                }
                else if (currentQuestion.checkAnswer(AnswerB.Text))
                {
                    AnswerB.BackgroundImage = Properties.Resources.RightAnswerB;
                    AnswerB.ForeColor = Color.White;
                }
                else if (currentQuestion.checkAnswer(AnswerC.Text))
                {
                    AnswerC.BackgroundImage = Properties.Resources.RightAnswerC;
                    AnswerC.ForeColor = Color.White;
                }
                else
                {
                    AnswerD.BackgroundImage = Properties.Resources.RightAnswerD;
                    AnswerD.ForeColor = Color.White;
                }
                switch (questionNumber)
                {
                    case 1:
                        Prize1.BackgroundImage = Properties.Resources.BasicButton;
                        Prize1.ForeColor = Color.White;
                        break;
                    case 2:
                        Prize2.BackgroundImage = Properties.Resources.GuarantedButton;
                        Prize2.ForeColor = Color.Black;
                        break;
                    case 3:
                        Prize3.BackgroundImage = Properties.Resources.BasicButton;
                        Prize3.ForeColor = Color.White;
                        Prize2.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize2.ForeColor = Color.White;
                        break;
                    case 4:
                        Prize4.BackgroundImage = Properties.Resources.BasicButton;
                        Prize4.ForeColor = Color.White;
                        Prize2.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize2.ForeColor = Color.White;
                        break;
                    case 5:
                        Prize5.BackgroundImage = Properties.Resources.BasicButton;
                        Prize5.ForeColor = Color.White;
                        Prize2.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize2.ForeColor = Color.White;
                        break;
                    case 6:
                        Prize6.BackgroundImage = Properties.Resources.BasicButton;
                        Prize6.ForeColor = Color.White;
                        Prize2.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize2.ForeColor = Color.White;
                        break;
                    case 7:
                        Prize7.BackgroundImage = Properties.Resources.GuarantedButton;
                        Prize7.ForeColor = Color.Black;
                        Prize2.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize2.ForeColor = Color.White;
                        break;
                    case 8:
                        Prize8.BackgroundImage = Properties.Resources.BasicButton;
                        Prize8.ForeColor = Color.White;
                        Prize7.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize7.ForeColor = Color.White;
                        break;
                    case 9:
                        Prize9.BackgroundImage = Properties.Resources.BasicButton;
                        Prize9.ForeColor = Color.White;
                        Prize7.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize7.ForeColor = Color.White;
                        break;
                    case 10:
                        Prize10.BackgroundImage = Properties.Resources.BasicButton;
                        Prize10.ForeColor = Color.White;
                        Prize7.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize7.ForeColor = Color.White;
                        break;
                    case 11:
                        Prize11.BackgroundImage = Properties.Resources.BasicButton;
                        Prize11.ForeColor = Color.White;
                        Prize7.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize7.ForeColor = Color.White;
                        break;
                    case 12:
                        Prize12.BackgroundImage = Properties.Resources.GuarantedButton;
                        Prize12.ForeColor = Color.Black;
                        Prize7.BackgroundImage = Properties.Resources.RightAnswer;
                        Prize7.ForeColor = Color.White;
                        break;
                }
                if (questionNumber < 3)
                {
                    questionNumber = 1;
                }
                else if(questionNumber <= 7 && questionNumber >= 3)
                {
                    questionNumber = 3;
                }
                else
                {
                    questionNumber = 8;
                }
            }
        }
        private void finito()
        {
            Form3 window;
            window = new Form3(questionNumber);
            window.setForm1Form(this.form1Form);
            window.Show();
            this.Dispose();
            }

        private void HelpdeskSwap_Click(object sender, EventArgs e)
        {
            usingSwap = true;
            HelpdeskSwap.BackgroundImage = Properties.Resources.SwapUsed;
            resetingButtons();
            Question pomocniczy = null;
            switch (questionNumber)
            {
                case 1:
                    Prize1.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize1.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion1();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Visible = false;
                    break;
                case 2:
                    Prize2.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize2.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion2();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 3:
                    Prize3.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize3.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion3();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 4:
                    Prize4.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize4.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion4();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 5:
                    Prize5.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize5.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion5();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 6:
                    Prize6.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize6.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion6();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 7:
                    Prize7.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize7.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion7();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 8:
                    Prize8.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize8.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion8();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 9:
                    Prize9.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize9.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion9();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 10:
                    Prize10.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize10.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion10();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 11:
                    Prize11.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize11.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion11();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
                case 12:
                    Prize12.BackgroundImage = Properties.Resources.CheckingButton;
                    Prize12.ForeColor = Color.Black;
                    do
                    {
                        pomocniczy = bases.getQuestion12();
                    } while (pomocniczy == currentQuestion);
                    ButtonContinue.Text = "REZYGNUJ";
                    resignPosibility = true;
                    break;
            }
            currentQuestion = pomocniczy;
            QuestionText.Text = currentQuestion.task;
            Random xd = new Random();
            int optionPlace = xd.Next(1, 5);
            switch (optionPlace)
            {
                case 1:
                    AnswerA.Text = currentQuestion.rightAnswer;
                    AnswerB.Text = currentQuestion.wrongAnswer1;
                    AnswerC.Text = currentQuestion.wrongAnswer2;
                    AnswerD.Text = currentQuestion.wrongAnswer3;
                    break;
                case 2:
                    AnswerB.Text = currentQuestion.rightAnswer;
                    AnswerD.Text = currentQuestion.wrongAnswer1;
                    AnswerA.Text = currentQuestion.wrongAnswer2;
                    AnswerC.Text = currentQuestion.wrongAnswer3;
                    break;
                case 3:
                    AnswerC.Text = currentQuestion.rightAnswer;
                    AnswerA.Text = currentQuestion.wrongAnswer1;
                    AnswerD.Text = currentQuestion.wrongAnswer2;
                    AnswerB.Text = currentQuestion.wrongAnswer3;
                    break;
                case 4:
                    AnswerD.Text = currentQuestion.rightAnswer;
                    AnswerC.Text = currentQuestion.wrongAnswer1;
                    AnswerB.Text = currentQuestion.wrongAnswer2;
                    AnswerA.Text = currentQuestion.wrongAnswer3;
                    break;
            }
        }

        private void Helpdesk5050_Click(object sender, EventArgs e)
        {
            using50 = true;
            isUsing5050 = true;
            Helpdesk5050.BackgroundImage = Properties.Resources.FiftyUsed;
            Helpdesk5050.Enabled = false;
            Random xd = new Random();
            int optionPlace = xd.Next(1, 5);
            switch (optionPlace)
            {
                case 1:
                    if(!(currentQuestion.checkAnswer(AnswerA.Text)))
                    {
                        AnswerA.Enabled = false;
                        AnswerA.Text = "";
                    }
                    else
                    {
                        AnswerC.Enabled = false;
                        AnswerC.Text = "";
                    }
                    if (!(currentQuestion.checkAnswer(AnswerB.Text)))
                    {
                        AnswerB.Enabled = false;
                        AnswerB.Text = "";
                    }
                    else
                    {
                        AnswerC.Enabled = false;
                        AnswerC.Text = "";
                    }
                    break;
                case 2:
                    if (!(currentQuestion.checkAnswer(AnswerC.Text)))
                    {
                        AnswerC.Enabled = false;
                        AnswerC.Text = "";
                    }
                    else
                    {
                        AnswerA.Enabled = false;
                        AnswerA.Text = "";
                    }
                    if (!(currentQuestion.checkAnswer(AnswerD.Text)))
                    {
                        AnswerD.Enabled = false;
                        AnswerD.Text = "";
                    }
                    else
                    {
                        AnswerA.Enabled = false;
                        AnswerA.Text = "";
                    }
                    break;
                case 3:
                    if (!(currentQuestion.checkAnswer(AnswerB.Text)))
                    {
                        AnswerB.Enabled = false;
                        AnswerB.Text = "";
                    }
                    else
                    {
                        AnswerD.Enabled = false;
                        AnswerD.Text = "";
                    }
                    if (!(currentQuestion.checkAnswer(AnswerC.Text)))
                    {
                        AnswerC.Enabled = false;
                        AnswerC.Text = "";
                    }
                    else
                    {
                        AnswerD.Enabled = false;
                        AnswerD.Text = "";
                    }
                    break;
                case 4:
                    if (!(currentQuestion.checkAnswer(AnswerA.Text)))
                    {
                        AnswerA.Enabled = false;
                        AnswerA.Text = "";
                    }
                    else
                    {
                        AnswerB.Enabled = false;
                        AnswerB.Text = "";
                    }
                    if (!(currentQuestion.checkAnswer(AnswerD.Text)))
                    {
                        AnswerD.Enabled = false;
                        AnswerD.Text = "";
                    }
                    else
                    {
                        AnswerB.Enabled = false;
                        AnswerB.Text = "";
                    }
                    break;
            }
        }

        private void HelpdeskAudience_Click(object sender, EventArgs e)
        {
            PanelPoll.Visible = true;
            usingAudience = true;
            HelpdeskAudience.BackgroundImage = Properties.Resources.AudienceUsed;
            HelpdeskAudience.Enabled = false;
            AudienceResults.Visible = true;
            LetterA.Visible = true;
            LetterB.Visible = true;
            LetterC.Visible = true;
            LetterD.Visible = true;
            Random xd = new Random();
            if(questionNumber < 8)
            {
                if (!isUsing5050)
                {
                    int sume = 0;
                    int[] table = new int[4];
                    table[0] = xd.Next(0, 101);
                    sume += table[0];
                    table[1] = xd.Next(0, 101 - sume);
                    sume += table[1];
                    table[2] = xd.Next(0, 101 - sume);
                    sume += table[2];
                    table[3] = 100 - sume;
                    Array.Sort(table);
                    if (currentQuestion.checkAnswer(AnswerA.Text))
                    {
                        AudienceResults.Series[0].Points[0].YValues[0] = table[3];
                        int randomix = xd.Next(1, 4);
                        switch (randomix)
                        {
                            case 1:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[0];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                            case 2:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[1];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                break;
                            case 3:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[2];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                        }
                    }
                    else if (currentQuestion.checkAnswer(AnswerB.Text))
                    {
                        AudienceResults.Series[0].Points[1].YValues[0] = table[3];
                        int randomix = xd.Next(1, 4);
                        switch (randomix)
                        {
                            case 1:
                                AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                            case 2:
                                AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                break;
                            case 3:
                                AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                        }
                    }
                    else if (currentQuestion.checkAnswer(AnswerC.Text))
                    {
                        AudienceResults.Series[0].Points[2].YValues[0] = table[3];
                        int randomix = xd.Next(1, 4);
                        switch (randomix)
                        {
                            case 1:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[0];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                            case 2:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[1];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                break;
                            case 3:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[2];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                        }
                    }
                    else
                    {
                        AudienceResults.Series[0].Points[3].YValues[0] = table[3];
                        int randomix = xd.Next(1, 4);
                        switch (randomix)
                        {
                            case 1:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[0];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                }
                                break;
                            case 2:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[1];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                }
                                break;
                            case 3:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[2];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                }
                                break;
                        }
                    }
                }
                else
                {
                    int higher = xd.Next(50, 101);
                    int rest = 100 - higher;
                    if (currentQuestion.checkAnswer(AnswerA.Text))
                    {
                        AudienceResults.Series[0].Points[0].YValues[0] = higher;
                        if (AnswerB.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[1].YValues[0] = rest;
                        }
                        else if (AnswerC.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[2].YValues[0] = rest;
                        }
                        else
                        {
                            AudienceResults.Series[0].Points[3].YValues[0] = rest;
                        }
                    }
                    else if (currentQuestion.checkAnswer(AnswerB.Text))
                    {
                        AudienceResults.Series[0].Points[1].YValues[0] = higher;
                        if (AnswerA.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[0].YValues[0] = rest;
                        }
                        else if (AnswerC.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[2].YValues[0] = rest;
                        }
                        else
                        {
                            AudienceResults.Series[0].Points[3].YValues[0] = rest;
                        }
                    }
                    else if (currentQuestion.checkAnswer(AnswerC.Text))
                    {
                        AudienceResults.Series[0].Points[2].YValues[0] = higher;
                        if (AnswerA.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[0].YValues[0] = rest;
                        }
                        else if (AnswerB.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[1].YValues[0] = rest;
                        }
                        else
                        {
                            AudienceResults.Series[0].Points[3].YValues[0] = rest;
                        }
                    }
                    else
                    {
                        AudienceResults.Series[0].Points[3].YValues[0] = higher;
                        if (AnswerA.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[0].YValues[0] = rest;
                        }
                        else if (AnswerB.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[1].YValues[0] = rest;
                        }
                        else
                        {
                            AudienceResults.Series[0].Points[2].YValues[0] = rest;
                        }
                    }
                }
            }
            else
            {
                if (!isUsing5050)
                {
                    int sume = 0;
                    int[] table = new int[4];
                    table[3] = xd.Next(25, 101);
                    sume += table[3];
                    table[1] = xd.Next(0, 101 - sume);
                    sume += table[1];
                    table[2] = xd.Next(0, 101 - sume);
                    sume += table[2];
                    table[0] = 100 - sume;
                    if (currentQuestion.checkAnswer(AnswerA.Text))
                    {
                        AudienceResults.Series[0].Points[0].YValues[0] = table[3];
                        int randomix = xd.Next(1, 4);
                        switch (randomix)
                        {
                            case 1:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[0];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                            case 2:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[1];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                break;
                            case 3:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[2];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                        }
                    }
                    else if (currentQuestion.checkAnswer(AnswerB.Text))
                    {
                        AudienceResults.Series[0].Points[1].YValues[0] = table[3];
                        int randomix = xd.Next(1, 4);
                        switch (randomix)
                        {
                            case 1:
                                AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                            case 2:
                                AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                break;
                            case 3:
                                AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                        }
                    }
                    else if (currentQuestion.checkAnswer(AnswerC.Text))
                    {
                        AudienceResults.Series[0].Points[2].YValues[0] = table[3];
                        int randomix = xd.Next(1, 4);
                        switch (randomix)
                        {
                            case 1:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[0];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                            case 2:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[1];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                break;
                            case 3:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[2];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[0];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[3].YValues[0] = table[1];
                                }
                                break;
                        }
                    }
                    else
                    {
                        AudienceResults.Series[0].Points[3].YValues[0] = table[3];
                        int randomix = xd.Next(1, 4);
                        switch (randomix)
                        {
                            case 1:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[0];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                }
                                break;
                            case 2:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[1];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[2];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[2];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                }
                                break;
                            case 3:
                                AudienceResults.Series[0].Points[1].YValues[0] = table[2];
                                randomix = xd.Next(0, 2);
                                if (randomix == 0)
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[1];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[0];
                                }
                                else
                                {
                                    AudienceResults.Series[0].Points[2].YValues[0] = table[0];
                                    AudienceResults.Series[0].Points[0].YValues[0] = table[1];
                                }
                                break;
                        }
                    }
                }
                else
                {
                    int higher = xd.Next(33, 101);
                    int rest = 100 - higher;
                    if (currentQuestion.checkAnswer(AnswerA.Text))
                    {
                        AudienceResults.Series[0].Points[0].YValues[0] = higher;
                        if (AnswerB.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[1].YValues[0] = rest;
                        }
                        else if (AnswerC.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[2].YValues[0] = rest;
                        }
                        else
                        {
                            AudienceResults.Series[0].Points[3].YValues[0] = rest;
                        }
                    }
                    else if (currentQuestion.checkAnswer(AnswerB.Text))
                    {
                        AudienceResults.Series[0].Points[1].YValues[0] = higher;
                        if (AnswerA.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[0].YValues[0] = rest;
                        }
                        else if (AnswerC.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[2].YValues[0] = rest;
                        }
                        else
                        {
                            AudienceResults.Series[0].Points[3].YValues[0] = rest;
                        }
                    }
                    else if (currentQuestion.checkAnswer(AnswerC.Text))
                    {
                        AudienceResults.Series[0].Points[2].YValues[0] = higher;
                        if (AnswerA.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[0].YValues[0] = rest;
                        }
                        else if (AnswerB.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[1].YValues[0] = rest;
                        }
                        else
                        {
                            AudienceResults.Series[0].Points[3].YValues[0] = rest;
                        }
                    }
                    else
                    {
                        AudienceResults.Series[0].Points[3].YValues[0] = higher;
                        if (AnswerA.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[0].YValues[0] = rest;
                        }
                        else if (AnswerB.Enabled == true)
                        {
                            AudienceResults.Series[0].Points[1].YValues[0] = rest;
                        }
                        else
                        {
                            AudienceResults.Series[0].Points[2].YValues[0] = rest;
                        }
                    }
                }
            }
        }

        private void QuestionText_Click(object sender, EventArgs e)
        {

        }
    }
}
