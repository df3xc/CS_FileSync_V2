using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace GuiThread
{
    public class guiThreadClass
    {

        private delegate void cbCheckChange(CheckBox cb, Boolean state);

        /// <summary>
        ///  Multi Thraeding save : Change CheckBox.Checked
        /// </summary>

        public void cbChecked(CheckBox cb, Boolean state)
        {
            if (cb.InvokeRequired)
            {
                cb.Invoke(new cbCheckChange(cbCheckChangeDelegate), cb, state);
            }
            else
            {
            	cbCheckChangeDelegate(cb, state);
            }
        }

        private void cbCheckChangeDelegate(CheckBox cb, Boolean state)
        {
        	cb.Checked = state;
        }    	
    	
    	
       
        
        private delegate void CB_ColorDelegate(CheckBox cb, System.Drawing.Color color);

        /// <summary>
        ///  Multi Threading save : Change colour of checkbox
        /// </summary>

        public void CB_UpdateColor(CheckBox cb, System.Drawing.Color color)
        {
            if (cb.InvokeRequired)
            {
                cb.Invoke(new CB_ColorDelegate(CB_UpdateColorDelegate), cb, color);
            }
            else
            {
                CB_UpdateColorDelegate(cb, color);
            }
        }

        private void CB_UpdateColorDelegate(CheckBox cb, System.Drawing.Color color)
        {
            cb.BackColor = color;
        }

        

        private delegate void ColorDelegate(Panel lb, System.Drawing.Color color);

        /// <summary>
        ///  Multi Thraeding save : Change colour of a panel
        /// </summary>

        public void UpdateColor(Panel lb, System.Drawing.Color color)
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new ColorDelegate(UpdateColorDelegate), lb, color);
            }
            else
            {
                UpdateColorDelegate(lb, color);
            }
        }        
  
        private void UpdateColorDelegate(Panel lb, System.Drawing.Color color)
        {
            lb.BackColor = color;
        }        
  
        private delegate void BtnColorDelegate(Button bt, System.Drawing.Color color);

        /// <summary>
        ///  Multi Thraeding save : Change colour of a panel
        /// </summary>

        public void BtnColor(Button bt, System.Drawing.Color color)
        {
            if (bt.InvokeRequired)
            {
                bt.Invoke(new BtnColorDelegate(BtnUpdateColorDelegate), bt, color);
            }
            else
            {
                BtnUpdateColorDelegate (bt, color);
            }
        }       
        
        
        private void BtnUpdateColorDelegate(Button bt, System.Drawing.Color color)
        {
            bt.BackColor = color;
        }         

        private delegate void ClearDelegateTextBox(RichTextBox box);

        /// <summary>
        /// clear a textbox
        /// </summary>
        /// <param name="box"></param>

        public void TextBoxClear(RichTextBox box)
        {
            if (box.InvokeRequired)
            {
                box.Invoke(new ClearDelegateTextBox(ClearTextBoxDelegate), box);
            }
            else
            {
                ClearTextBoxDelegate(box);
            }
        }

        private void ClearTextBoxDelegate(RichTextBox box)
        {
            if (box != null)
            {
                box.Clear();
            }
        }

        private delegate void WriteDelegateRichTextBox(RichTextBox box, string line);

        /// <summary>
        /// Multi Thraeding save : write text to a textbox
        /// </summary>
        /// <param name="box"></param>
        /// <param name="line"></param>

        public void RichTextBoxWrite(RichTextBox box, string line)
        {

            try
            {
                if (box.InvokeRequired)
                {
                    box.Invoke(new WriteDelegateRichTextBox(Write_to_RichTextBox), box, line);
                }
                else
                {
                    Write_to_RichTextBox(box, line);
                }
            }
            catch (Exception ex)
            {
                int k = 0;
            }
        }

        private void Write_to_RichTextBox(RichTextBox box, string line)
        {

           if (box != null)
            {

                box.AppendText(line);
                box.ScrollToCaret();
                box.Refresh();
            }
        }


        private delegate void WriteDelegateLabel(Label lb, string line);

        /// <summary>
        /// Multi Thraeding save :  write text to a label
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="line"></param>

        public void LabelWrite(Label lb, string line)
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new WriteDelegateLabel(Write_to_Label), lb, line);
            }
            else
            {
                Write_to_Label(lb, line);
            }
        }

        private void Write_to_Label(Label lb, string line)
        {

            if (lb != null)
            {
                lb.Text = line;
            }
        }



        private delegate void WriteDelegateTextBox(TextBox tb, string line);

        /// <summary>
        /// Multi Thraeding save :  write text to a label
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="line"></param>

        public void TextBoxWrite(TextBox tb, string line)
        {
            if (tb.InvokeRequired)
            {
                tb.Invoke(new WriteDelegateTextBox(Write_to_TextBox), tb, line);
            }
            else
            {
                Write_to_TextBox(tb, line);
            }
        }

        private void Write_to_TextBox(TextBox tb, string line)
        {

            if (tb != null)
            {
                tb.Text = line;
            }
        }




 

 

  


    }
}
