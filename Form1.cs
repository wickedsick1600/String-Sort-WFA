namespace MAY2024JoseMariJaysonCayabyab
{
    using System.Drawing.Text;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            // Applies the sorted text in the label
            this.sortedString.Text = MediatorFunc.SelectorFunction(this.sortSelector.Text, this.stringBox.Text);
        }
    }
}
