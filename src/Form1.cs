using System;
using System.Windows.Forms;
using System.Diagnostics;


// TODO: the main problem below is authintefication via token?
//      I don't need this because of all what I want to download is public.
//      Also it looks to much complex, via ps it should looks more easier.
//      And in case of this I need install dotnet core runtime for each machine.
//
// TODO: prepare storage for files with public access.
// TODO: prepare script for downloading:
// TODO: paramters genie viersion, genie language, installation of our software flags
// TODO: check if genie2k already exist - uninstall it for installing the new version?
// TODO: check if ttlcmd doesn't exist install it and move wcx file to directory of ttlcmd ftp and tcmd sucks!
// TODO: wrap sctript to gui
// TODO: how to insert script to app?

namespace AutoInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RunCommand("set-executionpolicy", "remotesigned");
            RunCommand("Invoke-WebRequest", @"-Uri https://raw.githubusercontent.com/regata-jinr/AutoInstaller/master/macro/auto.ps1 -OutFile auto.ps1");

        }

    
        private void RunCommand(string command, string args = "", bool background = true)
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = command;
                process.StartInfo.Arguments = args;
                process.StartInfo.UseShellExecute = !background;
                process.StartInfo.RedirectStandardInput = background;
                process.StartInfo.RedirectStandardOutput = background;
                process.StartInfo.RedirectStandardError = background;
                process.StartInfo.CreateNoWindow = background;
                process.StartInfo.WorkingDirectory = AppContext.BaseDirectory;
                //process.OutputDataReceived += Process_OutputDataReceived;
                process.Start();
            }
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            label1.Text += $"{Environment.NewLine}{e.Data}";
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            var lang = "eng";
            var vers = "3.2.1";

            if (radioButtonRus.Checked)
                lang = "rus";
            if (radioButtonVers340.Checked)
                vers = "3.4.0";
            RunCommand("auto.ps1", $"-vers {vers} -lang {lang}");
        }
    }
}
