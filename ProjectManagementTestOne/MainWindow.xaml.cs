using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ControllerLibrary;
using ControllerLibrary.interfaces;
using DomainLibrary;

namespace ProjectManagementTestOne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables and Constructor
        Random rand;

        IRepository<Chapter, int> chapterController;
        IRepository<Question, int> questionController;
        IAnswerRepository answerController;

        private List<Question> questionList;

        TextBlock questionLabel;

        public MainWindow()
        {    
            InitializeComponent();
            rand = new Random();
            chapterController = new ChapterController();
            questionController = new QuestionController();
            answerController = new AnswersController();

            questionList = questionController.getAllItems();

            questionLabel = new TextBlock();
            questionLabel.TextWrapping = TextWrapping.Wrap;
            double all = 10;
            questionLabel.Margin = new Thickness(all);
            Grid.SetRow(questionLabel, 1);
            Grid.SetColumn(questionLabel, 0);
            Grid.SetColumnSpan(questionLabel, 2);
            mainGrid.Children.Add(questionLabel);

            //Initialize value and question
            HUD.value = next();
            nextQuestion();
            this.Title = "" + HUD.number;
        }
        #endregion

        #region Event Handlers and UIElement

        public void createChoices()
        {
            var random = rand.Next(0, 4);
            var questionID = HUD.question.QuestionID;
            var answer = answerController.getAnswerByQuestionID(questionID);
            switch(random) {
                case 0:
                    radioOne.Content = answer.AnswerOne;
                    radioTwo.Content = answer.AnswerTwo;
                    radioThree.Content = answer.AnswerThree;
                    radioFour.Content = answer.AnswerFour;
                    break;
                case 1:
                    radioOne.Content = answer.AnswerFour;
                    radioTwo.Content = answer.AnswerOne;
                    radioThree.Content = answer.AnswerTwo;
                    radioFour.Content = answer.AnswerThree;
                    break;
                case 2:
                    radioOne.Content = answer.AnswerThree;
                    radioTwo.Content = answer.AnswerFour;
                    radioThree.Content = answer.AnswerOne;
                    radioFour.Content = answer.AnswerTwo;
                    break;
                case 3:
                    radioOne.Content = answer.AnswerTwo;
                    radioTwo.Content = answer.AnswerThree;
                    radioThree.Content = answer.AnswerFour;
                    radioFour.Content = answer.AnswerOne;
                    break;
            }
            if (!String.IsNullOrEmpty(answer.AnswerFive))
            {
                radioFive.Content = answer.AnswerFive;
                radioFive.Visibility = Visibility.Visible;
            }
        }

        private void submitClick(object sender, RoutedEventArgs e)
        {
            //conditions
            //if 0 get answer messagebox that says you ahve to answer
            //if correct or not
            int answer = getAnswerFromChoices();
            
            if (answer == 0)
            {
                MessageBox.Show("You have to answer the question!!");
            }
            else
            {
                questionIsAnswered();
                if (checkAnswer(answer))
                    HUD.score++;
                else
                    showCorrectAnswer();

                bool finished = questionList.All(q => q.IsAnswered == true);
                if (finished)
                {
                    finish();
                    btnTryAgain.IsEnabled = true;
                }
                else
                {
                    //Reset Value and Contents
                    clearChoices();
                    nextQuestion();
                    HUD.number++;
                    this.Title = "" + HUD.number;
                }  
            }
        }

        private void tryagain(object sender, RoutedEventArgs e)
        {
            reset();
        }
        #endregion

        #region Utiliy Methods
        private void nextQuestion()
        {
            HUD.value = next();
            HUD.question = questionList[HUD.value];
            createChoices();
            printQuestion();
        }

        private void printQuestion()
        {
            questionLabel.Text = HUD.question.QuestionName;
        }

        private void questionIsAnswered()
        {
            HUD.question.IsAnswered = true;
        }

        private int next()
        {
            int value = rand.Next(0, questionList.Count);

            while (questionList[value].IsAnswered)
            {
                value = rand.Next(0, questionList.Count);
            }

            return value;
        }

        private void clearChoices()
        {
            radioOne.Content = "";
            radioTwo.Content = "";
            radioThree.Content = "";
            radioFour.Content = "";
            radioFive.Visibility = Visibility.Hidden;
            radioFive.Content = "";
            radioOne.IsChecked = false;
            radioTwo.IsChecked = false;
            radioThree.IsChecked = false;
            radioFour.IsChecked = false;
            radioFive.IsChecked = false;
            
        }

        private int getAnswerFromChoices()
        {
            int value = 0;
            if (radioOne.IsChecked == true)
            {
                value = 1;
            }
            else if (radioTwo.IsChecked == true)
            {
                value = 2;
            }
            else if (radioThree.IsChecked == true)
            {
                value = 3;
            }
            else if (radioFour.IsChecked == true)
            {
                value = 4;
            }
            else if (radioFive.IsChecked == true)
            {
                value = 5;
            }
            return value;
        }

        private bool checkAnswer(int answer)
        {
            bool value = false;
            var ans = numberToChar(answer);
            if (HUD.question.Answer == ans)
                value = true;
            return value;
        }

        private void showCorrectAnswer()
        {
            int answerNumber = charToNumber(HUD.question.Answer);
            string answer = "";
            var a = answerController.getAnswerByQuestionID(HUD.question.QuestionID);
            switch (answerNumber)
            {
                case 1:
                    answer = a.AnswerOne;
                    break;
                case 2:
                    answer = a.AnswerTwo;
                    break;
                case 3:
                    answer = a.AnswerThree;
                    break;
                case 4:
                    answer = a.AnswerFour;
                    break;
                case 5:
                    answer = a.AnswerFive;
                    break;
            }
            MessageBox.Show("Wrong the answer was *" + answer + "*");
        }

        private void finish()
        {
            MessageBox.Show("Your score is " + HUD.score + "/" + questionList.Count);
        }

        private void reset()
        {
            clearChoices();
            HUD.score = 0;
            HUD.number = 1;
            questionList.ForEach(q => q.IsAnswered = false);
            nextQuestion();
            printQuestion();
        }
        #endregion

        #region Conversions
        private char numberToChar(int j)
        {
            char letter = 'a';

            if (j == 1) letter = 'a';
            else if (j == 2) letter = 'b';
            else if (j == 3) letter = 'c';
            else if (j == 4) letter = 'd';
            else if (j == 5) letter = 'e';

            return letter;
        }

        private int charToNumber(char ans)
        {
            int temp = 0;

            if (ans == 'a') temp = 1;
            else if (ans == 'b') temp = 2;
            else if (ans == 'c') temp = 3;
            else if (ans == 'd') temp = 4;
            else if (ans == 'e') temp = 5;

            return temp;
        }
        #endregion
    }
}
