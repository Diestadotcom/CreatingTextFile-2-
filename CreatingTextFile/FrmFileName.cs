using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName = string.Empty;

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFileName.Text))
                {
                    throw new ArgumentException("File name cannot be empty. Please enter a valid name.");
                }

                string proposedFileName = txtFileName.Text + ".txt";
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fullPath = Path.Combine(docPath, proposedFileName);

                if (File.Exists(fullPath))
                {
                    throw new IOException("A file with this name already exists. Please choose a different name.");
                }

                SetFileName = proposedFileName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}