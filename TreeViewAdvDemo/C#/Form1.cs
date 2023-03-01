using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using System.Windows.Forms;

namespace TreeViewAdvDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.treeViewAdv1.SelectionMode = TreeSelectionMode.MultiSelectAll;

            // To ensure that the selected node is highlighted always
            this.treeViewAdv1.HideSelection = false;

            // The appearence of selection rectangle can be changed by following property
            // To identify selected node is highlighted or not when TreeViewAdv loses focus           
            // Set custom colors to the selection rectangle
            this.treeViewAdv1.InactiveSelectedNodeBackground = new BrushInfo(Color.Green);
            this.treeViewAdv1.InactiveSelectedNodeForeColor = Color.White;            
        }
    }
}