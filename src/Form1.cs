using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Octokit;
using System.Net;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AutoInstaller
{
    public partial class Form1 : Form
    {
        private readonly GitHubClient _client;
        private readonly Dictionary<string, string> _reposList;
        public Form1(string token)
        {
            InitializeComponent();

            _client = new GitHubClient(new ProductHeaderValue("regata-jinr"));
            var tokenAuth = new Credentials(token);
            _client.Credentials = tokenAuth;

            _reposList = new Dictionary<string, string>
            {
                { "RegataDBC", @"https://github.com/regata-jinr/RegataDBC/releases/latest" },
                { "CalcConc", @"https://github.com/regata-jinr/CalcConc/releases/latest"},
                { "SearchOfStandards", @"https://github.com/regata-jinr/SearchOfStandards" }
            };

            Directory.CreateDirectory($"{AppContext.BaseDirectory}\\.temp");
        }


        private async void DownloadLatestSetupExe(string repo)
        {
            var release = await _client.Repository.Release.GetLatest("regata-jinr", repo);
            var asset = release.Assets.Where(a => a.Name == "Setup.exe").Last();

            using (var client = new WebClient())
            {
                client.DownloadFile(asset.Url, $".temp\\{_reposList[repo]}Setup.exe");
            }

            RunCommand($"{_reposList[repo]}Setup.exe");

        }

        private void RunCommand(string command, string args = "")
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = command;
                process.StartInfo.Arguments = args;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WorkingDirectory = $"{AppContext.BaseDirectory}\\.temp";
                process.Start();
            }
        }



        private async void GetFilesFromArchive()
        {
            var release = await _client.Repository.Release.GetLatest("regata-jinr", "");
            var asset = release.Assets.Where(a => a.Name == "sources.zip").Last();

            using (var client = new WebClient())
                client.DownloadFile(asset.Url, $".temp\\sources.zip");

            RunCommand("Expand-Archive", @"-Path .\sources.zip .");

            if (!Directory.Exists(@".temp\sources"))
                throw new DirectoryNotFoundException("Directory with sources files not found");
            else
                File.Delete(@".temp\sources.zip");


            Directory.Move(@".temp\WORKPROG", @"C:\");

            if (radioButtonRus.Checked)
                MoveAndRenameIssFiles("Rus");
            else
                MoveAndRenameIssFiles("Eng");

            RunCommand(@"sources\S504V3.2.1\\setup.exe", "/s");
            RunCommand(@"sources\S501V3.2.1\\setup.exe", "/s");
            RunCommand(@"sources\S506V3.2.1\\setup.exe", "/s");

            Directory.Delete(@".temp");

        }

        private void MoveAndRenameIssFiles(string pattern)
        {
            var dir = new DirectoryInfo(@".temp\sources\Genie2K_v3.2.1");
            var files = dir.GetFiles($"*{pattern}.iss");
            var reg = new Regex(@"\d{3}");

            foreach (var file in files)
            {
                var pack = reg.Match(file.Name).Value;
                file.MoveTo($"S{pack}V3.2.1\\setup.iss");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var repo in _reposList.Keys)
                DownloadLatestSetupExe(_reposList[repo]);

            GetFilesFromArchive();
        }
    }
}
