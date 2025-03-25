using System;
using System.Web.UI;

namespace _05_Calculator
{
    public partial class Calculator : Page
    {
        private static Calculate calc = new Calculate();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                calc.Clear();
                UpdateResult();
            }
        }

        private void UpdateResult()
        {
            calc_result.Value = calc.CurrentValue;
        }

        protected void ButtonCE_Click(object sender, EventArgs e)
        {
            calc.Clear();
            UpdateResult();
        }

        protected void ButtonReturn_Click(object sender, EventArgs e)
        {
            calc.Backspace();
            UpdateResult();
        }

        protected void ButtonPercentage_Click(object sender, EventArgs e)
        {
            calc.SetOperator('%');
            UpdateResult();
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            calc.SetOperator('+');
            UpdateResult();
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            calc.SetOperator('-');
            UpdateResult();
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            calc.SetOperator('*');
            UpdateResult();
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            calc.SetOperator('/');
            UpdateResult();
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            calc.CalculateResult();
            UpdateResult();
        }

        protected void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            calc.ToggleSign();
            UpdateResult();
        }

        protected void ButtonComa_Click(object sender, EventArgs e)
        {
            calc.AddDecimal();
            UpdateResult();
        }

        protected void Button0_Click(object sender, EventArgs e) { calc.AppendDigit('0'); UpdateResult(); }
        protected void Button1_Click(object sender, EventArgs e) { calc.AppendDigit('1'); UpdateResult(); }
        protected void Button2_Click(object sender, EventArgs e) { calc.AppendDigit('2'); UpdateResult(); }
        protected void Button3_Click(object sender, EventArgs e) { calc.AppendDigit('3'); UpdateResult(); }
        protected void Button4_Click(object sender, EventArgs e) { calc.AppendDigit('4'); UpdateResult(); }
        protected void Button5_Click(object sender, EventArgs e) { calc.AppendDigit('5'); UpdateResult(); }
        protected void Button6_Click(object sender, EventArgs e) { calc.AppendDigit('6'); UpdateResult(); }
        protected void Button7_Click(object sender, EventArgs e) { calc.AppendDigit('7'); UpdateResult(); }
        protected void Button8_Click(object sender, EventArgs e) { calc.AppendDigit('8'); UpdateResult(); }
        protected void Button9_Click(object sender, EventArgs e) { calc.AppendDigit('9'); UpdateResult(); }
    }
}
