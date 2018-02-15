 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace RepoApp
{
    class Menu
    {
        string url;
        string commitComment;
        ConsoleKey currentlyPressed;


        public void MainMenu()
        {
            Console.WriteLine(
                  "-----------------------" +
                "\n** M A I N   M E N U **\n" +
                  "-----------------------");
            Console.WriteLine("What would you like to do? Type in a number then press enter\n" +
                "[1]Create New Repository\n" +
                "[2]Update Existing Repository\n" +
                "[3]Commit/Push Local Repository\n" +
                "[4]Revert Repository");
            int input = Convert.ToInt16(Console.ReadLine());
            switch (input)
            {
                case 1:
                    NewRepo();
                    break;
                case 2:
                    UpdateRepo();
                    break;
                case 3:
                    CommitPushRepo();
                    break;
                case 4:
                    RevertRepo();
                    break;
                default:
                    NewRepo();
                    break;
            }
        }

        public void NewRepo()
        {
            Console.Clear();
            Console.WriteLine("Please enter in a url (ex. https://www.example.com)");
            url = Console.ReadLine();

            string originalPath = Environment.CurrentDirectory;
            string repoPath = Path.GetFullPath(Path.Combine(originalPath, @"..\..\..\"));
            string finalPath = repoPath + @"Local Repository\newRepoBatch.bat";
            Process.Start(finalPath, url);

            Console.WriteLine("Would you like to work inside a certain branch? Press [Y] or [N]");
            string userInput = Console.ReadLine();
            if (userInput == "Y" || userInput == "y")
            {
                BranchLocalRepo();
            }
        }

        public void BranchLocalRepo()
        {
            Console.Clear();
            Console.Write("Please enter your branch name: ");
            string branchName = Console.ReadLine();

        }

        public void UpdateRepo()
        {
            Console.Clear();

        }

        public void CommitPushRepo()
        {

            Console.Clear();
            Console.Write(
            "Please note that this action will commit and " +
            "push your changes.\n" +
            "Please enter the comment for your commit: ");
            commitComment = Console.ReadLine();
            string originalPath = Environment.CurrentDirectory;
            string repoPath = Path.GetFullPath(Path.Combine(originalPath, @"..\..\..\"));
            string finalPath = repoPath + @"Local Repository\commitPushBatch.bat";
            Process.Start(finalPath, commitComment);
        }

        public void RevertRepo()
        {

        }
    }
}
