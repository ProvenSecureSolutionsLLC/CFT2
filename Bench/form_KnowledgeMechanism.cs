﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bench
{
    public partial class form_KnowledgeMechanism : Form
    {
        public Double knowledgescore = Double.NaN;

        public form_KnowledgeMechanism()
        {
            InitializeComponent();
        }

        public static string Compute(string word)
        {
            return Compute(word, 6);
        }

        public void clear()
        {
            tb_maybe.Text = "";
            tb_Score.Text = "";
            knowledgescore = Double.NaN;
        }

 public static string Compute(string word, int length)
    {
        // Value to return
        string value = "";
        // Size of the word to process
        int size = word.Length;
        // Make sure the word is at least two characters in length
        if (size > 1)
        {
            // Convert the word to all uppercase
            word = word.ToUpper();
            // Convert the word to character array for faster processing
            char[] chars = word.ToCharArray();
            // Buffer to build up with character codes
            StringBuilder buffer = new StringBuilder();
            buffer.Length = 0;
            // The current and previous character codes
            int prevCode = 0;
            int currCode = 0;
            // Append the first character to the buffer
            buffer.Append(chars[0]);
            // Loop through all the characters and convert them to the proper character code
            for (int i = 1; i < size; i++)
            {
                switch (chars[i])
                {
                    case 'A':
                        currCode = 0;
                        break;
                    case 'E':
                        currCode = 0;
                        break;
                    case 'I':
                        currCode = 0;
                        break;
                    case 'O':
                        currCode = 0;
                        break;
                    case 'U':
                        currCode = 0;
                        break;
                    case 'H':
                        currCode = 0;
                        break;
                    case 'W':
                        currCode = 0;
                        break;
                    case 'Y':
                        currCode = 0;
                        break;
                    case 'B':
                        currCode = 1;
                        break;
                    case 'F':
                        currCode = 1;
                        break;
                    case 'P':
                        currCode = 1;
                        break;
                    case 'V':
                        currCode = 1;
                        break;
                    case 'C':
                        currCode = 2;
                        break;
                    case 'G':
                        currCode = 2;
                        break;
                    case 'J':
                        currCode = 2;
                        break;
                    case 'K':
                        currCode = 2;
                        break;
                    case 'Q':
                        currCode = 2;
                        break;
                    case 'S':
                        currCode = 2;
                        break;
                    case 'X':
                        currCode = 2;
                        break;
                    case 'Z':
                        currCode = 2;
                        break;
                    case 'D':
                        currCode = 3;
                        break;
                    case 'T':
                        currCode = 3;
                        break;
                    case 'L':
                        currCode = 4;
                        break;
                    case 'M':
                        currCode = 5;
                        break;
                    case 'N':
                        currCode = 5;
                        break;
                    case 'R':
                        currCode = 6;
                        break;
                 }
 // Check to see if the current code is the same as the last one
                if (currCode != prevCode)
                {
                    // Check to see if the current code is 0 (a vowel); do not process vowels
                    if (currCode != 0)
                        buffer.Append(currCode);
                }
                // Set the new previous character code
                prevCode = currCode;
                // If the buffer size meets the length limit, then exit the loop
                if (buffer.Length == length)
                    break;
                }
              // Pad the buffer, if required
                size = buffer.Length;
                if (size < length)
                    buffer.Append('0', (length - size));
                // Set the value to return
                value = buffer.ToString();
            }
            // Return the value
            return value;
        }
   

        private void recalculate()
        {
            int count = 0;

            string soundex1 = "";
            string soundex2 = "";

            Double weight = 0.00;

            if (combo_risk.Text == "Easy")
            {
                weight = 0.00;
            }
            if (combo_risk.Text == "Medium")
            {
                weight = -1.00;
            }
            if (combo_risk.Text == "Hard")
            {
                weight = -2.00;
            }

            weight = 9.7 - weight;

            soundex1 = Compute(this.tb_right.Text);
            soundex2 = Compute(this.tb_maybe.Text);

            //MessageBox.Show(soundex1 + "\r\n" + soundex2);

            for (int x = 0; x < soundex2.Length; x++)
            {
                try
                {
                    if (soundex1[x] == soundex2[x])
                    {
                        count++;
                    }
                }
                catch { count = 0;  }
            }

            if (count == 0) { count = 0; }
            if (count > 10) { count = 10; }
            Double d = (count * weight) / 100.00;
            tb_Score.Text = d.ToString("###.####");
            knowledgescore = d;
        }

        public Panel childbody()
        {
            return this.panel_ChildBody;
        }

        private void combo_risk_SelectedIndexChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void tb_right_TextChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void tb_maybe_TextChanged(object sender, EventArgs e)
        {
            recalculate();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
