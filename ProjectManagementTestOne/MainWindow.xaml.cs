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
        Random rand;

        IRepository<Chapter, int> chapterController;
        IRepository<Question, int> questionController;
        IRepository<Answer, int> answerController;

        private List<Question> questionList;

        Label questionLabel;

        public MainWindow()
        {    
            InitializeComponent();
            rand = new Random();
            chapterController = new ChapterController();
            questionController = new QuestionController();
            answerController = new AnswersController();

            this.Title = "" + HUD.score;

            questionList = questionController.getAllItems();

            questionLabel = new Label();
            questionLabel.Content = questionList[0].QuestionName;

            Grid.SetRow(questionLabel, 0);
            mainGrid.Children.Add(questionLabel);

            //Initialize value
            //HUD.value = next();
        }

        private void submitClick(object sender, RoutedEventArgs e)
        {
            HUD.value = next();
            questionLabel.Content = HUD.value;
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
    }
}
