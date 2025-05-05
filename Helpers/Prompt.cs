using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePortal.Helpers
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string defaultValue = "")
        {
            var prompt = new Form
            {
                Width = 300,
                Height = 150,
                Text = caption,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent
            };

            var lbl = new Label
            {
                Left = 10,
                Top = 10,
                Text = text,
                AutoSize = true
            };
            var txt = new TextBox
            {
                Left = 10,
                Top = 35,
                Width = 260,
                Text = defaultValue
            };
            var ok = new Button
            {
                Text = "OK",
                Left = 200,
                Width = 70,
                Top = 70,
                DialogResult = DialogResult.OK
            };

            prompt.Controls.AddRange(new Control[] { lbl, txt, ok });
            prompt.AcceptButton = ok;

            return prompt.ShowDialog() == DialogResult.OK
                ? txt.Text
                : "";
        }
    }
}
