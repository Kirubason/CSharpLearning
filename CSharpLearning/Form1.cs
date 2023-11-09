using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReverseString obj = new ReverseString();
            obj.ReverseWholeSentense();
            obj.ReverseEachWordInSentense();
            obj.ReverseEachWordCharacterInSentense();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PalindromeCheck obj = new PalindromeCheck();
            obj.PalindromeCheckMethod();
            obj.PalindromeCheckMethod2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringCharacterCount obj = new StringCharacterCount();
            obj.StringCharacterCountMethod();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThrowVsThrowEx obj = new ThrowVsThrowEx();
            obj.ThrowMethod();
            obj.ThrowExMethod();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GenericsExample<bool> obj = new GenericsExample<bool>();
            obj.GenericMethod<bool>(false, false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LinQExample obj = new LinQExample();
            obj.LinQMethod();
            obj.LinQMethodLmbda();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            YieldKeyword obj = new YieldKeyword();
            obj.YieldMethodMain();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ConstantReadOnlyStatic obj = new ConstantReadOnlyStatic(3);
            obj.ConstantReadOnlyStaticMethod();

            ConstantReadOnlyStatic obj1 = new ConstantReadOnlyStatic();
            ConstantReadOnlyStatic obj2 = new ConstantReadOnlyStatic();
            ConstantReadOnlyStatic obj3 = new ConstantReadOnlyStatic();
            ConstantReadOnlyStatic obj4 = new ConstantReadOnlyStatic();
            ConstantReadOnlyStatic obj5 = new ConstantReadOnlyStatic();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ParentInheritenceClass bank = new ChildInheritenceClass();
            bank.BankName();

            ParentInheritenceClass obj1 = new ChildInheritenceClass();
            ChildInheritenceClass obj2 = new ChildInheritenceClass();
            ParentInheritenceClass obj3 = new ParentInheritenceClass();
        }
    }
}
