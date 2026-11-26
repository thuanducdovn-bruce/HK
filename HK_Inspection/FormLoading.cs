using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Insnex.Utility;
using Insnex.Vision2D.ToolBlock;
using InsWorks;
using InsWorks.Studio;
using System.Reflection;

namespace HK_Inspection
{
    public partial class FormLoading : Form
    {
        private readonly string modelDirectory = Path.Combine(Application.StartupPath, "Models");

        public FormLoading()
        {
            InitializeComponent();
            Load += FormLoading_Load;
            btnStart.Click += btnStart_Click;
            btnExit.Click += btnExit_Click;
            btnStart.Enabled = false;
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            cbModelList.Items.Clear();
            if (Directory.Exists(modelDirectory))
            {
                foreach (string directory in Directory.GetDirectories(modelDirectory))
                    cbModelList.Items.Add(Path.GetFileName(directory));
            }

            btnStart.Enabled = cbModelList.Items.Count > 0;
        }

        private static InsToolBlock LoadToolBlock(string path)
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type[] types;
                try
                {
                    types = assembly.GetTypes();
                }
                catch (ReflectionTypeLoadException ex)
                {
                    types = ex.Types.Where(type => type != null).ToArray();
                }

                foreach (Type type in types)
                {
                    if (type.Name != "InsUtils")
                        continue;

                    MethodInfo loader = type.GetMethod("LoadObjectFromFile",
                        BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string) }, null);
                    if (loader == null)
                        continue;

                    return loader.Invoke(null, new object[] { path }) as InsToolBlock;
                }
            }

            throw new MissingMethodException("The loaded InsWorks SDK does not provide InsUtils.LoadObjectFromFile(string).");
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (cbModelList.SelectedItem == null)
            {
                MessageBox.Show("Select a model first.", "Model", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnStart.Enabled = false;
            cbModelList.Enabled = false;
            progressBarStatus.Value = 0;
            lbStatus.Text = "Loading program...";
            try
            {
                string selectedModel = cbModelList.SelectedItem.ToString();
                string toolBlockPath = Path.Combine(modelDirectory, selectedModel, "Program.tolb");

                InsToolBlock job = await Task.Run(() =>
                    LoadToolBlock(toolBlockPath));
                if (job == null)
                    throw new InvalidDataException("The selected model does not contain a valid Program.tolb Insnex tool block.");

                var mainForm = new FormMain();
                mainForm.Initialize(job, selectedModel);
                mainForm.FormClosed += (s, args) => Close();
                progressBarStatus.Value = 100;
                lbStatus.Text = "Ready";
                mainForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Initialization failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStart.Enabled = true;
                cbModelList.Enabled = true;
                progressBarStatus.Value = 0;
                lbStatus.Text = "Loading failed";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
